Public Class Data_Penjualan
    Dim data_barang As DataTable
    Private Sub AmbilDataBarang()
        If Ckode_barang.SelectedIndex <> -1 Then
            Tnama_barang.Text = data_barang.Rows(Ckode_barang.SelectedIndex).Item("nama_barang")
            Tharga_beli.Text = data_barang.Rows(Ckode_barang.SelectedIndex).Item("harga_barang")
            Tstok.Text = data_barang.Rows(Ckode_barang.SelectedIndex).Item("stock")
            If Val(Tstok.Text) = 0 Then
                MessageBox.Show("Stok tidak mencukupi!")
                Ckode_barang.SelectedIndex = -1
            End If
        Else
            Tnama_barang.Clear()
            Tharga_beli.Clear()
            Tstok.Clear()
        End If

    End Sub
    Private Sub HitungSubTotal()
        Dim jumlah As Integer = 0
        Dim harga As Integer = 0
        Dim total_harga As Integer = 0

        If IsNumeric(Tjumlah.Text) Then
            jumlah = Tjumlah.Text
        End If
        If IsNumeric(Tharga_beli.Text) Then
            harga = Tharga_beli.Text
        End If
        total_harga = jumlah * harga
        Tsub_total.Text = total_harga
    End Sub

    Private Sub ResetBarang()
        Ckode_barang.SelectedIndex = -1
        Tharga_beli.Clear()
        Tjumlah.Clear()
        Tsub_total.Clear()
    End Sub
    Private Sub ResetPembelian()
        Tno_nota.Clear()
        Ttgl_beli.ResetText()
        Tnm_pembeli.Clear()
        Turaian_jual.Clear()
        Tno_nota.Text = Aplikasi.GenerateKode("penjualan", "no_nota", "NP")
        AmbilDataBarang()
        AmbilDataPembelian()
    End Sub
    Private Sub TambahKeranjang()
        Dim stok As Integer = 0
        Dim jumlah As Integer = 0
        Dim sisa As Integer = 0
        If IsNumeric(Tstok.Text) Then
            stok = Val(Tstok.Text)
        End If
        If IsNumeric(Tjumlah.Text) Then
            jumlah = Val(Tjumlah.Text)
        End If
        sisa = stok - jumlah
        If sisa < 0 Then
            MessageBox.Show("Stok tidak mencukupi!")
            ResetBarang()
        Else
            Dim no_nota As String = Tno_nota.Text
            Dim kode_barang As String = Ckode_barang.SelectedValue
            Dim harga_barang As String = Tharga_beli.Text
            Dim sub_total As String = Tsub_total.Text
            Dim sql As String = "INSERT INTO detail_penjualan (no_nota, kode_barang, harga_barang, sub_total, jumlah) VALUES ('" & no_nota & "', '" & kode_barang & "', '" & harga_barang & "', '" & sub_total & "', '" & jumlah & "')"
            Aplikasi.Db.JalankanSql(sql)
            If Aplikasi.Db.ApakahError Then
                MessageBox.Show("Error : " & Aplikasi.Db.AmbilPesanError())
            Else
                ' update stok barang setelah dilakukan penjualan
                Aplikasi.Db.JalankanSql("UPDATE barang SET stock = stock - " & jumlah & " WHERE kode_barang = '" & kode_barang & "'")
                MessageBox.Show("Barang berhasil ditambahkan ke keranjang", "Pesan")
                AmbilDataKeranjang()
                ResetBarang()
            End If
        End If


    End Sub
    Private Sub SimpanPembelian()
        Dim no_nota As String = Tno_nota.Text
        Dim tgl_beli As String = Ttgl_beli.Value.ToString("yyyy-MM-dd")
        Dim nm_pembeli As String = Tnm_pembeli.Text
        Dim uraian_jual As String = Turaian_jual.Text
        Dim total_harga As String = Ttotal_harga.Text
        Dim sql As String = "INSERT INTO penjualan (no_nota, tgl_jual, nm_pembeli, uraian_jual, total_harga) VALUES ('" & no_nota & "', '" & tgl_beli & "', '" & nm_pembeli & "', '" & uraian_jual & "', '" & total_harga & "')"
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
        Aplikasi.Db.JalankanSql("DELETE FROM detail_penjualan WHERE id_detail = " & id_detail)
        If Aplikasi.Db.ApakahError Then
            MessageBox.Show("Error : " & Aplikasi.Db.AmbilPesanError())
        Else
            ' update stok barang setelah dilakukan penghapusan barang dari keranjang
            Aplikasi.Db.JalankanSql("UPDATE barang SET stock = stock + " & DGkeranjang.CurrentRow.Cells("jumlah").Value.ToString() & " WHERE kode_barang = '" & DGkeranjang.CurrentRow.Cells("kode_barang").Value.ToString() & "'")
            MessageBox.Show("Pesan", "Barang berhasil dihapus dari keranjang")
            AmbilDataKeranjang()
        End If

    End Sub
    Private Sub AmbilDataKeranjang()
        DGkeranjang.Rows.Clear()
        DGkeranjang.DataSource = Nothing
        Dim no_nota As String = Tno_nota.Text
        Dim total_harga As Integer = 0
        Dim data_keranjang As DataTable = Aplikasi.Db.JalankanDanAmbilData("SELECT detail_penjualan.*, barang.nama_barang FROM detail_penjualan JOIN barang ON detail_penjualan.kode_barang = barang.kode_barang WHERE detail_penjualan.no_nota = '" & no_nota & "'")
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
        Dim sql As String = "Select penjualan.no_nota, penjualan.tgl_jual, penjualan.total_harga, penjualan.nm_pembeli, penjualan.uraian_jual, SUM(detail_penjualan.jumlah) AS jumlah From penjualan Inner Join detail_penjualan On detail_penjualan.no_nota = penjualan.no_nota  GROUP BY penjualan.no_nota ORDER BY penjualan.tgl_jual DESC"
        DGpenjualan.Rows.Clear()
        DGpenjualan.DataSource = Nothing
        Dim data_penjualan As DataTable = Aplikasi.Db.JalankanDanAmbilData(sql)
        Dim nomor As Int16 = 1
        If Aplikasi.Db.ApakahError Then
            MessageBox.Show("Error : " & Aplikasi.Db.AmbilPesanError())
        Else
            For Each row As DataRow In data_penjualan.Rows
                DGpenjualan.Rows.Add(New String() {
                nomor.ToString,
                row.Item("no_nota"),
                row.Item("tgl_jual"),
                row.Item("nm_pembeli"),
                row.Item("jumlah"),
                row.Item("total_harga"),
                row.Item("uraian_jual")
                })
                nomor += 1
            Next row
        End If

    End Sub
    Private Sub HapusDataPembelian()
        Dim no_nota As String = DGpenjualan.Rows(DGpenjualan.CurrentRow.Index).Cells("no_nota").Value
        Aplikasi.Db.JalankanSql("DELETE FROM penjualan WHERE no_nota = '" & no_nota & "'")
        Aplikasi.Db.JalankanSql("DELETE FROM detail_penjualan WHERE no_nota = '" & no_nota & "'")
        If Aplikasi.Db.ApakahError Then
            MessageBox.Show("Error : " & Aplikasi.Db.AmbilPesanError())
        Else
            MessageBox.Show("Data pembelian berhasil dihapus", "Pesan")
            AmbilDataPembelian()
        End If

    End Sub

    Public Sub BukaForm()
        Me.data_barang = Aplikasi.Db.JalankanDanAmbilData("SELECT * FROM barang")
        Ckode_barang.DataSource = data_barang
        Ckode_barang.DisplayMember = "nama_barang"
        Ckode_barang.ValueMember = "kode_barang"

        ResetBarang()
        AmbilDataPembelian()
        ResetPembelian()
    End Sub



    Private Sub AksiTambahBarang(sender As Object, e As EventArgs) Handles Button1.Click
        TambahKeranjang()
    End Sub

    Private Sub AksiSimpanPembelian(sender As Object, e As EventArgs) Handles Bsimpan.Click
        SimpanPembelian()
    End Sub


    Private Sub AksiAmbilDataBarang(sender As Object, e As EventArgs) Handles Ckode_barang.SelectedIndexChanged
        AmbilDataBarang()
    End Sub

    Private Sub AksiHapusBarang(sender As Object, e As EventArgs) Handles Button2.Click
        HapusKeranjang()
    End Sub

    Private Sub AksiHapusPembelian(sender As Object, e As EventArgs) Handles Button3.Click
        HapusDataPembelian()
        ResetPembelian()
        ResetBarang()
    End Sub

    Private Sub AksiHitungSubTotal(sender As Object, e As KeyEventArgs) Handles Tjumlah.KeyUp
        HitungSubTotal()
    End Sub

    Private Sub AksiCetakNota(sender As Object, e As EventArgs) Handles Button4.Click
        Dim no_nota As String = DGpenjualan.Rows(DGpenjualan.CurrentRow.Index).Cells("no_nota").Value
        Cetak_Laporan.url = Aplikasi.url_laporan & "/cetak-nota.php?nota=" & no_nota
        Cetak_Laporan.ShowDialog()
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)
    End Sub

    Private Sub Data_Penjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
