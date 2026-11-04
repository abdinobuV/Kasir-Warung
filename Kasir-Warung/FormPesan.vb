''' <summary>
''' Dialog pesan seragam pengganti MessageBox polos (Tahap 4-fix).
''' Desain mengikuti FormCariBarang: header biru tua 47,95,167,
''' latar 220,232,248, panel biru muda 227,236,249, TombolBulat.
''' </summary>
Public Class FormPesan

    Public Enum JenisPesan
        Informasi = 0
        Sukses = 1
        Peringatan = 2
        Kesalahan = 3
    End Enum

    Private _judul As String = "Pesan"
    Private _pesan As String = ""
    Private _jenis As JenisPesan = JenisPesan.Informasi
    Private _konfirmasi As Boolean = False

    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property Judul As String
        Get
            Return _judul
        End Get
        Set(value As String)
            _judul = If(value, "Pesan")
        End Set
    End Property

    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property IsiPesan As String
        Get
            Return _pesan
        End Get
        Set(value As String)
            _pesan = If(value, "")
        End Set
    End Property

    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property Jenis As JenisPesan
        Get
            Return _jenis
        End Get
        Set(value As JenisPesan)
            _jenis = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(judul As String, pesan As String, jenis As JenisPesan)
        InitializeComponent()
        _judul = If(judul, "Pesan")
        _pesan = If(pesan, "")
        _jenis = jenis
    End Sub

    ''' <summary>
    ''' Dialog konfirmasi Yes/No, dipakai misalnya tombol Keluar.
    ''' </summary>
    Public Sub New(judul As String, pesan As String, konfirmasi As Boolean)
        InitializeComponent()
        _judul = If(judul, "Pesan")
        _pesan = If(pesan, "")
        _konfirmasi = konfirmasi

        If konfirmasi Then
            _jenis = JenisPesan.Peringatan
        Else
            _jenis = JenisPesan.Informasi
        End If
    End Sub

    ''' <summary>
    ''' Menampilkan dialog pesan secara modal seperti MessageBox.Show.
    ''' </summary>
    Public Shared Function Tampilkan(owner As Form, judul As String,
                                     pesan As String, jenis As JenisPesan) As DialogResult
        Using dlg As New FormPesan(judul, pesan, jenis)
            Return dlg.ShowDialog(owner)
        End Using
    End Function

    Private Sub FormPesan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = _judul
        lblJudul.Text = _judul
        lblPesan.Text = _pesan
        lblIkon.Font = BuatFontIkon(18)
        lblIkon.Text = IkonUntukJenis(_jenis)
        lblIkonBesar.Font = BuatFontIkon(36)
        lblIkonBesar.Text = IkonUntukJenis(_jenis)
        btnOK.BackColor = WarnaUntukJenis(_jenis)

        If _konfirmasi Then
            ' Bentuk tombol jadi Yes/No (Yes = warna jenis pesan, No = biru tua)
            ' No selalu di KANAN dan Yes di kiri, ukuran sama besar.
            btnOK.Text = "Yes"
            btnOK.DialogResult = DialogResult.Yes
            btnOK.Size = New Size(120, 36)
            btnOK.Location = New Point(252, 12)
            btnTidak = New TombolBulat()
            btnTidak.Anchor = CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles)
            btnTidak.BackColor = Color.FromArgb(47, 95, 167)
            btnTidak.CornerRadius = 8
            btnTidak.DialogResult = DialogResult.No
            btnTidak.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            btnTidak.ForeColor = Color.White
            btnTidak.Location = New Point(386, 12)
            btnTidak.Name = "btnTidak"
            btnTidak.Size = New Size(120, 36)
            btnTidak.TabIndex = 1
            btnTidak.Text = "No"
            btnTidak.UseVisualStyleBackColor = False
            pnlTombol.Controls.Add(btnTidak)
        End If
    End Sub

    Private Shared Function IkonUntukJenis(jenis As JenisPesan) As String
        Select Case jenis
            Case JenisPesan.Sukses
                Return ChrW(&HE73E)
            Case JenisPesan.Peringatan
                Return ChrW(&HE7BA)
            Case JenisPesan.Kesalahan
                Return ChrW(&HE8F6)
            Case Else
                Return ChrW(&HE8F1)
        End Select
    End Function

    Private Shared Function WarnaUntukJenis(jenis As JenisPesan) As Color
        Select Case jenis
            Case JenisPesan.Sukses
                Return Color.FromArgb(46, 166, 46)
            Case JenisPesan.Peringatan
                Return Color.FromArgb(230, 126, 34)
            Case JenisPesan.Kesalahan
                Return Color.FromArgb(223, 58, 53)
            Case Else
                Return Color.FromArgb(47, 95, 167)
        End Select
    End Function

End Class
