Imports MySqlConnector

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
        Dim jawaban As DialogResult = MessageBox.Show(
            "Tutup aplikasi Kasir Minimarket?",
            "Keluar",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If jawaban = DialogResult.Yes Then
            Close()
        End If
    End Sub

    ' CATATAN TAHAP BERIKUTNYA:
    ' btnProses  -> Tahap 4 (INSERT transaksi + detail + pengurangan stok dalam 1 transaction)
    ' btnCetak   -> Tahap 5 (PrintDocument struk, aktif setelah transaksi sukses)
    ' F2/F3      -> Tahap 6 (FormDataBarang, FormRiwayat)

End Class
