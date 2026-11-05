<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDataBarang
    Inherits System.Windows.Forms.UserControl

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
        Me.pnlCariTop = New Global.Kasir_Warung.PanelBulat()
        Me.lblIkon = New System.Windows.Forms.Label()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.pnlCari = New System.Windows.Forms.Panel()
        Me.lblCari = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.lblJumlahRecord = New System.Windows.Forms.Label()
        Me.dgvBarang = New System.Windows.Forms.DataGridView()
        Me.colKode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlInput = New Global.Kasir_Warung.PanelBulat()
        Me.pnlTabInput = New Global.Kasir_Warung.PanelBulat()
        Me.lblTabInput = New System.Windows.Forms.Label()
        Me.lblKode = New System.Windows.Forms.Label()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.lblStok = New System.Windows.Forms.Label()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.btnTambah = New Global.Kasir_Warung.TombolBulat()
        Me.btnUbah = New Global.Kasir_Warung.TombolBulat()
        Me.btnHapus = New Global.Kasir_Warung.TombolBulat()
        Me.pnlNavigasi = New System.Windows.Forms.Panel()
        Me.btnPertama = New Global.Kasir_Warung.TombolBulat()
        Me.btnSebelumnya = New Global.Kasir_Warung.TombolBulat()
        Me.btnBerikutnya = New Global.Kasir_Warung.TombolBulat()
        Me.btnTerakhir = New Global.Kasir_Warung.TombolBulat()
        Me.btnTutup = New Global.Kasir_Warung.TombolBulat()
        Me.btnRefresh = New Global.Kasir_Warung.TombolBulat()
        Me.btnHalKasir = New Global.Kasir_Warung.TombolBulat()
        Me.btnHalData = New Global.Kasir_Warung.TombolBulat()
        Me.btnHalRiwayat = New Global.Kasir_Warung.TombolBulat()
        Me.tblIsi = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlHeader.SuspendLayout()
        Me.pnlCariTop.SuspendLayout()
        Me.pnlCari.SuspendLayout()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInput.SuspendLayout()
        Me.pnlTabInput.SuspendLayout()
        Me.pnlNavigasi.SuspendLayout()
        Me.tblIsi.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader - biru tua, judul halaman (Dock = Top, dibuat ringkas agar ruang tabel maksimal)
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.pnlHeader.Controls.Add(Me.lblIkon)
        Me.pnlHeader.Controls.Add(Me.lblJudul)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1080, 48)
        Me.pnlHeader.TabIndex = 0
        '
        'lblIkon - ikon kotak barang (glyph E7F4), font diganti saat form dibuka
        '
        Me.lblIkon.Font = New System.Drawing.Font("Segoe Fluent Icons", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblIkon.ForeColor = System.Drawing.Color.White
        Me.lblIkon.Location = New System.Drawing.Point(14, 8)
        Me.lblIkon.Name = "lblIkon"
        Me.lblIkon.Size = New System.Drawing.Size(38, 32)
        Me.lblIkon.TabIndex = 0
        Me.lblIkon.Text = Global.Microsoft.VisualBasic.ChrW(&HE7F4)
        Me.lblIkon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblJudul.ForeColor = System.Drawing.Color.White
        Me.lblJudul.Location = New System.Drawing.Point(58, 10)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(230, 28)
        Me.lblJudul.TabIndex = 1
        Me.lblJudul.Text = "Kelola Barang (F2)"
        '
        'pnlCariTop - panel kanan ala POS berisi bar pencarian di atas + tabel daftar barang besar di bawah
        '
        Me.pnlCariTop.BackColor = System.Drawing.Color.FromArgb(227, 236, 249)
        Me.pnlCariTop.CornerRadius = 12
        Me.pnlCariTop.Controls.Add(Me.dgvBarang)
        Me.pnlCariTop.Controls.Add(Me.pnlCari)
        Me.pnlCariTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCariTop.Location = New System.Drawing.Point(366, 6)
        Me.pnlCariTop.Margin = New System.Windows.Forms.Padding(6, 6, 0, 4)
        Me.pnlCariTop.Name = "pnlCariTop"
        Me.pnlCariTop.Padding = New System.Windows.Forms.Padding(12, 8, 12, 12)
        Me.pnlCariTop.Size = New System.Drawing.Size(714, 486)
        Me.pnlCariTop.TabIndex = 1
        '
        'pnlCari - kotak cari + label jumlah record (Dock = Top di dalam panel kanan)
        '
        Me.pnlCari.BackColor = System.Drawing.Color.FromArgb(227, 236, 249)
        Me.pnlCari.Controls.Add(Me.lblCari)
        Me.pnlCari.Controls.Add(Me.txtCari)
        Me.pnlCari.Controls.Add(Me.lblJumlahRecord)
        Me.pnlCari.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCari.Location = New System.Drawing.Point(12, 8)
        Me.pnlCari.Name = "pnlCari"
        Me.pnlCari.Size = New System.Drawing.Size(690, 42)
        Me.pnlCari.TabIndex = 0
        '
        'lblCari
        '
        Me.lblCari.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCari.ForeColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.lblCari.Location = New System.Drawing.Point(0, 5)
        Me.lblCari.Name = "lblCari"
        Me.lblCari.Size = New System.Drawing.Size(52, 28)
        Me.lblCari.TabIndex = 0
        Me.lblCari.Text = "Cari :"
        Me.lblCari.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCari
        '
        Me.txtCari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCari.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCari.Location = New System.Drawing.Point(56, 5)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(450, 28)
        Me.txtCari.TabIndex = 1
        '
        'lblJumlahRecord - jumlah record dari BindingSource.Count
        '
        Me.lblJumlahRecord.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblJumlahRecord.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblJumlahRecord.ForeColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.lblJumlahRecord.Location = New System.Drawing.Point(514, 5)
        Me.lblJumlahRecord.Name = "lblJumlahRecord"
        Me.lblJumlahRecord.Size = New System.Drawing.Size(176, 28)
        Me.lblJumlahRecord.TabIndex = 2
        Me.lblJumlahRecord.Text = "Jumlah record : 0"
        Me.lblJumlahRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgvBarang - isi recordset barang (Dock = Fill memenuhi area utama kanan seperti POS)
        '
        Me.dgvBarang.AllowUserToAddRows = False
        Me.dgvBarang.AllowUserToDeleteRows = False
        Me.dgvBarang.AllowUserToResizeColumns = True
        Me.dgvBarang.AllowUserToResizeRows = False
        Me.dgvBarang.BackgroundColor = System.Drawing.Color.White
        Me.dgvBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvBarang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single
        Me.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colKode, Me.colNama, Me.colHarga, Me.colStok})
        Me.dgvBarang.ColumnHeadersHeight = 40
        Me.dgvBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBarang.EnableHeadersVisualStyles = False
        Me.dgvBarang.GridColor = System.Drawing.Color.FromArgb(200, 210, 225)
        Me.dgvBarang.Location = New System.Drawing.Point(12, 50)
        Me.dgvBarang.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvBarang.MinimumSize = New System.Drawing.Size(0, 120)
        Me.dgvBarang.MultiSelect = False
        Me.dgvBarang.Name = "dgvBarang"
        Me.dgvBarang.ReadOnly = True
        Me.dgvBarang.RowHeadersVisible = False
        Me.dgvBarang.RowTemplate.Height = 36
        Me.dgvBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBarang.Size = New System.Drawing.Size(690, 424)
        Me.dgvBarang.TabIndex = 2
        Me.dgvBarang.TabStop = False
        '
        'colKode
        '
        Me.colKode.DataPropertyName = "kode_barang"
        Me.colKode.HeaderText = "Kode Barang"
        Me.colKode.Name = "colKode"
        Me.colKode.ReadOnly = True
        Me.colKode.Width = 140
        '
        'colNama - melebar mengikuti lebar panel
        '
        Me.colNama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNama.DataPropertyName = "nama_barang"
        Me.colNama.HeaderText = "Nama Barang"
        Me.colNama.MinimumWidth = 180
        Me.colNama.Name = "colNama"
        Me.colNama.ReadOnly = True
        '
        'colHarga - rata kanan, format Rp
        '
        Me.colHarga.DataPropertyName = "harga"
        Me.colHarga.HeaderText = "Harga"
        Me.colHarga.Name = "colHarga"
        Me.colHarga.ReadOnly = True
        Me.colHarga.Width = 140
        '
        'colStok - rata tengah
        '
        Me.colStok.DataPropertyName = "stok"
        Me.colStok.HeaderText = "Stok"
        Me.colStok.Name = "colStok"
        Me.colStok.ReadOnly = True
        Me.colStok.Width = 95
        '
        'pnlInput - panel input/edit di sebelah kiri ala POS (Dock = Fill di Kolom 0)
        '
        Me.pnlInput.BackColor = System.Drawing.Color.FromArgb(227, 236, 249)
        Me.pnlInput.CornerRadius = 12
        Me.pnlInput.Controls.Add(Me.pnlTabInput)
        Me.pnlInput.Controls.Add(Me.lblKode)
        Me.pnlInput.Controls.Add(Me.txtKode)
        Me.pnlInput.Controls.Add(Me.lblNama)
        Me.pnlInput.Controls.Add(Me.txtNama)
        Me.pnlInput.Controls.Add(Me.lblHarga)
        Me.pnlInput.Controls.Add(Me.txtHarga)
        Me.pnlInput.Controls.Add(Me.lblStok)
        Me.pnlInput.Controls.Add(Me.txtStok)
        Me.pnlInput.Controls.Add(Me.btnTambah)
        Me.pnlInput.Controls.Add(Me.btnUbah)
        Me.pnlInput.Controls.Add(Me.btnHapus)
        Me.pnlInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInput.Location = New System.Drawing.Point(0, 6)
        Me.pnlInput.Margin = New System.Windows.Forms.Padding(0, 6, 6, 4)
        Me.pnlInput.MinimumSize = New System.Drawing.Size(340, 340)
        Me.pnlInput.Name = "pnlInput"
        Me.pnlInput.Padding = New System.Windows.Forms.Padding(16, 12, 16, 12)
        Me.pnlInput.Size = New System.Drawing.Size(354, 486)
        Me.pnlInput.TabIndex = 3
        '
        'pnlTabInput - tab judul biru tua di pojok kiri atas panel input (seragam dengan FormKasir)
        '
        Me.pnlTabInput.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlTabInput.BackColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.pnlTabInput.CornerRadius = 8
        Me.pnlTabInput.TebalGarisTepi = 0
        Me.pnlTabInput.Controls.Add(Me.lblTabInput)
        Me.pnlTabInput.Location = New System.Drawing.Point(0, 0)
        Me.pnlTabInput.Name = "pnlTabInput"
        Me.pnlTabInput.Size = New System.Drawing.Size(176, 34)
        Me.pnlTabInput.TabIndex = 0
        '
        'lblTabInput
        '
        Me.lblTabInput.BackColor = System.Drawing.Color.Transparent
        Me.lblTabInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTabInput.Font = New System.Drawing.Font("Segoe UI", 11.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTabInput.ForeColor = System.Drawing.Color.White
        Me.lblTabInput.Location = New System.Drawing.Point(0, 0)
        Me.lblTabInput.Name = "lblTabInput"
        Me.lblTabInput.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.lblTabInput.Size = New System.Drawing.Size(176, 34)
        Me.lblTabInput.TabIndex = 0
        Me.lblTabInput.Text = "Data Barang"
        Me.lblTabInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKode
        '
        Me.lblKode.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblKode.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40)
        Me.lblKode.Location = New System.Drawing.Point(12, 50)
        Me.lblKode.Name = "lblKode"
        Me.lblKode.Size = New System.Drawing.Size(96, 28)
        Me.lblKode.TabIndex = 0
        Me.lblKode.Text = "Kode :"
        Me.lblKode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtKode - kode tidak boleh kosong, tidak boleh kembar (divalidasi di kode)
        '
        Me.txtKode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKode.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtKode.Location = New System.Drawing.Point(116, 50)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(218, 28)
        Me.txtKode.TabIndex = 1
        '
        'lblNama
        '
        Me.lblNama.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNama.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40)
        Me.lblNama.Location = New System.Drawing.Point(12, 92)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(96, 28)
        Me.lblNama.TabIndex = 2
        Me.lblNama.Text = "Nama :"
        Me.lblNama.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNama
        '
        Me.txtNama.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNama.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNama.Location = New System.Drawing.Point(116, 92)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(218, 28)
        Me.txtNama.TabIndex = 3
        '
        'lblHarga
        '
        Me.lblHarga.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblHarga.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40)
        Me.lblHarga.Location = New System.Drawing.Point(12, 134)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(96, 28)
        Me.lblHarga.TabIndex = 4
        Me.lblHarga.Text = "Harga :"
        Me.lblHarga.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHarga - hanya angka >= 0
        '
        Me.txtHarga.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHarga.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtHarga.Location = New System.Drawing.Point(116, 134)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(218, 28)
        Me.txtHarga.TabIndex = 5
        '
        'lblStok
        '
        Me.lblStok.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblStok.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40)
        Me.lblStok.Location = New System.Drawing.Point(12, 176)
        Me.lblStok.Name = "lblStok"
        Me.lblStok.Size = New System.Drawing.Size(96, 28)
        Me.lblStok.TabIndex = 6
        Me.lblStok.Text = "Stok :"
        Me.lblStok.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStok - hanya angka >= 0
        '
        Me.txtStok.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStok.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtStok.Location = New System.Drawing.Point(116, 176)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(218, 28)
        Me.txtStok.TabIndex = 7
        '
        'btnTambah - hijau
        '
        Me.btnTambah.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTambah.BackColor = System.Drawing.Color.FromArgb(46, 166, 46)
        Me.btnTambah.CornerRadius = 8
        Me.btnTambah.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.Location = New System.Drawing.Point(20, 224)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(314, 40)
        Me.btnTambah.TabIndex = 8
        Me.btnTambah.TabStop = False
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'btnUbah - oranye
        '
        Me.btnUbah.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUbah.BackColor = System.Drawing.Color.FromArgb(255, 148, 22)
        Me.btnUbah.CornerRadius = 8
        Me.btnUbah.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnUbah.ForeColor = System.Drawing.Color.White
        Me.btnUbah.Location = New System.Drawing.Point(20, 272)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(314, 40)
        Me.btnUbah.TabIndex = 9
        Me.btnUbah.TabStop = False
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'btnHapus - merah
        '
        Me.btnHapus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(223, 58, 53)
        Me.btnHapus.CornerRadius = 8
        Me.btnHapus.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Location = New System.Drawing.Point(20, 320)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(314, 40)
        Me.btnHapus.TabIndex = 10
        Me.btnHapus.TabStop = False
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'pnlNavigasi - tombol navigasi record + tutup (baris bawah merentang 2 kolom)
        '
        Me.pnlNavigasi.BackColor = System.Drawing.Color.FromArgb(220, 232, 248)
        Me.pnlNavigasi.Controls.Add(Me.btnPertama)
        Me.pnlNavigasi.Controls.Add(Me.btnSebelumnya)
        Me.pnlNavigasi.Controls.Add(Me.btnBerikutnya)
        Me.pnlNavigasi.Controls.Add(Me.btnTerakhir)
        Me.pnlNavigasi.Controls.Add(Me.btnTutup)
        Me.pnlNavigasi.Controls.Add(Me.btnRefresh)
        Me.pnlNavigasi.Controls.Add(Me.btnHalKasir)
        Me.pnlNavigasi.Controls.Add(Me.btnHalData)
        Me.pnlNavigasi.Controls.Add(Me.btnHalRiwayat)
        Me.pnlNavigasi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlNavigasi.Location = New System.Drawing.Point(0, 498)
        Me.pnlNavigasi.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.pnlNavigasi.MinimumSize = New System.Drawing.Size(0, 52)
        Me.pnlNavigasi.Name = "pnlNavigasi"
        Me.pnlNavigasi.Padding = New System.Windows.Forms.Padding(0)
        Me.pnlNavigasi.Size = New System.Drawing.Size(1080, 54)
        Me.pnlNavigasi.TabIndex = 4
        '
        'btnPertama - MoveFirst
        '
        Me.btnPertama.BackColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.btnPertama.CornerRadius = 8
        Me.btnPertama.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPertama.ForeColor = System.Drawing.Color.White
        Me.btnPertama.Location = New System.Drawing.Point(4, 9)
        Me.btnPertama.Name = "btnPertama"
        Me.btnPertama.Size = New System.Drawing.Size(104, 36)
        Me.btnPertama.TabIndex = 0
        Me.btnPertama.TabStop = False
        Me.btnPertama.Text = "|< Pertama"
        Me.btnPertama.UseVisualStyleBackColor = False
        '
        'btnSebelumnya - MovePrevious
        '
        Me.btnSebelumnya.BackColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.btnSebelumnya.CornerRadius = 8
        Me.btnSebelumnya.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSebelumnya.ForeColor = System.Drawing.Color.White
        Me.btnSebelumnya.Location = New System.Drawing.Point(116, 9)
        Me.btnSebelumnya.Name = "btnSebelumnya"
        Me.btnSebelumnya.Size = New System.Drawing.Size(120, 36)
        Me.btnSebelumnya.TabIndex = 1
        Me.btnSebelumnya.TabStop = False
        Me.btnSebelumnya.Text = "< Sebelumnya"
        Me.btnSebelumnya.UseVisualStyleBackColor = False
        '
        'btnBerikutnya - MoveNext
        '
        Me.btnBerikutnya.BackColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.btnBerikutnya.CornerRadius = 8
        Me.btnBerikutnya.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBerikutnya.ForeColor = System.Drawing.Color.White
        Me.btnBerikutnya.Location = New System.Drawing.Point(244, 9)
        Me.btnBerikutnya.Name = "btnBerikutnya"
        Me.btnBerikutnya.Size = New System.Drawing.Size(112, 36)
        Me.btnBerikutnya.TabIndex = 2
        Me.btnBerikutnya.TabStop = False
        Me.btnBerikutnya.Text = "Berikutnya >"
        Me.btnBerikutnya.UseVisualStyleBackColor = False
        '
        'btnTerakhir - MoveLast
        '
        Me.btnTerakhir.BackColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.btnTerakhir.CornerRadius = 8
        Me.btnTerakhir.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnTerakhir.ForeColor = System.Drawing.Color.White
        Me.btnTerakhir.Location = New System.Drawing.Point(364, 9)
        Me.btnTerakhir.Name = "btnTerakhir"
        Me.btnTerakhir.Size = New System.Drawing.Size(104, 36)
        Me.btnTerakhir.TabIndex = 3
        Me.btnTerakhir.TabStop = False
        Me.btnTerakhir.Text = "Terakhir >|"
        Me.btnTerakhir.UseVisualStyleBackColor = False
        '
        'btnTutup - menutup form kelola
        '
        Me.btnTutup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTutup.BackColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.btnTutup.CornerRadius = 8
        Me.btnTutup.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnTutup.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnTutup.ForeColor = System.Drawing.Color.White
        Me.btnTutup.Location = New System.Drawing.Point(982, 9)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(94, 36)
        Me.btnTutup.TabIndex = 4
        Me.btnTutup.TabStop = False
        Me.btnTutup.Text = "Kembali"
        Me.btnTutup.UseVisualStyleBackColor = False
        '
        'btnRefresh - muat ulang data dari database
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(46, 166, 46)
        Me.btnRefresh.CornerRadius = 8
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(480, 9)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(104, 36)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.TabStop = False
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnHalKasir - pindah ke halaman Kasir (F1)
        '
        Me.btnHalKasir.BackColor = System.Drawing.Color.FromArgb(120, 130, 145)
        Me.btnHalKasir.CornerRadius = 8
        Me.btnHalKasir.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnHalKasir.ForeColor = System.Drawing.Color.White
        Me.btnHalKasir.Location = New System.Drawing.Point(592, 9)
        Me.btnHalKasir.Name = "btnHalKasir"
        Me.btnHalKasir.Size = New System.Drawing.Size(100, 36)
        Me.btnHalKasir.TabIndex = 6
        Me.btnHalKasir.TabStop = False
        Me.btnHalKasir.Text = "Kasir (F1)"
        Me.btnHalKasir.UseVisualStyleBackColor = False
        '
        'btnHalData - pindah ke Kelola Barang (F2)
        '
        Me.btnHalData.BackColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.btnHalData.CornerRadius = 8
        Me.btnHalData.Enabled = False
        Me.btnHalData.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnHalData.ForeColor = System.Drawing.Color.White
        Me.btnHalData.Location = New System.Drawing.Point(698, 9)
        Me.btnHalData.Name = "btnHalData"
        Me.btnHalData.Size = New System.Drawing.Size(110, 36)
        Me.btnHalData.TabIndex = 7
        Me.btnHalData.TabStop = False
        Me.btnHalData.Text = "Data (F2)"
        Me.btnHalData.UseVisualStyleBackColor = False
        '
        'btnHalRiwayat - pindah ke Riwayat (F3)
        '
        Me.btnHalRiwayat.BackColor = System.Drawing.Color.FromArgb(120, 130, 145)
        Me.btnHalRiwayat.CornerRadius = 8
        Me.btnHalRiwayat.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnHalRiwayat.ForeColor = System.Drawing.Color.White
        Me.btnHalRiwayat.Location = New System.Drawing.Point(814, 9)
        Me.btnHalRiwayat.Name = "btnHalRiwayat"
        Me.btnHalRiwayat.Size = New System.Drawing.Size(108, 36)
        Me.btnHalRiwayat.TabIndex = 8
        Me.btnHalRiwayat.TabStop = False
        Me.btnHalRiwayat.Text = "Riwayat (F3)"
        Me.btnHalRiwayat.UseVisualStyleBackColor = False
        '
        'tblIsi - tata letak 2 kolom ala POS (Kiri = Input Barang, Kanan = Daftar Barang Besar)
        '
        Me.tblIsi.BackColor = System.Drawing.Color.FromArgb(220, 232, 248)
        Me.tblIsi.ColumnCount = 2
        Me.tblIsi.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360.0!))
        Me.tblIsi.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblIsi.Controls.Add(Me.pnlInput, 0, 0)
        Me.tblIsi.Controls.Add(Me.pnlCariTop, 1, 0)
        Me.tblIsi.Controls.Add(Me.pnlNavigasi, 0, 1)
        Me.tblIsi.SetColumnSpan(Me.pnlNavigasi, 2)
        Me.tblIsi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblIsi.Location = New System.Drawing.Point(0, 48)
        Me.tblIsi.Margin = New System.Windows.Forms.Padding(0)
        Me.tblIsi.Name = "tblIsi"
        Me.tblIsi.Padding = New System.Windows.Forms.Padding(0)
        Me.tblIsi.RowCount = 2
        Me.tblIsi.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblIsi.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.tblIsi.Size = New System.Drawing.Size(1080, 552)
        Me.tblIsi.TabIndex = 5
        '
        'FormDataBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(220, 232, 248)
        Me.Size = New System.Drawing.Size(1080, 600)
        Me.Controls.Add(Me.tblIsi)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MinimumSize = New System.Drawing.Size(880, 450)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "FormDataBarang"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlCariTop.ResumeLayout(False)
        Me.pnlCari.ResumeLayout(False)
        Me.pnlCari.PerformLayout()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInput.ResumeLayout(False)
        Me.pnlInput.PerformLayout()
        Me.pnlTabInput.ResumeLayout(False)
        Me.pnlNavigasi.ResumeLayout(False)
        Me.tblIsi.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlCariTop As Global.Kasir_Warung.PanelBulat
    Friend WithEvents lblIkon As System.Windows.Forms.Label
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents pnlCari As System.Windows.Forms.Panel
    Friend WithEvents lblCari As System.Windows.Forms.Label
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents lblJumlahRecord As System.Windows.Forms.Label
    Friend WithEvents dgvBarang As System.Windows.Forms.DataGridView
    Friend WithEvents colKode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHarga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStok As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlInput As Global.Kasir_Warung.PanelBulat
    Friend WithEvents pnlTabInput As Global.Kasir_Warung.PanelBulat
    Friend WithEvents lblTabInput As System.Windows.Forms.Label
    Friend WithEvents lblKode As System.Windows.Forms.Label
    Friend WithEvents txtKode As System.Windows.Forms.TextBox
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents lblHarga As System.Windows.Forms.Label
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents lblStok As System.Windows.Forms.Label
    Friend WithEvents txtStok As System.Windows.Forms.TextBox
    Friend WithEvents btnTambah As Global.Kasir_Warung.TombolBulat
    Friend WithEvents btnUbah As Global.Kasir_Warung.TombolBulat
    Friend WithEvents btnHapus As Global.Kasir_Warung.TombolBulat
    Friend WithEvents pnlNavigasi As System.Windows.Forms.Panel
    Friend WithEvents btnPertama As Global.Kasir_Warung.TombolBulat
    Friend WithEvents btnSebelumnya As Global.Kasir_Warung.TombolBulat
    Friend WithEvents btnBerikutnya As Global.Kasir_Warung.TombolBulat
    Friend WithEvents btnTerakhir As Global.Kasir_Warung.TombolBulat
    Friend WithEvents btnTutup As Global.Kasir_Warung.TombolBulat
    Friend WithEvents btnRefresh As Global.Kasir_Warung.TombolBulat
    Friend WithEvents btnHalKasir As Global.Kasir_Warung.TombolBulat
    Friend WithEvents btnHalData As Global.Kasir_Warung.TombolBulat
    Friend WithEvents btnHalRiwayat As Global.Kasir_Warung.TombolBulat
    Friend WithEvents tblIsi As System.Windows.Forms.TableLayoutPanel

End Class
