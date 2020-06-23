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
('B001',	'Lemari 2p Mahoni',	1900000,	5,	1200000,	500000,	70,	5,	3,	'Buah'),
('B002',	'Sofa Arwana mahoni',	7800000,	5,	5400000,	1500000,	20,	3,	4,	'Buah'),
('B003',	'Lemari 3p Jati',	4500000,	20,	3400000,	600000,	50,	4,	10,	'Buah'),
('B004',	'Sofa kayu aldelwis ',	5800000,	7,	3600000,	1400000,	30,	3,	3,	'Buah');

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
  CONSTRAINT `detail_pembelian_ibfk_3` FOREIGN KEY (`kode_barang`) REFERENCES `barang` (`kode_barang`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `detail_pembelian` (`id_detail`, `no_nota`, `kode_barang`, `harga_barang`, `sub_total`, `jumlah`) VALUES
(5,	'0101',	'B001',	2000,	12000,	2),
(6,	'0101',	'B001',	2000,	12000,	2),
(7,	'0101',	'B001',	2000,	12000,	2),
(8,	'0101',	'B001',	2000,	12000,	2),
(9,	'01010',	'B001',	111,	1111,	1),
(10,	'01010',	'B001',	111,	1111,	1),
(15,	'1012',	'B003',	2,	120,	1),
(17,	'1001',	'B003',	3600000,	1080000000,	30),
(18,	'1002',	'B004',	3600000,	720000000,	20),
(19,	'1003',	'B001',	1200000,	24000000,	20);

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
  CONSTRAINT `detail_penjualan_ibfk_3` FOREIGN KEY (`kode_barang`) REFERENCES `barang` (`kode_barang`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `detail_penjualan` (`id_detail`, `no_nota`, `kode_barang`, `harga_barang`, `sub_total`, `jumlah`) VALUES
(11,	'2306200208327259',	'B002',	7800000,	7800000,	1),
(12,	'2306200208327259',	'B003',	4500000,	9000000,	2),
(13,	'2306200209570345',	'B004',	5800000,	5800000,	1),
(14,	'2306200210326594',	'B002',	7800000,	7800000,	1),
(15,	'2306200211081925',	'B004',	5800000,	11600000,	2),
(16,	'2306200238503299',	'B003',	4500000,	4500000,	1),
(17,	'2306200239573587',	'B004',	5800000,	11600000,	2),
(18,	'2306200240326523',	'B002',	7800000,	15600000,	2),
(21,	'2306200242397563',	'B004',	5800000,	5800000,	1),
(22,	'2306200242397563',	'B001',	1900000,	1900000,	1);

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
  CONSTRAINT `eoq_ibfk_2` FOREIGN KEY (`kode_barang`) REFERENCES `barang` (`kode_barang`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `eoq` (`kode_eoq`, `kode_barang`, `biaya_pesan`, `biaya_simpan`, `jml_kebutuhan`, `jml_eoq`, `frekuensi`) VALUES
('E00001',	'B001',	1200000,	500000,	2,	547723,	15),
('E00002',	'B002',	5400000,	1500000,	1300,	3096,	120);

DROP TABLE IF EXISTS `pembelian`;
CREATE TABLE `pembelian` (
  `no_nota` varchar(50) NOT NULL,
  `tgl_beli` datetime NOT NULL,
  `total_harga` int(11) NOT NULL,
  `kode_supplier` varchar(20) NOT NULL,
  PRIMARY KEY (`no_nota`),
  KEY `kode_supplier` (`kode_supplier`),
  CONSTRAINT `pembelian_ibfk_2` FOREIGN KEY (`kode_supplier`) REFERENCES `supplier` (`kode_supplier`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `pembelian` (`no_nota`, `tgl_beli`, `total_harga`, `kode_supplier`) VALUES
('1001',	'2020-06-23 00:00:00',	1080000000,	'S002'),
('1002',	'2020-06-01 00:00:00',	720000000,	'S002'),
('1003',	'2020-06-23 00:00:00',	24000000,	'S003');

DROP TABLE IF EXISTS `pengguna`;
CREATE TABLE `pengguna` (
  `id_pengguna` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(20) NOT NULL,
  `password` varchar(255) NOT NULL,
  `level` enum('Karyawan','Pimpinan') NOT NULL,
  `nohp` varchar(15) NOT NULL,
  `alamat` varchar(255) NOT NULL,
  PRIMARY KEY (`id_pengguna`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `pengguna` (`id_pengguna`, `username`, `password`, `level`, `nohp`, `alamat`) VALUES
(1,	'karyawan',	'9e014682c94e0f2cc834bf7348bda428',	'Karyawan',	'',	''),
(2,	'pimpinan',	'90973652b88fe07d05a4304f0a945de8',	'Pimpinan',	'',	'');

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
('2306200208327259',	'2020-06-23 00:00:00',	'buk tika',	'customer',	16800000),
('2306200209570345',	'2020-06-23 00:00:00',	'pak dodi',	'customer',	5800000),
('2306200210326594',	'2020-06-23 00:00:00',	'bpk Jon ',	'customer',	7800000),
('2306200234268993',	'2020-06-09 00:00:00',	'pak saiful',	'customer',	0),
('2306200238503299',	'2020-06-05 00:00:00',	'bpk saiful',	'customer',	4500000),
('2306200239573587',	'2020-05-19 00:00:00',	'buk sati',	'customer',	11600000),
('2306200240326523',	'2020-04-20 00:00:00',	'pak anton',	'customer',	15600000),
('2306200242397563',	'2020-05-03 00:00:00',	'buk safitri',	'customer',	7700000);

DROP TABLE IF EXISTS `supplier`;
CREATE TABLE `supplier` (
  `kode_supplier` varchar(20) NOT NULL,
  `nama_supplier` varchar(50) NOT NULL,
  `alamat` varchar(255) NOT NULL,
  `no_telp` varchar(15) NOT NULL,
  PRIMARY KEY (`kode_supplier`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `supplier` (`kode_supplier`, `nama_supplier`, `alamat`, `no_telp`) VALUES
('S001',	'toko kurnia',	'Simpang tugu Siteba',	'081266838995'),
('S002',	'Toko Anugrah',	'jln.Ligoo pasar raya',	'087895458901'),
('S003',	'Okvanelti',	'Jln KP.Jua Lubuk Begalung ',	'081266879066');

-- 2020-06-23 14:34:26
