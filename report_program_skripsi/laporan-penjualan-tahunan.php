<?php
	include_once "koneksi.php";
	include_once "helper.php";
	$tanggal = $_GET['tgl'];
?>
<html>
	<head>
		<meta charset="UTF-8">
        <title>Laporan Penjualan Tahunan</title>
        <meta content='width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no' name='viewport'>		<?php include_once "style_laporan.php"; ?>
	</head>
	<body>
		<?php include_once "header_laporan.php"; ?>

		<div style="text-align: center;">
		<h3>
			Laporan Penjualan Tahunan 
			<br>
			Tahun : <?=$tanggal?>
		</h3>
		</div>
		<hr>
		<table>
			<tr>
				<th>No</th>
				<th>No Nota</th>
				<th>Kode Barang</th>
				<th>Nama Barang</th>
				<th>Bulan</th>
				<th>Harga Jual</th>
				<th>Jumlah Jual</th>
			</tr>
			<?php
				$total = 0;
				$no = 1;
				$sql_query = mysqli_query($koneksi, "Select
    penjualan.no_nota,
    detail_penjualan.kode_barang,
    detail_penjualan.harga_barang,
	MONTH(penjualan.tgl_jual) AS bulan,
    detail_penjualan.sub_total,
    detail_penjualan.jumlah,
    barang.nama_barang
From
    barang Inner Join
    detail_penjualan On detail_penjualan.kode_barang = barang.kode_barang Inner Join
    penjualan On detail_penjualan.no_nota = penjualan.no_nota 
	WHERE LEFT(penjualan.tgl_jual, 4) = '$tanggal' ORDER BY penjualan.tgl_jual ASC");
				while($barang = mysqli_fetch_assoc($sql_query))
				{
					$total += $barang['sub_total'];
			?>
				<tr>
					<td><?=$no?></td>
					<td><?=$barang['no_nota']?></td>
					<td><?=$barang['kode_barang']?></td>
					<td><?=$barang['nama_barang']?></td>
					<td><?=namaBulan($barang['bulan'])?></td>
					<td><?=rupiah($barang['harga_barang'])?></td>
					<td><?=$barang['jumlah']?></td>
				</tr>
			<?php
					$no++;
				}
			?>
				<tr>
					<td colspan="4">Total Penjualan</td>
					<td colspan="2"><?=rupiah($total)?></td>
				</tr>
		</table>
		<hr>

		<div style="float: right;width: 300px;text-align: center;">
			<?=tanggal_indo(date("Y-m-d"), true)?> <br>
			Pimpinan
			<br>
			<br>
			<br>
			<br>
			(&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;)
		</div>

	</body>
</html>