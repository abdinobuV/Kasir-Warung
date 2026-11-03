Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

''' <summary>
''' Panel dengan sudut membulat sesuai mockup.
''' Panel bawaan Windows Forms hanya persegi, jadi kelas ini menggambar ulang
''' latarnya memakai GraphicsPath. Dibuat terpisah dari form agar Designer
''' Visual Studio tetap bisa membuka FormKasir tanpa error.
''' </summary>
Public Class PanelBulat
    Inherits Panel

    ' Radius sudut dalam piksel
    Private _cornerRadius As Integer = 12

    ' Garis tepi tipis agar panel terlihat rapi di atas latar form
    Private _warnaGarisTepi As Color = Color.FromArgb(178, 200, 232)
    Private _tebalGarisTepi As Integer = 1

    Public Sub New()
        ' Double buffer + semua gambar digambar sendiri -> tidak berkedip saat di-resize
        SetStyle(ControlStyles.UserPaint Or
                 ControlStyles.AllPaintingInWmPaint Or
                 ControlStyles.OptimizedDoubleBuffer Or
                 ControlStyles.ResizeRedraw, True)

        ' Warna default = biru muda panel (#E3ECF9)
        BackColor = Color.FromArgb(227, 236, 249)
    End Sub

    ''' <summary>Radius sudut membulat (pixel). 0 = persegi biasa.</summary>
    <System.ComponentModel.DefaultValue(12)>
    Public Property CornerRadius As Integer
        Get
            Return _cornerRadius
        End Get
        Set(value As Integer)
            ' Dibatasi >= 0 karena radius negatif membuat GraphicsPath error
            _cornerRadius = Math.Max(0, value)
            Invalidate()
        End Set
    End Property

    ''' <summary>Warna garis tepi panel.</summary>
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)>
    Public Property WarnaGarisTepi As Color
        Get
            Return _warnaGarisTepi
        End Get
        Set(value As Color)
            _warnaGarisTepi = value
            Invalidate()
        End Set
    End Property

    ''' <summary>Tebal garis tepi panel (0 = tanpa garis).</summary>
    <System.ComponentModel.DefaultValue(1)>
    Public Property TebalGarisTepi As Integer
        Get
            Return _tebalGarisTepi
        End Get
        Set(value As Integer)
            _tebalGarisTepi = Math.Max(0, value)
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        ' Gambar isi panel membentuk persegi membulat
        Using jalur As GraphicsPath = BuatJalurMembulat(Width, Height, CornerRadius)
            Using kuas As New SolidBrush(BackColor)
                e.Graphics.FillPath(kuas, jalur)
            End Using

            If _tebalGarisTepi > 0 Then
                Using pensil As New Pen(_warnaGarisTepi, _tebalGarisTepi)
                    e.Graphics.DrawPath(pensil, jalur)
                End Using
            End If
        End Using
    End Sub

    ''' <summary>
    ''' Membuat jalur persegi bersudut membulat.
    ''' Public Shared agar dipakai bersama oleh PanelBulat dan TombolBulat,
    ''' sehingga bentuk sudut semua control konsisten.
    ''' </summary>
    Public Shared Function BuatJalurMembulat(lebar As Integer, tinggi As Integer, radius As Integer) As GraphicsPath
        Dim jalur As New GraphicsPath()

        ' Ukuran 0/minus bisa terjadi saat control belum di-layout, langsung amankan
        If lebar <= 0 OrElse tinggi <= 0 Then Return jalur

        ' Radius dibatasi setengah sisi terpendek agar lingkaran sudut tidak bertabrakan
        Dim r As Integer = Math.Min(radius, Math.Min(lebar, tinggi) \ 2)

        If r <= 0 Then
            jalur.AddRectangle(New Rectangle(0, 0, lebar, tinggi))
        Else
            Dim d As Integer = r * 2
            jalur.AddArc(0, 0, d, d, 180, 90)                     ' sudut kiri atas
            jalur.AddArc(lebar - d, 0, d, d, 270, 90)              ' sudut kanan atas
            jalur.AddArc(lebar - d, tinggi - d, d, d, 0, 90)       ' sudut kanan bawah
            jalur.AddArc(0, tinggi - d, d, d, 90, 90)              ' sudut kiri bawah
            jalur.CloseFigure()
        End If

        Return jalur
    End Function

End Class
