Public Class Laporan
    Private Sub Init(sender As Object, e As EventArgs) Handles MyBase.Load
        WBlaporan.Navigate("http://www.google.com")
        WBlaporan.ShowPrintDialog()
    End Sub
End Class
