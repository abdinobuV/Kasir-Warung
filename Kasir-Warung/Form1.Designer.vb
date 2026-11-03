<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.btnTesKoneksi = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblJudul.Location = New System.Drawing.Point(40, 40)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(340, 25)
        Me.lblJudul.TabIndex = 0
        Me.lblJudul.Text = "Tahap 1 - Tes Koneksi Database MySQL"
        '
        'btnTesKoneksi
        '
        Me.btnTesKoneksi.BackColor = System.Drawing.Color.FromArgb(47, 95, 167)
        Me.btnTesKoneksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTesKoneksi.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnTesKoneksi.ForeColor = System.Drawing.Color.White
        Me.btnTesKoneksi.Location = New System.Drawing.Point(45, 100)
        Me.btnTesKoneksi.Name = "btnTesKoneksi"
        Me.btnTesKoneksi.Size = New System.Drawing.Size(220, 45)
        Me.btnTesKoneksi.TabIndex = 1
        Me.btnTesKoneksi.Text = "Tes Koneksi Database"
        Me.btnTesKoneksi.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(220, 232, 248)
        Me.ClientSize = New System.Drawing.Size(480, 220)
        Me.Controls.Add(Me.btnTesKoneksi)
        Me.Controls.Add(Me.lblJudul)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tahap 1 - Tes Koneksi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents btnTesKoneksi As System.Windows.Forms.Button

End Class
