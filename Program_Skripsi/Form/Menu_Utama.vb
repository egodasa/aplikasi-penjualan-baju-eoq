Public Class Menu_Utama
    Public FBeranda As New Beranda
    Public FBarang As New Data_Barang
    Public FSupplier As New Data_Supplier
    Public FPembelian As New Data_Pembelian
    Public FPenjualan As New Data_Penjualan
    Public FLaporanBarang As New Laporan
    Public Sub ShowForm(ByVal uc As UserControl, ByVal form As Form)
        uc.Location = New Point(0, 20)
        form.Size = New Size(uc.Size.Width + 2, uc.Size.Height + 50)
        uc.Show()
        uc.BringToFront()
    End Sub
    Private Sub Keluar(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem1.Click
        Aplikasi.Show()
        Me.Close()
    End Sub

    Private Sub Init(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Controls.Add(FBeranda)
        Me.Controls.Add(FBarang)
        Me.Controls.Add(FSupplier)
        Me.Controls.Add(FPembelian)
        Me.Controls.Add(FLaporanBarang)
        ShowForm(FBeranda, Me)
    End Sub

    Private Sub Tampil_Barang(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        ShowForm(FBarang, Me)
    End Sub

    Private Sub Tampil_Supplier(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        ShowForm(FSupplier, Me)
    End Sub

    Private Sub Tampil_Menu_Utama(sender As Object, e As EventArgs) Handles InputToolStripMenuItem.Click
        ShowForm(FBeranda, Me)
    End Sub

    Private Sub Tampil_Pembelian(sender As Object, e As EventArgs) Handles PembelianToolStripMenuItem.Click
        ShowForm(FPembelian, Me)
    End Sub

    Private Sub Tampil_Penjualan(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        ShowForm(FPenjualan, Me)
    End Sub

    Private Sub LaporanBarang(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem1.Click
        ShowForm(FLaporanBarang, Me)
    End Sub
End Class