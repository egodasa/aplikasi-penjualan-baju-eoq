<?php
	include_once "koneksi.php";
	include_once "helper.php";
?>
<html>
	<head>
		<meta charset="UTF-8">
        <title>Laporan Barang</title>
        <meta content='width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no' name='viewport'>		<?php include_once "style_laporan.php"; ?>
	</head>
	<body>
		<?php include_once "header_laporan.php"; ?>

		<div style="text-align: center;"><h3>Laporan Data Barang</h3></div>
		<hr>
		<table>
			<tr>
				<th>No</th>
				<th>Kode Barang</th>
				<th>Nama Barang</th>
				<th>Satuan</th>
				<th>Harga</th>
				<th>Stock <br> Barang </th>
				<th>Biaya <br> Barang </th>
				<th>Biaya <br> Simpan </th>
				<th>Jumlah <br> Pesan </th>
				<th>Leadtime <br> Kebutuhan </th>
				<th>ROP <br> (Stock Min)</th>
			</tr>
			<?php
				$no = 1;
				$sql_query = mysqli_query($koneksi, "SELECT * FROM barang");
				while($barang = mysqli_fetch_assoc($sql_query))
				{
			?>
				<tr>
					<td><?=$no?></td>
					<td><?=$barang['kode_barang']?></td>
					<td><?=$barang['nama_barang']?></td>
					<td><?=$barang['satuan']?></td>
					<td><?=rupiah($barang['harga_barang'])?></td>
					<td><?=$barang['stock']?></td>
					<td><?=$barang['biaya_pesan']?></td>
					<td><?=$barang['biaya_simpan']?></td>
					<td><?=$barang['jml_kebutuhan']?></td>
					<td><?=$barang['leadtime']?></td>
					<td><?=$barang['stock_cadangan']?></td>
				</tr>
			<?php
					$no++;
				}
			?>
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