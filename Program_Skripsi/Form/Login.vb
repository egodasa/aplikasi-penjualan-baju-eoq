Public Class Aplikasi
    Public Db As New Db()
    Public level As String
    Public username As String
    Public url_laporan As String = "http://localhost:8090"
    Private Sub Keluar(sender As Object, e As EventArgs) Handles Breset.Click
        Me.Close()
    End Sub

    Private Sub ResetLogin()
        Tusername.Clear()
        Tpassword.Clear()
    End Sub

    Private Sub Login(sender As Object, e As EventArgs) Handles Bsimpan.Click
        Dim username As String = Tusername.Text
        Dim password As String = Tpassword.Text
        Dim cek_login As New DataTable
        cek_login = Db.JalankanDanAmbilData("SELECT * FROM pengguna WHERE username = '" & username & "' AND password = md5('" & password & "')")
        If cek_login.Rows.Count = 0 Then
            MessageBox.Show("Username atau password salah!", "Peringatan")
        Else
            Me.username = username
            Me.level = cek_login.Rows(0).Item("level").ToString
            MessageBox.Show("Selamat datang, " & username, "Pesan")
            Me.Hide()
            Menu_Utama.Show()
        End If
        ResetLogin()
    End Sub


End Class