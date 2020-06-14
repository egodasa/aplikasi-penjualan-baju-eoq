Public Class Laporan_Penjualan_Bulanan
    Private Sub CetakLaporan(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tanggal As String = Ttgl.Value.ToString("yyyy-MM")
        Cetak_Laporan.url = Aplikasi.url_laporan & "/laporan-penjualan-bulanan.php?tgl=" & tanggal
        Cetak_Laporan.ShowDialog()
    End Sub
End Class
