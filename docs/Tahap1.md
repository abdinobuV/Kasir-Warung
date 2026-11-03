# Tahap 1 - Project, Database, Module Koneksi & Helper

## 1. Yang sudah dibuat

| File | Isi |
|------|-----|
| `Kasir-Warung.vbproj` | `OptionStrict On`, `OptionInfer On`, paket **MySqlConnector 2.6.2**, target `net10.0-windows` |
| `ApplicationEvents.vb` | Event `ApplyApplicationDefaults`: `HighDpiMode = PerMonitorV2` (anti buram) + font default Segoe UI 10 pt |
| `database\kasir_toko.sql` | Skrip lengkap: `DROP DATABASE IF EXISTS` → 3 tabel InnoDB + CHECK + FK → 8 barang contoh |
| `ModuleKoneksi.vb` | Connection string bersama + `BuatKoneksi()` + `TesKoneksi()` |
| `ModuleHelper.vb` | `FormatRupiah`, `ParseRupiah`, `FormatTanggalPanjang`, `FormatJam` (semua `CultureInfo("id-ID")`) |
| `Form1.vb` + `Form1.Designer.vb` | Form sementara Tahap 1: tombol **Tes Koneksi** (diganti FormKasir di Tahap 2) |

## 2. Cara memasang paket MySqlConnector (sudah dilakukan)

```powershell
cd "D:\semester 3\PEMROGRAMAN VISUAL\Kasir-Warung\Kasir-Warung"
dotnet add package MySqlConnector
```

> Jangan pakai `MySql.Data` atau `System.Data.OleDb` — sudah usang / tidak cocok untuk MySQL modern.

## 3. Cara menjalankan skrip database (DBeaver)

1. Buka DBeaver → koneksi **Laragon MySQL** (localhost:3306, user `root`, password kosong).
2. Klik kanan koneksi → **SQL Editor** → **New SQL Script**.
3. Buka file `database\kasir_toko.sql`, salin **seluruh isinya** → paste di editor.
4. Tekan **Ctrl+X** (Execute script).
5. Verifikasi: `SELECT * FROM barang;` → harus muncul 8 baris.

> Skrip ini juga sudah saya uji jalankan langsung ke MySQL Laragon Anda — berhasil, 8 barang masuk.

## 4. Cara menguji Tahap 1

```powershell
cd "D:\semester 3\PEMROGRAMAN VISUAL\Kasir-Warung\Kasir-Warung"
dotnet build     # harus: Build succeeded, 0 Warning, 0 Error
dotnet run       # muncul form "Tahap 1 - Tes Koneksi"
```

Klik **Tes Koneksi Database**:

- **Hasil diharapkan:** kotak dialog `Koneksi ke database kasir_toko BERHASIL.`
- **Bukti lain:** fungsi tes dari kode .NET terbukti membaca `SELECT COUNT(*) FROM barang` = 8.

## 5. Penanganan error umum

| Pesan error | Penyebab | Solusi |
|---|---|---|
| `Unable to connect to any of the specified MySQL hosts` | Laragon belum jalan, atau port bukan 3306 | Buka Laragon → klik **Start All**. Cek port: `netstat -an \| findstr :3306` |
| `Access denied for user 'root'@'localhost'` | User/password salah | Di Laragon default: user `root`, password **kosong**. Cocokkan dengan `ModuleKoneksi.vb` |
| `Unknown database 'kasir_toko'` | Skrip SQL belum dijalankan | Jalankan `database\kasir_toko.sql` di DBeaver (langkah di atas) |
| `Public Key Retrieval is not allowed` (muncul di DBeaver) | MySQL 8 memakai caching_sha2_password | Di DBeaver: koneksi → **Connection Settings** → tab **Driver Properties** → set `allowPublicKeyRetrieval` = `true` |

## 6. Cuplikan kode kunci

**Connection string (ModuleKoneksi.vb):**
```vb
Public Const KoneksiString As String =
    "Server=localhost;Port=3306;Database=kasir_toko;User ID=root;Password=;AllowLoadLocalInfile=false;ConnectionTimeout=10"
```

**Format uang (ModuleHelper.vb):**
```vb
Public Function FormatRupiah(nilai As Decimal) As String
    Return "Rp" & nilai.ToString("N0", budaya)   ' budaya = CultureInfo("id-ID")
End Function
```

**High DPI (ApplicationEvents.vb):**
```vb
Private Sub MyApplication_ApplyApplicationDefaults(sender As Object, e As ApplyApplicationDefaultsEventArgs) Handles Me.ApplyApplicationDefaults
    e.HighDpiMode = HighDpiMode.PerMonitorV2
    e.Font = New Drawing.Font("Segoe UI", 10.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
End Sub
```
