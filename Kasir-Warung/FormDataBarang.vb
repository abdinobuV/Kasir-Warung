Imports MySqlConnector

''' <summary>
''' Form CRUD master barang (Tahap 6, dibuka pakai tombol F2 dari FormKasir).
''' Memakai konsep recordset: data dari database diisi ke DataTable lewat
''' MySqlDataAdapter, lalu DataTable dihubungkan ke DataGridView memakai
''' BindingSource. BindingSource inilah yang menyediakan navigasi record
''' (MoveFirst/MovePrevious/MoveNext/MoveLast) dan jumlah record (Count).
''' </summary>
Public Class FormDataBarang

    ' Cache FormKasir: halaman ini hanya navigasi di dalam FormKasir,
    ' jadi tombol Kembali langsung menampilkan lagi halaman kasir.
    Private _formKasir As FormKasir

    ' Recordset barang: diisi sekali saat form dibuka
    Private dtBarang As DataTable

    ' Penghubung antara recordset dan grid + sumber navigasi record.
    ' WithEvents dipakai supaya event PositionChanged bisa ditangani dengan Handles.
    Private WithEvents bsBarang As BindingSource

    Private Sub FormDataBarang_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Ikon memakai font ikon yang benar-benar tersedia di Windows ini
        lblIkon.Font = BuatFontIkon(18)

        ' Kolom harga ditampilkan dalam format Rupiah (id-ID)
        Dim gayaRupiah As New System.Windows.Forms.DataGridViewCellStyle()
        gayaRupiah.Format = "Rp#,##0"
        gayaRupiah.FormatProvider = BudayaId()
        gayaRupiah.Alignment = DataGridViewContentAlignment.MiddleRight
        colHarga.DefaultCellStyle = gayaRupiah

        Dim gayaTengah As New System.Windows.Forms.DataGridViewCellStyle()
        gayaTengah.Alignment = DataGridViewContentAlignment.MiddleCenter
        colStok.DefaultCellStyle = gayaTengah

        ' Header grid bold agar sama dengan gaya FormKasir
        Dim gayaHeader As New System.Windows.Forms.DataGridViewCellStyle()
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
                Using cmd As New MySqlCommand(
                        "SELECT kode_barang, nama_barang, harga, stok " &
                        "FROM barang ORDER BY kode_barang", conn)
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dtBarang)   ' mengisi recordset
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            FormPesan.Tampilkan(DirectCast(ParentForm, Form), "Kelola Barang",
                                "Gagal membaca data barang." & vbCrLf & vbCrLf &
                                "Pastikan Laragon (MySQL) sudah berjalan." & vbCrLf & ex.Message,
                                FormPesan.JenisPesan.Kesalahan)
            Return
        Catch ex As Exception
            FormPesan.Tampilkan(DirectCast(ParentForm, Form), "Kelola Barang",
                                "Terjadi kesalahan saat membuka data barang." & vbCrLf & vbCrLf & ex.Message,
                                FormPesan.JenisPesan.Kesalahan)
            Return
        End Try

        ' BindingSource menjadi jembatan: recordset -> grid
        bsBarang = New BindingSource()
        bsBarang.DataSource = dtBarang
        dgvBarang.DataSource = bsBarang

        ' Posisi awal record pertama supaya tombol navigasi langsung benar
        If bsBarang.Count > 0 Then bsBarang.MoveFirst()

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

    ''' <summary>Baris yang sedang dipilih di grid (Nothing jika tidak ada).</summary>
    Private Function BarisTerpilih() As DataRow
        If bsBarang Is Nothing Then Return Nothing
        Dim tampilan As DataRowView = TryCast(bsBarang.Current, DataRowView)
        If tampilan Is Nothing Then Return Nothing
        Return tampilan.Row
    End Function

    ''' <summary>
    ''' Mengisi textbox dari record yang sedang dipilih (tersinkron dengan BindingSource).
    ''' </summary>
    Private Sub IsiInputDariRecord()
        Dim baris As DataRow = BarisTerpilih()
        If baris Is Nothing Then
            KosongkanInput()
            Return
        End If

        txtKode.Text = baris("kode_barang").ToString()
        txtNama.Text = baris("nama_barang").ToString()
        txtHarga.Text = FormatRupiah(CDec(baris("harga")))
        txtStok.Text = CInt(baris("stok")).ToString()
    End Sub

    Private Sub KosongkanInput()
        txtKode.Text = ""
        txtNama.Text = ""
        txtHarga.Text = ""
        txtStok.Text = ""
    End Sub

    ''' <summary>
    ''' Menyaring recordset memakai BindingSource.Filter (di memori).
    ''' Tidak menyambung teks pengguna ke SQL, jadi aman dan cepat.
    ''' </summary>
    Private Sub TerapkanFilter()
        If bsBarang Is Nothing Then Return

        Dim kata As String = txtCari.Text.Trim().Replace("'", "''")

        Try
            If kata = "" Then
                bsBarang.RemoveFilter()
            Else
                bsBarang.Filter = "kode_barang LIKE '*" & kata & "*' OR " &
                                  "nama_barang LIKE '*" & kata & "*'"
            End If
        Catch ex As Exception
            ' Karakter khusus seperti [ atau * bisa membuat filter salah baca.
            Return
        End Try

        PerbaruiJumlahRecord()
        PerbaruiTombolNavigasi()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        TerapkanFilter()
    End Sub

    ' Enter di kotak cari = pindah fokus ke grid
    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        If e.KeyChar = ChrW(13) Then
            e.Handled = True
            If bsBarang IsNot Nothing AndAlso bsBarang.Count > 0 Then dgvBarang.Focus()
        End If
    End Sub

    ' Hanya angka (dan koma/titik untuk desimal) di kolom harga/stok
    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub txtStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStok.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
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

    ' Setiap kali posisi record bergeser, grid, textbox, dan tombol navigasi ikut diperbarui
    Private Sub bsBarang_PositionChanged(sender As Object, e As EventArgs) Handles bsBarang.PositionChanged
        PerbaruiTombolNavigasi()
        PerbaruiJumlahRecord()
        IsiInputDariRecord()
    End Sub

    ' ---------------- CRUD ----------------

    ''' <summary>
    ''' Validasi umum sebelum INSERT/UPDATE:
    ''' kode & nama tidak kosong, harga/stok angka >= 0.
    ''' Mengembalikan False bila ada yang salah (pesan sudah ditampilkan).
    ''' </summary>
    Private Function ValidasiInput(ByRef harga As Decimal, ByRef stok As Integer) As Boolean
        If txtKode.Text.Trim() = "" Then
            FormPesan.Tampilkan(DirectCast(ParentForm, Form), "Kelola Barang", "Kode barang belum diisi.", FormPesan.JenisPesan.Peringatan)
            txtKode.Focus()
            Return False
        End If

        If txtNama.Text.Trim() = "" Then
            FormPesan.Tampilkan(DirectCast(ParentForm, Form), "Kelola Barang", "Nama barang belum diisi.", FormPesan.JenisPesan.Peringatan)
            txtNama.Focus()
            Return False
        End If

        harga = ParseRupiah(txtHarga.Text)
        If harga < 0 Then
            FormPesan.Tampilkan(DirectCast(ParentForm, Form), "Kelola Barang", "Harga harus berupa angka >= 0.", FormPesan.JenisPesan.Peringatan)
            txtHarga.Focus()
            Return False
        End If

        If Not Integer.TryParse(txtStok.Text.Trim(), stok) OrElse stok < 0 Then
            FormPesan.Tampilkan(DirectCast(ParentForm, Form), "Kelola Barang", "Stok harus berupa angka >= 0.", FormPesan.JenisPesan.Peringatan)
            txtStok.Focus()
            txtStok.SelectAll()
            Return False
        End If

        Return True
    End Function

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim harga As Decimal
        Dim stok As Integer
        If Not ValidasiInput(harga, stok) Then Return

        Dim kode As String = txtKode.Text.Trim()
        Dim nama As String = txtNama.Text.Trim()

        ' Cek kembar di database sebelum INSERT
        If KodeSudahAda(kode) Then
            FormPesan.Tampilkan(DirectCast(ParentForm, Form), "Kelola Barang",
                                "Kode barang sudah ada: " & kode & vbCrLf & vbCrLf &
                                "Pilih kode lain, misalnya B009 untuk barang baru.",
                                FormPesan.JenisPesan.Peringatan)
            txtKode.Focus()
            txtKode.SelectAll()
            Return
        End If

        Try
            Using conn As MySqlConnection = BuatKoneksi()
                Using cmd As New MySqlCommand(
                        "INSERT INTO barang (kode_barang, nama_barang, harga, stok) " &
                        "VALUES (@kode, @nama, @harga, @stok)", conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@stok", stok)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As MySqlException When ex.Number = 1062
            ' 1062 = duplicate entry: kode kembar
            FormPesan.Tampilkan(DirectCast(ParentForm, Form), "Kelola Barang",
                                "Kode barang sudah ada: " & kode,
                                FormPesan.JenisPesan.Peringatan)
            Return
        Catch ex As MySqlException
            FormPesan.Tampilkan(DirectCast(ParentForm, Form), "Kelola Barang",
                                "Gagal menambah barang." & vbCrLf & vbCrLf & ex.Message,
                                FormPesan.JenisPesan.Kesalahan)
            Return
        Catch ex As Exception
            FormPesan.Tampilkan(DirectCast(ParentForm, Form), "Kelola Barang",
                                "Gagal menambah barang." & vbCrLf & vbCrLf & ex.Message,
                                FormPesan.JenisPesan.Kesalahan)
            Return
        End Try

        MuatDataBarang()
        KosongkanInput()
        FormPesan.Tampilkan(DirectCast(ParentForm, Form), "Kelola Barang",
                            "Barang berhasil ditambahkan." & vbCrLf & vbCrLf &
                            "Kode : " & kode & vbCrLf & "Nama : " & nama,
                            FormPesan.JenisPesan.Sukses)
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Dim baris As DataRow = BarisTerpilih()
        If baris Is Nothing Then
            FormPesan.Tampilkan(DirectCast(ParentForm, Form), "Kelola Barang",
                                "Pilih dulu baris barang yang ingin diubah.",
                                FormPesan.JenisPesan.Informasi)
            Return
        End If

        Dim harga As Decimal
        Dim stok As Integer
        If Not ValidasiInput(harga, stok) Then Return

        ' Kode barang adalah kunci utama: tidak boleh diubah
        Dim kodeLama As String = baris("kode_barang").ToString()
        Dim kodeBaru As String = txtKode.Text.Trim()
        If Not String.Equals(kodeLama, kodeBaru, StringComparison.OrdinalIgnoreCase) Then
            FormPesan.Tampilkan(DirectCast(ParentForm, Form), "Kelola Barang",
                                "Kode barang tidak bisa diubah." & vbCrLf &
                                "Kode asal " & kodeLama & " harus tetap dipakai.",
                                FormPesan.JenisPesan.Peringatan)
            txtKode.Text = kodeLama
            txtKode.Focus()
            Return
        End If

        Dim nama As String = txtNama.Text.Trim()

        Try
            Using conn As MySqlConnection = BuatKoneksi()
                Using cmd As New MySqlCommand(
                        "UPDATE barang SET nama_barang = @nama, harga = @harga, stok = @stok " &
                        "WHERE kode_barang = @kode", conn)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@stok", stok)
                    cmd.Parameters.AddWithValue("@kode", kodeLama)
                    conn.Open()
                    If cmd.ExecuteNonQuery() = 0 Then
                        FormPesan.Tampilkan(DirectCast(ParentForm, Form), "Kelola Barang",
                                            "Barang tidak ditemukan di database.",
                                            FormPesan.JenisPesan.Peringatan)
                        Return
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            FormPesan.Tampilkan(DirectCast(ParentForm, Form), "Kelola Barang",
                                "Gagal mengubah barang." & vbCrLf & vbCrLf & ex.Message,
                                FormPesan.JenisPesan.Kesalahan)
            Return
        Catch ex As Exception
            FormPesan.Tampilkan(DirectCast(ParentForm, Form), "Kelola Barang",
                                "Gagal mengubah barang." & vbCrLf & vbCrLf & ex.Message,
                                FormPesan.JenisPesan.Kesalahan)
            Return
        End Try

        MuatDataBarang()
        FormPesan.Tampilkan(DirectCast(ParentForm, Form), "Kelola Barang",
                            "Barang berhasil diubah." & vbCrLf & vbCrLf &
                            "Kode : " & kodeLama & vbCrLf & "Nama : " & nama,
                            FormPesan.JenisPesan.Sukses)
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim baris As DataRow = BarisTerpilih()
        If baris Is Nothing Then
            FormPesan.Tampilkan(DirectCast(ParentForm, Form), "Kelola Barang",
                                "Pilih dulu baris barang yang ingin dihapus.",
                                FormPesan.JenisPesan.Informasi)
            Return
        End If

        Dim kode As String = baris("kode_barang").ToString()
        Dim nama As String = baris("nama_barang").ToString()

        Dim dlg As New FormPesan("Hapus Barang",
                                 "Hapus barang " & kode & " - " & nama & "?" & vbCrLf & vbCrLf &
                                 "Barang yang sudah pernah terjual tidak bisa dihapus (aturan relasi database).",
                                 True)
        If dlg.ShowDialog(DirectCast(ParentForm, Form)) <> DialogResult.Yes Then Return

        Try
            Using conn As MySqlConnection = BuatKoneksi()
                Using cmd As New MySqlCommand(
                        "DELETE FROM barang WHERE kode_barang = @kode", conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As MySqlException When ex.Number = 1451
            ' 1451 = FK constraint: barang masih dipakai detail_transaksi (ON DELETE RESTRICT)
            FormPesan.Tampilkan(DirectCast(ParentForm, Form), "Kelola Barang",
                                "Barang ini tidak bisa dihapus karena sudah pernah terjual." & vbCrLf & vbCrLf &
                                "Kode : " & kode & vbCrLf & "Nama : " & nama,
                                FormPesan.JenisPesan.Peringatan)
            Return
        Catch ex As MySqlException
            FormPesan.Tampilkan(DirectCast(ParentForm, Form), "Kelola Barang",
                                "Gagal menghapus barang." & vbCrLf & vbCrLf & ex.Message,
                                FormPesan.JenisPesan.Kesalahan)
            Return
        Catch ex As Exception
            FormPesan.Tampilkan(DirectCast(ParentForm, Form), "Kelola Barang",
                                "Gagal menghapus barang." & vbCrLf & vbCrLf & ex.Message,
                                FormPesan.JenisPesan.Kesalahan)
            Return
        End Try

        MuatDataBarang()
        FormPesan.Tampilkan(DirectCast(ParentForm, Form), "Kelola Barang",
                            "Barang berhasil dihapus." & vbCrLf & vbCrLf &
                            "Kode : " & kode & vbCrLf & "Nama : " & nama,
                            FormPesan.JenisPesan.Sukses)
    End Sub

    ''' <summary>Mengecek apakah kode sudah dipakai barang lain.</summary>
    Private Function KodeSudahAda(kode As String) As Boolean
        Try
            Using conn As MySqlConnection = BuatKoneksi()
                Using cmd As New MySqlCommand(
                        "SELECT COUNT(*) FROM barang WHERE kode_barang = @kode", conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    conn.Open()
                    Return CInt(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch ex As MySqlException
            FormPesan.Tampilkan(DirectCast(ParentForm, Form), "Kelola Barang",
                                "Gagal memeriksa kode barang." & vbCrLf & vbCrLf & ex.Message,
                                FormPesan.JenisPesan.Kesalahan)
            Return False
        Catch ex As Exception
            FormPesan.Tampilkan(DirectCast(ParentForm, Form), "Kelola Barang",
                                "Gagal memeriksa kode barang." & vbCrLf & vbCrLf & ex.Message,
                                FormPesan.JenisPesan.Kesalahan)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Tombol Kembali: menampilkan halaman kasir (panelIsi FormKasir).
    ''' </summary>
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        DirectCast(ParentForm, FormKasir).TampilkanHalamanKasir()
    End Sub

End Class






