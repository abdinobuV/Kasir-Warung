# Tahap 2 - Desain FormKasir Sesuai Mockup (Tanpa Logika)

## 1. Yang sudah dibuat

| File | Isi |
|------|-----|
| `Kasir-Warung/FormKasir.vb` | Form utama: timer tanggal/jam real time (`PerbaruiTanggalJam`), `FormKasir_Load` set font ikon + perataan footer |
| `Kasir-Warung/FormKasir.Designer.vb` | Header, panel Data Barang / Daftar Belanja / Data Transaksi, tombol besar, footer (921 baris) |
| `Kasir-Warung/FormKasir.resx` | Rename dari `Form1.resx` |
| `Kasir-Warung/PanelBulat.vb` | Control kustom panel bersudut membulat (`GraphicsPath`, radius 12, garis tepi `178,200,232`) |
| `Kasir-Warung/TombolBulat.vb` | Control kustom tombol membulat: hover gelap otomatis, ikon di atas teks (`IkonTeks`, `UkuranIkon`, `WarnaHover`) |
| `Kasir-Warung/ModuleHelper.vb` | Tambahan: `NamaFontIkon` + `BuatFontIkon` (Segoe Fluent Icons / Segoe MDL2 Assets / Segoe UI Symbol) |
| `My Project/Application.Designer.vb`, `Application.myapp` | Startup form diatur ke `FormKasir` |
| `Form1.vb`, `Form1.Designer.vb` | Dihapus (diganti `FormKasir`) |

## 2. Desain Visual

| Elemen | Warna / Nilai |
|---|---|
| Header biru tua | `47,95,167` |
| Latar isi | `220,232,248` |
| Panel biru muda | `227,236,249` |
| Tombol utama (Proses) | Biru tua, ikon keranjang `ChrW(&HE7BF)` |
| Tombol Tambah | Hijau `46,166,46`, ikon `ChrW(&HE710)` |
| Tombol Batal / Hapus | Merah `223,58,53` |
| Font judul | Segoe UI 32 pt Bold |
| Font ikon | `BuatFontIkon()` — dipilih otomatis dari font terpasang di Windows ini |

## 3. Cara menjalankan

```powershell
dotnet run --project Kasir-Warung\Kasir-Warung.vbproj
```

## 4. Cara menguji Tahap 2

1. Form dibuka → tanggal & jam header tampil **real time** dari jam sistem (detak tiap 1 detik), format Indonesia (`Senin, 03 November 2025` / `14:25:17`).
2. Ikon (keranjang, kalender, jam, toko) tampil sebagai glyph, bukan kotak — font otomatis cocok dengan Windows 10/11.
3. Semua panel bersudut membulat, tombol besar membulat dengan efek hover.
4. Footer: `lblHati` rata kanan (jarak tetap dari tepi panel) dan `lblTerima` di kiri `lblHati`.
5. Resize form → layout tetap rapi (anchor/dock).

> Tahap 2 **tanpa logika**: tombol Cari/Tambah/Proses/Cetak belum berfungsi — baru ditambahkan di Tahap 3 dan 4.

## 5. Hasil build

```
Build succeeded.
    0 Warning(s)
    0 Error(s)
```
