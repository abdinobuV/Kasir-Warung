Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

''' <summary>
''' Tombol bersudut membulat dengan efek hover dan ikon huruf
''' (Segoe Fluent Icons / Segoe MDL2 Assets) yang digambar di ATAS teks
''' sesuai mockup. Semua digambar sendiri lewat OnPaint sehingga
''' tidak membutuhkan file gambar eksternal.
''' </summary>
Public Class TombolBulat
    Inherits Button

    Private _cornerRadius As Integer = 10
    Private _warnaHover As Color = Color.Empty      ' kosong = warna dasar otomatis digelapkan
    Private _ikonTeks As String = ""                ' karakter ikon, mis. ChrW(&HE710) untuk tanda +
    Private _ukuranIkon As Single = 18.0F           ' ukuran ikon dalam point
    Private _fontIkon As Font = Nothing             ' dibuat sekali, tidak dibuat ulang tiap gambar
    Private _sedangHover As Boolean = False

    Public Sub New()
        ' Semua gambar dikerjakan sendiri supaya sudut membulat dan ikon bisa dikontrol
        SetStyle(ControlStyles.UserPaint Or
                 ControlStyles.AllPaintingInWmPaint Or
                 ControlStyles.OptimizedDoubleBuffer Or
                 ControlStyles.ResizeRedraw, True)

        FlatStyle = FlatStyle.Flat
        FlatAppearance.BorderSize = 0
        ForeColor = Color.White
        Cursor = Cursors.Hand
        TextAlign = ContentAlignment.MiddleCenter
    End Sub

    ''' <summary>Radius sudut membulat (pixel).</summary>
    <System.ComponentModel.DefaultValue(10)>
    Public Property CornerRadius As Integer
        Get
            Return _cornerRadius
        End Get
        Set(value As Integer)
            _cornerRadius = Math.Max(0, value)
            Invalidate()
        End Set
    End Property

    ''' <summary>Warna saat kursor berada di atas tombol. Kosongkan untuk otomatis (lebih gelap).</summary>
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)>
    Public Property WarnaHover As Color
        Get
            Return _warnaHover
        End Get
        Set(value As Color)
            _warnaHover = value
            Invalidate()
        End Set
    End Property

    ''' <summary>Karakter ikon dari font ikon, contoh: ChrW(&amp;HE710) = tanda +.</summary>
    <System.ComponentModel.DefaultValue("")>
    Public Property IkonTeks As String
        Get
            Return _ikonTeks
        End Get
        Set(value As String)
            _ikonTeks = If(value, "")
            Invalidate()
        End Set
    End Property

    ''' <summary>Ukuran ikon dalam point.</summary>
    <System.ComponentModel.DefaultValue(18.0F)>
    Public Property UkuranIkon As Single
        Get
            Return _ukuranIkon
        End Get
        Set(value As Single)
            _ukuranIkon = value
            ' Font ikon harus dibuat ulang karena ukurannya berubah
            If _fontIkon IsNot Nothing Then
                _fontIkon.Dispose()
                _fontIkon = Nothing
            End If
            Invalidate()
        End Set
    End Property

    ''' <summary>Font ikon dipakai bersama selama tombol hidup (lebih hemat).</summary>
    Private Function FontIkon() As Font
        If _fontIkon Is Nothing Then
            _fontIkon = BuatFontIkon(_ukuranIkon)
        End If
        Return _fontIkon
    End Function

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        _sedangHover = True
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        _sedangHover = False
        Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        ' Latar di luar sudut membulat harus warna induk, agar sudut terlihat "terpotong"
        Dim latarInduk As Color = If(Parent IsNot Nothing, Parent.BackColor, BackColor)
        g.Clear(latarInduk)

        ' Warna isi: nonaktif = pudar, hover = lebih gelap, normal = warna dasar
        Dim warnaIsi As Color = BackColor
        If Not Enabled Then
            warnaIsi = Gelapkan(BackColor, 0.7R)
        ElseIf _sedangHover Then
            warnaIsi = If(_warnaHover.IsEmpty, Gelapkan(BackColor, 0.85R), _warnaHover)
        End If

        Using jalur As GraphicsPath = PanelBulat.BuatJalurMembulat(Width, Height, CornerRadius)
            Using kuas As New SolidBrush(warnaIsi)
                g.FillPath(kuas, jalur)
            End Using

            ' Garis tepi 1px sedikit lebih gelap agar batas tombol tetap terlihat
            Using pensil As New Pen(Gelapkan(warnaIsi, 0.85R), 1.0F)
                g.DrawPath(pensil, jalur)
            End Using
        End Using

        Dim warnaTeks As Color = If(Enabled, ForeColor, Color.FromArgb(170, 170, 170))
        Dim adaIkon As Boolean = Not String.IsNullOrEmpty(_ikonTeks)

        ' ---------- Gambar ikon ----------
        If adaIkon Then
            Dim fIkon As Font = FontIkon()
            Dim ukuranGlyph As SizeF = g.MeasureString(_ikonTeks, fIkon)
            Dim kotakIkon As RectangleF

            If String.IsNullOrEmpty(Text) Then
                ' Tombol khusus ikon (mis. btnCari): ikon ditengahkan penuh
                kotakIkon = New RectangleF((Width - ukuranGlyph.Width) / 2.0F,
                                           (Height - ukuranGlyph.Height) / 2.0F,
                                           ukuranGlyph.Width,
                                           ukuranGlyph.Height)
            Else
                ' Sesuai mockup: ikon di bagian atas, teks di bagian bawah
                Dim yIkon As Single = (Height * 0.3F) - (ukuranGlyph.Height / 2.0F)
                kotakIkon = New RectangleF((Width - ukuranGlyph.Width) / 2.0F,
                                           yIkon,
                                           ukuranGlyph.Width,
                                           ukuranGlyph.Height)
            End If

            Using kuasIkon As New SolidBrush(warnaTeks)
                g.DrawString(_ikonTeks, fIkon, kuasIkon, kotakIkon)
            End Using
        End If

        ' ---------- Gambar teks ----------
        If Not String.IsNullOrEmpty(Text) Then
            Dim kotakTeks As Rectangle

            If adaIkon Then
                ' Teks memakai sisa ruang di bawah ikon (boleh 2 baris, mis. "Proses Pembayaran")
                Dim yTeks As Integer = CInt(Height * 0.5F)
                kotakTeks = New Rectangle(4, yTeks, Width - 8, Height - yTeks - 4)
            Else
                kotakTeks = New Rectangle(4, 4, Width - 8, Height - 8)
            End If

            Dim flags As TextFormatFlags = TextFormatFlags.HorizontalCenter Or
                                           TextFormatFlags.VerticalCenter Or
                                           TextFormatFlags.WordBreak

            TextRenderer.DrawText(g, Text, Font, kotakTeks, warnaTeks, flags)
        End If
    End Sub

    ''' <summary>Menggelapkan warna (faktor &lt; 1) untuk efek hover/tepi.</summary>
    Private Shared Function Gelapkan(warna As Color, faktor As Double) As Color
        Dim r As Integer = CInt(Math.Max(0, Math.Min(255, warna.R * faktor)))
        Dim g As Integer = CInt(Math.Max(0, Math.Min(255, warna.G * faktor)))
        Dim b As Integer = CInt(Math.Max(0, Math.Min(255, warna.B * faktor)))
        Return Color.FromArgb(r, g, b)
    End Function

    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso _fontIkon IsNot Nothing Then
                _fontIkon.Dispose()
                _fontIkon = Nothing
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

End Class
