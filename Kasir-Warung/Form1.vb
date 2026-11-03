''' <summary>
''' Form sementara Tahap 1: hanya untuk membuktikan aplikasi bisa
''' terhubung ke database kasir_toko. Akan diganti FormKasir di Tahap 2.
''' </summary>
Public Class Form1

    Private Sub btnTesKoneksi_Click(sender As Object, e As EventArgs) Handles btnTesKoneksi.Click
        ' Panggil fungsi tes dari Module Koneksi
        Dim pesanError As String = ""
        If TesKoneksi(pesanError) Then
            MessageBox.Show(
                "Koneksi ke database kasir_toko BERHASIL." & vbCrLf & vbCrLf &
                "Laragon / MySQL berjalan normal.",
                "Tes Koneksi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)
        Else
            ' Tampilkan pesan error lengkap supaya mudah didiagnosis
            MessageBox.Show(
                "Koneksi GAGAL:" & vbCrLf & vbCrLf & pesanError,
                "Tes Koneksi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
        End If
    End Sub

End Class
