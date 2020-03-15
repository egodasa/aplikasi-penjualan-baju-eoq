Public Class Data_Pengguna
    Private id_pengguna As Integer
    Private Sub TampilData()
        DGpengguna.Rows.Clear()
        DGpengguna.DataSource = Nothing
        Dim data_pengguna As DataTable = Aplikasi.Db.JalankanDanAmbilData("SELECT * FROM pengguna")
        Dim nomor As Int16 = 1
        For Each row As DataRow In data_pengguna.Rows
            DGpengguna.Rows.Add(New String() {
            nomor.ToString,
            row.Item("id_pengguna"),
            row.Item("username"),
            row.Item("password"),
            row.Item("level"),
            row.Item("nohp"),
            row.Item("alamat")
            })
            nomor += 1
        Next row
    End Sub

    Private Sub TambahData()
        Dim username As String = Tusername.Text
        Dim password As String = Tpassword.Text
        Dim level As String = Clevel.Text
        Dim nohp As String = Tnohp.Text
        Dim alamat As String = Talamat.Text
        Aplikasi.Db.JalankanSql("INSERT INTO pengguna (username, password, level, nohp, alamat) VALUES ('" & username & "',MD5('" & password & "'),'" & level & "','" & nohp & "','" & alamat & "')")
        If Aplikasi.Db.ApakahError() = True Then
            MessageBox.Show("Error : " & Aplikasi.Db.AmbilPesanError(), "Pesan")
        Else
            MessageBox.Show("Data berhasil disimpan!", "Pesan")
            ResetData()
            TampilData()
        End If
    End Sub
    Private Sub EditData()
        Dim username As String = Tusername.Text
        Dim password As String = Tpassword.Text
        Dim level As String = Clevel.Text
        Dim nohp As String = Tnohp.Text
        Dim alamat As String = Talamat.Text
        Dim sql_edit As String

        If Tpassword.Text <> "" Then
            sql_edit = "UPDATE pengguna SET username = '" & username & "'," &
            "password = MD5('" & password & "'), " &
            "level = '" & level & "', nohp = '" & nohp & "', alamat = '" & alamat & "' WHERE id_pengguna = '" & Me.id_pengguna & "'"
        Else
            sql_edit = "UPDATE pengguna SET username = '" & username & "'," &
            "level = '" & level & "', nohp = '" & nohp & "', alamat = '" & alamat & "' WHERE id_pengguna = '" & Me.id_pengguna & "'"
        End If

        Aplikasi.Db.JalankanSql(sql_edit)
        If Aplikasi.Db.ApakahError() = True Then
            MessageBox.Show("Error : " & Aplikasi.Db.AmbilPesanError(), "Pesan")
        Else
            MessageBox.Show("Data berhasil disimpan!", "Pesan")
            ResetData()
            TampilData()
        End If
    End Sub
    Private Sub HapusData()
        Dim data_terpilih As Int16 = DGpengguna.CurrentRow.Index
        Dim sql_hapus As String = "DELETE FROM pengguna WHERE id_pengguna = '" & DGpengguna.Rows(data_terpilih).Cells("DGid_pengguna").Value & "'"
        Aplikasi.Db.JalankanSql(sql_hapus)
        If Aplikasi.Db.ApakahError() = True Then
            MessageBox.Show("Error : " & Aplikasi.Db.AmbilPesanError(), "Pesan")
        Else
            MessageBox.Show("Data berhasil dihapus!", "Pesan")
            TampilData()
        End If
        TampilData()
    End Sub
    Private Sub AmbilData()
        ResetData()
        Dim data_terpilih As Int16 = DGpengguna.CurrentRow.Index
        id_pengguna = DGpengguna.Rows(data_terpilih).Cells("DGid_pengguna").Value
        Tusername.Text = DGpengguna.Rows(data_terpilih).Cells("username").Value
        'Tpassword.Text = DGpengguna.Rows(data_terpilih).Cells("password").Value
        Talamat.Text = DGpengguna.Rows(data_terpilih).Cells("alamat").Value
        Tnohp.Text = DGpengguna.Rows(data_terpilih).Cells("nohp").Value
        Clevel.Text = DGpengguna.Rows(data_terpilih).Cells("level").Value
    End Sub
    Private Sub ResetData()
        Tusername.Clear()
        Tpassword.Clear()
        Talamat.Clear()
        Tnohp.Clear()
        Clevel.SelectedIndex = -1
    End Sub

    Private Sub AksiAmbilData(sender As Object, e As DataGridViewCellEventArgs) Handles DGpengguna.CellContentDoubleClick
        AmbilData()
    End Sub

    Private Sub AksiSimpan(sender As Object, e As EventArgs) Handles Bsimpan.Click
        TambahData()
    End Sub

    Private Sub AksiEditData(sender As Object, e As EventArgs) Handles Button1.Click
        EditData()
    End Sub

    Private Sub AksiHapusData(sender As Object, e As EventArgs) Handles Button2.Click
        HapusData()
    End Sub

    Private Sub AKsiKeluar(sender As Object, e As EventArgs) Handles Button3.Click
        Menu_Utama.ShowForm(Menu_Utama.FBeranda, Menu_Utama)
    End Sub
    Public Sub BukaForm()
        TampilData()
    End Sub
End Class
