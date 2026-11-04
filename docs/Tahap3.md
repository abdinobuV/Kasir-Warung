# Tahap 3 - FormCariBarang dan Logika Keranjang FormKasir

## 1. Yang sudah dibuat

| File | Isi |
|------|-----|
| `Kasir-Warung/FormCariBarang.vb` | Dialog cari barang: recordset `DataTable` + `MySqlDataAdapter` + `BindingSource`, filter `BindingSource.Filter`, navigasi `MoveFirst/MovePrevious/MoveNext/MoveLast`, pilih via klik ganda/Enter/tombol Pilih |
| `Kasir-Warung/FormCariBarang.Designer.vb` | Header biru tua, kotak cari, grid `dgvBarang`, panel navigasi + tombol Pilih (hijau `46,166,46`) / Batal (merah `223,58,53`) |
| `Kasir-Warung/FormCariBarang.resx` | Resource form |
| `Kasir-Warung/FormKasir.vb` | Logika keranjang: cari kode (Enter/tombol), tambah dengan gabung baris sama + validasi stok, edit dua langkah (`btnEdit` → `SimpanEdit`), hapus + nomor urut ulang, bersih dengan konfirmasi, total & kembalian, format ribuan `txtBayar` |
| `Kasir-Warung/ModuleHelper.vb` | `BudayaId()` untuk `DefaultCellStyle.FormatProvider` grid (Rupiah id-ID) |

## 2. Fungsi Kunci FormKasir

| Fungsi | Keterangan |
|---|---|
| `AmbilBarang(kode)` | `SELECT ... WHERE kode_barang = @kode` (parameter, aman SQL injection) |
| `CariBarang()` | Enter di `txtKodeBarang` / klik `btnCari` → tampilkan nama/harga + fokus ke jumlah |
| `TambahKeKeranjang()` | Gabung baris kode sama, cek `JumlahDiKeranjang + jumlah > stok` → peringatan |
| `btnEdit_Click` → `SimpanEdit()` | Edit dua langkah: klik sekali untuk memuat ke input, klik lagi untuk simpan |
| `btnHapus_Click` | Hapus baris terpilih + `PerbaruiNomor()` |
| `btnBersih_Click` | Konfirmasi, lalu kosongkan keranjang |
| `HitungTotal()` / `HitungKembalian()` | Total = jumlah subtotal; kembalian = bayar − total |
| `txtBayar_TextChanged` | Format ribuan saat mengetik (flag `sedangFormatBayar` cegah loop) |

## 3. Cara menjalankan

```powershell
dotnet run --project Kasir-Warung\Kasir-Warung.vbproj
```

Prasyarat: Laragon sudah Start All, database `kasir_toko` sudah di-import dari `database\kasir_toko.sql`.

## 4. Cara menguji Tahap 3

1. **Cari kode**: ketik kode barang (mis. `B001`) lalu Enter → nama/harga terisi, fokus pindah ke jumlah.
2. **Tombol Cari**: klik **Cari** → `FormCariBarang` terbuka; ketik kata kunci (tersaring langsung), navigasi `|<=`, `<=`, `>=`, `>|` aktif sesuai posisi, klik ganda/Enter/**Pilih** → kode kembali ke `FormKasir`.
3. **Tambah**: isi jumlah lalu **Tambah** → baris masuk `dgvBelanja`; tambah kode sama lagi → baris lama ditambah, bukan baris baru.
4. **Validasi stok**: tambah melebihi stok → `Stok tidak cukup` (tampil stok tersedia, sudah di keranjang, diminta).
5. **Edit**: pilih baris → **Edit** (baris teruat ke input) → ubah jumlah → **Edit** lagi → tersimpan.
6. **Hapus / Bersih**: hapus baris terpilih; **Bersih** meminta konfirmasi lalu mengosongkan.
7. **Total & bayar**: total terhitung otomatis; ketik `txtBayar` → format ribuan, kembalian terhitung live.

## 5. Hasil build

```
Build succeeded.
    0 Warning(s)
    0 Error(s)
```
