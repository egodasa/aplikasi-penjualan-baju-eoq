Public Class Data_Supplier
    Private Sub Keluar(sender As Object, e As EventArgs) Handles Button3.Click
        Menu_Utama.ShowForm(Menu_Utama.FBeranda, Menu_Utama)
    End Sub
    Private Sub TampilData()
        DGsupplier.Rows.Clear()
        DGsupplier.DataSource = Nothing
        Dim data_supplier As DataTable = Aplikasi.Db.JalankanDanAmbilData("SELECT * FROM supplier")
        Dim nomor As Int16 = 1
        For Each row As DataRow In data_supplier.Rows
            DGsupplier.Rows.Add(New String() {
            nomor.ToString,
            row.Item("kode_supplier"),
            row.Item("nama_supplier"),
            row.Item("no_telp"),
            row.Item("alamat")
            })
            nomor += 1
        Next row
    End Sub
    Private Sub TambahData()
        Dim kode_supplier As String = Tkode_supplier.Text
        Dim nama_supplier As String = Tnama_supplier.Text
        Dim alamat As String = Talamat.Text
        Dim no_telp As String = Tnohp.Text
        Aplikasi.Db.JalankanSql("INSERT INTO supplier (kode_supplier, nama_supplier, alamat, no_telp) VALUES ('" & kode_supplier & "','" & nama_supplier & "','" & alamat & "','" & no_telp & "')")
        If Aplikasi.Db.ApakahError() = True Then
            MessageBox.Show("Error : " & Aplikasi.Db.AmbilPesanError(), "Pesan")
        Else
            MessageBox.Show("Data berhasil disimpan!", "Pesan")
            ResetData()
            TampilData()
        End If
    End Sub
    Private Sub EditData()
        Dim data_terpilih As Int16 = DGsupplier.CurrentRow.Index
        Dim kode_supplier As String = Tkode_supplier.Text
        Dim nama_supplier As String = Tnama_supplier.Text
        Dim alamat As String = Talamat.Text
        Dim no_telp As String = Tnohp.Text
        Dim sql_edit As String = "UPDATE supplier SET nama_supplier = '" & nama_supplier & "'," &
            "alamat = '" & alamat & "', " &
            "no_telp = '" & no_telp & "' WHERE kode_supplier = '" & kode_supplier & "'"
        Aplikasi.Db.JalankanSql(sql_edit)
        If Aplikasi.Db.ApakahError() = True Then
            MessageBox.Show("Error : " & Aplikasi.Db.AmbilPesanError(), "Pesan")
        Else
            MessageBox.Show("Data berhasil disimpan!", "Pesan")
            TampilData()
            ResetData()
        End If
    End Sub
    Private Sub HapusData()
        Dim data_terpilih As Int16 = DGsupplier.CurrentRow.Index
        Dim sql_hapus As String = "DELETE FROM supplier WHERE kode_supplier = '" & DGsupplier.Rows(data_terpilih).Cells("kode_supplier").Value & "'"
        Aplikasi.Db.JalankanSql(sql_hapus)
        If Aplikasi.Db.ApakahError() = True Then
            MessageBox.Show("Error : " & Aplikasi.Db.AmbilPesanError(), "Pesan")
        Else
            MessageBox.Show("Data berhasil dihapus!", "Pesan")
            TampilData()
        End If
    End Sub
    Private Sub AmbilData()
        Dim data_terpilih As Int16 = DGsupplier.CurrentRow.Index
        Tkode_supplier.Text = DGsupplier.Rows(data_terpilih).Cells("kode_supplier").Value
        Tnama_supplier.Text = DGsupplier.Rows(data_terpilih).Cells("nama_supplier").Value
        Talamat.Text = DGsupplier.Rows(data_terpilih).Cells("alamat").Value
        Tnohp.Text = DGsupplier.Rows(data_terpilih).Cells("nohp").Value
    End Sub
    Private Sub ResetData()
        Tkode_supplier.Clear()
        Tnama_supplier.Clear()
        Talamat.Clear()
        Tnohp.Clear()
        Tkode_supplier.Text = Aplikasi.GenerateKode("supplier", "kode_supplier", "S")
    End Sub

    Private Sub Simpan(sender As Object, e As EventArgs) Handles Bsimpan.Click
        TambahData()
    End Sub

    Private Sub AmbilDataSupplier(sender As Object, e As DataGridViewCellEventArgs) Handles DGsupplier.CellContentClick
        AmbilData()
    End Sub

    Private Sub HapusDataSupplier(sender As Object, e As EventArgs) Handles Button2.Click
        HapusData()
        ResetData()
    End Sub

    Public Sub BukaForm()
        TampilData()
        ResetData()
    End Sub

    Private Sub Edit(sender As Object, e As EventArgs) Handles Button1.Click
        EditData()
    End Sub

    Private Sub Data_Supplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
