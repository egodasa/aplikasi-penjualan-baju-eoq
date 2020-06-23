<?php
	include_once "koneksi.php";
	include_once "helper.php";
?>
<html>
	<head>
		<meta charset="UTF-8">
        <title>Laporan Proses EOQ</title>
        <meta content='width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no' name='viewport'>
		<?php include_once "style_laporan.php"; ?>
	</head>
	<body>
		<?php include_once "header_laporan.php"; ?>

		<div style="text-align: center;"><h3>Laporan Proses EOQ</h3></div>
		<hr>
		<table>
			<tr>
				<th>No</th>
				<th>Kode EOQ</th>
				<th>Kode Barang</th>
				<th>Nama Barang</th>
				<th>Stock <br> Barang </th>
				<th>Biaya <br> Barang </th>
				<th>Biaya <br> Simpan </th>
				<th>Jumlah <br> Kebutuhan </th>
				<th>Jumlah <br> EOQ </th>
				<th>Frekuensi</th>
			</tr>
			<?php
				$no = 1;
				$sql_query = mysqli_query($koneksi, "SELECT eoq.*, barang.nama_barang, barang.stock FROM eoq JOIN barang ON eoq.kode_barang = barang.kode_barang");
				while($barang = mysqli_fetch_assoc($sql_query))
				{
			?>
				<tr>
					<td><?=$no?></td>
					<td><?=$barang['kode_eoq']?></td>
					<td><?=$barang['kode_barang']?></td>
					<td><?=$barang['nama_barang']?></td>
					<td><?=$barang['stock']?></td>
					<td><?=rupiah($barang['biaya_pesan'])?></td>
					<td><?=rupiah($barang['biaya_simpan'])?></td>
					<td><?=$barang['jml_kebutuhan']?></td>
					<td><?=$barang['jml_eoq']?></td>
					<td><?=$barang['frekuensi']?></td>
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