Public Class Menu_Utama

    Public FBeranda As New Beranda
    Public FBarang As New Data_Barang
    Public FSupplier As New Data_Supplier
    Public FPembelian As New Data_Pembelian
    Public FPenjualan As New Data_Penjualan
    Public FEoq As New Data_Eoq
    Public FLaporanPenjualanHarian As New Laporan_Penjualan_Harian
    Public FLaporanPenjualanBulanan As New Laporan_Penjualan_Bulanan
    Public FLaporanPenjualanTahunan As New Laporan_Penjualan_Tahunan
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
        Me.Controls.Add(FPenjualan)
        Me.Controls.Add(FEoq)
        Me.Controls.Add(FLaporanPenjualanHarian)
        Me.Controls.Add(FLaporanPenjualanBulanan)
        Me.Controls.Add(FLaporanPenjualanTahunan)
        ShowForm(FBeranda, Me)
    End Sub

    Private Sub Tampil_Barang(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        ShowForm(FBarang, Me)
        FBarang.BukaForm()
    End Sub

    Private Sub Tampil_Supplier(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        ShowForm(FSupplier, Me)
        FSupplier.BukaForm()
    End Sub

    Private Sub Tampil_Menu_Utama(sender As Object, e As EventArgs) Handles InputToolStripMenuItem.Click
        ShowForm(FBeranda, Me)
    End Sub

    Private Sub Tampil_Pembelian(sender As Object, e As EventArgs) Handles PembelianToolStripMenuItem.Click
        ShowForm(FPembelian, Me)
        FPembelian.BukaForm()
    End Sub

    Private Sub Tampil_Penjualan(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        ShowForm(FPenjualan, Me)
        FPenjualan.BukaForm()
    End Sub

    Private Sub LaporanBarang(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem1.Click
        Cetak_Laporan.url = Aplikasi.url_laporan & "/laporan-barang.php"
        Cetak_Laporan.ShowDialog()
        Cetak_Laporan.AmbilDataLaporan()
    End Sub

    Private Sub MenuLaporanPenjualanHarian(sender As Object, e As EventArgs) Handles HarianToolStripMenuItem.Click
        ShowForm(FLaporanPenjualanHarian, Me)
    End Sub

    Private Sub MenuLaporanPenjualanBulanan(sender As Object, e As EventArgs) Handles BulananToolStripMenuItem.Click
        ShowForm(FLaporanPenjualanBulanan, Me)
    End Sub

    Private Sub MenuLaporanPenjualanTahunan(sender As Object, e As EventArgs) Handles TahunanToolStripMenuItem.Click
        ShowForm(FLaporanPenjualanTahunan, Me)
    End Sub

    Private Sub MenuSupplier(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem1.Click
        Cetak_Laporan.url = Aplikasi.url_laporan & "/laporan-supplier.php"
        Cetak_Laporan.ShowDialog()
        Cetak_Laporan.AmbilDataLaporan()
    End Sub

    Private Sub MenuPembelian(sender As Object, e As EventArgs) Handles PembelianToolStripMenuItem1.Click
        Cetak_Laporan.url = Aplikasi.url_laporan & "/laporan-pembelian.php"
        Cetak_Laporan.ShowDialog()
        Cetak_Laporan.AmbilDataLaporan()
    End Sub

    Private Sub MenuLaporanEoq(sender As Object, e As EventArgs) Handles EOQToolStripMenuItem1.Click
        Cetak_Laporan.url = Aplikasi.url_laporan & "/laporan-eoq.php"
        Cetak_Laporan.ShowDialog()
        Cetak_Laporan.AmbilDataLaporan()
    End Sub

    Private Sub MenuEoq(sender As Object, e As EventArgs) Handles EOQToolStripMenuItem.Click
        Me.ShowForm(FEoq, Me)
    End Sub
End Class