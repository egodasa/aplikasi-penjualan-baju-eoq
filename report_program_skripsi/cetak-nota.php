<?php
	include_once "koneksi.php";
	include_once "helper.php";
	$nota = $_GET['nota'];
	$data_penjualan = mysqli_fetch_assoc(mysqli_query($koneksi, "SELECT *, LEFT(tgl, 10) AS tgl_jual FROM penjualan WHERE no_nota = '$nota'"));
?>
<html>
	<head>
		<meta charset="UTF-8">
        <title>Nota Penjualan</title>
        <meta content='width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no' name='viewport'>		<?php include_once "style_laporan.php"; ?>
	</head>
	<body>
		<?php include_once "header_laporan.php"; ?>

		<div style="text-align: left;width: 100%;">
			<div style="width: 600px;display: inline;">
				<div style="width: 300px;float: left;">No Nota</div>
				<div style="width: 300px;float: right;"><?=$data_penjualan['no_nota']?></div>
			</div>
			<div style="width: 600px;">
				<div style="width: 300px;float: left;">Tanggal</div>
				<div style="width: 300px;float: right;"><?=tgl_indo($data_penjualan['tgl_jual'])?></div>
			</div>
			<div style="width: 600px;">
				<div style="width: 300px;float: left;">Nama Pembeli</div>
				<div style="width: 300px;float: right;"><?=$data_penjualan['nm_pembeli']?></div>
			</div>
			<div style="width: 600px;">
				<div style="width: 300px;float: left;">Keterangan</div>
				<div style="width: 300px;float: right;"><?=$data_penjualan['uraian_jual']?></div>
			</div>
		</div>
		<hr>
		<table>
			<tr>
				<th>No</th>
				<th>Kode Barang</th>
				<th>Nama Barang</th>
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
    detail_penjualan.sub_total,
    detail_penjualan.jumlah,
    barang.nama_barang
From
    barang Inner Join
    detail_penjualan On detail_penjualan.kode_barang = barang.kode_barang Inner Join
    penjualan On detail_penjualan.no_nota = penjualan.no_nota WHERE penjualan.no_nota = '$nota'");
				while($barang = mysqli_fetch_assoc($sql_query))
				{
					$total += $barang['sub_total'];
			?>
				<tr>
					<td><?=$no?></td>
					<td><?=$barang['kode_barang']?></td>
					<td><?=$barang['nama_barang']?></td>
					<td><?=rupiah($barang['harga_barang'])?></td>
					<td><?=$barang['jumlah']?></td>
				</tr>
			<?php
					$no++;
				}
			?>
				<tr>
					<td colspan="4">Total</td>
					<td colspan="2"><?=rupiah($total)?></td>
				</tr>
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