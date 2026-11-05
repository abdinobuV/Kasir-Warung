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
        Me.pnlCariTop = New System.Windows.Forms.Panel()
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
        Me.pnlHeader.SuspendLayout()
        Me.pnlCariTop.SuspendLayout()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInput.SuspendLayout()
        Me.pnlNavigasi.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader - biru tua, judul dialog (Dock = Top)
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.pnlHeader.Controls.Add(Me.lblIkon)
        Me.pnlHeader.Controls.Add(Me.lblJudul)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(880, 72)
        Me.pnlHeader.TabIndex = 0
        '
        'lblIkon - ikon kotak barang (glyph E7F4), font diganti saat form dibuka
        '
        Me.lblIkon.Font = New System.Drawing.Font("Segoe Fluent Icons", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblIkon.ForeColor = System.Drawing.Color.White
        Me.lblIkon.Location = New System.Drawing.Point(16, 18)
        Me.lblIkon.Name = "lblIkon"
        Me.lblIkon.Size = New System.Drawing.Size(44, 36)
        Me.lblIkon.TabIndex = 0
        Me.lblIkon.Text = Global.Microsoft.VisualBasic.ChrW(&HE7F4)
        Me.lblIkon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblJudul.ForeColor = System.Drawing.Color.White
        Me.lblJudul.Location = New System.Drawing.Point(68, 20)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(260, 30)
        Me.lblJudul.TabIndex = 1
        Me.lblJudul.Text = "Kelola Barang (F2)"
        '
        'pnlCari - kotak cari + label jumlah record (Dock = Top)
        '
        Me.pnlCari.BackColor = System.Drawing.Color.FromArgb(227, 236, 249)
        Me.pnlCari.Controls.Add(Me.lblCari)
        Me.pnlCari.Controls.Add(Me.txtCari)
        Me.pnlCari.Controls.Add(Me.lblJumlahRecord)
        Me.pnlCari.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCari.Location = New System.Drawing.Point(0, 0)
        Me.pnlCari.Name = "pnlCari"
        Me.pnlCari.Size = New System.Drawing.Size(880, 62)
        Me.pnlCari.TabIndex = 1
        Me.pnlCariTop.Controls.Add(Me.pnlCari)
        Me.pnlCariTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCariTop.Location = New System.Drawing.Point(0, 72)
        Me.pnlCariTop.Name = "pnlCariTop"
        Me.pnlCariTop.Size = New System.Drawing.Size(880, 62)
        '
        'lblCari
        '
        Me.lblCari.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40)
        Me.lblCari.Location = New System.Drawing.Point(16, 15)
        Me.lblCari.Name = "lblCari"
        Me.lblCari.Size = New System.Drawing.Size(62, 32)
        Me.lblCari.TabIndex = 0
        Me.lblCari.Text = "Cari :"
        Me.lblCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCari
        '
        Me.txtCari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCari.Location = New System.Drawing.Point(84, 15)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(420, 32)
        Me.txtCari.TabIndex = 1
        '
        'lblJumlahRecord - jumlah record dari BindingSource.Count
        '
        Me.lblJumlahRecord.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblJumlahRecord.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40)
        Me.lblJumlahRecord.Location = New System.Drawing.Point(516, 15)
        Me.lblJumlahRecord.Name = "lblJumlahRecord"
        Me.lblJumlahRecord.Size = New System.Drawing.Size(348, 32)
        Me.lblJumlahRecord.TabIndex = 2
        Me.lblJumlahRecord.Text = "Jumlah record : 0"
        Me.lblJumlahRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgvBarang - isi recordset barang (Dock = Fill)
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
        Me.dgvBarang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvBarang.ColumnHeadersHeight = 40
        Me.dgvBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBarang.EnableHeadersVisualStyles = False
        Me.dgvBarang.GridColor = System.Drawing.Color.FromArgb(200, 210, 225)
        Me.dgvBarang.Location = New System.Drawing.Point(0, 134)
        Me.dgvBarang.MultiSelect = False
        Me.dgvBarang.Name = "dgvBarang"
        Me.dgvBarang.ReadOnly = True
        Me.dgvBarang.RowHeadersVisible = False
        Me.dgvBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBarang.Size = New System.Drawing.Size(880, 428)
        Me.dgvBarang.TabIndex = 2
        Me.dgvBarang.TabStop = False
        '
        'colKode
        '
        Me.colKode.DataPropertyName = "kode_barang"
        Me.colKode.HeaderText = "Kode Barang"
        Me.colKode.Name = "colKode"
        Me.colKode.ReadOnly = True
        Me.colKode.Width = 160
        '
        'colNama - melebar mengikuti lebar dialog
        '
        Me.colNama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNama.DataPropertyName = "nama_barang"
        Me.colNama.HeaderText = "Nama Barang"
        Me.colNama.MinimumWidth = 200
        Me.colNama.Name = "colNama"
        Me.colNama.ReadOnly = True
        '
        'colHarga - rata kanan, format Rp
        '
        Me.colHarga.DataPropertyName = "harga"
        Me.colHarga.HeaderText = "Harga"
        Me.colHarga.Name = "colHarga"
        Me.colHarga.ReadOnly = True
        Me.colHarga.Width = 150
        '
        'colStok - rata tengah
        '
        Me.colStok.DataPropertyName = "stok"
        Me.colStok.HeaderText = "Stok"
        Me.colStok.Name = "colStok"
        Me.colStok.ReadOnly = True
        Me.colStok.Width = 100
        '
        'pnlInput - panel input/edit di bawah grid (Dock = Bottom)
        '
        Me.pnlInput.BackColor = System.Drawing.Color.FromArgb(227, 236, 249)
        Me.pnlInput.CornerRadius = 12
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
        Me.pnlInput.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlInput.Location = New System.Drawing.Point(0, 562)
        Me.pnlInput.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.pnlInput.Name = "pnlInput"
        Me.pnlInput.Padding = New System.Windows.Forms.Padding(16, 12, 16, 12)
        Me.pnlInput.Size = New System.Drawing.Size(880, 154)
        Me.pnlInput.TabIndex = 3
        '
        'lblKode
        '
        Me.lblKode.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblKode.Location = New System.Drawing.Point(16, 18)
        Me.lblKode.Name = "lblKode"
        Me.lblKode.Size = New System.Drawing.Size(90, 24)
        Me.lblKode.TabIndex = 0
        Me.lblKode.Text = "Kode :"
        Me.lblKode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtKode - kode tidak boleh kosong, tidak boleh kembar (divalidasi di kode)
        '
        Me.txtKode.Location = New System.Drawing.Point(112, 16)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(110, 30)
        Me.txtKode.TabIndex = 1
        '
        'lblNama
        '
        Me.lblNama.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNama.Location = New System.Drawing.Point(16, 60)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(90, 24)
        Me.lblNama.TabIndex = 2
        Me.lblNama.Text = "Nama :"
        Me.lblNama.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(112, 58)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(300, 30)
        Me.txtNama.TabIndex = 3
        '
        'lblHarga
        '
        Me.lblHarga.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblHarga.Location = New System.Drawing.Point(424, 18)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(70, 24)
        Me.lblHarga.TabIndex = 4
        Me.lblHarga.Text = "Harga :"
        Me.lblHarga.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHarga - hanya angka >= 0
        '
        Me.txtHarga.Location = New System.Drawing.Point(500, 16)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(140, 30)
        Me.txtHarga.TabIndex = 5
        '
        'lblStok
        '
        Me.lblStok.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblStok.Location = New System.Drawing.Point(424, 60)
        Me.lblStok.Name = "lblStok"
        Me.lblStok.Size = New System.Drawing.Size(70, 24)
        Me.lblStok.TabIndex = 6
        Me.lblStok.Text = "Stok :"
        Me.lblStok.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStok - hanya angka >= 0
        '
        Me.txtStok.Location = New System.Drawing.Point(500, 58)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(140, 30)
        Me.txtStok.TabIndex = 7
        '
        'btnTambah - hijau
        '
        Me.btnTambah.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTambah.BackColor = System.Drawing.Color.FromArgb(46, 166, 46)
        Me.btnTambah.CornerRadius = 8
        Me.btnTambah.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.Location = New System.Drawing.Point(656, 16)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(208, 36)
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
        Me.btnUbah.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnUbah.ForeColor = System.Drawing.Color.White
        Me.btnUbah.Location = New System.Drawing.Point(656, 62)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(208, 36)
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
        Me.btnHapus.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Location = New System.Drawing.Point(656, 104)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(208, 36)
        Me.btnHapus.TabIndex = 10
        Me.btnHapus.TabStop = False
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'pnlNavigasi - tombol navigasi record + tutup (Dock = Bottom)
        '
        Me.pnlNavigasi.BackColor = System.Drawing.Color.FromArgb(220, 232, 248)
        Me.pnlNavigasi.Controls.Add(Me.btnPertama)
        Me.pnlNavigasi.Controls.Add(Me.btnSebelumnya)
        Me.pnlNavigasi.Controls.Add(Me.btnBerikutnya)
        Me.pnlNavigasi.Controls.Add(Me.btnTerakhir)
        Me.pnlNavigasi.Controls.Add(Me.btnTutup)
        Me.pnlNavigasi.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlNavigasi.Location = New System.Drawing.Point(0, 716)
        Me.pnlNavigasi.Name = "pnlNavigasi"
        Me.pnlNavigasi.Size = New System.Drawing.Size(880, 64)
        Me.pnlNavigasi.TabIndex = 4
        '
        'btnPertama - MoveFirst
        '
        Me.btnPertama.BackColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.btnPertama.CornerRadius = 8
        Me.btnPertama.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPertama.ForeColor = System.Drawing.Color.White
        Me.btnPertama.Location = New System.Drawing.Point(16, 14)
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
        Me.btnSebelumnya.Location = New System.Drawing.Point(128, 14)
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
        Me.btnBerikutnya.Location = New System.Drawing.Point(256, 14)
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
        Me.btnTerakhir.Location = New System.Drawing.Point(376, 14)
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
        Me.btnTutup.Location = New System.Drawing.Point(770, 14)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(94, 36)
        Me.btnTutup.TabIndex = 4
        Me.btnTutup.TabStop = False
        Me.btnTutup.Text = "Kembali"
        Me.btnTutup.UseVisualStyleBackColor = False
        '
        'FormDataBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(220, 232, 248)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Size = New System.Drawing.Size(880, 786)
        Me.Controls.Add(Me.dgvBarang)
        Me.Controls.Add(Me.pnlInput)
        Me.Controls.Add(Me.pnlNavigasi)
        Me.Controls.Add(Me.pnlCariTop)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MinimumSize = New System.Drawing.Size(880, 786)
        Me.Name = "FormDataBarang"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlCariTop.ResumeLayout(False)
        Me.pnlCari.ResumeLayout(False)
        Me.pnlCari.PerformLayout()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInput.ResumeLayout(False)
        Me.pnlInput.PerformLayout()
        Me.pnlNavigasi.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlCariTop As System.Windows.Forms.Panel
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

End Class
