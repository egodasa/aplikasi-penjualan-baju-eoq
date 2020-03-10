<?php
	include_once "koneksi.php";
	include_once "helper.php";
?>
<html>
	<head>
		<meta charset="UTF-8">
        <title>Laporan Pembelian</title>
        <meta content='width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no' name='viewport'>		<?php include_once "style_laporan.php"; ?>
	</head>
	<body>
		<?php include_once "header_laporan.php"; ?>

		<div style="text-align: center;"><h3>Laporan Data Pembelian</h3></div>
		<hr>
		<table>
			<tr>
				<th>No</th>
				<th>No Nota</th>
				<th>Nama Supplier</th>
				<th>Nama Barang</th>
				<th>Tanggal Beli</th>
				<th>Jumlah Beli</th>
				<th>Total Harga</th>
			</tr>
			<?php
				$no = 1;
				$sql_query = mysqli_query($koneksi, "Select
    supplier.nama_supplier,
    pembelian.tgl_beli,
    detail_pembelian.sub_total,
    detail_pembelian.harga_barang,
    barang.nama_barang,
    detail_pembelian.jumlah,
    pembelian.no_nota
From
    barang Inner Join
    detail_pembelian On detail_pembelian.kode_barang = barang.kode_barang Inner Join
    pembelian On detail_pembelian.no_nota = pembelian.no_nota Inner Join
    supplier On pembelian.kode_supplier = supplier.kode_supplier ORDER BY pembelian.tgl_beli DESC");
				while($barang = mysqli_fetch_assoc($sql_query))
				{
			?>
				<tr>
					<td><?=$no?></td>
					<td><?=$barang['no_nota']?></td>
					<td><?=$barang['nama_supplier']?></td>
					<td><?=$barang['nama_barang']?></td>
					<td><?=tanggal_indo(barang['tgl_beli'])?></td>
					<td><?=$barang['jumlah']?></td>
					<td><?=rupiah($barang['sub_total'])?></td>
				</tr>
			<?php
					$no++;
				}
			?>
		</table>
		<hr>

		<div style="float: right;width: 300px;text-align: center;">
			<?=tanggal_indo(date("Y-m-d"), true)?> <br>
			Admin Ririn Busana
			<br>
			<br>
			<br>
			<br>
			(&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;)
		</div>

	</body>
</html>