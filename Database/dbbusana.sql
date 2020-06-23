-- Adminer 4.7.5 MySQL dump

SET NAMES utf8;
SET time_zone = '+00:00';
SET foreign_key_checks = 0;
SET sql_mode = 'NO_AUTO_VALUE_ON_ZERO';

DROP TABLE IF EXISTS `barang`;
CREATE TABLE `barang` (
  `kode_barang` varchar(20) NOT NULL,
  `nama_barang` varchar(100) NOT NULL,
  `harga_barang` int(11) NOT NULL,
  `stock` int(11) NOT NULL,
  `biaya_pesan` decimal(10,0) NOT NULL,
  `biaya_simpan` decimal(10,0) NOT NULL,
  `jml_kebutuhan` int(11) NOT NULL,
  `leadtime` decimal(10,0) NOT NULL,
  `stock_cadangan` int(11) NOT NULL,
  `satuan` varchar(10) NOT NULL,
  PRIMARY KEY (`kode_barang`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `barang` (`kode_barang`, `nama_barang`, `harga_barang`, `stock`, `biaya_pesan`, `biaya_simpan`, `jml_kebutuhan`, `leadtime`, `stock_cadangan`, `satuan`) VALUES
('B001',	'Barang 2',	98,	5,	100,	100,	20,	2,	2,	'Kg'),
('B003',	'Barang 3',	120000,	20,	10000,	10,	100,	1,	10,	'Pcs'),
('B004',	'Barang 4',	20000,	10,	20,	10,	120,	0,	10,	'Pcs');

DROP TABLE IF EXISTS `detail_pembelian`;
CREATE TABLE `detail_pembelian` (
  `id_detail` int(11) NOT NULL AUTO_INCREMENT,
  `no_nota` varchar(20) NOT NULL,
  `kode_barang` varchar(20) NOT NULL,
  `harga_barang` int(11) NOT NULL,
  `sub_total` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  PRIMARY KEY (`id_detail`),
  KEY `no_nota` (`no_nota`),
  KEY `kode_barang` (`kode_barang`),
  CONSTRAINT `detail_pembelian_ibfk_2` FOREIGN KEY (`kode_barang`) REFERENCES `barang` (`kode_barang`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `detail_pembelian` (`id_detail`, `no_nota`, `kode_barang`, `harga_barang`, `sub_total`, `jumlah`) VALUES
(5,	'0101',	'B001',	2000,	12000,	2),
(6,	'0101',	'B001',	2000,	12000,	2),
(7,	'0101',	'B001',	2000,	12000,	2),
(8,	'0101',	'B001',	2000,	12000,	2),
(9,	'01010',	'B001',	111,	1111,	1),
(10,	'01010',	'B001',	111,	1111,	1),
(11,	'1010',	'B001',	10000,	200000,	10),
(12,	'1010',	'B001',	2,	3,	1),
(13,	'1010',	'B004',	123,	312,	231),
(15,	'1012',	'B003',	2,	120,	1);

DROP TABLE IF EXISTS `detail_penjualan`;
CREATE TABLE `detail_penjualan` (
  `id_detail` int(11) NOT NULL AUTO_INCREMENT,
  `no_nota` varchar(20) NOT NULL,
  `kode_barang` varchar(20) NOT NULL,
  `harga_barang` int(11) NOT NULL,
  `sub_total` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  PRIMARY KEY (`id_detail`),
  KEY `no_nota` (`no_nota`),
  KEY `kode_barang` (`kode_barang`),
  CONSTRAINT `detail_penjualan_ibfk_2` FOREIGN KEY (`kode_barang`) REFERENCES `barang` (`kode_barang`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `detail_penjualan` (`id_detail`, `no_nota`, `kode_barang`, `harga_barang`, `sub_total`, `jumlah`) VALUES
(8,	'N000001',	'B001',	98,	196,	2),
(9,	'N000001',	'B003',	120000,	120000,	1),
(10,	'N000002',	'B003',	120000,	120000,	1);

DROP TABLE IF EXISTS `eoq`;
CREATE TABLE `eoq` (
  `kode_eoq` varchar(20) NOT NULL,
  `kode_barang` varchar(20) NOT NULL,
  `biaya_pesan` decimal(10,0) NOT NULL,
  `biaya_simpan` decimal(10,0) NOT NULL,
  `jml_kebutuhan` int(11) NOT NULL,
  `jml_eoq` decimal(10,0) NOT NULL,
  `frekuensi` decimal(10,0) NOT NULL,
  KEY `kode_barang` (`kode_barang`),
  CONSTRAINT `eoq_ibfk_1` FOREIGN KEY (`kode_barang`) REFERENCES `barang` (`kode_barang`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DROP TABLE IF EXISTS `pembelian`;
CREATE TABLE `pembelian` (
  `no_nota` varchar(50) NOT NULL,
  `tgl_beli` datetime NOT NULL,
  `total_harga` int(11) NOT NULL,
  `kode_supplier` varchar(20) NOT NULL,
  PRIMARY KEY (`no_nota`),
  KEY `kode_supplier` (`kode_supplier`),
  CONSTRAINT `pembelian_ibfk_1` FOREIGN KEY (`kode_supplier`) REFERENCES `supplier` (`kode_supplier`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `pembelian` (`no_nota`, `tgl_beli`, `total_harga`, `kode_supplier`) VALUES
('1010',	'2020-03-08 00:00:00',	200315,	'S001');

DROP TABLE IF EXISTS `pengguna`;
CREATE TABLE `pengguna` (
  `id_pengguna` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(20) NOT NULL,
  `password` varchar(255) NOT NULL,
  `level` enum('Karyawan','Pimpinan') NOT NULL,
  `nohp` varchar(15) NOT NULL,
  PRIMARY KEY (`id_pengguna`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `pengguna` (`id_pengguna`, `username`, `password`, `level`, `nohp`) VALUES
(1,	'karyawan',	'9e014682c94e0f2cc834bf7348bda428',	'Karyawan',	''),
(2,	'pimpinan',	'90973652b88fe07d05a4304f0a945de8',	'Pimpinan',	'');

DROP TABLE IF EXISTS `penjualan`;
CREATE TABLE `penjualan` (
  `no_nota` varchar(50) NOT NULL,
  `tgl_jual` datetime NOT NULL,
  `nm_pembeli` varchar(50) NOT NULL,
  `uraian_jual` varchar(100) NOT NULL,
  `total_harga` int(11) NOT NULL,
  PRIMARY KEY (`no_nota`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `penjualan` (`no_nota`, `tgl_jual`, `nm_pembeli`, `uraian_jual`, `total_harga`) VALUES
('N000001',	'2020-05-10 00:00:00',	'Pembeli 1',	'Pembelian pertama',	120196),
('N000002',	'2020-05-10 00:00:00',	'Pembeli 2',	'pembelian kedua',	120000);

DROP TABLE IF EXISTS `supplier`;
CREATE TABLE `supplier` (
  `kode_supplier` varchar(20) NOT NULL,
  `nama_supplier` varchar(50) NOT NULL,
  `alamat` varchar(255) NOT NULL,
  `no_telp` varchar(15) NOT NULL,
  PRIMARY KEY (`kode_supplier`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `supplier` (`kode_supplier`, `nama_supplier`, `alamat`, `no_telp`) VALUES
('S001',	'Supplier 1',	'Alamat 1',	'081266838995'),
('S002',	'Supplier 1',	'Alamat 1',	'0812345');

-- 2020-06-23 09:32:27
