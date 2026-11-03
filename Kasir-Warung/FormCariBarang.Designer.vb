<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCariBarang
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
    'It can be modified using the code editor.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlHeader = New System.Windows.Forms.Panel()
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
        Me.pnlNavigasi = New System.Windows.Forms.Panel()
        Me.btnPertama = New Global.Kasir_Warung.TombolBulat()
        Me.btnSebelumnya = New Global.Kasir_Warung.TombolBulat()
        Me.btnBerikutnya = New Global.Kasir_Warung.TombolBulat()
        Me.btnTerakhir = New Global.Kasir_Warung.TombolBulat()
        Me.btnPilih = New Global.Kasir_Warung.TombolBulat()
        Me.btnBatal = New Global.Kasir_Warung.TombolBulat()
        Me.pnlHeader.SuspendLayout()
        Me.pnlCari.SuspendLayout()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlHeader.Size = New System.Drawing.Size(740, 58)
        Me.pnlHeader.TabIndex = 0
        '
        'lblIkon - kaca pembesar (glyph E721), font diganti saat form dibuka
        '
        Me.lblIkon.Font = New System.Drawing.Font("Segoe Fluent Icons", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblIkon.ForeColor = System.Drawing.Color.White
        Me.lblIkon.Location = New System.Drawing.Point(16, 13)
        Me.lblIkon.Name = "lblIkon"
        Me.lblIkon.Size = New System.Drawing.Size(32, 32)
        Me.lblIkon.TabIndex = 0
        Me.lblIkon.Text = Global.Microsoft.VisualBasic.ChrW(&HE721)
        Me.lblIkon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblJudul - judul dialog
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblJudul.ForeColor = System.Drawing.Color.White
        Me.lblJudul.Location = New System.Drawing.Point(56, 14)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(151, 30)
        Me.lblJudul.TabIndex = 1
        Me.lblJudul.Text = "Cari Barang"
        '
        'pnlCari - kotak cari + label jumlah record (Dock = Top)
        '
        Me.pnlCari.BackColor = System.Drawing.Color.FromArgb(227, 236, 249)
        Me.pnlCari.Controls.Add(Me.lblCari)
        Me.pnlCari.Controls.Add(Me.txtCari)
        Me.pnlCari.Controls.Add(Me.lblJumlahRecord)
        Me.pnlCari.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCari.Location = New System.Drawing.Point(0, 58)
        Me.pnlCari.Name = "pnlCari"
        Me.pnlCari.Size = New System.Drawing.Size(740, 62)
        Me.pnlCari.TabIndex = 1
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
        'txtCari - mengetik langsung menyaring daftar barang
        '
        Me.txtCari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCari.Location = New System.Drawing.Point(84, 15)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(360, 32)
        Me.txtCari.TabIndex = 1
        '
        'lblJumlahRecord - jumlah record dari BindingSource.Count
        '
        Me.lblJumlahRecord.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblJumlahRecord.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40)
        Me.lblJumlahRecord.Location = New System.Drawing.Point(456, 15)
        Me.lblJumlahRecord.Name = "lblJumlahRecord"
        Me.lblJumlahRecord.Size = New System.Drawing.Size(268, 32)
        Me.lblJumlahRecord.TabIndex = 2
        Me.lblJumlahRecord.Text = "Jumlah record : 0"
        Me.lblJumlahRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgvBarang - isi recordset barang (Dock = Fill)
        '
        Me.dgvBarang.AllowUserToAddRows = False
        Me.dgvBarang.AllowUserToDeleteRows = False
        Me.dgvBarang.AllowUserToResizeColumns = False
        Me.dgvBarang.AllowUserToResizeRows = False
        Me.dgvBarang.BackgroundColor = System.Drawing.Color.White
        Me.dgvBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvBarang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single
        Me.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colKode, Me.colNama, Me.colHarga, Me.colStok})
        Me.dgvBarang.ColumnHeadersHeight = 34
        Me.dgvBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBarang.EnableHeadersVisualStyles = False
        Me.dgvBarang.GridColor = System.Drawing.Color.FromArgb(200, 210, 225)
        Me.dgvBarang.Location = New System.Drawing.Point(0, 120)
        Me.dgvBarang.MultiSelect = False
        Me.dgvBarang.Name = "dgvBarang"
        Me.dgvBarang.ReadOnly = True
        Me.dgvBarang.RowHeadersVisible = False
        Me.dgvBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBarang.Size = New System.Drawing.Size(740, 286)
        Me.dgvBarang.TabIndex = 2
        Me.dgvBarang.TabStop = False
        '
        'colKode - DataPropertyName diisi agar cocok dengan kolom DataTable
        '
        Me.colKode.DataPropertyName = "kode_barang"
        Me.colKode.HeaderText = "Kode Barang"
        Me.colKode.Name = "colKode"
        Me.colKode.ReadOnly = True
        Me.colKode.Width = 110
        '
        'colNama - melebar mengikuti lebar dialog
        '
        Me.colNama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNama.DataPropertyName = "nama_barang"
        Me.colNama.HeaderText = "Nama Barang"
        Me.colNama.MinimumWidth = 150
        Me.colNama.Name = "colNama"
        Me.colNama.ReadOnly = True
        '
        'colHarga - rata kanan, format Rp
        '
        Me.colHarga.DataPropertyName = "harga"
        Me.colHarga.HeaderText = "Harga"
        Me.colHarga.Name = "colHarga"
        Me.colHarga.ReadOnly = True
        Me.colHarga.Width = 120
        '
        'colStok - rata tengah
        '
        Me.colStok.DataPropertyName = "stok"
        Me.colStok.HeaderText = "Stok"
        Me.colStok.Name = "colStok"
        Me.colStok.ReadOnly = True
        Me.colStok.Width = 80
        '
        'pnlNavigasi - tombol navigasi record + pilih/batal (Dock = Bottom)
        '
        Me.pnlNavigasi.BackColor = System.Drawing.Color.FromArgb(220, 232, 248)
        Me.pnlNavigasi.Controls.Add(Me.btnPertama)
        Me.pnlNavigasi.Controls.Add(Me.btnSebelumnya)
        Me.pnlNavigasi.Controls.Add(Me.btnBerikutnya)
        Me.pnlNavigasi.Controls.Add(Me.btnTerakhir)
        Me.pnlNavigasi.Controls.Add(Me.btnPilih)
        Me.pnlNavigasi.Controls.Add(Me.btnBatal)
        Me.pnlNavigasi.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlNavigasi.Location = New System.Drawing.Point(0, 406)
        Me.pnlNavigasi.Name = "pnlNavigasi"
        Me.pnlNavigasi.Size = New System.Drawing.Size(740, 64)
        Me.pnlNavigasi.TabIndex = 3
        '
        'btnPertama - MoveFirst
        '
        Me.btnPertama.BackColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.btnPertama.CornerRadius = 8
        Me.btnPertama.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPertama.ForeColor = System.Drawing.Color.White
        Me.btnPertama.Location = New System.Drawing.Point(14, 14)
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
        Me.btnSebelumnya.Location = New System.Drawing.Point(126, 14)
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
        Me.btnBerikutnya.Location = New System.Drawing.Point(254, 14)
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
        Me.btnTerakhir.Location = New System.Drawing.Point(374, 14)
        Me.btnTerakhir.Name = "btnTerakhir"
        Me.btnTerakhir.Size = New System.Drawing.Size(104, 36)
        Me.btnTerakhir.TabIndex = 3
        Me.btnTerakhir.TabStop = False
        Me.btnTerakhir.Text = "Terakhir >|"
        Me.btnTerakhir.UseVisualStyleBackColor = False
        '
        'btnPilih - hijau, mengirim kode barang terpilih ke FormKasir
        '
        Me.btnPilih.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPilih.BackColor = System.Drawing.Color.FromArgb(46, 166, 46)
        Me.btnPilih.CornerRadius = 8
        Me.btnPilih.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPilih.ForeColor = System.Drawing.Color.White
        Me.btnPilih.Location = New System.Drawing.Point(516, 14)
        Me.btnPilih.Name = "btnPilih"
        Me.btnPilih.Size = New System.Drawing.Size(104, 36)
        Me.btnPilih.TabIndex = 4
        Me.btnPilih.TabStop = False
        Me.btnPilih.Text = "Pilih"
        Me.btnPilih.UseVisualStyleBackColor = False
        '
        'btnBatal - merah, menutup dialog tanpa memilih
        '
        Me.btnBatal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(223, 58, 53)
        Me.btnBatal.CornerRadius = 8
        Me.btnBatal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBatal.ForeColor = System.Drawing.Color.White
        Me.btnBatal.Location = New System.Drawing.Point(628, 14)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(98, 36)
        Me.btnBatal.TabIndex = 5
        Me.btnBatal.TabStop = False
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'FormCariBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(220, 232, 248)
        Me.CancelButton = Me.btnBatal
        Me.ClientSize = New System.Drawing.Size(740, 470)
        Me.Controls.Add(Me.dgvBarang)
        Me.Controls.Add(Me.pnlNavigasi)
        Me.Controls.Add(Me.pnlCari)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCariBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cari Barang"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlCari.ResumeLayout(False)
        Me.pnlCari.PerformLayout()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNavigasi.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
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
    Friend WithEvents pnlNavigasi As System.Windows.Forms.Panel
    Friend WithEvents btnPertama As Global.Kasir_Warung.TombolBulat
    Friend WithEvents btnSebelumnya As Global.Kasir_Warung.TombolBulat
    Friend WithEvents btnBerikutnya As Global.Kasir_Warung.TombolBulat
    Friend WithEvents btnTerakhir As Global.Kasir_Warung.TombolBulat
    Friend WithEvents btnPilih As Global.Kasir_Warung.TombolBulat
    Friend WithEvents btnBatal As Global.Kasir_Warung.TombolBulat

End Class
