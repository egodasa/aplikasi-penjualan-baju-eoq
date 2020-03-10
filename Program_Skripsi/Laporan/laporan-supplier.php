<?php
	include_once "koneksi.php";
	include_once "helper.php";
?>
<html>
	<head>
		<meta charset="UTF-8">
        <title>Laporan Supplier</title>
        <meta content='width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no' name='viewport'>		<?php include_once "style_laporan.php"; ?>
	</head>
	<body>
		<?php include_once "header_laporan.php"; ?>

		<div style="text-align: center;"><h3>Laporan Data Supplier</h3></div>
		<hr>
		<table>
			<tr>
				<th>No</th>
				<th>Kode Supplier</th>
				<th>Nama Supplier</th>
				<th>Alamat</th>
				<th>No Telephone</th>
			</tr>
			<?php
				$no = 1;
				$sql_query = mysqli_query($koneksi, "SELECT * FROM supplier");
				while($barang = mysqli_fetch_assoc($sql_query))
				{
			?>
				<tr>
					<td><?=$no?></td>
					<td><?=$barang['kode_supplier']?></td>
					<td><?=$barang['nama_supplier']?></td>
					<td><?=$barang['alamat']?></td>
					<td><?=$barang['no_telp']?></td>
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