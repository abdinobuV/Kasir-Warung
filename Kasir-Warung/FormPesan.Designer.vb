<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPesan
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblIkon = New System.Windows.Forms.Label()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.pnlIsi = New System.Windows.Forms.Panel()
        Me.pnlPesan = New Global.Kasir_Warung.PanelBulat()
        Me.lblIkonBesar = New System.Windows.Forms.Label()
        Me.lblPesan = New System.Windows.Forms.Label()
        Me.pnlTombol = New System.Windows.Forms.Panel()
        Me.btnOK = New Global.Kasir_Warung.TombolBulat()
        Me.pnlHeader.SuspendLayout()
        Me.pnlIsi.SuspendLayout()
        Me.pnlPesan.SuspendLayout()
        Me.pnlTombol.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader - biru tua, menempel di atas
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.pnlHeader.Controls.Add(Me.lblIkon)
        Me.pnlHeader.Controls.Add(Me.lblJudul)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(520, 58)
        Me.pnlHeader.TabIndex = 0
        '
        'lblIkon - ikon di header
        '
        Me.lblIkon.Font = New System.Drawing.Font("Segoe Fluent Icons", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblIkon.ForeColor = System.Drawing.Color.White
        Me.lblIkon.Location = New System.Drawing.Point(14, 13)
        Me.lblIkon.Name = "lblIkon"
        Me.lblIkon.Size = New System.Drawing.Size(36, 32)
        Me.lblIkon.TabIndex = 0
        Me.lblIkon.Text = "i"
        Me.lblIkon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblJudul - judul dialog
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblJudul.ForeColor = System.Drawing.Color.White
        Me.lblJudul.Location = New System.Drawing.Point(58, 14)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(71, 30)
        Me.lblJudul.TabIndex = 1
        Me.lblJudul.Text = "Pesan"
        '
        'pnlIsi - wadah tengah
        '
        Me.pnlIsi.BackColor = System.Drawing.Color.FromArgb(220, 232, 248)
        Me.pnlIsi.Controls.Add(Me.pnlPesan)
        Me.pnlIsi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlIsi.Location = New System.Drawing.Point(0, 58)
        Me.pnlIsi.Name = "pnlIsi"
        Me.pnlIsi.Padding = New System.Windows.Forms.Padding(12, 12, 12, 12)
        Me.pnlIsi.Size = New System.Drawing.Size(520, 222)
        Me.pnlIsi.TabIndex = 1
        '
        'pnlPesan - panel biru muda membulat berisi pesan
        '
        Me.pnlPesan.BackColor = System.Drawing.Color.FromArgb(227, 236, 249)
        Me.pnlPesan.Controls.Add(Me.lblIkonBesar)
        Me.pnlPesan.Controls.Add(Me.lblPesan)
        Me.pnlPesan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPesan.Location = New System.Drawing.Point(12, 12)
        Me.pnlPesan.Name = "pnlPesan"
        Me.pnlPesan.Size = New System.Drawing.Size(496, 198)
        Me.pnlPesan.TabIndex = 0
        '
        'lblIkonBesar - ikon jenis pesan besar
        '
        Me.lblIkonBesar.Font = New System.Drawing.Font("Segoe Fluent Icons", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblIkonBesar.ForeColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.lblIkonBesar.Location = New System.Drawing.Point(16, 20)
        Me.lblIkonBesar.Name = "lblIkonBesar"
        Me.lblIkonBesar.Size = New System.Drawing.Size(64, 64)
        Me.lblIkonBesar.TabIndex = 0
        Me.lblIkonBesar.Text = "i"
        Me.lblIkonBesar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPesan - isi pesan
        '
        Me.lblPesan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPesan.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPesan.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40)
        Me.lblPesan.Location = New System.Drawing.Point(92, 20)
        Me.lblPesan.Name = "lblPesan"
        Me.lblPesan.Size = New System.Drawing.Size(388, 158)
        Me.lblPesan.TabIndex = 1
        Me.lblPesan.Text = "Pesan"
        Me.lblPesan.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'pnlTombol - tombol OK di bawah
        '
        Me.pnlTombol.BackColor = System.Drawing.Color.FromArgb(220, 232, 248)
        Me.pnlTombol.Controls.Add(Me.btnOK)
        Me.pnlTombol.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlTombol.Location = New System.Drawing.Point(0, 280)
        Me.pnlTombol.Name = "pnlTombol"
        Me.pnlTombol.Size = New System.Drawing.Size(520, 60)
        Me.pnlTombol.TabIndex = 2
        '
        'btnOK - tombol OK biru tua membulat
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.BackColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.btnOK.CornerRadius = 8
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(386, 12)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(120, 36)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'FormPesan
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(220, 232, 248)
        Me.ClientSize = New System.Drawing.Size(520, 340)
        Me.Controls.Add(Me.pnlIsi)
        Me.Controls.Add(Me.pnlTombol)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPesan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pesan"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlIsi.ResumeLayout(False)
        Me.pnlPesan.ResumeLayout(False)
        Me.pnlPesan.PerformLayout()
        Me.pnlTombol.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblIkon As System.Windows.Forms.Label
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents pnlIsi As System.Windows.Forms.Panel
    Friend WithEvents pnlPesan As Global.Kasir_Warung.PanelBulat
    Friend WithEvents lblIkonBesar As System.Windows.Forms.Label
    Friend WithEvents lblPesan As System.Windows.Forms.Label
    Friend WithEvents pnlTombol As System.Windows.Forms.Panel
    Friend WithEvents btnOK As Global.Kasir_Warung.TombolBulat
    Friend WithEvents btnTidak As Global.Kasir_Warung.TombolBulat

End Class
