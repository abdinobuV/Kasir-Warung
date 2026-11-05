<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKasir
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblIkonKeranjang = New System.Windows.Forms.Label()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.lblSubjudul = New System.Windows.Forms.Label()
        Me.pnlJam = New Global.Kasir_Warung.PanelBulat()
        Me.lblIkonKalender = New System.Windows.Forms.Label()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.lblIkonJam = New System.Windows.Forms.Label()
        Me.lblJam = New System.Windows.Forms.Label()
        Me.pnlIsi = New System.Windows.Forms.Panel()
        Me.tblUtama = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlDataBarang = New Global.Kasir_Warung.PanelBulat()
        Me.pnlTabBarang = New Global.Kasir_Warung.PanelBulat()
        Me.lblTabBarang = New System.Windows.Forms.Label()
        Me.lblKodeBarang = New System.Windows.Forms.Label()
        Me.txtKodeBarang = New System.Windows.Forms.TextBox()
        Me.btnCari = New Global.Kasir_Warung.TombolBulat()
        Me.lblNamaBarang = New System.Windows.Forms.Label()
        Me.txtNamaBarang = New System.Windows.Forms.TextBox()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.lblJumlah = New System.Windows.Forms.Label()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.btnTambah = New Global.Kasir_Warung.TombolBulat()
        Me.btnEdit = New Global.Kasir_Warung.TombolBulat()
        Me.btnHapus = New Global.Kasir_Warung.TombolBulat()
        Me.btnBersih = New Global.Kasir_Warung.TombolBulat()
        Me.pnlDaftarBelanja = New Global.Kasir_Warung.PanelBulat()
        Me.pnlTabBelanja = New Global.Kasir_Warung.PanelBulat()
        Me.lblTabBelanja = New System.Windows.Forms.Label()
        Me.dgvBelanja = New System.Windows.Forms.DataGridView()
        Me.colNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colJumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlDataTransaksi = New Global.Kasir_Warung.PanelBulat()
        Me.pnlTabTransaksi = New Global.Kasir_Warung.PanelBulat()
        Me.lblTabTransaksi = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblBayar = New System.Windows.Forms.Label()
        Me.txtBayar = New System.Windows.Forms.TextBox()
        Me.lblKembalian = New System.Windows.Forms.Label()
        Me.txtKembalian = New System.Windows.Forms.TextBox()
        Me.pnlTombol = New System.Windows.Forms.TableLayoutPanel()
        Me.btnProses = New Global.Kasir_Warung.TombolBulat()
        Me.btnCetak = New Global.Kasir_Warung.TombolBulat()
        Me.btnKeluar = New Global.Kasir_Warung.TombolBulat()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.lblIkonToko = New System.Windows.Forms.Label()
        Me.lblToko = New System.Windows.Forms.Label()
        Me.lblTerima = New System.Windows.Forms.Label()
        Me.lblHati = New System.Windows.Forms.Label()
        Me.tmrJam = New System.Windows.Forms.Timer(Me.components)
        Me.pnlHeader.SuspendLayout()
        Me.pnlJam.SuspendLayout()
        Me.pnlIsi.SuspendLayout()
        Me.tblUtama.SuspendLayout()
        Me.pnlDataBarang.SuspendLayout()
        Me.pnlTabBarang.SuspendLayout()
        Me.pnlDaftarBelanja.SuspendLayout()
        Me.pnlTabBelanja.SuspendLayout()
        CType(Me.dgvBelanja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDataTransaksi.SuspendLayout()
        Me.pnlTabTransaksi.SuspendLayout()
        Me.pnlTombol.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader - biru tua, menempel di atas (Dock = Top)
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.pnlHeader.Controls.Add(Me.lblIkonKeranjang)
        Me.pnlHeader.Controls.Add(Me.lblJudul)
        Me.pnlHeader.Controls.Add(Me.lblSubjudul)
        Me.pnlHeader.Controls.Add(Me.pnlJam)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1100, 85)
        Me.pnlHeader.TabIndex = 0
        '
        'lblIkonKeranjang - ikon keranjang putih besar (glyph E7BF)
        '
        Me.lblIkonKeranjang.Font = New System.Drawing.Font("Segoe Fluent Icons", 46.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblIkonKeranjang.ForeColor = System.Drawing.Color.White
        Me.lblIkonKeranjang.Location = New System.Drawing.Point(14, 8)
        Me.lblIkonKeranjang.Name = "lblIkonKeranjang"
        Me.lblIkonKeranjang.Size = New System.Drawing.Size(76, 68)
        Me.lblIkonKeranjang.TabIndex = 0
        Me.lblIkonKeranjang.Text = Global.Microsoft.VisualBasic.ChrW(&HE7BF)
        Me.lblIkonKeranjang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblJudul - "Kasir Minimarket" bold 32 pt
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Font = New System.Drawing.Font("Segoe UI", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblJudul.ForeColor = System.Drawing.Color.White
        Me.lblJudul.Location = New System.Drawing.Point(100, 4)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(474, 59)
        Me.lblJudul.TabIndex = 1
        Me.lblJudul.Text = "Kasir Minimarket"
        '
        'lblSubjudul - tagline miring di bawah judul
        '
        Me.lblSubjudul.AutoSize = True
        Me.lblSubjudul.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lblSubjudul.ForeColor = System.Drawing.Color.White
        Me.lblSubjudul.Location = New System.Drawing.Point(104, 55)
        Me.lblSubjudul.Name = "lblSubjudul"
        Me.lblSubjudul.Size = New System.Drawing.Size(344, 25)
        Me.lblSubjudul.TabIndex = 2
        Me.lblSubjudul.Text = "Belanja Mudah, Harga Bersahabat"
        '
        'pnlJam - panel biru muda bersudut membulat: tanggal + jam
        '
        Me.pnlJam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlJam.BackColor = System.Drawing.Color.FromArgb(227, 236, 249)
        Me.pnlJam.CornerRadius = 12
        Me.pnlJam.Controls.Add(Me.lblIkonKalender)
        Me.pnlJam.Controls.Add(Me.lblTanggal)
        Me.pnlJam.Controls.Add(Me.lblIkonJam)
        Me.pnlJam.Controls.Add(Me.lblJam)
        Me.pnlJam.Location = New System.Drawing.Point(755, 9)
        Me.pnlJam.Name = "pnlJam"
        Me.pnlJam.Size = New System.Drawing.Size(330, 67)
        Me.pnlJam.TabIndex = 3
        '
        'lblIkonKalender - glyph E787
        '
        Me.lblIkonKalender.Font = New System.Drawing.Font("Segoe Fluent Icons", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblIkonKalender.ForeColor = System.Drawing.Color.FromArgb(55, 55, 55)
        Me.lblIkonKalender.Location = New System.Drawing.Point(14, 8)
        Me.lblIkonKalender.Name = "lblIkonKalender"
        Me.lblIkonKalender.Size = New System.Drawing.Size(26, 24)
        Me.lblIkonKalender.TabIndex = 0
        Me.lblIkonKalender.Text = Global.Microsoft.VisualBasic.ChrW(&HE787)
        Me.lblIkonKalender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTanggal - diisi Timer, format "dddd, dd MMMM yyyy"
        '
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTanggal.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45)
        Me.lblTanggal.Location = New System.Drawing.Point(46, 10)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(223, 20)
        Me.lblTanggal.TabIndex = 1
        Me.lblTanggal.Text = "Senin, 03 November 2025"
        '
        'lblIkonJam - glyph E823
        '
        Me.lblIkonJam.Font = New System.Drawing.Font("Segoe Fluent Icons", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblIkonJam.ForeColor = System.Drawing.Color.FromArgb(55, 55, 55)
        Me.lblIkonJam.Location = New System.Drawing.Point(14, 37)
        Me.lblIkonJam.Name = "lblIkonJam"
        Me.lblIkonJam.Size = New System.Drawing.Size(26, 24)
        Me.lblIkonJam.TabIndex = 2
        Me.lblIkonJam.Text = Global.Microsoft.VisualBasic.ChrW(&HE823)
        Me.lblIkonJam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblJam - diisi Timer, format "HH:mm:ss"
        '
        Me.lblJam.AutoSize = True
        Me.lblJam.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblJam.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45)
        Me.lblJam.Location = New System.Drawing.Point(46, 39)
        Me.lblJam.Name = "lblJam"
        Me.lblJam.Size = New System.Drawing.Size(77, 20)
        Me.lblJam.TabIndex = 3
        Me.lblJam.Text = "14:25:17"
        '
        'pnlIsi - wadah tengah (isi form) berisi tabel tata letak
        '
        Me.pnlIsi.BackColor = System.Drawing.Color.FromArgb(220, 232, 248)
        Me.pnlIsi.Controls.Add(Me.tblUtama)
        Me.pnlIsi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlIsi.Location = New System.Drawing.Point(0, 85)
        Me.pnlIsi.Name = "pnlIsi"
        Me.pnlIsi.Padding = New System.Windows.Forms.Padding(10, 8, 10, 8)
        Me.pnlIsi.Size = New System.Drawing.Size(1100, 440)
        Me.pnlIsi.TabIndex = 1
        '
        'tblUtama - 2 kolom (kiri = input, kanan = keranjang), 2 baris
        '
        Me.tblUtama.BackColor = System.Drawing.Color.FromArgb(220, 232, 248)
        Me.tblUtama.ColumnCount = 2
        Me.tblUtama.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 430.0!))
        Me.tblUtama.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblUtama.Controls.Add(Me.pnlDataBarang, 0, 0)
        Me.tblUtama.Controls.Add(Me.pnlDaftarBelanja, 1, 0)
        Me.tblUtama.Controls.Add(Me.pnlDataTransaksi, 0, 1)
        Me.tblUtama.Controls.Add(Me.pnlTombol, 1, 1)
        Me.tblUtama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblUtama.Location = New System.Drawing.Point(10, 8)
        Me.tblUtama.Name = "tblUtama"
        Me.tblUtama.RowCount = 2
        Me.tblUtama.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.0!))
        Me.tblUtama.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.tblUtama.Size = New System.Drawing.Size(1080, 424)
        Me.tblUtama.TabIndex = 0
        '
        'pnlDataBarang - panel kiri atas "Data Barang"
        '
        Me.pnlDataBarang.BackColor = System.Drawing.Color.FromArgb(227, 236, 249)
        Me.pnlDataBarang.CornerRadius = 12
        Me.pnlDataBarang.Controls.Add(Me.pnlTabBarang)
        Me.pnlDataBarang.Controls.Add(Me.lblKodeBarang)
        Me.pnlDataBarang.Controls.Add(Me.txtKodeBarang)
        Me.pnlDataBarang.Controls.Add(Me.btnCari)
        Me.pnlDataBarang.Controls.Add(Me.lblNamaBarang)
        Me.pnlDataBarang.Controls.Add(Me.txtNamaBarang)
        Me.pnlDataBarang.Controls.Add(Me.lblHarga)
        Me.pnlDataBarang.Controls.Add(Me.txtHarga)
        Me.pnlDataBarang.Controls.Add(Me.lblJumlah)
        Me.pnlDataBarang.Controls.Add(Me.txtJumlah)
        Me.pnlDataBarang.Controls.Add(Me.lblSubtotal)
        Me.pnlDataBarang.Controls.Add(Me.txtSubtotal)
        Me.pnlDataBarang.Controls.Add(Me.btnTambah)
        Me.pnlDataBarang.Controls.Add(Me.btnEdit)
        Me.pnlDataBarang.Controls.Add(Me.btnHapus)
        Me.pnlDataBarang.Controls.Add(Me.btnBersih)
        Me.pnlDataBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDataBarang.Location = New System.Drawing.Point(0, 0)
        Me.pnlDataBarang.Margin = New System.Windows.Forms.Padding(0, 0, 6, 6)
        Me.pnlDataBarang.Name = "pnlDataBarang"
        Me.pnlDataBarang.Size = New System.Drawing.Size(424, 369)
        Me.pnlDataBarang.TabIndex = 0
        '
        'pnlTabBarang - tab judul biru tua di pojok kiri atas panel
        '
        Me.pnlTabBarang.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlTabBarang.BackColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.pnlTabBarang.CornerRadius = 8
        Me.pnlTabBarang.TebalGarisTepi = 0
        Me.pnlTabBarang.Controls.Add(Me.lblTabBarang)
        Me.pnlTabBarang.Location = New System.Drawing.Point(0, 0)
        Me.pnlTabBarang.Name = "pnlTabBarang"
        Me.pnlTabBarang.Size = New System.Drawing.Size(168, 34)
        Me.pnlTabBarang.TabIndex = 0
        '
        'lblTabBarang
        '
        Me.lblTabBarang.BackColor = System.Drawing.Color.Transparent
        Me.lblTabBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTabBarang.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTabBarang.ForeColor = System.Drawing.Color.White
        Me.lblTabBarang.Location = New System.Drawing.Point(0, 0)
        Me.lblTabBarang.Name = "lblTabBarang"
        Me.lblTabBarang.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.lblTabBarang.Size = New System.Drawing.Size(168, 34)
        Me.lblTabBarang.TabIndex = 0
        Me.lblTabBarang.Text = "Data Barang"
        Me.lblTabBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKodeBarang - titik dua sejajar dengan label lain (rata kanan)
        '
        Me.lblKodeBarang.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblKodeBarang.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40)
        Me.lblKodeBarang.Location = New System.Drawing.Point(16, 48)
        Me.lblKodeBarang.Name = "lblKodeBarang"
        Me.lblKodeBarang.Size = New System.Drawing.Size(150, 32)
        Me.lblKodeBarang.TabIndex = 1
        Me.lblKodeBarang.Text = "Kode Barang :"
        Me.lblKodeBarang.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtKodeBarang - input utama, tekan Enter untuk cari (Tahap 3)
        '
        Me.txtKodeBarang.BackColor = System.Drawing.Color.White
        Me.txtKodeBarang.Location = New System.Drawing.Point(178, 48)
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtKodeBarang.Size = New System.Drawing.Size(160, 32)
        Me.txtKodeBarang.TabIndex = 2
        '
        'btnCari - tombol terang berikon kaca pembesar (glyph E721)
        '
        Me.btnCari.BackColor = System.Drawing.Color.FromArgb(244, 247, 252)
        Me.btnCari.CornerRadius = 8
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCari.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCari.ForeColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.btnCari.IkonTeks = Global.Microsoft.VisualBasic.ChrW(&HE721)
        Me.btnCari.Location = New System.Drawing.Point(346, 47)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(46, 34)
        Me.btnCari.TabIndex = 3
        Me.btnCari.TabStop = False
        Me.btnCari.UkuranIkon = 16.0!
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'lblNamaBarang
        '
        Me.lblNamaBarang.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNamaBarang.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40)
        Me.lblNamaBarang.Location = New System.Drawing.Point(16, 90)
        Me.lblNamaBarang.Name = "lblNamaBarang"
        Me.lblNamaBarang.Size = New System.Drawing.Size(150, 32)
        Me.lblNamaBarang.TabIndex = 4
        Me.lblNamaBarang.Text = "Nama Barang :"
        Me.lblNamaBarang.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNamaBarang - terisi otomatis dari database, latar abu
        '
        Me.txtNamaBarang.BackColor = System.Drawing.Color.FromArgb(225, 225, 225)
        Me.txtNamaBarang.Location = New System.Drawing.Point(178, 90)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.ReadOnly = True
        Me.txtNamaBarang.Size = New System.Drawing.Size(220, 32)
        Me.txtNamaBarang.TabIndex = 5
        Me.txtNamaBarang.TabStop = False
        '
        'lblHarga
        '
        Me.lblHarga.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblHarga.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40)
        Me.lblHarga.Location = New System.Drawing.Point(16, 132)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(150, 32)
        Me.lblHarga.TabIndex = 6
        Me.lblHarga.Text = "Harga :"
        Me.lblHarga.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHarga - terisi dari database, latar putih (readonly)
        '
        Me.txtHarga.BackColor = System.Drawing.Color.White
        Me.txtHarga.Location = New System.Drawing.Point(178, 132)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.ReadOnly = True
        Me.txtHarga.Size = New System.Drawing.Size(160, 32)
        Me.txtHarga.TabIndex = 7
        Me.txtHarga.TabStop = False
        '
        'lblJumlah
        '
        Me.lblJumlah.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblJumlah.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40)
        Me.lblJumlah.Location = New System.Drawing.Point(16, 174)
        Me.lblJumlah.Name = "lblJumlah"
        Me.lblJumlah.Size = New System.Drawing.Size(150, 32)
        Me.lblJumlah.TabIndex = 8
        Me.lblJumlah.Text = "Jumlah :"
        Me.lblJumlah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtJumlah - hanya angka (divalidasi di Tahap 3)
        '
        Me.txtJumlah.BackColor = System.Drawing.Color.White
        Me.txtJumlah.Location = New System.Drawing.Point(178, 174)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(95, 32)
        Me.txtJumlah.TabIndex = 9
        '
        'lblSubtotal
        '
        Me.lblSubtotal.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40)
        Me.lblSubtotal.Location = New System.Drawing.Point(16, 216)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(150, 32)
        Me.lblSubtotal.TabIndex = 10
        Me.lblSubtotal.Text = "Subtotal :"
        Me.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSubtotal - dihitung otomatis Harga x Jumlah (readonly, abu)
        '
        Me.txtSubtotal.BackColor = System.Drawing.Color.FromArgb(225, 225, 225)
        Me.txtSubtotal.Location = New System.Drawing.Point(178, 216)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(220, 32)
        Me.txtSubtotal.TabIndex = 11
        Me.txtSubtotal.TabStop = False
        '
        'btnTambah - ikon + (glyph E710), ikon di atas teks
        '
        Me.btnTambah.BackColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.btnTambah.CornerRadius = 10
        Me.btnTambah.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.IkonTeks = Global.Microsoft.VisualBasic.ChrW(&HE710)
        Me.btnTambah.Location = New System.Drawing.Point(16, 266)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(92, 58)
        Me.btnTambah.TabIndex = 12
        Me.btnTambah.TabStop = False
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UkuranIkon = 18.0!
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'btnEdit - ikon pensil (glyph E70F)
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.btnEdit.CornerRadius = 10
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.IkonTeks = Global.Microsoft.VisualBasic.ChrW(&HE70F)
        Me.btnEdit.Location = New System.Drawing.Point(114, 266)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(92, 58)
        Me.btnEdit.TabIndex = 13
        Me.btnEdit.TabStop = False
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UkuranIkon = 18.0!
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnHapus - ikon tempat sampah (glyph E74D)
        '
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.btnHapus.CornerRadius = 10
        Me.btnHapus.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.IkonTeks = Global.Microsoft.VisualBasic.ChrW(&HE74D)
        Me.btnHapus.Location = New System.Drawing.Point(212, 266)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(92, 58)
        Me.btnHapus.TabIndex = 14
        Me.btnHapus.TabStop = False
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UkuranIkon = 18.0!
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnBersih - ikon refresh (glyph E72C)
        '
        Me.btnBersih.BackColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.btnBersih.CornerRadius = 10
        Me.btnBersih.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBersih.ForeColor = System.Drawing.Color.White
        Me.btnBersih.IkonTeks = Global.Microsoft.VisualBasic.ChrW(&HE72C)
        Me.btnBersih.Location = New System.Drawing.Point(310, 266)
        Me.btnBersih.Name = "btnBersih"
        Me.btnBersih.Size = New System.Drawing.Size(92, 58)
        Me.btnBersih.TabIndex = 15
        Me.btnBersih.TabStop = False
        Me.btnBersih.Text = "Bersih"
        Me.btnBersih.UkuranIkon = 18.0!
        Me.btnBersih.UseVisualStyleBackColor = False
        '
        'pnlDaftarBelanja - panel kanan "Daftar Belanja"
        '
        Me.pnlDaftarBelanja.BackColor = System.Drawing.Color.FromArgb(227, 236, 249)
        Me.pnlDaftarBelanja.CornerRadius = 12
        Me.pnlDaftarBelanja.Controls.Add(Me.pnlTabBelanja)
        Me.pnlDaftarBelanja.Controls.Add(Me.dgvBelanja)
        Me.pnlDaftarBelanja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDaftarBelanja.Location = New System.Drawing.Point(436, 0)
        Me.pnlDaftarBelanja.Margin = New System.Windows.Forms.Padding(0, 0, 0, 6)
        Me.pnlDaftarBelanja.Name = "pnlDaftarBelanja"
        Me.pnlDaftarBelanja.Size = New System.Drawing.Size(644, 369)
        Me.pnlDaftarBelanja.TabIndex = 1
        '
        'pnlTabBelanja
        '
        Me.pnlTabBelanja.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlTabBelanja.BackColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.pnlTabBelanja.CornerRadius = 8
        Me.pnlTabBelanja.TebalGarisTepi = 0
        Me.pnlTabBelanja.Controls.Add(Me.lblTabBelanja)
        Me.pnlTabBelanja.Location = New System.Drawing.Point(0, 0)
        Me.pnlTabBelanja.Name = "pnlTabBelanja"
        Me.pnlTabBelanja.Size = New System.Drawing.Size(178, 34)
        Me.pnlTabBelanja.TabIndex = 0
        '
        'lblTabBelanja
        '
        Me.lblTabBelanja.BackColor = System.Drawing.Color.Transparent
        Me.lblTabBelanja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTabBelanja.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTabBelanja.ForeColor = System.Drawing.Color.White
        Me.lblTabBelanja.Location = New System.Drawing.Point(0, 0)
        Me.lblTabBelanja.Name = "lblTabBelanja"
        Me.lblTabBelanja.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.lblTabBelanja.Size = New System.Drawing.Size(178, 34)
        Me.lblTabBelanja.TabIndex = 0
        Me.lblTabBelanja.Text = "Daftar Belanja"
        Me.lblTabBelanja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvBelanja - grid keranjang belanja
        '
        Me.dgvBelanja.AllowUserToAddRows = False
        Me.dgvBelanja.AllowUserToDeleteRows = False
        Me.dgvBelanja.AllowUserToResizeColumns = False
        Me.dgvBelanja.AllowUserToResizeRows = False
        Me.dgvBelanja.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBelanja.BackgroundColor = System.Drawing.Color.White
        Me.dgvBelanja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvBelanja.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single
        Me.dgvBelanja.ColumnHeadersHeight = 38
        Me.dgvBelanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvBelanja.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNo, Me.colKode, Me.colNama, Me.colHarga, Me.colJumlah, Me.colSubtotal})
        Me.dgvBelanja.EnableHeadersVisualStyles = False
        Me.dgvBelanja.GridColor = System.Drawing.Color.FromArgb(200, 210, 225)
        Me.dgvBelanja.Location = New System.Drawing.Point(12, 44)
        Me.dgvBelanja.MultiSelect = False
        Me.dgvBelanja.Name = "dgvBelanja"
        Me.dgvBelanja.ReadOnly = True
        Me.dgvBelanja.RowHeadersVisible = False
        Me.dgvBelanja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBelanja.Size = New System.Drawing.Size(620, 315)
        Me.dgvBelanja.TabIndex = 1
        Me.dgvBelanja.TabStop = False
        '
        'colNo - nomor urut diisi otomatis
        '
        Me.colNo.DefaultCellStyle = New System.Windows.Forms.DataGridViewCellStyle() With {.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter}
        Me.colNo.HeaderText = "No"
        Me.colNo.Name = "colNo"
        Me.colNo.ReadOnly = True
        Me.colNo.Width = 50
        '
        'colKode
        '
        Me.colKode.HeaderText = "Kode Barang"
        Me.colKode.Name = "colKode"
        Me.colKode.ReadOnly = True
        Me.colKode.Width = 95
        '
        'colNama - melebar mengikuti lebar panel
        '
        Me.colNama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNama.HeaderText = "Nama Barang"
        Me.colNama.MinimumWidth = 90
        Me.colNama.Name = "colNama"
        Me.colNama.ReadOnly = True
        '
        'colHarga - rata kanan, format Rp (Tahap 3)
        '
        Me.colHarga.DefaultCellStyle = New System.Windows.Forms.DataGridViewCellStyle() With {.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight}
        Me.colHarga.HeaderText = "Harga"
        Me.colHarga.Name = "colHarga"
        Me.colHarga.ReadOnly = True
        Me.colHarga.Width = 100
        '
        'colJumlah
        '
        Me.colJumlah.DefaultCellStyle = New System.Windows.Forms.DataGridViewCellStyle() With {.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter}
        Me.colJumlah.HeaderText = "Jumlah"
        Me.colJumlah.Name = "colJumlah"
        Me.colJumlah.ReadOnly = True
        Me.colJumlah.Width = 65
        '
        'colSubtotal - rata kanan, format Rp (Tahap 3)
        '
        Me.colSubtotal.DefaultCellStyle = New System.Windows.Forms.DataGridViewCellStyle() With {.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight}
        Me.colSubtotal.HeaderText = "Subtotal"
        Me.colSubtotal.Name = "colSubtotal"
        Me.colSubtotal.ReadOnly = True
        Me.colSubtotal.Width = 110
        '
        'pnlDataTransaksi - panel kiri bawah "Data Transaksi"
        '
        Me.pnlDataTransaksi.BackColor = System.Drawing.Color.FromArgb(227, 236, 249)
        Me.pnlDataTransaksi.CornerRadius = 12
        Me.pnlDataTransaksi.Controls.Add(Me.pnlTabTransaksi)
        Me.pnlDataTransaksi.Controls.Add(Me.lblTotal)
        Me.pnlDataTransaksi.Controls.Add(Me.txtTotal)
        Me.pnlDataTransaksi.Controls.Add(Me.lblBayar)
        Me.pnlDataTransaksi.Controls.Add(Me.txtBayar)
        Me.pnlDataTransaksi.Controls.Add(Me.lblKembalian)
        Me.pnlDataTransaksi.Controls.Add(Me.txtKembalian)
        Me.pnlDataTransaksi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDataTransaksi.Location = New System.Drawing.Point(0, 375)
        Me.pnlDataTransaksi.Margin = New System.Windows.Forms.Padding(0, 0, 6, 0)
        Me.pnlDataTransaksi.Name = "pnlDataTransaksi"
        Me.pnlDataTransaksi.Size = New System.Drawing.Size(424, 193)
        Me.pnlDataTransaksi.TabIndex = 2
        '
        'pnlTabTransaksi
        '
        Me.pnlTabTransaksi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlTabTransaksi.BackColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.pnlTabTransaksi.CornerRadius = 8
        Me.pnlTabTransaksi.TebalGarisTepi = 0
        Me.pnlTabTransaksi.Controls.Add(Me.lblTabTransaksi)
        Me.pnlTabTransaksi.Location = New System.Drawing.Point(0, 0)
        Me.pnlTabTransaksi.Name = "pnlTabTransaksi"
        Me.pnlTabTransaksi.Size = New System.Drawing.Size(186, 34)
        Me.pnlTabTransaksi.TabIndex = 0
        '
        'lblTabTransaksi
        '
        Me.lblTabTransaksi.BackColor = System.Drawing.Color.Transparent
        Me.lblTabTransaksi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTabTransaksi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTabTransaksi.ForeColor = System.Drawing.Color.White
        Me.lblTabTransaksi.Location = New System.Drawing.Point(0, 0)
        Me.lblTabTransaksi.Name = "lblTabTransaksi"
        Me.lblTabTransaksi.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.lblTabTransaksi.Size = New System.Drawing.Size(186, 34)
        Me.lblTabTransaksi.TabIndex = 0
        Me.lblTabTransaksi.Text = "Data Transaksi"
        Me.lblTabTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40)
        Me.lblTotal.Location = New System.Drawing.Point(16, 46)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(140, 32)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "Total Belanja :"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotal - rata kanan, bold, terisi saat keranjang berubah
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtTotal.Location = New System.Drawing.Point(162, 46)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(230, 34)
        Me.txtTotal.TabIndex = 2
        Me.txtTotal.TabStop = False
        Me.txtTotal.Text = "Rp0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblBayar
        '
        Me.lblBayar.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblBayar.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40)
        Me.lblBayar.Location = New System.Drawing.Point(16, 88)
        Me.lblBayar.Name = "lblBayar"
        Me.lblBayar.Size = New System.Drawing.Size(140, 32)
        Me.lblBayar.TabIndex = 3
        Me.lblBayar.Text = "Bayar :"
        Me.lblBayar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBayar - input pembayaran, format ribuan saat mengetik (Tahap 3)
        '
        Me.txtBayar.BackColor = System.Drawing.Color.White
        Me.txtBayar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBayar.Location = New System.Drawing.Point(162, 88)
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(230, 34)
        Me.txtBayar.TabIndex = 4
        Me.txtBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblKembalian
        '
        Me.lblKembalian.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblKembalian.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40)
        Me.lblKembalian.Location = New System.Drawing.Point(16, 130)
        Me.lblKembalian.Name = "lblKembalian"
        Me.lblKembalian.Size = New System.Drawing.Size(140, 32)
        Me.lblKembalian.TabIndex = 5
        Me.lblKembalian.Text = "Kembalian :"
        Me.lblKembalian.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtKembalian - rata kanan, bold, latar abu (readonly)
        '
        Me.txtKembalian.BackColor = System.Drawing.Color.FromArgb(225, 225, 225)
        Me.txtKembalian.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtKembalian.Location = New System.Drawing.Point(162, 130)
        Me.txtKembalian.Name = "txtKembalian"
        Me.txtKembalian.ReadOnly = True
        Me.txtKembalian.Size = New System.Drawing.Size(230, 34)
        Me.txtKembalian.TabIndex = 6
        Me.txtKembalian.TabStop = False
        Me.txtKembalian.Text = "Rp0"
        Me.txtKembalian.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlTombol - 3 tombol besar: Proses / Cetak / Keluar
        '
        Me.pnlTombol.ColumnCount = 3
        Me.pnlTombol.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.pnlTombol.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.pnlTombol.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.pnlTombol.Controls.Add(Me.btnProses, 0, 0)
        Me.pnlTombol.Controls.Add(Me.btnCetak, 1, 0)
        Me.pnlTombol.Controls.Add(Me.btnKeluar, 2, 0)
        Me.pnlTombol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTombol.Location = New System.Drawing.Point(436, 375)
        Me.pnlTombol.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlTombol.Name = "pnlTombol"
        Me.pnlTombol.RowCount = 1
        Me.pnlTombol.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlTombol.Size = New System.Drawing.Size(644, 193)
        Me.pnlTombol.TabIndex = 3
        '
        'btnProses - hijau, ikon keranjang (glyph E7BF)
        '
        Me.btnProses.BackColor = System.Drawing.Color.FromArgb(46, 166, 46)
        Me.btnProses.CornerRadius = 14
        Me.btnProses.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnProses.ForeColor = System.Drawing.Color.White
        Me.btnProses.IkonTeks = Global.Microsoft.VisualBasic.ChrW(&HE7BF)
        Me.btnProses.Location = New System.Drawing.Point(3, 6)
        Me.btnProses.Margin = New System.Windows.Forms.Padding(0, 6, 6, 6)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(205, 181)
        Me.btnProses.TabIndex = 0
        Me.btnProses.TabStop = False
        Me.btnProses.Text = "Proses" & vbCrLf & "Pembayaran"
        Me.btnProses.UkuranIkon = 30.0!
        Me.btnProses.UseVisualStyleBackColor = False
        '
        'btnCetak - oranye, ikon printer (glyph E749), nonaktif sampai ada transaksi
        '
        Me.btnCetak.BackColor = System.Drawing.Color.FromArgb(255, 148, 22)
        Me.btnCetak.CornerRadius = 14
        Me.btnCetak.Enabled = False
        Me.btnCetak.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCetak.ForeColor = System.Drawing.Color.White
        Me.btnCetak.IkonTeks = Global.Microsoft.VisualBasic.ChrW(&HE749)
        Me.btnCetak.Location = New System.Drawing.Point(217, 6)
        Me.btnCetak.Margin = New System.Windows.Forms.Padding(0, 6, 6, 6)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(205, 181)
        Me.btnCetak.TabIndex = 1
        Me.btnCetak.TabStop = False
        Me.btnCetak.Text = "Cetak Struk"
        Me.btnCetak.UkuranIkon = 30.0!
        Me.btnCetak.UseVisualStyleBackColor = False
        '
        'btnKeluar - merah, ikon keluar (glyph F3B1)
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.FromArgb(223, 58, 53)
        Me.btnKeluar.CornerRadius = 14
        Me.btnKeluar.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnKeluar.ForeColor = System.Drawing.Color.White
        Me.btnKeluar.IkonTeks = Global.Microsoft.VisualBasic.ChrW(&HF3B1)
        Me.btnKeluar.Location = New System.Drawing.Point(431, 6)
        Me.btnKeluar.Margin = New System.Windows.Forms.Padding(0, 6, 0, 6)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(213, 181)
        Me.btnKeluar.TabIndex = 2
        Me.btnKeluar.TabStop = False
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UkuranIkon = 30.0!
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'pnlFooter - biru tua, menempel di bawah (Dock = Bottom)
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.pnlFooter.Controls.Add(Me.lblIkonToko)
        Me.pnlFooter.Controls.Add(Me.lblToko)
        Me.pnlFooter.Controls.Add(Me.lblTerima)
        Me.pnlFooter.Controls.Add(Me.lblHati)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 525)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1100, 60)
        Me.pnlFooter.TabIndex = 2
        '
        'lblIkonToko - ikon toko (glyph E719)
        '
        Me.lblIkonToko.Font = New System.Drawing.Font("Segoe Fluent Icons", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblIkonToko.ForeColor = System.Drawing.Color.White
        Me.lblIkonToko.Location = New System.Drawing.Point(18, 11)
        Me.lblIkonToko.Name = "lblIkonToko"
        Me.lblIkonToko.Size = New System.Drawing.Size(42, 38)
        Me.lblIkonToko.TabIndex = 0
        Me.lblIkonToko.Text = Global.Microsoft.VisualBasic.ChrW(&HE719)
        Me.lblIkonToko.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblToko
        '
        Me.lblToko.AutoSize = True
        Me.lblToko.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblToko.ForeColor = System.Drawing.Color.White
        Me.lblToko.Location = New System.Drawing.Point(66, 19)
        Me.lblToko.Name = "lblToko"
        Me.lblToko.Size = New System.Drawing.Size(235, 25)
        Me.lblToko.TabIndex = 1
        Me.lblToko.Text = "Minimarket Sejahtera"
        '
        'lblTerima - kanan footer, italic
        '
        Me.lblTerima.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTerima.AutoSize = True
        Me.lblTerima.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lblTerima.ForeColor = System.Drawing.Color.White
        Me.lblTerima.Location = New System.Drawing.Point(770, 19)
        Me.lblTerima.Name = "lblTerima"
        Me.lblTerima.Size = New System.Drawing.Size(335, 25)
        Me.lblTerima.TabIndex = 2
        Me.lblTerima.Text = "Terima Kasih atas Kunjungan Anda"
        '
        'lblHati - ikon hati putih (bukan dari font ikon, memakai karakter ♥)
        '
        Me.lblHati.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHati.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHati.ForeColor = System.Drawing.Color.White
        Me.lblHati.Location = New System.Drawing.Point(1056, 14)
        Me.lblHati.Name = "lblHati"
        Me.lblHati.Size = New System.Drawing.Size(28, 30)
        Me.lblHati.TabIndex = 3
        Me.lblHati.Text = Global.Microsoft.VisualBasic.ChrW(&H2665)
        Me.lblHati.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrJam - memperbarui tanggal & jam tiap 1 detik
        '
        Me.tmrJam.Interval = 1000
        '
        'FormKasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(220, 232, 248)
        Me.ClientSize = New System.Drawing.Size(1100, 730)
        Me.Controls.Add(Me.pnlIsi)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(1000, 680)
        Me.Name = "FormKasir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Text = "Kasir Minimarket"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlJam.ResumeLayout(False)
        Me.pnlJam.PerformLayout()
        Me.pnlIsi.ResumeLayout(False)
        Me.tblUtama.ResumeLayout(False)
        Me.pnlDataBarang.ResumeLayout(False)
        Me.pnlDataBarang.PerformLayout()
        Me.pnlTabBarang.ResumeLayout(False)
        Me.pnlDaftarBelanja.ResumeLayout(False)
        Me.pnlTabBelanja.ResumeLayout(False)
        CType(Me.dgvBelanja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDataTransaksi.ResumeLayout(False)
        Me.pnlDataTransaksi.PerformLayout()
        Me.pnlTabTransaksi.ResumeLayout(False)
        Me.pnlTombol.ResumeLayout(False)
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlFooter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblIkonKeranjang As System.Windows.Forms.Label
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents lblSubjudul As System.Windows.Forms.Label
    Friend WithEvents pnlJam As Global.Kasir_Warung.PanelBulat
    Friend WithEvents lblIkonKalender As System.Windows.Forms.Label
    Friend WithEvents lblTanggal As System.Windows.Forms.Label
    Friend WithEvents lblIkonJam As System.Windows.Forms.Label
    Friend WithEvents lblJam As System.Windows.Forms.Label
    Friend WithEvents pnlIsi As System.Windows.Forms.Panel
    Friend WithEvents tblUtama As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlDataBarang As Global.Kasir_Warung.PanelBulat
    Friend WithEvents pnlTabBarang As Global.Kasir_Warung.PanelBulat
    Friend WithEvents lblTabBarang As System.Windows.Forms.Label
    Friend WithEvents lblKodeBarang As System.Windows.Forms.Label
    Friend WithEvents txtKodeBarang As System.Windows.Forms.TextBox
    Friend WithEvents btnCari As Global.Kasir_Warung.TombolBulat
    Friend WithEvents lblNamaBarang As System.Windows.Forms.Label
    Friend WithEvents txtNamaBarang As System.Windows.Forms.TextBox
    Friend WithEvents lblHarga As System.Windows.Forms.Label
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents lblJumlah As System.Windows.Forms.Label
    Friend WithEvents txtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents btnTambah As Global.Kasir_Warung.TombolBulat
    Friend WithEvents btnEdit As Global.Kasir_Warung.TombolBulat
    Friend WithEvents btnHapus As Global.Kasir_Warung.TombolBulat
    Friend WithEvents btnBersih As Global.Kasir_Warung.TombolBulat
    Friend WithEvents pnlDaftarBelanja As Global.Kasir_Warung.PanelBulat
    Friend WithEvents pnlTabBelanja As Global.Kasir_Warung.PanelBulat
    Friend WithEvents lblTabBelanja As System.Windows.Forms.Label
    Friend WithEvents dgvBelanja As System.Windows.Forms.DataGridView
    Friend WithEvents colNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colKode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHarga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colJumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlDataTransaksi As Global.Kasir_Warung.PanelBulat
    Friend WithEvents pnlTabTransaksi As Global.Kasir_Warung.PanelBulat
    Friend WithEvents lblTabTransaksi As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblBayar As System.Windows.Forms.Label
    Friend WithEvents txtBayar As System.Windows.Forms.TextBox
    Friend WithEvents lblKembalian As System.Windows.Forms.Label
    Friend WithEvents txtKembalian As System.Windows.Forms.TextBox
    Friend WithEvents pnlTombol As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnProses As Global.Kasir_Warung.TombolBulat
    Friend WithEvents btnCetak As Global.Kasir_Warung.TombolBulat
    Friend WithEvents btnKeluar As Global.Kasir_Warung.TombolBulat
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents lblIkonToko As System.Windows.Forms.Label
    Friend WithEvents lblToko As System.Windows.Forms.Label
    Friend WithEvents lblTerima As System.Windows.Forms.Label
    Friend WithEvents lblHati As System.Windows.Forms.Label
    Friend WithEvents tmrJam As System.Windows.Forms.Timer

End Class
