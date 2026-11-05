# Tahap 6 - Form Pendukung: Kelola Barang (F2) & Riwayat (F3)

## 1. Yang sudah dibuat

| File | Isi |
|------|-----|
| `Kasir-Warung/FormDataBarang.vb` | CRUD master barang: DataTable + BindingSource, navigasi record (MoveFirst/Previous/Next/Last), label jumlah record, pencarian (BindingSource.Filter), validasi kode tidak kembar, harga/stok angka >= 0, tangkap error FK 1451 saat menghapus barang yang sudah terjual |
| `Kasir-Warung/FormDataBarang.Designer.vb` | Header biru tua, panel cari, grid, panel input (Kode/Nama/Harga/Stok + Tambah/Ubah/Hapus), footer navigasi |
| `Kasir-Warung/FormRiwayat.vb` | Master-detail: grid `transaksi` (filter rentang tanggal, total pendapatan), grid detail item transaksi terpilih (JOIN detail_transaksi + barang) |
| `Kasir-Warung/FormRiwayat.Designer.vb` | Header biru tua, panel filter tanggal, panel master, panel detail, footer |
| `Kasir-Warung/FormKasir.vb` | Shortcut keyboard `KeyPreview` (sudah aktif): **F2** = FormDataBarang, **F3** = FormRiwayat |

Gaya visual kedua form mengikuti tema biru FormKasir: header `47,95,167`, latar `220,232,248`, panel `227,236,249`, `PanelBulat`, `TombolBulat`.

FormDataBarang kini ClientSize 880×786 dan FormRiwayat 1000×710 agar semua kontrol terlihat.
Judul panel master/detail kini menempati alokasi sendiri (Padding atas) dan tidak menutupi header kolom grid; kolom grid bisa di-resize dan header tinggi auto-fit DPI sehingga tidak ada tulisan terpotong di layar apa pun.
Panel input `pnlInput` diperlebar dari 118 → 154px supaya tombol Tambah/Ubah/Hapus tidak keluar dari panel (Hapus kini terlihat full, tidak terpotong).

## 2. FormDataBarang (F2)

- **Recordset**: `DataTable` + `MySqlDataAdapter` + `BindingSource` — `PositionChanged` menyinkronkan textbox saat navigasi.
- **Navigasi**: tombol Pertama/Sebelumnya/Berikutnya/Terakhir memakai `MoveFirst/MovePrevious/MoveNext/MoveLast`, aktif/nonaktif mengikuti posisi record.
- **Jumlah record**: `bsBarang.Count` di label kanan.
- **Pencarian**: `BindingSource.Filter` pada kode/nama (di memori, tidak ke SQL).
- **Validasi**:
  - Kode & nama tidak boleh kosong.
  - Kode tidak boleh kembar (cek `SELECT COUNT(*)` + tangkap error duplikat 1062).
  - Harga & stok angka >= 0.
  - Kode barang tidak bisa diubah (kunci utama).
  - Hapus barang yang sudah terjual → pesan ramah dari error FK 1451 (`ON DELETE RESTRICT`).

## 3. FormRiwayat (F3)

- **Master**: `SELECT no_transaksi, tanggal, total, bayar, kembali FROM transaksi WHERE tanggal BETWEEN @dari AND @sampai ORDER BY tanggal DESC` — filter rentang tanggal via `DateTimePicker` (parameter `@dari`, `@sampai`).
- **Total pendapatan**: jumlah kolom `total` pada recordset yang tampil.
- **Detail**: `SELECT ... FROM detail_transaksi d JOIN barang b ON b.kode_barang = d.kode_barang WHERE d.no_transaksi = @no ORDER BY d.id` — nomor urut dihitung sendiri dari 1.
- **Master-detail**: `PositionChanged` pada BindingSource master otomatis memuat ulang grid detail.

## 4. Cara menjalankan

```powershell
dotnet run --project Kasir-Warung\Kasir-Warung.vbproj
```

Prasyarat: Laragon sudah Start All, database `kasir_toko` sudah di-import dari `database\kasir_toko.sql`.

## 5. Cara menguji Tahap 6

### F2 - Kelola Barang
1. Di FormKasir tekan **F2**. Pastikan grid menampilkan 8 barang contoh, label jumlah record benar.
2. Tombol **Pertama/Sebelumnya/Berikutnya/Terakhir**: posisi berubah, textbox input ikut berubah, tombol nonaktif di ujung.
3. Ketik kata di kotak cari: grid tersaring, jumlah record berkurang.
4. **Tambah**: isi Kode `B009`, Nama `Teh Botol 350ml`, Harga `4500`, Stok `50` → klik Tambah → muncul di grid.
5. **Tambah kode kembar**: pakai `B001` lagi → pesan *Kode barang sudah ada*.
6. **Ubah**: pilih baris, ubah Harga/Stok, klik Ubah → tersimpan (kode tidak bisa diubah).
7. **Hapus**: hapus barang baru (belum terjual) → berhasil; coba hapus barang yang sudah terjual → pesan ramah FK.

### F3 - Riwayat
1. Lakukan transaksi dulu di FormKasir, lalu tekan **F3**.
2. Pilih rentang tanggal hari ini → transaksi tampil, total pendapatan benar.
3. Klik baris transaksi → grid detail menampilkan itemnya (nama, jumlah × harga, subtotal).
4. Geser posisi dengan tombol navigasi di grid master / klik baris lain → detail berubah mengikuti.

## 6. Hasil build

```
Build succeeded.
    0 Warning(s)
    0 Error(s)
```
