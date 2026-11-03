Imports MySqlConnector

''' <summary>
''' Dialog pencarian barang (Tahap 3).
''' Memakai konsep recordset: data dari database diisi ke DataTable lewat
''' MySqlDataAdapter, lalu DataTable dihubungkan ke DataGridView memakai
''' BindingSource. BindingSource inilah yang menyediakan navigasi record
''' (MoveFirst/MovePrevious/MoveNext/MoveLast) dan jumlah record (Count).
''' </summary>
Public Class FormCariBarang

    ' Recordset barang: diisi sekali saat form dibuka
    Private dtBarang As DataTable

    ' Penghubung antara recordset dan grid + sumber navigasi record.
    ' WithEvents dipakai supaya event PositionChanged bisa ditangani dengan Handles.
    Private WithEvents bsBarang As BindingSource

    ''' <summary>
    ''' Kode barang yang dipilih pengguna. Dibaca FormKasir setelah
    ''' ShowDialog() mengembalikan DialogResult.OK.
    ''' Hidden supaya Visual Studio Designer tidak berusaha menyimpannya
    ''' ke file .resx (WFO1000).
    ''' </summary>
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property KodeBarangTerpilih As String = ""

    Private Sub FormCariBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ikon memakai font ikon yang benar-benar tersedia di Windows ini
        lblIkon.Font = BuatFontIkon(18)

        ' Kolom harga ditampilkan dalam format Rupiah (id-ID)
        Dim gayaRupiah As New DataGridViewCellStyle()
        gayaRupiah.Format = "Rp#,##0"
        gayaRupiah.FormatProvider = BudayaId()
        gayaRupiah.Alignment = DataGridViewContentAlignment.MiddleRight
        colHarga.DefaultCellStyle = gayaRupiah

        ' Header grid bold agar sama dengan gaya FormKasir
        Dim gayaHeader As New DataGridViewCellStyle()
        gayaHeader.Font = New Font(Font, FontStyle.Bold)
        dgvBarang.ColumnHeadersDefaultCellStyle = gayaHeader

        MuatDataBarang()
        txtCari.Focus()
    End Sub

    ''' <summary>
    ''' Mengisi recordset dari database. Seluruh koneksi memakai Using
    ''' sehingga tertutup otomatis walau terjadi error.
    ''' </summary>
    Private Sub MuatDataBarang()
        dtBarang = New DataTable("barang")

        Try
            Using conn As MySqlConnection = BuatKoneksi()
                ' Semua input memakai parameter (@...) supaya aman dari SQL injection
                Using cmd As New MySqlCommand(
                        "SELECT kode_barang, nama_barang, harga, stok " &
                        "FROM barang ORDER BY kode_barang", conn)
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dtBarang)   ' mengisi recordset
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show(
                "Gagal membaca data barang dari database." & vbCrLf & vbCrLf &
                "Pastikan Laragon (MySQL) sudah berjalan." & vbCrLf & ex.Message,
                "Cari Barang", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Catch ex As Exception
            MessageBox.Show(
                "Terjadi kesalahan saat membuka daftar barang." & vbCrLf & vbCrLf & ex.Message,
                "Cari Barang", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        ' BindingSource menjadi jembatan: recordset -> grid
        bsBarang = New BindingSource()
        bsBarang.DataSource = dtBarang
        dgvBarang.DataSource = bsBarang

        ' Posisi awal record pertama supaya tombol navigasi langsung benar
        If bsBarang.Count > 0 Then
            bsBarang.MoveFirst()
        End If

        PerbaruiJumlahRecord()
        PerbaruiTombolNavigasi()
    End Sub

    ''' <summary>Menampilkan jumlah record hasil pencarian (Count).</summary>
    Private Sub PerbaruiJumlahRecord()
        If bsBarang Is Nothing Then
            lblJumlahRecord.Text = "Jumlah record : 0"
        Else
            lblJumlahRecord.Text = "Jumlah record : " & bsBarang.Count.ToString()
        End If
    End Sub

    ''' <summary>
    ''' Menyalakan/menonaktifkan tombol navigasi sesuai posisi record.
    ''' Tombol pertama & sebelumnya mati di record pertama,
    ''' tombol berikutnya & terakhir mati di record terakhir.
    ''' </summary>
    Private Sub PerbaruiTombolNavigasi()
        If bsBarang Is Nothing Then
            btnPertama.Enabled = False
            btnSebelumnya.Enabled = False
            btnBerikutnya.Enabled = False
            btnTerakhir.Enabled = False
            Return
        End If

        Dim adaRecord As Boolean = bsBarang.Count > 0
        Dim diAwal As Boolean = (Not adaRecord) OrElse bsBarang.Position <= 0
        Dim diAkhir As Boolean = (Not adaRecord) OrElse bsBarang.Position >= bsBarang.Count - 1

        btnPertama.Enabled = adaRecord AndAlso Not diAwal
        btnSebelumnya.Enabled = adaRecord AndAlso Not diAwal
        btnBerikutnya.Enabled = adaRecord AndAlso Not diAkhir
        btnTerakhir.Enabled = adaRecord AndAlso Not diAkhir
    End Sub

    ''' <summary>
    ''' Menyaring recordset memakai BindingSource.Filter (di memori).
    ''' Tidak menyambung teks pengguna ke SQL, jadi aman dan pencarian
    ''' langsung terasa cepat karena tidak query database berulang kali.
    ''' </summary>
    Private Sub TerapkanFilter()
        If bsBarang Is Nothing Then Return

        Dim kata As String = txtCari.Text.Trim().Replace("'", "''")

        Try
            If kata = "" Then
                bsBarang.RemoveFilter()            ' tampilkan semua record
            Else
                ' Tanda bintang = wildcard pada filter DataView
                bsBarang.Filter = "kode_barang LIKE '*" & kata & "*' OR " &
                                  "nama_barang LIKE '*" & kata & "*'"
            End If
        Catch ex As Exception
            ' Karakter khusus seperti [ atau * bisa membuat filter salah baca.
            ' Diabaikan saja supaya form tidak error saat mengetik.
            Return
        End Try

        PerbaruiJumlahRecord()
        PerbaruiTombolNavigasi()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        TerapkanFilter()
    End Sub

    ' Enter di kotak cari = pindah fokus ke grid (bukan langsung memilih)
    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        If e.KeyChar = ChrW(13) Then   ' ChrW(13) = tombol Enter
            e.Handled = True           ' cegah bunyi "ding"
            If bsBarang IsNot Nothing AndAlso bsBarang.Count > 0 Then
                dgvBarang.Focus()
            End If
        End If
    End Sub

    ' ---------------- Navigasi record ----------------

    Private Sub btnPertama_Click(sender As Object, e As EventArgs) Handles btnPertama.Click
        If bsBarang Is Nothing OrElse bsBarang.Count = 0 Then Return
        bsBarang.MoveFirst()
    End Sub

    Private Sub btnSebelumnya_Click(sender As Object, e As EventArgs) Handles btnSebelumnya.Click
        If bsBarang Is Nothing OrElse bsBarang.Count = 0 Then Return
        bsBarang.MovePrevious()
    End Sub

    Private Sub btnBerikutnya_Click(sender As Object, e As EventArgs) Handles btnBerikutnya.Click
        If bsBarang Is Nothing OrElse bsBarang.Count = 0 Then Return
        bsBarang.MoveNext()
    End Sub

    Private Sub btnTerakhir_Click(sender As Object, e As EventArgs) Handles btnTerakhir.Click
        If bsBarang Is Nothing OrElse bsBarang.Count = 0 Then Return
        bsBarang.MoveLast()
    End Sub

    ' Setiap kali posisi record bergeser, tombol navigasi ikut diperbarui
    Private Sub bsBarang_PositionChanged(sender As Object, e As EventArgs) Handles bsBarang.PositionChanged
        PerbaruiTombolNavigasi()
    End Sub

    ' ---------------- Pemilihan record ----------------

    Private Sub btnPilih_Click(sender As Object, e As EventArgs) Handles btnPilih.Click
        PilihBaris()
    End Sub

    ' Klik ganda baris = memilih barang tersebut
    Private Sub dgvBarang_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBarang.CellDoubleClick
        If e.RowIndex >= 0 Then
            PilihBaris()
        End If
    End Sub

    ' Enter di grid juga dianggap memilih baris
    Private Sub dgvBarang_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvBarang.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True   ' cegah bunyi "ding"
            PilihBaris()
        End If
    End Sub

    ''' <summary>
    ''' Mengirim kode barang terpilih ke FormKasir lalu menutup dialog.
    ''' </summary>
    Private Sub PilihBaris()
        If bsBarang Is Nothing OrElse bsBarang.Count = 0 Then
            MessageBox.Show(
                "Belum ada barang yang bisa dipilih.",
                "Cari Barang", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim baris As DataRowView = TryCast(bsBarang.Current, DataRowView)
        If baris Is Nothing Then
            MessageBox.Show(
                "Pilih dulu baris barang yang akan dipakai.",
                "Cari Barang", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        KodeBarangTerpilih = baris("kode_barang").ToString()
        DialogResult = DialogResult.OK
        Close()
    End Sub

End Class
