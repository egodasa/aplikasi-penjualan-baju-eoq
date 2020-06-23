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
('B00001',	'Barang 1',	10000,	118,	100,	20,	20,	10,	20,	'Kg');

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


DROP TABLE IF EXISTS `supplier`;
CREATE TABLE `supplier` (
  `kode_supplier` varchar(20) NOT NULL,
  `nama_supplier` varchar(50) NOT NULL,
  `alamat` varchar(255) NOT NULL,
  `no_telp` varchar(15) NOT NULL,
  PRIMARY KEY (`kode_supplier`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `supplier` (`kode_supplier`, `nama_supplier`, `alamat`, `no_telp`) VALUES
('SP00001',	'Supplier 1',	'Alamat 1',	'08123341');

-- 2020-06-23 14:00:48
