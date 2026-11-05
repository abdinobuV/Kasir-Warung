<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRiwayat
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
        Me.lblIkon = New System.Windows.Forms.Label()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.pnlFilterTop = New System.Windows.Forms.Panel()
        Me.pnlFilter = New System.Windows.Forms.Panel()
        Me.lblDari = New System.Windows.Forms.Label()
        Me.dtpDari = New System.Windows.Forms.DateTimePicker()
        Me.lblSampai = New System.Windows.Forms.Label()
        Me.dtpSampai = New System.Windows.Forms.DateTimePicker()
        Me.btnTerapkan = New Global.Kasir_Warung.TombolBulat()
        Me.lblPendapatan = New System.Windows.Forms.Label()
        Me.lblTotalPendapatan = New System.Windows.Forms.Label()
        Me.pnlMaster = New Global.Kasir_Warung.PanelBulat()
        Me.lblMaster = New System.Windows.Forms.Label()
        Me.dgvTransaksi = New System.Windows.Forms.DataGridView()
        Me.colNoTransaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBayar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKembali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlDetail = New Global.Kasir_Warung.PanelBulat()
        Me.lblDetail = New System.Windows.Forms.Label()
        Me.dgvDetail = New System.Windows.Forms.DataGridView()
        Me.colDNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDKode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDNama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDJumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.lblJudulDetail = New System.Windows.Forms.Label()
        Me.btnTutup = New Global.Kasir_Warung.TombolBulat()
        Me.pnlNavigasi = New System.Windows.Forms.Panel()
        Me.btnPertama = New Global.Kasir_Warung.TombolBulat()
        Me.btnSebelumnya = New Global.Kasir_Warung.TombolBulat()
        Me.btnBerikutnya = New Global.Kasir_Warung.TombolBulat()
        Me.btnTerakhir = New Global.Kasir_Warung.TombolBulat()
        Me.lblPosisi = New System.Windows.Forms.Label()
        Me.btnHalKasir = New Global.Kasir_Warung.TombolBulat()
        Me.btnHalData = New Global.Kasir_Warung.TombolBulat()
        Me.btnHalRiwayat = New Global.Kasir_Warung.TombolBulat()
        Me.tblIsi = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlHeader.SuspendLayout()
        Me.pnlFilterTop.SuspendLayout()
        Me.pnlFilter.SuspendLayout()
        Me.pnlMaster.SuspendLayout()
        CType(Me.dgvTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDetail.SuspendLayout()
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFooter.SuspendLayout()
        Me.pnlNavigasi.SuspendLayout()
        Me.tblIsi.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader - biru tua, judul halaman (Dock = Top, ringkas 48px seragam dengan Kelola Barang)
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
        'lblIkon - ikon jam/riwayat (glyph E823), font diganti saat form dibuka
        '
        Me.lblIkon.Font = New System.Drawing.Font("Segoe Fluent Icons", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblIkon.ForeColor = System.Drawing.Color.White
        Me.lblIkon.Location = New System.Drawing.Point(14, 8)
        Me.lblIkon.Name = "lblIkon"
        Me.lblIkon.Size = New System.Drawing.Size(38, 32)
        Me.lblIkon.TabIndex = 0
        Me.lblIkon.Text = Global.Microsoft.VisualBasic.ChrW(&HE823)
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
        Me.lblJudul.Text = "Riwayat Transaksi (F3)"
        '
        'pnlFilter - filter rentang tanggal + total pendapatan (Dock = Top, ringkas 48px)
        '
        Me.pnlFilter.BackColor = System.Drawing.Color.FromArgb(227, 236, 249)
        Me.pnlFilter.Controls.Add(Me.lblDari)
        Me.pnlFilter.Controls.Add(Me.dtpDari)
        Me.pnlFilter.Controls.Add(Me.lblSampai)
        Me.pnlFilter.Controls.Add(Me.dtpSampai)
        Me.pnlFilter.Controls.Add(Me.btnTerapkan)
        Me.pnlFilter.Controls.Add(Me.lblPendapatan)
        Me.pnlFilter.Controls.Add(Me.lblTotalPendapatan)
        Me.pnlFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFilter.Location = New System.Drawing.Point(0, 0)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Size = New System.Drawing.Size(1080, 48)
        Me.pnlFilterTop.Controls.Add(Me.pnlFilter)
        Me.pnlFilterTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilterTop.Location = New System.Drawing.Point(0, 48)
        Me.pnlFilterTop.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlFilterTop.Name = "pnlFilterTop"
        Me.pnlFilterTop.Size = New System.Drawing.Size(1080, 48)
        Me.pnlFilter.TabIndex = 1
        '
        'lblDari
        '
        Me.lblDari.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDari.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40)
        Me.lblDari.Location = New System.Drawing.Point(12, 9)
        Me.lblDari.Name = "lblDari"
        Me.lblDari.Size = New System.Drawing.Size(52, 30)
        Me.lblDari.TabIndex = 0
        Me.lblDari.Text = "Dari :"
        Me.lblDari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpDari - awal rentang filter
        '
        Me.dtpDari.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left
        Me.dtpDari.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpDari.Location = New System.Drawing.Point(70, 10)
        Me.dtpDari.Name = "dtpDari"
        Me.dtpDari.Size = New System.Drawing.Size(140, 28)
        Me.dtpDari.TabIndex = 1
        '
        'lblSampai
        '
        Me.lblSampai.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSampai.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40)
        Me.lblSampai.Location = New System.Drawing.Point(218, 9)
        Me.lblSampai.Name = "lblSampai"
        Me.lblSampai.Size = New System.Drawing.Size(72, 30)
        Me.lblSampai.TabIndex = 2
        Me.lblSampai.Text = "Sampai :"
        Me.lblSampai.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpSampai - akhir rentang filter
        '
        Me.dtpSampai.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left
        Me.dtpSampai.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpSampai.Location = New System.Drawing.Point(296, 10)
        Me.dtpSampai.Name = "dtpSampai"
        Me.dtpSampai.Size = New System.Drawing.Size(140, 28)
        Me.dtpSampai.TabIndex = 3
        '
        'btnTerapkan - hijau
        '
        Me.btnTerapkan.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left
        Me.btnTerapkan.BackColor = System.Drawing.Color.FromArgb(46, 166, 46)
        Me.btnTerapkan.CornerRadius = 8
        Me.btnTerapkan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnTerapkan.ForeColor = System.Drawing.Color.White
        Me.btnTerapkan.Location = New System.Drawing.Point(448, 8)
        Me.btnTerapkan.Name = "btnTerapkan"
        Me.btnTerapkan.Size = New System.Drawing.Size(124, 32)
        Me.btnTerapkan.TabIndex = 4
        Me.btnTerapkan.TabStop = False
        Me.btnTerapkan.Text = "Tampilkan"
        Me.btnTerapkan.UseVisualStyleBackColor = False
        '
        'lblPendapatan
        '
        Me.lblPendapatan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPendapatan.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPendapatan.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40)
        Me.lblPendapatan.Location = New System.Drawing.Point(710, 9)
        Me.lblPendapatan.Name = "lblPendapatan"
        Me.lblPendapatan.Size = New System.Drawing.Size(165, 30)
        Me.lblPendapatan.TabIndex = 5
        Me.lblPendapatan.Text = "Total Pendapatan :"
        Me.lblPendapatan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalPendapatan - diisi dari SUM(total) recordset
        '
        Me.lblTotalPendapatan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalPendapatan.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalPendapatan.ForeColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.lblTotalPendapatan.Location = New System.Drawing.Point(880, 9)
        Me.lblTotalPendapatan.Name = "lblTotalPendapatan"
        Me.lblTotalPendapatan.Size = New System.Drawing.Size(184, 30)
        Me.lblTotalPendapatan.TabIndex = 6
        Me.lblTotalPendapatan.Text = "Rp0"
        Me.lblTotalPendapatan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlMaster - panel kiri: Daftar Transaksi (Dock = Fill di Kolom 0)
        '
        Me.pnlMaster.BackColor = System.Drawing.Color.FromArgb(227, 236, 249)
        Me.pnlMaster.CornerRadius = 12
        Me.pnlMaster.Controls.Add(Me.dgvTransaksi)
        Me.pnlMaster.Controls.Add(Me.lblMaster)
        Me.pnlMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMaster.Location = New System.Drawing.Point(0, 6)
        Me.pnlMaster.Margin = New System.Windows.Forms.Padding(0, 6, 6, 4)
        Me.pnlMaster.MinimumSize = New System.Drawing.Size(0, 150)
        Me.pnlMaster.Name = "pnlMaster"
        Me.pnlMaster.Padding = New System.Windows.Forms.Padding(12, 42, 12, 12)
        Me.pnlMaster.Size = New System.Drawing.Size(556, 438)
        Me.pnlMaster.TabIndex = 2
        '
        'lblMaster - judul tab biru tua
        '
        Me.lblMaster.BackColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.lblMaster.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblMaster.ForeColor = System.Drawing.Color.White
        Me.lblMaster.Location = New System.Drawing.Point(12, 6)
        Me.lblMaster.Name = "lblMaster"
        Me.lblMaster.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.lblMaster.Size = New System.Drawing.Size(200, 30)
        Me.lblMaster.TabIndex = 0
        Me.lblMaster.Text = "Daftar Transaksi"
        Me.lblMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvTransaksi - master (kepala transaksi, memanjang penuh dari atas ke bawah)
        '
        Me.dgvTransaksi.AllowUserToAddRows = False
        Me.dgvTransaksi.AllowUserToDeleteRows = False
        Me.dgvTransaksi.AllowUserToResizeColumns = True
        Me.dgvTransaksi.AllowUserToResizeRows = False
        Me.dgvTransaksi.BackgroundColor = System.Drawing.Color.White
        Me.dgvTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvTransaksi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single
        Me.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvTransaksi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNoTransaksi, Me.colTanggal, Me.colTotal, Me.colBayar, Me.colKembali})
        Me.dgvTransaksi.ColumnHeadersHeight = 38
        Me.dgvTransaksi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTransaksi.EnableHeadersVisualStyles = False
        Me.dgvTransaksi.GridColor = System.Drawing.Color.FromArgb(200, 210, 225)
        Me.dgvTransaksi.Location = New System.Drawing.Point(12, 42)
        Me.dgvTransaksi.MultiSelect = False
        Me.dgvTransaksi.Name = "dgvTransaksi"
        Me.dgvTransaksi.ReadOnly = True
        Me.dgvTransaksi.RowHeadersVisible = False
        Me.dgvTransaksi.RowTemplate.Height = 34
        Me.dgvTransaksi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTransaksi.Size = New System.Drawing.Size(532, 384)
        Me.dgvTransaksi.TabIndex = 1
        Me.dgvTransaksi.TabStop = False
        '
        'colNoTransaksi
        '
        Me.colNoTransaksi.DataPropertyName = "no_transaksi"
        Me.colNoTransaksi.HeaderText = "No Transaksi"
        Me.colNoTransaksi.Name = "colNoTransaksi"
        Me.colNoTransaksi.ReadOnly = True
        Me.colNoTransaksi.Width = 145
        '
        'colTanggal - format tanggal id-ID
        '
        Me.colTanggal.DataPropertyName = "tanggal"
        Me.colTanggal.HeaderText = "Tanggal"
        Me.colTanggal.Name = "colTanggal"
        Me.colTanggal.ReadOnly = True
        Me.colTanggal.Width = 130
        '
        'colTotal - rata kanan, format Rp
        '
        Me.colTotal.DataPropertyName = "total"
        Me.colTotal.HeaderText = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.ReadOnly = True
        Me.colTotal.Width = 95
        '
        'colBayar - rata kanan, format Rp
        '
        Me.colBayar.DataPropertyName = "bayar"
        Me.colBayar.HeaderText = "Bayar"
        Me.colBayar.Name = "colBayar"
        Me.colBayar.ReadOnly = True
        Me.colBayar.Width = 95
        '
        'colKembali - rata kanan, format Rp, melebar
        '
        Me.colKembali.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colKembali.DataPropertyName = "kembali"
        Me.colKembali.HeaderText = "Kembali"
        Me.colKembali.MinimumWidth = 85
        Me.colKembali.Name = "colKembali"
        Me.colKembali.ReadOnly = True
        '
        'pnlDetail - panel kanan: Detail Item (Dock = Fill di Kolom 1)
        '
        Me.pnlDetail.BackColor = System.Drawing.Color.FromArgb(227, 236, 249)
        Me.pnlDetail.CornerRadius = 12
        Me.pnlDetail.Controls.Add(Me.dgvDetail)
        Me.pnlDetail.Controls.Add(Me.lblJudulDetail)
        Me.pnlDetail.Controls.Add(Me.lblDetail)
        Me.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDetail.Location = New System.Drawing.Point(568, 6)
        Me.pnlDetail.Margin = New System.Windows.Forms.Padding(6, 6, 0, 4)
        Me.pnlDetail.MinimumSize = New System.Drawing.Size(0, 150)
        Me.pnlDetail.Name = "pnlDetail"
        Me.pnlDetail.Padding = New System.Windows.Forms.Padding(12, 42, 12, 12)
        Me.pnlDetail.Size = New System.Drawing.Size(512, 438)
        Me.pnlDetail.TabIndex = 3
        '
        'lblDetail - judul tab biru tua
        '
        Me.lblDetail.BackColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.lblDetail.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDetail.ForeColor = System.Drawing.Color.White
        Me.lblDetail.Location = New System.Drawing.Point(12, 6)
        Me.lblDetail.Name = "lblDetail"
        Me.lblDetail.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.lblDetail.Size = New System.Drawing.Size(170, 30)
        Me.lblDetail.TabIndex = 0
        Me.lblDetail.Text = "Detail Item"
        Me.lblDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvDetail - detail (item transaksi terpilih, memanjang penuh dari atas ke bawah)
        '
        Me.dgvDetail.AllowUserToAddRows = False
        Me.dgvDetail.AllowUserToDeleteRows = False
        Me.dgvDetail.AllowUserToResizeColumns = True
        Me.dgvDetail.AllowUserToResizeRows = False
        Me.dgvDetail.BackgroundColor = System.Drawing.Color.White
        Me.dgvDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single
        Me.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDNo, Me.colDKode, Me.colDNama, Me.colDJumlah, Me.colDHarga, Me.colDSubtotal})
        Me.dgvDetail.ColumnHeadersHeight = 38
        Me.dgvDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDetail.EnableHeadersVisualStyles = False
        Me.dgvDetail.GridColor = System.Drawing.Color.FromArgb(200, 210, 225)
        Me.dgvDetail.Location = New System.Drawing.Point(12, 42)
        Me.dgvDetail.MultiSelect = False
        Me.dgvDetail.Name = "dgvDetail"
        Me.dgvDetail.ReadOnly = True
        Me.dgvDetail.RowHeadersVisible = False
        Me.dgvDetail.RowTemplate.Height = 34
        Me.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetail.Size = New System.Drawing.Size(488, 384)
        Me.dgvDetail.TabIndex = 1
        Me.dgvDetail.TabStop = False
        '
        'colDNo - nomor urut diisi sendiri
        '
        Me.colDNo.DataPropertyName = "no"
        Me.colDNo.DefaultCellStyle = New System.Windows.Forms.DataGridViewCellStyle() With {.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter}
        Me.colDNo.HeaderText = "No"
        Me.colDNo.Name = "colDNo"
        Me.colDNo.ReadOnly = True
        Me.colDNo.Width = 44
        '
        'colDKode
        '
        Me.colDKode.DataPropertyName = "kode_barang"
        Me.colDKode.HeaderText = "Kode"
        Me.colDKode.Name = "colDKode"
        Me.colDKode.ReadOnly = True
        Me.colDKode.Width = 85
        '
        'colDNama - melebar
        '
        Me.colDNama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDNama.DataPropertyName = "nama_barang"
        Me.colDNama.HeaderText = "Nama Barang"
        Me.colDNama.MinimumWidth = 120
        Me.colDNama.Name = "colDNama"
        Me.colDNama.ReadOnly = True
        '
        'colDJumlah
        '
        Me.colDJumlah.DefaultCellStyle = New System.Windows.Forms.DataGridViewCellStyle() With {.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter}
        Me.colDJumlah.DataPropertyName = "jumlah"
        Me.colDJumlah.HeaderText = "Jml"
        Me.colDJumlah.Name = "colDJumlah"
        Me.colDJumlah.ReadOnly = True
        Me.colDJumlah.Width = 58
        '
        'colDHarga - rata kanan, format Rp
        '
        Me.colDHarga.DataPropertyName = "harga_satuan"
        Me.colDHarga.HeaderText = "Harga"
        Me.colDHarga.Name = "colDHarga"
        Me.colDHarga.ReadOnly = True
        Me.colDHarga.Width = 95
        '
        'colDSubtotal - rata kanan, format Rp
        '
        Me.colDSubtotal.DataPropertyName = "subtotal"
        Me.colDSubtotal.HeaderText = "Subtotal"
        Me.colDSubtotal.Name = "colDSubtotal"
        Me.colDSubtotal.ReadOnly = True
        Me.colDSubtotal.Width = 100
        '
        'pnlFooter - panel cadangan (lblJudulDetail dipindah ke pnlDetail dan btnTutup ke pnlNavigasi)
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(220, 232, 248)
        Me.pnlFooter.Location = New System.Drawing.Point(0, 0)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(0, 0)
        Me.pnlFooter.TabIndex = 4
        Me.pnlFooter.Visible = False
        '
        'lblJudulDetail - info transaksi terpilih di kanan atas pnlDetail
        '
        Me.lblJudulDetail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblJudulDetail.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblJudulDetail.ForeColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.lblJudulDetail.Location = New System.Drawing.Point(190, 6)
        Me.lblJudulDetail.Name = "lblJudulDetail"
        Me.lblJudulDetail.Size = New System.Drawing.Size(310, 30)
        Me.lblJudulDetail.TabIndex = 2
        Me.lblJudulDetail.Text = "Pilih transaksi untuk melihat detail"
        Me.lblJudulDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnTutup - menutup form riwayat (di ujung kanan pnlNavigasi seragam dengan Kelola Barang)
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
        Me.btnTutup.TabIndex = 8
        Me.btnTutup.TabStop = False
        Me.btnTutup.Text = "Kembali"
        Me.btnTutup.UseVisualStyleBackColor = False
        '
        'pnlNavigasi - tombol navigasi record + navigasi halaman + Kembali (baris bawah merentang 2 kolom)
        '
        Me.pnlNavigasi.BackColor = System.Drawing.Color.FromArgb(220, 232, 248)
        Me.pnlNavigasi.Controls.Add(Me.btnPertama)
        Me.pnlNavigasi.Controls.Add(Me.btnSebelumnya)
        Me.pnlNavigasi.Controls.Add(Me.btnBerikutnya)
        Me.pnlNavigasi.Controls.Add(Me.btnTerakhir)
        Me.pnlNavigasi.Controls.Add(Me.lblPosisi)
        Me.pnlNavigasi.Controls.Add(Me.btnHalKasir)
        Me.pnlNavigasi.Controls.Add(Me.btnHalData)
        Me.pnlNavigasi.Controls.Add(Me.btnHalRiwayat)
        Me.pnlNavigasi.Controls.Add(Me.btnTutup)
        Me.pnlNavigasi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlNavigasi.Location = New System.Drawing.Point(0, 450)
        Me.pnlNavigasi.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.pnlNavigasi.MinimumSize = New System.Drawing.Size(0, 52)
        Me.pnlNavigasi.Name = "pnlNavigasi"
        Me.pnlNavigasi.Size = New System.Drawing.Size(1080, 54)
        Me.pnlNavigasi.TabIndex = 5
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
        'lblPosisi - posisi record saat ini
        '
        Me.lblPosisi.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPosisi.ForeColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.lblPosisi.Location = New System.Drawing.Point(476, 9)
        Me.lblPosisi.Name = "lblPosisi"
        Me.lblPosisi.Size = New System.Drawing.Size(110, 36)
        Me.lblPosisi.TabIndex = 4
        Me.lblPosisi.Text = "Record 0 dari 0"
        Me.lblPosisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btnHalKasir.TabIndex = 5
        Me.btnHalKasir.TabStop = False
        Me.btnHalKasir.Text = "Kasir (F1)"
        Me.btnHalKasir.UseVisualStyleBackColor = False
        '
        'btnHalData - pindah ke Kelola Barang (F2)
        '
        Me.btnHalData.BackColor = System.Drawing.Color.FromArgb(120, 130, 145)
        Me.btnHalData.CornerRadius = 8
        Me.btnHalData.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnHalData.ForeColor = System.Drawing.Color.White
        Me.btnHalData.Location = New System.Drawing.Point(698, 9)
        Me.btnHalData.Name = "btnHalData"
        Me.btnHalData.Size = New System.Drawing.Size(110, 36)
        Me.btnHalData.TabIndex = 6
        Me.btnHalData.TabStop = False
        Me.btnHalData.Text = "Data (F2)"
        Me.btnHalData.UseVisualStyleBackColor = False
        '
        'btnHalRiwayat - pindah ke Riwayat (F3)
        '
        Me.btnHalRiwayat.BackColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.btnHalRiwayat.CornerRadius = 8
        Me.btnHalRiwayat.Enabled = False
        Me.btnHalRiwayat.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnHalRiwayat.ForeColor = System.Drawing.Color.White
        Me.btnHalRiwayat.Location = New System.Drawing.Point(814, 9)
        Me.btnHalRiwayat.Name = "btnHalRiwayat"
        Me.btnHalRiwayat.Size = New System.Drawing.Size(108, 36)
        Me.btnHalRiwayat.TabIndex = 7
        Me.btnHalRiwayat.TabStop = False
        Me.btnHalRiwayat.Text = "Riwayat (F3)"
        Me.btnHalRiwayat.UseVisualStyleBackColor = False
        '
        'tblIsi - tata letak 2 kolom ala POS (Kiri = Daftar Transaksi, Kanan = Detail Item)
        '
        Me.tblIsi.BackColor = System.Drawing.Color.FromArgb(220, 232, 248)
        Me.tblIsi.ColumnCount = 2
        Me.tblIsi.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.0!))
        Me.tblIsi.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.0!))
        Me.tblIsi.Controls.Add(Me.pnlMaster, 0, 0)
        Me.tblIsi.Controls.Add(Me.pnlDetail, 1, 0)
        Me.tblIsi.Controls.Add(Me.pnlNavigasi, 0, 1)
        Me.tblIsi.SetColumnSpan(Me.pnlNavigasi, 2)
        Me.tblIsi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblIsi.Location = New System.Drawing.Point(0, 96)
        Me.tblIsi.Margin = New System.Windows.Forms.Padding(0)
        Me.tblIsi.Name = "tblIsi"
        Me.tblIsi.Padding = New System.Windows.Forms.Padding(0)
        Me.tblIsi.RowCount = 2
        Me.tblIsi.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblIsi.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.tblIsi.Size = New System.Drawing.Size(1080, 504)
        Me.tblIsi.TabIndex = 6
        '
        'FormRiwayat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(220, 232, 248)
        Me.Size = New System.Drawing.Size(1080, 600)
        Me.Controls.Add(Me.tblIsi)
        Me.Controls.Add(Me.pnlFilterTop)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MinimumSize = New System.Drawing.Size(880, 450)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "FormRiwayat"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlFilterTop.ResumeLayout(False)
        Me.pnlFilter.ResumeLayout(False)
        Me.pnlFilter.PerformLayout()
        Me.pnlMaster.ResumeLayout(False)
        Me.pnlMaster.PerformLayout()
        CType(Me.dgvTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDetail.ResumeLayout(False)
        Me.pnlDetail.PerformLayout()
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlNavigasi.ResumeLayout(False)
        Me.tblIsi.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlFilterTop As System.Windows.Forms.Panel
    Friend WithEvents lblIkon As System.Windows.Forms.Label
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents pnlFilter As System.Windows.Forms.Panel
    Friend WithEvents lblDari As System.Windows.Forms.Label
    Friend WithEvents dtpDari As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSampai As System.Windows.Forms.Label
    Friend WithEvents dtpSampai As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnTerapkan As Global.Kasir_Warung.TombolBulat
    Friend WithEvents lblPendapatan As System.Windows.Forms.Label
    Friend WithEvents lblTotalPendapatan As System.Windows.Forms.Label
    Friend WithEvents pnlMaster As Global.Kasir_Warung.PanelBulat
    Friend WithEvents lblMaster As System.Windows.Forms.Label
    Friend WithEvents dgvTransaksi As System.Windows.Forms.DataGridView
    Friend WithEvents colNoTransaksi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTanggal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBayar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colKembali As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlDetail As Global.Kasir_Warung.PanelBulat
    Friend WithEvents lblDetail As System.Windows.Forms.Label
    Friend WithEvents dgvDetail As System.Windows.Forms.DataGridView
    Friend WithEvents colDNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDKode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDNama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDJumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDHarga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDSubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents lblJudulDetail As System.Windows.Forms.Label
    Friend WithEvents btnTutup As Global.Kasir_Warung.TombolBulat
    Friend WithEvents pnlNavigasi As System.Windows.Forms.Panel
    Friend WithEvents btnPertama As Global.Kasir_Warung.TombolBulat
    Friend WithEvents btnSebelumnya As Global.Kasir_Warung.TombolBulat
    Friend WithEvents btnBerikutnya As Global.Kasir_Warung.TombolBulat
    Friend WithEvents btnTerakhir As Global.Kasir_Warung.TombolBulat
    Friend WithEvents lblPosisi As System.Windows.Forms.Label
    Friend WithEvents btnHalKasir As Global.Kasir_Warung.TombolBulat
    Friend WithEvents btnHalData As Global.Kasir_Warung.TombolBulat
    Friend WithEvents btnHalRiwayat As Global.Kasir_Warung.TombolBulat
    Friend WithEvents tblIsi As System.Windows.Forms.TableLayoutPanel

End Class
