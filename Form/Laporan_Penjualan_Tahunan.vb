Public Class Laporan_Penjualan_Tahunan
    Private Sub CetakLaporan(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tanggal As String = Ttgl.Value.ToString("yyyy")
        Cetak_Laporan.url = Aplikasi.url_laporan & "/laporan-penjualan-tahunan.php?tgl=" & tanggal
        Cetak_Laporan.ShowDialog()
    End Sub
End Class
