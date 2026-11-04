# Tahap 4 - Proses Pembayaran (MySqlTransaction)

## 1. Yang sudah dibuat

| File | Isi |
|------|-----|
| `Kasir-Warung/FormKasir.vb` | `btnProses_Click` → `ProsesPembayaran()`: validasi keranjang kosong & bayar < total, nomor `TRX-yyyyMMdd-001`, `INSERT` transaksi + detail + `UPDATE` stok dalam **satu** `MySqlTransaction`, `Rollback` bila stok kurang, snapshot struk untuk Tahap 5, `btnCetak.Enabled = True` |
| `Kasir-Warung/FormPesan.vb` | Dialog pesan seragam pengganti `MessageBox` polos |
| `Kasir-Warung/FormPesan.Designer.vb` | Header biru tua `47,95,167`, latar `220,232,248`, panel biru muda `227,236,249`, `PanelBulat`, `TombolBulat` — mengikuti `FormCariBarang` |
| `Kasir-Warung/FormPesan.resx` | Resource dasar form |

## 2. Dialog FormPesan

Penggunaan seperti `MessageBox.Show`, tapi tampil seragam dengan program:

```vb
FormPesan.Tampilkan(Me, "Proses Pembayaran", pesan, FormPesan.JenisPesan.Sukses)
```

| `JenisPesan` | Warna Tombol OK | Dipakai untuk |
|---|---|---|
| `Informasi` | Biru tua `47,95,167` | Keranjang kosong |
| `Sukses` | Hijau `46,166,46` | Transaksi berhasil |
| `Peringatan` | Oranye `230,126,34` | Bayar kurang, stok kurang |
| `Kesalahan` | Merah `223,58,53` | `MySqlException`, error lain |

Diganti 6 `MessageBox.Show` di `ProsesPembayaran()`:
1. Keranjang kosong → Informasi
2. Bayar < total → Peringatan
3. Stok kurang (rollback) → Peringatan
4. `MySqlException` → Kesalahan
5. `Exception` → Kesalahan
6. Transaksi berhasil → Sukses

## 3. Cara menjalankan

```powershell
dotnet run --project Kasir-Warung\Kasir-Warung.vbproj
```

Prasyarat: Laragon sudah Start All, database `kasir_toko` sudah di-import dari `database\kasir_toko.sql`.

## 4. Cara menguji Tahap 4

1. **Keranjang kosong**: klik **Proses** tanpa isi keranjang → dialog Informasi, fokus kembali ke `txtKodeBarang`.
2. **Bayar kurang**: isi keranjang, isi `txtBayar` lebih kecil dari total → dialog Peringatan, fokus ke `txtBayar` (teks terseleksi).
3. **Stok kurang**: isi keranjang melebihi stok barang → dialog Peringatan, transaksi dibatalkan (stok tidak berubah, tidak ada baris baru di `transaksi`).
4. **Sukses**: isi keranjang, bayar >= total → dialog Sukses, `btnCetak` aktif, form dikosongkan untuk transaksi berikutnya.

Verifikasi database: cek `SELECT * FROM transaksi ORDER BY tanggal DESC;` dan `SELECT stok FROM barang WHERE kode_barang = 'B001';` (stok berkurang sesuai jumlah).

## 5. Hasil build

```
Build succeeded.
    0 Warning(s)
    0 Error(s)
```
