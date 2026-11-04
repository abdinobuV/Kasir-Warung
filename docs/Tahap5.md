# Tahap 5 - Cetak Struk (PrintDocument)

## 1. Yang sudah dibuat

| File | Isi |
|------|-----|
| `Kasir-Warung/FormKasir.vb` | `btnCetak_Click` → `PrintPreviewDialog` memakai snapshot Tahap 4 (`noTransaksiTerakhir`, `tanggalTransaksiTerakhir`, `itemsTerakhir`, `totalTerakhir`, `bayarTerakhir`, `kembaliTerakhir`); `Struk_PrintPage` menggambar struk dengan font monospace `Courier New`; `SiapkanCetak()` dipanggil di `FormKasir_Load` |
| `Kasir-Warung/FormKasir.vb` | `tmrJam.Enabled = True` di `FormKasir_Load` — jam/tanggal header sekarang berjalan tiap detik |
| `Kasir-Warung/FormKasir.vb` | `btnKeluar_Click` memakai `FormPesan` seragam (Ya/Tidak judul *Keluar*) pengganti `MessageBox` polos |
| `Kasir-Warung/FormPesan.vb` | Konstruktor konfirmasi (`Yes/No`) + `btnTidak` dinamis; ikon & warna mengikuti `JenisPesan` |
| `Kasir-Warung/FormPesan.Designer.vb` | Deklarasi `btnTidak` |

## 2. Isi struk

Sesuai instruksi, struk terdiri dari:

- Nama toko **Minimarket Sejahtera** + **Belanja Mudah, Harga Bersahabat**
- Nomor dan tanggal transaksi (format `id-ID`)
- Daftar item: nama, jumlah x harga, subtotal (format Rupiah)
- Total, Bayar, Kembali
- **Terima Kasih atas Kunjungan Anda**

Kertas: sempit `300 x 800` (`PaperSize "Struk"`), orientasi tegak, margin 30.
Font: `Courier New` supaya kolom sejajar seperti struk toko beneran.

## 3. Perilaku tombol

- `btnCetak` tetap nonaktif sampai ada transaksi sukses (dari Tahap 4, `ProsesPembayaran()` set `Enabled = True`).
- Jika dipanggil tanpa transaksi sukses → dialog Informasi *Belum ada transaksi untuk dicetak.*
- Klik **Cetak Struk** → `PrintPreviewDialog` tampil; pengguna bisa cek tampilan, lalu Print dari dialog tersebut.

## 4. Cara menjalankan

```powershell
dotnet run --project Kasir-Warung\Kasir-Warung.vbproj
```

Prasyarat: Laragon sudah Start All, database `kasir_toko` sudah di-import dari `database\kasir_toko.sql`.

## 5. Cara menguji Tahap 5

1. Jalankan aplikasi, pastikan jam di header berjalan.
2. Masukkan barang, klik **Proses Pembayaran** → `btnCetak` aktif.
3. Klik **Cetak Struk** → jendela pratinjau tampil; pastikan struk berisi nama toko, nomor, tanggal, semua item, total/bayar/kembali, dan ucapan terima kasih.
4. (Opsional) klik ikon Print di pratinjau → printer tercetak; atau pilih *Print to Microsoft Print to PDF* untuk simpan PDF.
5. Klik **Keluar** → dialog seragam *Tutup aplikasi Kasir Minimarket?* dengan tombol **Yes/No**; **Yes** menutup aplikasi, **No** batal.

## 6. Hasil build

```
Build succeeded.
    0 Warning(s)
    0 Error(s)
```
