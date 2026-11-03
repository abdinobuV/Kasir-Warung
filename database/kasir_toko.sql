-- =============================================================
-- Database : kasir_toko  (tugas Pemrograman Visual - Kasir Minimarket)
-- Jalankan : buka DBeaver > New SQL Script > paste seluruh file > Ctrl+X
-- =============================================================

DROP DATABASE IF EXISTS kasir_toko;

CREATE DATABASE kasir_toko
    DEFAULT CHARACTER SET utf8mb4
    DEFAULT COLLATE utf8mb4_unicode_ci;

USE kasir_toko;

-- -------------------------------------------------------------
-- Tabel barang (master produk minimarket)
-- -------------------------------------------------------------
CREATE TABLE barang (
    kode_barang  VARCHAR(10)   NOT NULL,
    nama_barang  VARCHAR(100)  NOT NULL,
    harga        DECIMAL(12,2) NOT NULL,
    stok         INT           NOT NULL,
    PRIMARY KEY (kode_barang),
    -- CHECK menjaga data tetap masuk akal: harga/stok tidak boleh negatif
    CONSTRAINT chk_harga CHECK (harga >= 0),
    CONSTRAINT chk_stok  CHECK (stok  >= 0)
) ENGINE = InnoDB;

-- -------------------------------------------------------------
-- Tabel transaksi (kepala transaksi penjualan)
-- -------------------------------------------------------------
CREATE TABLE transaksi (
    no_transaksi VARCHAR(20)   NOT NULL,
    tanggal      DATETIME      NOT NULL,
    total        DECIMAL(12,2) NOT NULL,
    bayar        DECIMAL(12,2) NOT NULL,
    kembali      DECIMAL(12,2) NOT NULL,
    PRIMARY KEY (no_transaksi)
) ENGINE = InnoDB;

-- -------------------------------------------------------------
-- Tabel detail_transaksi (item di dalam satu transaksi)
-- -------------------------------------------------------------
CREATE TABLE detail_transaksi (
    id            INT           NOT NULL AUTO_INCREMENT,
    no_transaksi  VARCHAR(20)   NOT NULL,
    kode_barang   VARCHAR(10)   NOT NULL,
    jumlah        INT           NOT NULL,
    harga_satuan  DECIMAL(12,2) NOT NULL,
    subtotal      DECIMAL(12,2) NOT NULL,
    PRIMARY KEY (id),
    CONSTRAINT fk_detail_transaksi FOREIGN KEY (no_transaksi)
        REFERENCES transaksi (no_transaksi) ON DELETE CASCADE,
    CONSTRAINT fk_detail_barang FOREIGN KEY (kode_barang)
        REFERENCES barang (kode_barang) ON DELETE RESTRICT,
    CONSTRAINT chk_jumlah CHECK (jumlah > 0)
) ENGINE = InnoDB;

-- -------------------------------------------------------------
-- Data contoh: 8 barang.
-- Tiga barang pertama harga & nama sesuai mockup FormKasir.
-- -------------------------------------------------------------
INSERT INTO barang (kode_barang, nama_barang, harga, stok) VALUES
    ('B001', 'Aqua 600ml',        3000.00,  40),
    ('B002', 'Indomie Goreng',    3000.00, 120),
    ('B003', 'Snack Taro',        2000.00,  60),
    ('B004', 'Teh Pucuk 350ml',   4000.00,  80),
    ('B005', 'Chitato 68g',      10500.00,  35),
    ('B006', 'Mizone 500ml',      6000.00,  50),
    ('B007', 'Kopi Kapal Api',    3500.00, 100),
    ('B008', 'Baterai AA (2 pcs)',9000.00,  20);

-- Selesai. Cek dengan: SELECT * FROM barang;
