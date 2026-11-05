Imports MySqlConnector

''' <summary>
''' Form riwayat transaksi (Tahap 6, dibuka pakai tombol F3 dari FormKasir).
''' Memakai konsep master-detail:
''' - Grid master menampilkan kepala transaksi dari tabel transaksi.
''' - Grid detail menampilkan item transaksi terpilih (JOIN detail_transaksi + barang).
''' Keduanya adalah recordset (DataTable + BindingSource).
''' </summary>
Public Class FormRiwayat

    ' Recordset master: kepala transaksi
    Private dtTransaksi As DataTable

    ' Recordset detail: item dari transaksi terpilih
    Private dtDetail As DataTable

    ' Penghubung recordset master ke grid master
    Private WithEvents bsTransaksi As BindingSource

    Private Sub FormRiwayat_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Ikon memakai font ikon yang benar-benar tersedia di Windows ini
        lblIkon.Font = BuatFontIkon(18)

        ' Kolom uang ditampilkan format Rp (id-ID)
        Dim gayaRupiah As New DataGridViewCellStyle()
        gayaRupiah.Format = "Rp#,##0"
        gayaRupiah.FormatProvider = BudayaId()
        gayaRupiah.Alignment = DataGridViewContentAlignment.MiddleRight
        colTotal.DefaultCellStyle = gayaRupiah
        colBayar.DefaultCellStyle = gayaRupiah
        colKembali.DefaultCellStyle = gayaRupiah
        colDHarga.DefaultCellStyle = gayaRupiah
        colDSubtotal.DefaultCellStyle = gayaRupiah

        Dim gayaTengah As New DataGridViewCellStyle()
        gayaTengah.Alignment = DataGridViewContentAlignment.MiddleCenter
        colDJumlah.DefaultCellStyle = gayaTengah

        ' Kolom tanggal format Indonesia
        colTanggal.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
        colTanggal.DefaultCellStyle.FormatProvider = BudayaId()

        ' Header grid bold agar sama dengan gaya FormKasir
        Dim gayaHeader As New DataGridViewCellStyle()
        gayaHeader.Font = New Font(Font, FontStyle.Bold)
        dgvTransaksi.ColumnHeadersDefaultCellStyle = gayaHeader
        dgvDetail.ColumnHeadersDefaultCellStyle = gayaHeader

        tblIsi.BringToFront()

        ' Awalnya tampilkan semua hari ini
        dtpDari.Value = DateTime.Today
        dtpSampai.Value = DateTime.Today

        MuatTransaksi()
    End Sub

    ''' <summary>
    ''' Memuat recordset master dari database dengan filter rentang tanggal.
    ''' Semua input tanggal memakai parameter (@dari, @sampai) supaya aman.
    ''' </summary>
    Private Sub MuatTransaksi()
        dtTransaksi = New DataTable("transaksi")

        ' Filter: awal hari s.d. akhir hari yang dipilih
        Dim dari As Date = dtpDari.Value.Date
        Dim sampai As Date = dtpSampai.Value.Date.AddDays(1).AddSeconds(-1)  ' 23:59:59

        Try
            Using conn As MySqlConnection = BuatKoneksi()
                Using cmd As New MySqlCommand(
                        "SELECT no_transaksi, tanggal, total, bayar, kembali " &
                        "FROM transaksi WHERE tanggal BETWEEN @dari AND @sampai " &
                        "ORDER BY tanggal DESC", conn)
                    cmd.Parameters.AddWithValue("@dari", dari)
                    cmd.Parameters.AddWithValue("@sampai", sampai)
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dtTransaksi)
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            FormPesan.Tampilkan(DirectCast(ParentForm, Form), "Riwayat Transaksi",
                                "Gagal membaca riwayat transaksi." & vbCrLf & vbCrLf &
                                "Pastikan Laragon (MySQL) sudah berjalan." & vbCrLf & ex.Message,
                                FormPesan.JenisPesan.Kesalahan)
            Return
        Catch ex As Exception
            FormPesan.Tampilkan(DirectCast(ParentForm, Form), "Riwayat Transaksi",
                                "Terjadi kesalahan saat membaca riwayat." & vbCrLf & vbCrLf & ex.Message,
                                FormPesan.JenisPesan.Kesalahan)
            Return
        End Try

        ' Total pendapatan = jumlah semua total pada recordset yang tampil
        Dim totalPendapatan As Decimal = 0
        For Each baris As DataRow In dtTransaksi.Rows
            totalPendapatan += CDec(baris("total"))
        Next
        lblTotalPendapatan.Text = FormatRupiah(totalPendapatan)

        ' BindingSource menjadi jembatan: recordset -> grid master
        If bsTransaksi Is Nothing Then
            bsTransaksi = New BindingSource()
        End If
        bsTransaksi.DataSource = dtTransaksi
        dgvTransaksi.DataSource = bsTransaksi

        If bsTransaksi.Count > 0 Then bsTransaksi.MoveFirst()

        lblJudulDetail.Text = "Pilih transaksi untuk melihat detail"
        MuatDetail()
        PerbaruiTombolNavigasi()
        PerbaruiPosisi()
    End Sub

    ''' <summary>
    ''' Memuat recordset detail untuk transaksi yang sedang dipilih di grid master.
    ''' JOIN detail_transaksi + barang supaya nama barang ikut tampil.
    ''' </summary>
    Private Sub MuatDetail()
        dtDetail = New DataTable("detail")
        dtDetail.Columns.Add("no", GetType(Integer))
        dtDetail.Columns.Add("kode_barang", GetType(String))
        dtDetail.Columns.Add("nama_barang", GetType(String))
        dtDetail.Columns.Add("jumlah", GetType(Integer))
        dtDetail.Columns.Add("harga_satuan", GetType(Decimal))
        dtDetail.Columns.Add("subtotal", GetType(Decimal))

        Dim noTerpilih As String = NoTransaksiTerpilih()
        If noTerpilih = "" Then
            ' Belum ada transaksi terpilih: grid detail tetap kosong
            dgvDetail.DataSource = dtDetail
            Return
        End If

        Try
            Using conn As MySqlConnection = BuatKoneksi()
                Using cmd As New MySqlCommand(
                        "SELECT d.kode_barang, b.nama_barang, d.jumlah, d.harga_satuan, d.subtotal " &
                        "FROM detail_transaksi d " &
                        "JOIN barang b ON b.kode_barang = d.kode_barang " &
                        "WHERE d.no_transaksi = @no " &
                        "ORDER BY d.id", conn)
                    cmd.Parameters.AddWithValue("@no", noTerpilih)
                    Using da As New MySqlDataAdapter(cmd)
                        Using tabel As New DataTable()
                            da.Fill(tabel)
                            ' Nomor urut dihitung sendiri dari 1
                            Dim nomor As Integer = 1
                            For Each brg As DataRow In tabel.Rows
                                dtDetail.Rows.Add(
                                    nomor,
                                    brg("kode_barang").ToString(),
                                    brg("nama_barang").ToString(),
                                    CInt(brg("jumlah")),
                                    CDec(brg("harga_satuan")),
                                    CDec(brg("subtotal")))
                                nomor += 1
                            Next
                        End Using
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            FormPesan.Tampilkan(DirectCast(ParentForm, Form), "Riwayat Transaksi",
                                "Gagal membaca detail transaksi." & vbCrLf & vbCrLf & ex.Message,
                                FormPesan.JenisPesan.Kesalahan)
            Return
        Catch ex As Exception
            FormPesan.Tampilkan(DirectCast(ParentForm, Form), "Riwayat Transaksi",
                                "Terjadi kesalahan saat membaca detail." & vbCrLf & vbCrLf & ex.Message,
                                FormPesan.JenisPesan.Kesalahan)
            Return
        End Try

        dgvDetail.DataSource = dtDetail
        lblJudulDetail.Text = "Detail transaksi : " & noTerpilih
    End Sub

    ''' <summary>No transaksi dari baris master yang sedang dipilih ("" bila tidak ada).</summary>
    Private Function NoTransaksiTerpilih() As String
        If bsTransaksi Is Nothing OrElse bsTransaksi.Count = 0 Then Return ""
        Dim tampilan As DataRowView = TryCast(bsTransaksi.Current, DataRowView)
        If tampilan Is Nothing Then Return ""
        Return tampilan("no_transaksi").ToString()
    End Function

    ' Setiap kali baris master berubah, grid detail ikut diperbarui (master-detail)
    Private Sub bsTransaksi_PositionChanged(sender As Object, e As EventArgs) Handles bsTransaksi.PositionChanged
        MuatDetail()
        PerbaruiTombolNavigasi()
        PerbaruiPosisi()
    End Sub

    ' Klik tombol Tampilkan = menerapkan filter rentang tanggal
    Private Sub btnTerapkan_Click(sender As Object, e As EventArgs) Handles btnTerapkan.Click
        ' Tanggal akhir tidak boleh sebelum awal
        If dtpSampai.Value.Date < dtpDari.Value.Date Then
            FormPesan.Tampilkan(DirectCast(ParentForm, Form), "Riwayat Transaksi",
                                "Tanggal sampai tidak boleh sebelum tanggal dari.",
                                FormPesan.JenisPesan.Peringatan)
            Return
        End If
        MuatTransaksi()
    End Sub

    ' Klik ganda baris master = muat ulang detailnya (juga berguna bila data baru saja disimpan)
    Private Sub dgvTransaksi_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransaksi.CellDoubleClick
        If e.RowIndex >= 0 Then MuatDetail()
    End Sub

    ' Enter di grid master = muat detail baris terpilih
    Private Sub dgvTransaksi_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvTransaksi.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            MuatDetail()
        End If
    End Sub

    ''' <summary>
    ''' Tombol Kembali: menampilkan halaman kasir (panelIsi FormKasir).
    ''' </summary>
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        DirectCast(ParentForm, FormKasir).TampilkanHalamanKasir()
    End Sub

    ' ---------------- Navigasi record ----------------

    Private Sub PerbaruiTombolNavigasi()
        If bsTransaksi Is Nothing Then
            btnPertama.Enabled = False
            btnSebelumnya.Enabled = False
            btnBerikutnya.Enabled = False
            btnTerakhir.Enabled = False
            Return
        End If
        Dim adaRecord As Boolean = bsTransaksi.Count > 0
        Dim diAwal As Boolean = (Not adaRecord) OrElse bsTransaksi.Position <= 0
        Dim diAkhir As Boolean = (Not adaRecord) OrElse bsTransaksi.Position >= bsTransaksi.Count - 1
        btnPertama.Enabled = adaRecord AndAlso Not diAwal
        btnSebelumnya.Enabled = adaRecord AndAlso Not diAwal
        btnBerikutnya.Enabled = adaRecord AndAlso Not diAkhir
        btnTerakhir.Enabled = adaRecord AndAlso Not diAkhir
    End Sub

    Private Sub PerbaruiPosisi()
        If bsTransaksi Is Nothing OrElse bsTransaksi.Count = 0 Then
            lblPosisi.Text = "Record 0 dari 0"
        Else
            lblPosisi.Text = "Record " & (bsTransaksi.Position + 1) & " dari " & bsTransaksi.Count
        End If
    End Sub

    Private Sub btnPertama_Click(sender As Object, e As EventArgs) Handles btnPertama.Click
        If bsTransaksi Is Nothing OrElse bsTransaksi.Count = 0 Then Return
        bsTransaksi.MoveFirst()
    End Sub

    Private Sub btnSebelumnya_Click(sender As Object, e As EventArgs) Handles btnSebelumnya.Click
        If bsTransaksi Is Nothing OrElse bsTransaksi.Count = 0 Then Return
        bsTransaksi.MovePrevious()
    End Sub

    Private Sub btnBerikutnya_Click(sender As Object, e As EventArgs) Handles btnBerikutnya.Click
        If bsTransaksi Is Nothing OrElse bsTransaksi.Count = 0 Then Return
        bsTransaksi.MoveNext()
    End Sub

    Private Sub btnTerakhir_Click(sender As Object, e As EventArgs) Handles btnTerakhir.Click
        If bsTransaksi Is Nothing OrElse bsTransaksi.Count = 0 Then Return
        bsTransaksi.MoveLast()
    End Sub

    ' ---------------- Navigasi halaman ----------------

    Private Sub btnHalKasir_Click(sender As Object, e As EventArgs) Handles btnHalKasir.Click
        DirectCast(ParentForm, FormKasir).TampilkanHalamanKasir()
    End Sub

    Private Sub btnHalData_Click(sender As Object, e As EventArgs) Handles btnHalData.Click
        DirectCast(ParentForm, FormKasir).TampilkanHalamanBarang()
    End Sub

End Class



