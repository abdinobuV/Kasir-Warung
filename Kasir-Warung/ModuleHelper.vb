Imports System.Globalization

''' <summary>
''' Helper bersama: format uang dan tanggal memakai budaya Indonesia (id-ID).
''' Satu fungsi dipakai semua form supaya tampilan rapi dan konsisten.
''' </summary>
Module ModuleHelper

    ' CultureInfo tetap dibuat sekali, tidak dibuat ulang tiap dipanggil (lebih hemat)
    Private ReadOnly budaya As New CultureInfo("id-ID")

    ''' <summary>
    ''' Format angka menjadi Rupiah tanpa spasi, contoh: 3000 -> "Rp3.000"
    ''' </summary>
    Public Function FormatRupiah(nilai As Decimal) As String
        Return "Rp" & nilai.ToString("N0", budaya)
    End Function

    ''' <summary>
    ''' Ubah teks Rupiah kembali ke angka, contoh: "Rp3.000" -> 3000.
    ''' Teks kosong atau tidak valid dianggap 0 supaya tidak membuat error saat mengetik.
    ''' </summary>
    Public Function ParseRupiah(teks As String) As Decimal
        If String.IsNullOrWhiteSpace(teks) Then Return 0D

        ' Buang karakter yang bukan angka, koma desimal, atau tanda minus
        Dim bersih As String = teks.Replace("Rp", "").Replace(" ", "").Trim()
        Dim hasil As Decimal
        If Decimal.TryParse(bersih, NumberStyles.Number, budaya, hasil) Then
            Return hasil
        End If
        Return 0D
    End Function

    ''' <summary>
    ''' Format tanggal panjang Indonesia, contoh: "Senin, 03 November 2025"
    ''' </summary>
    Public Function FormatTanggalPanjang(tanggal As Date) As String
        Return tanggal.ToString("dddd, dd MMMM yyyy", budaya)
    End Function

    ''' <summary>
    ''' Format jam 24 jam, contoh: "14:05:09".
    ''' Tanda ":" di tengah format = pemisah jam budaya (id-ID memakai titik, jadi "15.30"),
    ''' di-escape dengan supaya tetap tampil titik dua seperti mockup.
    ''' </summary>
    Public Function FormatJam(tanggal As Date) As String
        Return tanggal.ToString("HH\:mm\:ss", budaya)
    End Function

    ''' <summary>
    ''' Nama font ikon yang tersedia di Windows ini.
    ''' Windows 11 memakai "Segoe Fluent Icons", Windows 10 memakai "Segoe MDL2 Assets".
    ''' Dicari sekali lalu disimpan (Static) supaya tidak mengecek berulang-ulang.
    ''' </summary>
    Public Function NamaFontIkon() As String
        Static namaTerpilih As String = Nothing

        If namaTerpilih Is Nothing Then
            ' New Font() tidak error walau font tidak ada (diam-diam memakai font lain,
            ' akibatnya ikon jadi kotak), jadi harus dicek ke daftar font terpasang.
            Dim daftarCoba As String() = {"Segoe Fluent Icons", "Segoe MDL2 Assets", "Segoe UI Symbol"}

            For Each nama As String In daftarCoba
                For Each ff As FontFamily In FontFamily.Families
                    If ff.Name = nama Then
                        namaTerpilih = nama
                        Exit For
                    End If
                Next
                If namaTerpilih IsNot Nothing Then Exit For
            Next

            ' Cadangan terakhir: tetap pakai Segoe UI agar program tidak error
            If namaTerpilih Is Nothing Then namaTerpilih = "Segoe UI"
        End If

        Return namaTerpilih
    End Function

    ''' <summary>
    ''' Membuat font ikon dengan ukuran (point) tertentu, misalnya BuatFontIkon(24).
    ''' </summary>
    Public Function BuatFontIkon(ukuran As Single) As Font
        Return New Font(NamaFontIkon(), ukuran, FontStyle.Regular, GraphicsUnit.Point)
    End Function

End Module
