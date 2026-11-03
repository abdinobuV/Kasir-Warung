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
    ''' Format jam 24 jam, contoh: "14:05:09"
    ''' </summary>
    Public Function FormatJam(tanggal As Date) As String
        Return tanggal.ToString("HH:mm:ss", budaya)
    End Function

End Module
