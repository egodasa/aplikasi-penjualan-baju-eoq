Public Class Data_Pembelian
    Dim data_barang As DataTable
    Dim data_supplier As DataTable
    Private Function BuatNoNota()
        Return DateTime.Now.ToString("ddMMyyhhmmssffff")
    End Function
    Private Sub ResetBarang()
        Ckode_barang.SelectedIndex = -1
        Tharga_beli.Clear()
        Tjumlah.Clear()
        Tsub_total.Clear()
    End Sub
    Private Sub TambahKeranjang()
        Dim no_nota As String = Tno_nota.Text
        Dim kode_barang As String = Ckode_barang.SelectedValue
        Dim harga_barang As String = Tharga_beli.Text
        Dim jumlah As String = Tjumlah.Text
        Dim sub_total As String = Tsub_total.Text
        Dim sql As String = "INSERT INTO detail_pembelian (no_nota, kode_barang, harga_barang, sub_total, jumlah) VALUES (
                             '" & no_nota & "', '" & kode_barang & "', '" & harga_barang & "', '" & sub_total & "', '" & jumlah & "')"
        Aplikasi.Db.JalankanDanAmbilData(sql)
        MessageBox.Show("Barang berhasil ditambahkan ke keranjang", "Pesan")
        AmbilDataKeranjang()
    End Sub
    Private Sub HapusKeranjang()
        Dim id_detail As String = DGkeranjang.Rows(DGkeranjang.CurrentRow.Index).Cells("id_detail").Value
        Aplikasi.Db.JalankanSql("DELETE FROM detail_pembelian WHERE id_detail = " & id_detail)
        MessageBox.Show("Pesan", "Barang berhasil dihapus dari keranjang")
        AmbilDataKeranjang()
    End Sub
    Private Sub AmbilDataKeranjang()
        DGkeranjang.Rows.Clear()
        DGkeranjang.DataSource = Nothing
        Dim data_keranjang As DataTable = Aplikasi.Db.JalankanDanAmbilData("SELECT detail_pembelian.*, barang.nama_barang FROM detail_pembelian JOIN barang ON detail_pembelian.kode_barang = barang.kode_barang")
        Dim nomor As Int16 = 1
        For Each row As DataRow In data_barang.Rows
            DGkeranjang.Rows.Add(New String() {
            nomor.ToString,
            row.Item("kode_barang"),
            row.Item("nama_barang"),
            row.Item("harga_barang"),
            row.Item("jumlah"),
            row.Item("sub_total")
            })
            nomor += 1
        Next row
    End Sub
    Private Sub AmbilDataPembelian()
        Dim sql As String = "Select
                                pembelian.no_nota,
                                pembelian.tgl_beli,
                                pembelian.total_harga,
                                pembelian.kode_supplier,
                                supplier.nama_supplier,
                                SUM(detail_pembelian.jumlah) AS jumlah
                             From
                                pembelian Inner Join
                                detail_pembelian On detail_pembelian.no_nota = pembelian.no_nota 
                                Inner Join supplier On pembelian.kode_supplier = supplier.kode_supplier 
                             GROUP BY pembelian.no_nota ORDER BY pembelian.tgl_beli DESC"
        DGpembelian.Rows.Clear()
        DGpembelian.DataSource = Nothing
        Dim data_pembelian As DataTable = Aplikasi.Db.JalankanDanAmbilData(sql)
        Dim nomor As Int16 = 1
        For Each row As DataRow In data_barang.Rows
            DGpembelian.Rows.Add(New String() {
            nomor.ToString,
            row.Item("no_nota"),
            row.Item("tgl_beli"),
            row.Item("kode_supplier"),
            row.Item("nama_supplier"),
            row.Item("jumlah"),
            row.Item("total_harga")
            })
            nomor += 1
        Next row
    End Sub
    Private Sub HapusDataPembelian()
        Dim no_nota As String = DGpembelian.Rows(DGpembelian.CurrentRow.Index).Cells("no_nota").Value
        MessageBox.Show("Data pembelian berhasil dihapus", "Pesan")
        AmbilDataPembelian()
    End Sub

    Private Sub Init()
        data_barang = Aplikasi.Db.JalankanDanAmbilData("SELECT * FROM barang")
        data_supplier = Aplikasi.Db.JalankanDanAmbilData("SELECT * FROM supplier")
    End Sub

End Class
