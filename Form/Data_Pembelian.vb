Public Class Data_Pembelian
    Dim data_barang As DataTable
    Dim data_supplier As DataTable
    Private Sub AmbilDataBarang()
        If Ckode_barang.SelectedIndex <> -1 Then
            Tnama_barang.Text = data_barang.Rows(Ckode_barang.SelectedIndex).Item("nama_barang")
        Else
            Tnama_barang.Clear()
        End If

    End Sub
    Private Sub AmbilDataSupplier()
        If Ckode_supplier.SelectedIndex <> -1 Then
            Tnama_supplier.Text = data_supplier.Rows(Ckode_supplier.SelectedIndex).Item("nama_supplier")
        Else
            Tnama_supplier.Clear()
        End If

    End Sub
    Private Function BuatNoNota()
        Return DateTime.Now.ToString("ddMMyyhhmmssffff")
    End Function
    Private Sub ResetBarang()
        Ckode_barang.SelectedIndex = -1
        Tharga_beli.Clear()
        Tjumlah.Clear()
        Tsub_total.Clear()
    End Sub
    Private Sub ResetPembelian()
        Tno_nota.Clear()
        Ttgl_beli.ResetText()
        Ckode_supplier.SelectedIndex = -1
        Tnama_supplier.Clear()
    End Sub
    Private Sub TambahKeranjang()
        Dim no_nota As String = Tno_nota.Text
        Dim kode_barang As String = Ckode_barang.SelectedValue
        Dim harga_barang As String = Tharga_beli.Text
        Dim jumlah As String = Tjumlah.Text
        Dim sub_total As String = Tsub_total.Text
        Dim sql As String = "INSERT INTO detail_pembelian (no_nota, kode_barang, harga_barang, sub_total, jumlah) VALUES (
                             '" & no_nota & "', '" & kode_barang & "', '" & harga_barang & "', '" & sub_total & "', '" & jumlah & "')"
        Aplikasi.Db.JalankanSql(sql)
        If Aplikasi.Db.ApakahError Then
            MessageBox.Show("Error : " & Aplikasi.Db.AmbilPesanError())
        Else
            MessageBox.Show("Barang berhasil ditambahkan ke keranjang", "Pesan")
            AmbilDataKeranjang()
            ResetBarang()
        End If

    End Sub
    Private Sub SimpanPembelian()
        Dim no_nota As String = Tno_nota.Text
        Dim tgl_beli As String = Ttgl_beli.Value.ToString("yyyy-MM-dd")
        Dim kode_supplier As String = Ckode_supplier.SelectedValue
        Dim total_harga As String = Ttotal_harga.Text
        Dim sql As String = "INSERT INTO pembelian (no_nota, tgl_beli, kode_supplier, total_harga) VALUES ('" & no_nota & "', '" & tgl_beli & "', '" & kode_supplier & "', '" & total_harga & "')"
        Aplikasi.Db.JalankanSql(sql)
        If Aplikasi.Db.ApakahError Then
            MessageBox.Show("Error : " & Aplikasi.Db.AmbilPesanError())
        Else
            MessageBox.Show("Pembelian berhasil disimpan", "Pesan")
            ResetPembelian()
            ResetBarang()
            AmbilDataPembelian()
            AmbilDataKeranjang()
        End If

    End Sub
    Private Sub HapusKeranjang()
        Dim id_detail As String = DGkeranjang.Rows(DGkeranjang.CurrentRow.Index).Cells("id_detail").Value
        Aplikasi.Db.JalankanSql("DELETE FROM detail_pembelian WHERE id_detail = " & id_detail)
        If Aplikasi.Db.ApakahError Then
            MessageBox.Show("Error : " & Aplikasi.Db.AmbilPesanError())
        Else
            MessageBox.Show("Pesan", "Barang berhasil dihapus dari keranjang")
            AmbilDataKeranjang()
        End If

    End Sub
    Private Sub AmbilDataKeranjang()
        DGkeranjang.Rows.Clear()
        DGkeranjang.DataSource = Nothing
        Dim no_nota As String = Tno_nota.Text
        Dim total_harga As Integer = 0
        Dim data_keranjang As DataTable = Aplikasi.Db.JalankanDanAmbilData("SELECT detail_pembelian.*, barang.nama_barang FROM detail_pembelian JOIN barang ON detail_pembelian.kode_barang = barang.kode_barang WHERE detail_pembelian.no_nota = '" & no_nota & "'")
        Dim nomor As Int16 = 1
        If Aplikasi.Db.ApakahError Then
            MessageBox.Show("Error : " & Aplikasi.Db.AmbilPesanError())
        Else
            For Each row As DataRow In data_keranjang.Rows
                DGkeranjang.Rows.Add(New String() {
                row.Item("id_detail"),
                nomor.ToString,
                row.Item("kode_barang"),
                row.Item("nama_barang"),
                row.Item("harga_barang"),
                row.Item("jumlah"),
                row.Item("sub_total")
                })
                nomor += 1
                total_harga += Val(row.Item("sub_total"))
            Next row

        End If
        Ttotal_harga.Text = total_harga


    End Sub
    Private Sub AmbilDataPembelian()
        Dim sql As String = "Select pembelian.no_nota, pembelian.tgl_beli, pembelian.total_harga, pembelian.kode_supplier, supplier.nama_supplier, SUM(detail_pembelian.jumlah) AS jumlah From pembelian Inner Join detail_pembelian On detail_pembelian.no_nota = pembelian.no_nota  Inner Join supplier On pembelian.kode_supplier = supplier.kode_supplier  GROUP BY pembelian.no_nota ORDER BY pembelian.tgl_beli DESC"
        DGpembelian.Rows.Clear()
        DGpembelian.DataSource = Nothing
        Dim data_pembelian As DataTable = Aplikasi.Db.JalankanDanAmbilData(sql)
        Dim nomor As Int16 = 1
        If Aplikasi.Db.ApakahError Then
            MessageBox.Show("Error : " & Aplikasi.Db.AmbilPesanError())
        Else
            For Each row As DataRow In data_pembelian.Rows
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
        End If

    End Sub
    Private Sub HapusDataPembelian()
        Dim no_nota As String = DGpembelian.Rows(DGpembelian.CurrentRow.Index).Cells("no_nota").Value
        Aplikasi.Db.JalankanSql("DELETE FROM pembelian WHERE no_nota = '" & no_nota & "'")
        Aplikasi.Db.JalankanSql("DELETE FROM detail_pembelian WHERE no_nota = '" & no_nota & "'")
        If Aplikasi.Db.ApakahError Then
            MessageBox.Show("Error : " & Aplikasi.Db.AmbilPesanError())
        Else
            MessageBox.Show("Data pembelian berhasil dihapus", "Pesan")
            AmbilDataPembelian()
        End If

    End Sub

    Public Sub BukaForm()
        Me.data_barang = Aplikasi.Db.JalankanDanAmbilData("SELECT *, CONCAT(kode_barang, ' - ', nama_barang) as ket FROM barang")
        Ckode_barang.DataSource = data_barang
        Ckode_barang.DisplayMember = "ket"
        Ckode_barang.ValueMember = "kode_barang"
        Ckode_barang.SelectedIndex = -1

        Me.data_supplier = Aplikasi.Db.JalankanDanAmbilData("SELECT *, CONCAT(kode_supplier, ' - ', nama_supplier) as ket FROM supplier")
        Ckode_supplier.DisplayMember = "ket"
        Ckode_supplier.ValueMember = "kode_supplier"
        Ckode_supplier.DataSource = data_supplier
        Ckode_supplier.SelectedIndex = -1

        ResetBarang()
        AmbilDataPembelian()
    End Sub



    Private Sub AksiTambahBarang(sender As Object, e As EventArgs) Handles Button1.Click
        TambahKeranjang()
    End Sub

    Private Sub AksiSimpanPembelian(sender As Object, e As EventArgs) Handles Bsimpan.Click
        SimpanPembelian()
    End Sub

    Private Sub AksiAmbilDataSupplier(sender As Object, e As EventArgs) Handles Ckode_supplier.SelectionChangeCommitted
        AmbilDataSupplier()
    End Sub

    Private Sub AksiAmbilDataBarang(sender As Object, e As EventArgs) Handles Ckode_barang.SelectedIndexChanged
        AmbilDataBarang()
    End Sub

    Private Sub AksiHapusBarang(sender As Object, e As EventArgs) Handles Button2.Click
        HapusKeranjang()
    End Sub

    Private Sub AksiHapusPembelian(sender As Object, e As EventArgs) Handles Button3.Click
        HapusDataPembelian()
    End Sub

    Private Sub Data_Pembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
