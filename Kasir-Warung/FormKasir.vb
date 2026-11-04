Imports MySqlConnector
Imports System.Drawing.Printing
Imports System.Globalization

''' <summary>
''' Form utama Kasir Minimarket.
''' Tahap 2 : tampilan + timer tanggal/jam.
''' Tahap 3 : logika barang - cari, tambah, edit, hapus, bersih,
'''           total belanja, dan kembalian.
''' Tahap 4 : proses pembayaran (transaction database).
''' Tahap 5 : cetak struk.
''' </summary>
Public Class FormKasir

    ' ============ Data keranjang belanja (recordset) ============
    ' Keranjang disimpan sebagai DataTable supaya bisa langsung dijadikan
    ' sumber data dgvBelanja lewat BindingSource - satu sumber data saja,
    ' sehingga grid selalu ikut berubah jika baris ditambah/dihapus.
    Private dtKeranjang As DataTable
    Private bsKeranjang As BindingSource

    ' Baris yang sedang diubah lewat tombol Edit (Nothing = tidak sedang edit).
    ' Disimpan sebagai DataRow (bukan nomor baris) supaya tetap benar
    ' walaupun pengguna mengurutkan grid dengan cara mengklik judul kolom.
    Private barisEdit As DataRow = Nothing

    ' Penanda saat txtBayar sedang diformat ulang, agar tidak berputar-putar
    Private sedangFormatBayar As Boolean = False

    ' ============ Snapshot transaksi terakhir (Tahap 4) ============
    ' Disimpan setelah pembayaran sukses supaya bisa dicetak sebagai
    ' struk pada Tahap 5, tanpa perlu membaca database lagi.
    Private noTransaksiTerakhir As String = ""
    Private tanggalTransaksiTerakhir As Date = Date.MinValue
    Private totalTerakhir As Decimal = 0
    Private bayarTerakhir As Decimal = 0
    Private kembaliTerakhir As Decimal = 0
    Private itemsTerakhir As DataTable = Nothing   ' kolom: nama, jumlah, harga, subtotal
    Private transaksiTerakhirAda As Boolean = False

    ' ============================================================
    ' ============  Tanggal & jam (Tahap 2)  =====================
    ' ============================================================

    ''' <summary>
    ''' Mengisi label tanggal dan jam dari jam SISTEM (bukan contoh mockup),
    ''' memakai format budaya Indonesia (id-ID) lewat Module Helper.
    ''' </summary>
    Private Sub PerbaruiTanggalJam()
        lblTanggal.Text = FormatTanggalPanjang(DateTime.Now)  ' contoh: "Senin, 03 November 2025"
        lblJam.Text = FormatJam(DateTime.Now)                 ' contoh: "14:25:17"
    End Sub

    ' Timer berdetak tiap 1 detik sehingga jam di header selalu tampil real time
    Private Sub tmrJam_Tick(sender As Object, e As EventArgs) Handles tmrJam.Tick
        PerbaruiTanggalJam()
    End Sub

    Private Sub FormKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tampilkan tanggal/jam segera saat form dibuka (tanpa menunggu detik berikutnya)
        PerbaruiTanggalJam()
        tmrJam.Enabled = True   ' nyalakan timer supaya jam berjalan terus tiap detik

        ' Font ikon disesuaikan dengan font yang tersedia di Windows ini,
        ' supaya ikon tetap tampil walau dibuka di Windows 10 maupun 11.
        lblIkonKeranjang.Font = BuatFontIkon(46)
        lblIkonKalender.Font = BuatFontIkon(15)
        lblIkonJam.Font = BuatFontIkon(15)
        lblIkonToko.Font = BuatFontIkon(26)

        ' Rapikan teks kanan footer: jarak lblTerima ke lblHati dibuat tetap.
        ' Dilakukan di sini karena lebar teks AutoSize baru pasti setelah font terpasang.
        lblHati.Left = pnlFooter.ClientSize.Width - lblHati.Width - 18
        lblTerima.Left = lblHati.Left - lblTerima.Width - 12

        ' ---- Tahap 3 ----
        SiapkanGrid()          ' hubungkan kolom grid dengan kolom recordset
        BuatKeranjang()        ' buat recordset keranjang (masih kosong)
        SiapkanCetak()         ' siapkan PrintDocument untuk Tahap 5
        txtTotal.Text = FormatRupiah(0)
        txtKembalian.Text = FormatRupiah(0)

        ' Cetak baru aktif setelah ada transaksi sukses (Tahap 5)
        btnCetak.Enabled = False

        ' Kasir langsung bisa mengetik kode barang
        txtKodeBarang.Focus()
    End Sub

    ' ============================================================
    ' ============  Penyiapan grid & recordset  ==================
    ' ============================================================

    ''' <summary>
    ''' Menghubungkan setiap kolom DataGridView dengan kolom DataTable.
    ''' Dilakukan di kode (bukan di Designer) supaya file Designer tetap
    ''' milik Tahap 2 dan tidak bentrok saat digabung.
    ''' </summary>
    Private Sub SiapkanGrid()
        colNo.DataPropertyName = "no"
        colKode.DataPropertyName = "kode"
        colNama.DataPropertyName = "nama"
        colHarga.DataPropertyName = "harga"
        colJumlah.DataPropertyName = "jumlah"
        colSubtotal.DataPropertyName = "subtotal"

        ' Nomor urut dihitung sendiri, bukan urutan database
        colNo.SortMode = DataGridViewColumnSortMode.NotSortable
        colKode.SortMode = DataGridViewColumnSortMode.NotSortable
        colNama.SortMode = DataGridViewColumnSortMode.NotSortable
        colHarga.SortMode = DataGridViewColumnSortMode.NotSortable
        colJumlah.SortMode = DataGridViewColumnSortMode.NotSortable
        colSubtotal.SortMode = DataGridViewColumnSortMode.NotSortable

        ' Kolom uang ditampilkan format Rp3.000 (budaya id-ID)
        Dim gayaUang As New DataGridViewCellStyle()
        gayaUang.Format = "Rp#,##0"
        gayaUang.FormatProvider = BudayaId()
        gayaUang.Alignment = DataGridViewContentAlignment.MiddleRight
        colHarga.DefaultCellStyle = gayaUang
        colSubtotal.DefaultCellStyle = gayaUang

        ' Judul kolom bold, sama dengan gaya form
        Dim gayaHeader As New DataGridViewCellStyle()
        gayaHeader.Font = New Font(dgvBelanja.Font, FontStyle.Bold)
        dgvBelanja.ColumnHeadersDefaultCellStyle = gayaHeader
    End Sub

    ''' <summary>Membuat recordset keranjang (belum berisi baris).</summary>
    Private Sub BuatKeranjang()
        dtKeranjang = New DataTable("keranjang")
        dtKeranjang.Columns.Add("no", GetType(Integer))
        dtKeranjang.Columns.Add("kode", GetType(String))
        dtKeranjang.Columns.Add("nama", GetType(String))
        dtKeranjang.Columns.Add("harga", GetType(Decimal))
        dtKeranjang.Columns.Add("jumlah", GetType(Integer))
        dtKeranjang.Columns.Add("subtotal", GetType(Decimal))

        bsKeranjang = New BindingSource()
        bsKeranjang.DataSource = dtKeranjang
        dgvBelanja.DataSource = bsKeranjang
    End Sub

    ''' <summary>
    ''' Membaca satu barang dari database berdasarkan kode.
    ''' Mengembalikan Nothing jika kode tidak ditemukan.
    ''' </summary>
    Private Function AmbilBarang(kode As String) As DataRow
        Dim tabel As New DataTable()

        Try
            Using conn As MySqlConnection = BuatKoneksi()
                ' Parameter @kode: input pengguna tidak pernah disatukan ke SQL
                Using cmd As New MySqlCommand(
                        "SELECT kode_barang, nama_barang, harga, stok " &
                        "FROM barang WHERE kode_barang = @kode", conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    conn.Open()
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(tabel)
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show(
                "Gagal membaca data barang." & vbCrLf & vbCrLf &
                "Pastikan Laragon (MySQL) sudah berjalan." & vbCrLf & ex.Message,
                "Kasir Minimarket", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Catch ex As Exception
            MessageBox.Show(
                "Terjadi kesalahan saat mencari barang." & vbCrLf & vbCrLf & ex.Message,
                "Kasir Minimarket", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try

        If tabel.Rows.Count = 0 Then Return Nothing
        Return tabel.Rows(0)
    End Function

    ' ============================================================
    ' ============  Kode Barang (cari)  ==========================
    ' ============================================================

    ''' <summary>
    ''' Mencari barang sesuai isi txtKodeBarang.
    ''' Jika ketemu: isi nama, harga, jumlah default 1, lalu fokus ke jumlah.
    ''' </summary>
    Private Sub CariBarang()
        Dim kode As String = txtKodeBarang.Text.Trim()

        If kode = "" Then
            MessageBox.Show(
                "Kode barang belum diisi." & vbCrLf &
                "Contoh kode: B001",
                "Kasir Minimarket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtKodeBarang.Focus()
            Return
        End If

        Dim brg As DataRow = AmbilBarang(kode)

        If brg Is Nothing Then
            MessageBox.Show(
                "Barang tidak ditemukan.",
                "Kasir Minimarket", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKodeBarang.SelectAll()
            txtKodeBarang.Focus()
            Return
        End If

        ' Isi kolom input dari recordset
        txtKodeBarang.Text = brg("kode_barang").ToString()
        txtNamaBarang.Text = brg("nama_barang").ToString()
        txtHarga.Text = FormatRupiah(CDec(brg("harga")))
        txtJumlah.Text = "1"
        HitungSubtotal()

        ' Langsung ke jumlah supaya kasir tinggal mengetik berapa
        txtJumlah.Focus()
        txtJumlah.SelectAll()
    End Sub

    ' Enter di txtKodeBarang = langsung cari ke database
    Private Sub txtKodeBarang_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKodeBarang.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True   ' cegah bunyi "ding"
            CariBarang()
        End If
    End Sub

    ' Tombol kaca pembesar = dialog pencarian barang (recordset + navigasi)
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Using dialog As New FormCariBarang()
            If dialog.ShowDialog(Me) = DialogResult.OK Then
                txtKodeBarang.Text = dialog.KodeBarangTerpilih
                CariBarang()
            End If
        End Using
    End Sub

    ' ============================================================
    ' ============  Jumlah & Subtotal  ==========================
    ' ============================================================

    ' Hanya angka yang boleh diketik pada kolom Jumlah
    Private Sub txtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlah.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtJumlah_TextChanged(sender As Object, e As EventArgs) Handles txtJumlah.TextChanged
        HitungSubtotal()
    End Sub

    ''' <summary>Subtotal = Harga x Jumlah.</summary>
    Private Sub HitungSubtotal()
        Dim harga As Decimal = ParseRupiah(txtHarga.Text)
        Dim jumlah As Integer = 0
        Integer.TryParse(txtJumlah.Text, jumlah)   ' kosong/tidak valid dianggap 0

        txtSubtotal.Text = FormatRupiah(harga * jumlah)
    End Sub

    ' Enter di txtJumlah = sama dengan menekan tombol Tambah (atau menyimpan edit)
    Private Sub txtJumlah_KeyDown(sender As Object, e As KeyEventArgs) Handles txtJumlah.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If barisEdit IsNot Nothing Then
                SimpanEdit()
            Else
                TambahKeKeranjang()
            End If
        End If
    End Sub

    ' ============================================================
    ' ============  Tambah  ======================================
    ' ============================================================

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        TambahKeKeranjang()
    End Sub

    ''' <summary>
    ''' Menambahkan barang ke keranjang. Jika kode yang sama sudah ada,
    ''' jumlahnya digabung pada baris yang sama.
    ''' </summary>
    Private Sub TambahKeKeranjang()
        ' --- Validasi 1: barang harus sudah dipilih ---
        Dim kode As String = txtKodeBarang.Text.Trim()
        If kode = "" OrElse txtNamaBarang.Text = "" Then
            MessageBox.Show(
                "Barang belum dipilih." & vbCrLf &
                "Ketik kode lalu tekan Enter, atau klik tombol cari.",
                "Kasir Minimarket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtKodeBarang.Focus()
            Return
        End If

        ' --- Validasi 2: jumlah harus angka lebih dari 0 ---
        Dim jumlah As Integer
        If Not Integer.TryParse(txtJumlah.Text, jumlah) OrElse jumlah <= 0 Then
            MessageBox.Show(
                "Jumlah harus berupa angka lebih dari 0.",
                "Kasir Minimarket", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtJumlah.Focus()
            txtJumlah.SelectAll()
            Return
        End If

        ' --- Validasi 3: stok di database harus cukup ---
        ' Stok dibaca ulang dari database supaya tidak memakai data lama.
        Dim brg As DataRow = AmbilBarang(kode)
        If brg Is Nothing Then
            MessageBox.Show(
                "Barang tidak ditemukan.",
                "Kasir Minimarket", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim stok As Integer = CInt(brg("stok"))
        Dim jumlahSudah As Integer = JumlahDiKeranjang(kode)

        If jumlahSudah + jumlah > stok Then
            MessageBox.Show(
                "Stok tidak cukup." & vbCrLf & vbCrLf &
                "Barang   : " & brg("nama_barang").ToString() & vbCrLf &
                "Stok tersedia : " & stok & vbCrLf &
                "Sudah di keranjang : " & jumlahSudah & vbCrLf &
                "Diminta : " & (jumlahSudah + jumlah),
                "Kasir Minimarket", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtJumlah.Focus()
            txtJumlah.SelectAll()
            Return
        End If

        ' --- Masukkan ke recordset keranjang ---
        Dim sudahAda As Boolean = False

        For Each baris As DataRow In dtKeranjang.Rows
            If baris("kode").ToString() = kode Then
                ' Kode sama: jumlah digabung ke baris yang sudah ada
                Dim jumlahBaru As Integer = CInt(baris("jumlah")) + jumlah
                baris("jumlah") = jumlahBaru
                baris("subtotal") = CDec(baris("harga")) * jumlahBaru
                sudahAda = True
                Exit For
            End If
        Next

        If Not sudahAda Then
            Dim harga As Decimal = CDec(brg("harga"))
            dtKeranjang.Rows.Add(
                0,                              ' nomor urut diisi ulang di bawah
                kode,
                brg("nama_barang").ToString(),
                harga,
                jumlah,
                harga * jumlah)
        End If

        PerbaruiNomor()
        HitungTotal()
        KosongkanInput()

        ' Kasir langsung bisa mengetik kode barang berikutnya
        txtKodeBarang.Focus()
    End Sub

    ' ============================================================
    ' ============  Edit  ========================================
    ' ============================================================

    ''' <summary>
    ''' Klik pertama: baris terpilih dimuat ke kolom input.
    ''' Klik kedua (atau Enter di jumlah): perubahan disimpan ke baris itu.
    ''' </summary>
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If barisEdit Is Nothing Then
            ' ---- Langkah 1: muat baris ke kolom input ----
            Dim baris As DataRow = BarisTerpilih()
            If baris Is Nothing Then
                MessageBox.Show(
                    "Pilih dulu baris belanja yang ingin diedit.",
                    "Kasir Minimarket", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            barisEdit = baris
            txtKodeBarang.Text = baris("kode").ToString()
            txtNamaBarang.Text = baris("nama").ToString()
            txtHarga.Text = FormatRupiah(CDec(baris("harga")))
            txtJumlah.Text = baris("jumlah").ToString()
            HitungSubtotal()

            txtJumlah.Focus()
            txtJumlah.SelectAll()
        Else
            ' ---- Langkah 2: simpan perubahan ----
            SimpanEdit()
        End If
    End Sub

    ''' <summary>Menyimpan perubahan jumlah ke baris yang sedang diedit.</summary>
    Private Sub SimpanEdit()
        ' Validasi jumlah
        Dim jumlah As Integer
        If Not Integer.TryParse(txtJumlah.Text, jumlah) OrElse jumlah <= 0 Then
            MessageBox.Show(
                "Jumlah harus berupa angka lebih dari 0.",
                "Kasir Minimarket", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtJumlah.Focus()
            txtJumlah.SelectAll()
            Return
        End If

        ' Baca stok terbaru; jumlah di baris sendiri tidak dihitung
        Dim brg As DataRow = AmbilBarang(txtKodeBarang.Text.Trim())
        If brg Is Nothing Then
            MessageBox.Show(
                "Barang tidak ditemukan.",
                "Kasir Minimarket", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim stok As Integer = CInt(brg("stok"))
        Dim jumlahLain As Integer = JumlahDiKeranjang(brg("kode_barang").ToString(), barisEdit)

        If jumlahLain + jumlah > stok Then
            MessageBox.Show(
                "Stok tidak cukup." & vbCrLf & vbCrLf &
                "Barang   : " & brg("nama_barang").ToString() & vbCrLf &
                "Stok tersedia : " & stok & vbCrLf &
                "Diminta : " & (jumlahLain + jumlah),
                "Kasir Minimarket", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtJumlah.Focus()
            txtJumlah.SelectAll()
            Return
        End If

        ' Perbarui baris (harga ikut disegarkan dari database)
        barisEdit("nama") = brg("nama_barang").ToString()
        barisEdit("harga") = CDec(brg("harga"))
        barisEdit("jumlah") = jumlah
        barisEdit("subtotal") = CDec(barisEdit("harga")) * jumlah

        HitungTotal()
        KosongkanInput()
        txtKodeBarang.Focus()
    End Sub

    ' ============================================================
    ' ============  Hapus  =======================================
    ' ============================================================

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim baris As DataRow = BarisTerpilih()
        If baris Is Nothing Then
            MessageBox.Show(
                "Pilih dulu baris belanja yang ingin dihapus.",
                "Kasir Minimarket", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim jawaban As DialogResult = MessageBox.Show(
            "Hapus " & baris("nama").ToString() & " dari daftar belanja?",
            "Konfirmasi Hapus",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If jawaban = DialogResult.No Then Return

        ' Jika baris yang dihapus adalah yang sedang diedit, batalkan mode edit
        If barisEdit Is baris Then
            barisEdit = Nothing
        End If

        dtKeranjang.Rows.Remove(baris)

        PerbaruiNomor()
        HitungTotal()
        KosongkanInput()
        txtKodeBarang.Focus()
    End Sub

    ' ============================================================
    ' ============  Bersih  ======================================
    ' ============================================================

    Private Sub btnBersih_Click(sender As Object, e As EventArgs) Handles btnBersih.Click
        KosongkanInput()

        ' Konfirmasi tambahan: apakah daftar belanja juga dikosongkan?
        Dim jawaban As DialogResult = MessageBox.Show(
            "Kosongkan juga daftar belanja?",
            "Konfirmasi",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If jawaban = DialogResult.Yes Then
            dtKeranjang.Clear()
            PerbaruiNomor()
            HitungTotal()
        End If

        txtKodeBarang.Focus()
    End Sub

    ''' <summary>Mengosongkan seluruh kolom input barang.</summary>
    Private Sub KosongkanInput()
        barisEdit = Nothing
        txtKodeBarang.Text = ""
        txtNamaBarang.Text = ""
        txtHarga.Text = ""
        txtJumlah.Text = ""
        txtSubtotal.Text = ""
    End Sub

    ' ============================================================
    ' ============  Total, Bayar, Kembalian  =====================
    ' ============================================================

    ''' <summary>Total belanja = jumlah seluruh subtotal di keranjang.</summary>
    Private Sub HitungTotal()
        Dim total As Decimal = 0

        For Each baris As DataRow In dtKeranjang.Rows
            total += CDec(baris("subtotal"))
        Next

        txtTotal.Text = FormatRupiah(total)
        HitungKembalian()
    End Sub

    ''' <summary>Kembalian = Bayar - Total (tidak pernah minus).</summary>
    Private Sub HitungKembalian()
        Dim total As Decimal = ParseRupiah(txtTotal.Text)
        Dim bayar As Decimal = ParseRupiah(txtBayar.Text)
        Dim kembali As Decimal = bayar - total

        If kembali < 0 Then kembali = 0

        txtKembalian.Text = FormatRupiah(kembali)
    End Sub

    ' Hanya angka yang boleh diketik pada kolom Bayar
    Private Sub txtBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBayar.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' Mengubah angka ketikan menjadi format ribuan (3000 -> 3.000)
    ''' lalu langsung menghitung kembali kembalian.
    ''' </summary>
    Private Sub txtBayar_TextChanged(sender As Object, e As EventArgs) Handles txtBayar.TextChanged
        ' Penanda supaya format ulang tidak memicu TextChanged berulang
        If sedangFormatBayar Then Return
        sedangFormatBayar = True

        Dim nilai As Decimal = ParseRupiah(txtBayar.Text)
        Dim teksBaru As String = If(nilai = 0, "", nilai.ToString("N0", BudayaId()))

        If txtBayar.Text <> teksBaru Then
            txtBayar.Text = teksBaru
            txtBayar.SelectionStart = txtBayar.Text.Length   ' kursor selalu di ujung
        End If

        sedangFormatBayar = False
        HitungKembalian()
    End Sub

    ' ============================================================
    ' ============  Utilitas recordset  ==========================
    ' ============================================================

    ''' <summary>Baris yang sedang dipilih di grid (Nothing jika tidak ada).</summary>
    Private Function BarisTerpilih() As DataRow
        If bsKeranjang Is Nothing Then Return Nothing

        Dim tampilan As DataRowView = TryCast(bsKeranjang.Current, DataRowView)
        If tampilan Is Nothing Then Return Nothing
        Return tampilan.Row
    End Function

    ''' <summary>Menghitung ulang kolom No dari atas ke bawah.</summary>
    Private Sub PerbaruiNomor()
        Dim nomor As Integer = 1
        For Each baris As DataRow In dtKeranjang.Rows
            baris("no") = nomor
            nomor += 1
        Next
    End Sub

    ''' <summary>
    ''' Menjumlahkan jumlah suatu kode di keranjang.
    ''' Parameter kecuali dipakai saat edit, supaya baris yang sedang
    ''' diubah tidak ikut dihitung dua kali.
    ''' </summary>
    Private Function JumlahDiKeranjang(kode As String, Optional kecuali As DataRow = Nothing) As Integer
        Dim jumlahTotal As Integer = 0

        For Each baris As DataRow In dtKeranjang.Rows
            If baris Is kecuali Then Continue For
            If baris("kode").ToString() = kode Then
                jumlahTotal += CInt(baris("jumlah"))
            End If
        Next

        Return jumlahTotal
    End Function

    ' ============================================================
    ' ============  Tombol keluar  ===============================
    ' ============================================================

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        ' Dialog seragam FormPesan (tombol Yes/No) supaya tampil sama
        ' dengan tema biru program, bukan MessageBox polos.
        Dim dlg As New FormPesan("Keluar", "Tutup aplikasi Kasir Minimarket?", True)
        If dlg.ShowDialog(Me) = DialogResult.Yes Then
            Close()
        End If
    End Sub

    ' ============================================================
    ' ============  Proses Pembayaran (Tahap 4)  ================
    ' ============================================================

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        ProsesPembayaran()
    End Sub

    ''' <summary>
    ''' Menyimpan transaksi penjualan ke database.
    ''' Nomor, header, detail, dan pengurangan stok berjalan dalam SATU
    ''' MySqlTransaction: ada satu langkah yang gagal = seluruhnya dibatalkan
    ''' (rollback), sehingga data tidak pernah tersimpan setengah jadi.
    ''' </summary>
    Private Sub ProsesPembayaran()
        ' ---------- Validasi 1: keranjang tidak boleh kosong ----------
        If dtKeranjang Is Nothing OrElse dtKeranjang.Rows.Count = 0 Then
            FormPesan.Tampilkan(Me,
                "Proses Pembayaran",
                "Keranjang masih kosong." & vbCrLf &
                "Tambahkan barang dulu sebelum memproses pembayaran.",
                FormPesan.JenisPesan.Informasi)
            txtKodeBarang.Focus()
            Return
        End If

        ' ---------- Validasi 2: bayar harus >= total ----------
        Dim total As Decimal = ParseRupiah(txtTotal.Text)
        Dim bayar As Decimal = ParseRupiah(txtBayar.Text)

        If bayar < total Then
            FormPesan.Tampilkan(Me,
                "Proses Pembayaran",
                "Uang bayar kurang dari total belanja." & vbCrLf & vbCrLf &
                "Total : " & FormatRupiah(total) & vbCrLf &
                "Bayar : " & FormatRupiah(bayar),
                FormPesan.JenisPesan.Peringatan)
            txtBayar.Focus()
            txtBayar.SelectAll()
            Return
        End If

        Dim kembali As Decimal = bayar - total
        Dim noTransaksi As String = ""
        Dim tanggalTransaksi As Date = DateTime.Now

        Try
            Using conn As MySqlConnection = BuatKoneksi()
                conn.Open()

                ' Satu transaksi database untuk seluruh rangkaian penyimpanan
                Using trans As MySqlTransaction = conn.BeginTransaction()
                    Try
                        ' (1) Nomor urut per hari, dihitung DI DALAM transaksi ini
                        noTransaksi = BuatNomorTransaksi(conn, trans)

                        ' (2) Simpan kepala transaksi
                        InsertTransaksi(conn, trans, noTransaksi, tanggalTransaksi,
                                        total, bayar, kembali)

                        ' (3) Simpan tiap item, lalu kurangi stoknya
                        For Each baris As DataRow In dtKeranjang.Rows
                            Dim kode As String = baris("kode").ToString()
                            Dim nama As String = baris("nama").ToString()
                            Dim jumlah As Integer = CInt(baris("jumlah"))
                            Dim hargaSatuan As Decimal = CDec(baris("harga"))
                            Dim subtotal As Decimal = CDec(baris("subtotal"))

                            InsertDetail(conn, trans, noTransaksi, kode,
                                         jumlah, hargaSatuan, subtotal)

                            ' UPDATE memakai syarat stok >= jumlah.
                            ' RowsAffected = 0 berarti stok tidak cukup
                            ' (bisa saja baru terjual di kasir lain).
                            If Not KurangiStok(conn, trans, kode, jumlah) Then
                                trans.Rollback()   ' batalkan semua langkah di atas

                                FormPesan.Tampilkan(Me,
                                    "Proses Pembayaran",
                                    "Transaksi dibatalkan karena stok tidak cukup." & vbCrLf & vbCrLf &
                                    "Barang          : " & nama & vbCrLf &
                                    "Jumlah diminta  : " & jumlah & vbCrLf & vbCrLf &
                                    "Silakan kurangi jumlah barang tersebut di keranjang.",
                                    FormPesan.JenisPesan.Peringatan)
                                Return
                            End If
                        Next

                        trans.Commit()   ' semua langkah berhasil: simpan permanen
                    Catch ex As Exception
                        ' Pastikan transaksi batal bila error terjadi di tengah jalan
                        Try
                            trans.Rollback()
                        Catch
                            ' diabaikan: bisa jadi rollback sudah dilakukan di atas
                        End Try
                        Throw
                    End Try
                End Using
            End Using
        Catch ex As MySqlException
            FormPesan.Tampilkan(Me,
                "Proses Pembayaran",
                "Gagal menyimpan transaksi." & vbCrLf & vbCrLf & ex.Message,
                FormPesan.JenisPesan.Kesalahan)
            Return
        Catch ex As Exception
            FormPesan.Tampilkan(Me,
                "Proses Pembayaran",
                "Terjadi kesalahan saat memproses pembayaran." & vbCrLf & vbCrLf & ex.Message,
                FormPesan.JenisPesan.Kesalahan)
            Return
        End Try

        ' ---------- Berhasil: simpan snapshot untuk struk (Tahap 5) ----------
        SimpanSnapshot(noTransaksi, tanggalTransaksi, total, bayar, kembali)

        btnCetak.Enabled = True    ' struk baru boleh dicetak setelah transaksi sukses

        ' Bersih-bersih form untuk transaksi berikutnya
        dtKeranjang.Clear()
        PerbaruiNomor()
        txtBayar.Text = ""
        HitungTotal()
        KosongkanInput()
        txtKodeBarang.Focus()

        FormPesan.Tampilkan(Me,
            "Proses Pembayaran",
            "Transaksi berhasil disimpan." & vbCrLf & vbCrLf &
            "No Transaksi : " & noTransaksi & vbCrLf &
            "Total    : " & FormatRupiah(total) & vbCrLf &
            "Bayar    : " & FormatRupiah(bayar) & vbCrLf &
            "Kembali  : " & FormatRupiah(kembali),
            FormPesan.JenisPesan.Sukses)
    End Sub

    ''' <summary>
    ''' Membuat nomor transaksi TRX-yyyyMMdd-001 (urut per hari).
    ''' Dihitung di dalam transaksi database yang sama supaya dua kasir
    ''' tidak pernah mendapat nomor kembar.
    ''' </summary>
    Private Function BuatNomorTransaksi(conn As MySqlConnection,
                                        trans As MySqlTransaction) As String
        ' yyyyMMdd harus pola tetap, jadi memakai budaya Invariant
        ' (urutan tahun-bulan-tanggal, semua digit)
        Dim prefix As String = "TRX-" &
            DateTime.Now.ToString("yyyyMMdd", CultureInfo.InvariantCulture)

        Dim urut As Integer = 1   ' transaksi pertama hari ini

        Using cmd As New MySqlCommand(
                "SELECT no_transaksi FROM transaksi " &
                "WHERE no_transaksi LIKE @prefix " &
                "ORDER BY no_transaksi DESC LIMIT 1", conn, trans)
            cmd.Parameters.AddWithValue("@prefix", prefix & "-%")

            Dim hasil As Object = cmd.ExecuteScalar()
            If TypeOf hasil Is String Then
                ' Contoh hasil: TRX-20261103-002 -> ambil "002" lalu +1
                Dim bagian As String() = hasil.ToString().Split("-"c)
                Dim angka As Integer = 0
                If bagian.Length > 0 AndAlso
                   Integer.TryParse(bagian(bagian.Length - 1), angka) Then
                    urut = angka + 1
                End If
            End If
        End Using

        Return prefix & "-" & urut.ToString("D3", CultureInfo.InvariantCulture)
    End Function

    ''' <summary>INSERT ke tabel transaksi (kepala transaksi).</summary>
    Private Sub InsertTransaksi(conn As MySqlConnection, trans As MySqlTransaction,
                                no As String, tanggal As Date,
                                total As Decimal, bayar As Decimal, kembali As Decimal)
        Using cmd As New MySqlCommand(
                "INSERT INTO transaksi (no_transaksi, tanggal, total, bayar, kembali) " &
                "VALUES (@no, @tanggal, @total, @bayar, @kembali)", conn, trans)
            cmd.Parameters.AddWithValue("@no", no)
            cmd.Parameters.AddWithValue("@tanggal", tanggal)
            cmd.Parameters.AddWithValue("@total", total)
            cmd.Parameters.AddWithValue("@bayar", bayar)
            cmd.Parameters.AddWithValue("@kembali", kembali)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ''' <summary>INSERT satu baris ke tabel detail_transaksi.</summary>
    Private Sub InsertDetail(conn As MySqlConnection, trans As MySqlTransaction,
                             no As String, kode As String, jumlah As Integer,
                             hargaSatuan As Decimal, subtotal As Decimal)
        Using cmd As New MySqlCommand(
                "INSERT INTO detail_transaksi " &
                "(no_transaksi, kode_barang, jumlah, harga_satuan, subtotal) " &
                "VALUES (@no, @kode, @jumlah, @harga, @subtotal)", conn, trans)
            cmd.Parameters.AddWithValue("@no", no)
            cmd.Parameters.AddWithValue("@kode", kode)
            cmd.Parameters.AddWithValue("@jumlah", jumlah)
            cmd.Parameters.AddWithValue("@harga", hargaSatuan)
            cmd.Parameters.AddWithValue("@subtotal", subtotal)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ''' <summary>
    ''' Mengurangi stok satu barang. Syarat stok >= jumlah ada di SQL,
    ''' sehingga stok tidak akan pernah menjadi minus.
    ''' Mengembalikan False bila stok tidak mencukupi.
    ''' </summary>
    Private Function KurangiStok(conn As MySqlConnection, trans As MySqlTransaction,
                                 kode As String, jumlah As Integer) As Boolean
        Using cmd As New MySqlCommand(
                "UPDATE barang SET stok = stok - @jumlah " &
                "WHERE kode_barang = @kode AND stok >= @jumlah", conn, trans)
            cmd.Parameters.AddWithValue("@jumlah", jumlah)
            cmd.Parameters.AddWithValue("@kode", kode)
            Return cmd.ExecuteNonQuery() > 0
        End Using
    End Function

    ''' <summary>
    ''' Menyalin isi keranjang ke memori sebagai persiapan struk (Tahap 5),
    ''' supaya tidak perlu membaca database lagi saat mencetak.
    ''' </summary>
    Private Sub SimpanSnapshot(no As String, tanggal As Date,
                               total As Decimal, bayar As Decimal, kembali As Decimal)
        noTransaksiTerakhir = no
        tanggalTransaksiTerakhir = tanggal
        totalTerakhir = total
        bayarTerakhir = bayar
        kembaliTerakhir = kembali

        itemsTerakhir = New DataTable("struk")
        itemsTerakhir.Columns.Add("nama", GetType(String))
        itemsTerakhir.Columns.Add("jumlah", GetType(Integer))
        itemsTerakhir.Columns.Add("harga", GetType(Decimal))
        itemsTerakhir.Columns.Add("subtotal", GetType(Decimal))

        For Each baris As DataRow In dtKeranjang.Rows
            itemsTerakhir.Rows.Add(
                baris("nama").ToString(),
                CInt(baris("jumlah")),
                CDec(baris("harga")),
                CDec(baris("subtotal")))
        Next

        transaksiTerakhirAda = True
    End Sub

    ' ============================================================
    ' ============  Cetak Struk (Tahap 5)  =========================
    ' ============================================================

    Private struk As PrintDocument
    Private pratinjau As PrintPreviewDialog

    ''' <summary>
    ''' Menyiapkan PrintDocument dan PrintPreviewDialog di kode (bukan di
    ''' Designer) supaya file Designer tetap milik Tahap 2 dan tidak bentrok
    ''' saat digabung.
    ''' </summary>
    Private Sub SiapkanCetak()
        struk = New PrintDocument()
        ' Struk mode kasir: kertas sempit, orientasi tegak
        struk.DefaultPageSettings.PaperSize = New PaperSize("Struk", 300, 800)
        struk.DefaultPageSettings.Margins = New Margins(30, 30, 30, 30)
        AddHandler struk.PrintPage, AddressOf Struk_PrintPage

        pratinjau = New PrintPreviewDialog()
        pratinjau.Document = struk
        pratinjau.Text = "Cetak Struk - Minimarket Sejahtera"
    End Sub

    ''' <summary>
    ''' Tombol Cetak Struk. Hanya aktif setelah transaksi sukses (Tahap 4),
    ''' lalu menampilkan pratinjau sebelum mencetak.
    ''' </summary>
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        ' Belum ada transaksi sukses: tidak ada struk untuk dicetak
        If Not transaksiTerakhirAda OrElse itemsTerakhir Is Nothing OrElse itemsTerakhir.Rows.Count = 0 Then
            FormPesan.Tampilkan(Me,
                "Cetak Struk",
                "Belum ada transaksi untuk dicetak." & vbCrLf &
                "Selesaikan Proses Pembayaran terlebih dahulu.",
                FormPesan.JenisPesan.Informasi)
            Return
        End If

        ' Pastikan tugas cetak siap (dibuat sekali di FormKasir_Load)
        If struk Is Nothing Then SiapkanCetak()

        pratinjau.ShowDialog(Me)
    End Sub

    ''' <summary>
    ''' Menggambar struk pada kertas.
    ''' Font monospace (Courier New / Consolas) dipakai supaya kolom
    ''' terjajar rapi seperti struk toko beneran.
    ''' </summary>
    Private Sub Struk_PrintPage(sender As Object, e As PrintPageEventArgs)
        If Not transaksiTerakhirAda OrElse itemsTerakhir Is Nothing Then
            e.HasMorePages = False
            Return
        End If

        ' Baris-baris struk: huruf mono -> posisi selalu rata
        Dim fontJudul As New Font("Courier New", 14, FontStyle.Bold)
        Dim fontBiasa As New Font("Courier New", 10, FontStyle.Regular)
        Dim fontTebal As New Font("Courier New", 10, FontStyle.Bold)

        Dim x As Single = e.MarginBounds.Left
        Dim y As Single = e.MarginBounds.Top
        Dim lebar As Single = e.MarginBounds.Width
        Dim tinggiBaris As Single = fontBiasa.GetHeight(e.Graphics) + 2

        ' --- Kepala struk ---
        TulisBerbaris(e.Graphics, fontJudul, x, y, lebar, "Minimarket Sejahtera")
        y += tinggiBaris + tinggiBaris

        TulisBerbaris(e.Graphics, fontBiasa, x, y, lebar, "Belanja Mudah, Harga Bersahabat")
        y += tinggiBaris

        TulisBerbaris(e.Graphics, fontBiasa, x, y, lebar, "No Transaksi : " & noTransaksiTerakhir)
        y += tinggiBaris

        TulisBerbaris(e.Graphics, fontBiasa, x, y, lebar,
                      "Tanggal      : " & FormatTanggalPanjang(tanggalTransaksiTerakhir) & " " & FormatJam(tanggalTransaksiTerakhir))
        y += tinggiBaris

        ' Garis pemisah menandakan ganti bagian
        TulisBerbaris(e.Graphics, fontBiasa, x, y, lebar, New String("-"c, 32))
        y += tinggiBaris

        ' --- Daftar item: nama, jumlah x harga, subtotal ---
        For Each baris As DataRow In itemsTerakhir.Rows
            Dim nama As String = baris("nama").ToString()
            Dim jumlah As Integer = CInt(baris("jumlah"))
            Dim harga As Decimal = CDec(baris("harga"))
            Dim subtotal As Decimal = CDec(baris("subtotal"))

            ' Nama panjang dipotong supaya tidak merusak lebar struk
            TulisBerbaris(e.Graphics, fontBiasa, x, y, lebar, Potong(nama, 32))
            y += tinggiBaris

            Dim rincian As String = jumlah.ToString(BudayaId()) & " x " & FormatRupiah(harga)
            TulisKanan(e.Graphics, fontBiasa, x, y, lebar, rincian, FormatRupiah(subtotal))
            y += tinggiBaris
        Next

        TulisBerbaris(e.Graphics, fontBiasa, x, y, lebar, New String("-"c, 32))
        y += tinggiBaris

        ' --- Total / Bayar / Kembali ---
        TulisKanan(e.Graphics, fontTebal, x, y, lebar, "Total", FormatRupiah(totalTerakhir))
        y += tinggiBaris
        TulisKanan(e.Graphics, fontBiasa, x, y, lebar, "Bayar", FormatRupiah(bayarTerakhir))
        y += tinggiBaris
        TulisKanan(e.Graphics, fontTebal, x, y, lebar, "Kembali", FormatRupiah(kembaliTerakhir))
        y += tinggiBaris

        TulisBerbaris(e.Graphics, fontBiasa, x, y, lebar, New String("-"c, 32))
        y += tinggiBaris

        TulisBerbaris(e.Graphics, fontJudul, x, y, lebar, "Terima Kasih")
        y += tinggiBaris
        TulisBerbaris(e.Graphics, fontBiasa, x, y, lebar, "atas Kunjungan Anda")
        y += tinggiBaris

        TulisBerbaris(e.Graphics, fontBiasa, x, y, lebar, New String("-"c, 32))

        fontJudul.Dispose()
        fontBiasa.Dispose()
        fontTebal.Dispose()

        e.HasMorePages = False   ' struk selalu satu halaman
    End Sub

    ''' <summary>
    ''' Menulis teks rata kiri pada lebar penuh, di tengah garis.
    ''' </summary>
    Private Sub TulisBerbaris(g As Graphics, font As Font,
                              x As Single, y As Single, lebar As Single, teks As String)
        Using brush As New SolidBrush(Color.Black)
            g.DrawString(teks, font, brush, x, y)
        End Using
    End Sub

    ''' <summary>
    ''' Menulis label di kiri dan angka di kanan pada baris yang sama.
    ''' </summary>
    Private Sub TulisKanan(g As Graphics, font As Font,
                           x As Single, y As Single, lebar As Single,
                           label As String, nilai As String)
        Using brush As New SolidBrush(Color.Black)
            g.DrawString(label, font, brush, x, y)

            ' Geser ke kanan: akhir nilai menempel di tepi kanan kertas
            Dim lebarNilai As Single = g.MeasureString(nilai, font).Width
            g.DrawString(nilai, font, brush, x + lebar - lebarNilai, y)
        End Using
    End Sub

    ''' <summary>
    ''' Memotong teks kepanjangan sesuai lebar struk (font mono).
    ''' </summary>
    Private Function Potong(teks As String, maks As Integer) As String
        If teks.Length <= maks Then Return teks
        Return teks.Substring(0, maks - 3) & "..."
    End Function

    ' ============================================================
    ' ============  Catatan tahap berikutnya  ====================
    ' ============================================================
    ' F2 / F3   -> Tahap 6 (FormDataBarang, FormRiwayat)

End Class
