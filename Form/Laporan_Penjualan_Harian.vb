Public Class Laporan_Penjualan_Harian
    Private Sub AksiCetak(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tanggal As String = Ttgl.Value.ToString("yyyy-MM-dd")
        Cetak_Laporan.url = Aplikasi.url_laporan & "/laporan-penjualan-harian.php?tgl=" & tanggal
        Cetak_Laporan.ShowDialog()
    End Sub

End Class
