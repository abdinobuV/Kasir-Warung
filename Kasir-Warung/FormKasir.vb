''' <summary>
''' Form utama Kasir Minimarket.
''' Tahap 2: hanya tampilan + timer tanggal/jam.
''' Logika tombol (cari, tambah, proses, cetak) ditambahkan pada tahap berikutnya.
''' </summary>
Public Class FormKasir

    ''' <summary>
    ''' Mengisi label tanggal dan jam dari jam SISTEM (bukan contoh mockup),
    ''' memakai format budaya Indonesia (id-ID) lewat Module Helper.
    ''' </summary>
    Private Sub PerbaruiTanggalJam()
        lblTanggal.Text = FormatTanggalPanjang(DateTime.Now)  ' contoh: "Senin, 03 November 2025"
        lblJam.Text = FormatJam(DateTime.Now)                 ' contoh: "14:25:17"
    End Sub

    ' Timer berdetak tiap 1 detik sehingga jam di header selalu tampil real time
    Private Sub tmrJam_Tick(sender As Object, e As EventArgs) Handles tmrJam.Tick
        PerbaruiTanggalJam()
    End Sub

    Private Sub FormKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tampilkan tanggal/jam segera saat form dibuka (tanpa menunggu detik berikutnya)
        PerbaruiTanggalJam()

        ' Font ikon disesuaikan dengan font yang tersedia di Windows ini,
        ' supaya ikon tetap tampil walau dibuka di Windows 10 maupun 11.
        lblIkonKeranjang.Font = BuatFontIkon(46)
        lblIkonKalender.Font = BuatFontIkon(15)
        lblIkonJam.Font = BuatFontIkon(15)
        lblIkonToko.Font = BuatFontIkon(26)

        ' Rapikan teks kanan footer: jarak lblTerima ke lblHati dibuat tetap.
        ' Dilakukan di sini karena lebar teks AutoSize baru pasti setelah font terpasang.
        lblHati.Left = pnlFooter.ClientSize.Width - lblHati.Width - 18
        lblTerima.Left = lblHati.Left - lblTerima.Width - 12
    End Sub

End Class
