Public Class Laporan
    Private Sub Init(sender As Object, e As EventArgs) Handles MyBase.Load
        WBlaporan.Navigate(Application.StartupPath & "/Laporan/laporan-barang.html")
        WBlaporan.ShowPrintDialog()
    End Sub
End Class
