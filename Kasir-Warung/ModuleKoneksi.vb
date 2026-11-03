Imports MySqlConnector
Imports System.Windows.Forms

''' <summary>
''' Module bersama untuk koneksi database MySQL.
''' Dipakai semua form supaya connection string hanya ada di satu tempat.
''' </summary>
Module ModuleKoneksi

    ' Connection string Laragon: user root, password kosong, port default 3306.
    ' Password kosong ditulis eksplisit (Password=) supaya jelas bukan lupa isi.
    Public Const KoneksiString As String =
        "Server=localhost;Port=3306;Database=kasir_toko;User ID=root;Password=;AllowLoadLocalInfile=false;ConnectionTimeout=10"

    ''' <summary>
    ''' Membuka koneksi baru. Selalu pakai Using di pemanggil supaya koneksi tertutup otomatis.
    ''' </summary>
    Public Function BuatKoneksi() As MySqlConnection
        Return New MySqlConnection(KoneksiString)
    End Function

    ''' <summary>
    ''' Tes koneksi ke MySQL. Mengembalikan True bila berhasil,
    ''' pesan error dikirim lewat parameter ByRef supaya bisa ditampilkan di MessageBox.
    ''' </summary>
    Public Function TesKoneksi(ByRef pesanError As String) As Boolean
        Try
            ' Using: koneksi ditutup otomatis walau terjadi error
            Using conn As MySqlConnection = BuatKoneksi()
                conn.Open() ' coba buka koneksi sungguhan
            End Using
            pesanError = ""
            Return True
        Catch ex As MySqlException
            ' MySqlException memuat kode error MySQL (1045, 1049, dll.)
            pesanError = ex.Message
            Return False
        Catch ex As Exception
            pesanError = ex.Message
            Return False
        End Try
    End Function

End Module
