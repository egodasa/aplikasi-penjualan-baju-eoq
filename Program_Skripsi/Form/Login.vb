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

    Public Function GenerateKode(ByVal tabel As String, ByVal kolom As String, ByVal prefix As String)
        Dim hitung As DataTable = Db.JalankanDanAmbilData("SELECT LEFT(" & kolom & ", 5) AS kode FROM " & tabel & " ORDER BY " & kolom & " DESC LIMIT 1")
        Dim kode As Integer
        Dim kode_baru As String
        If hitung.Rows.Count = 0 Then
            kode_baru = prefix & "00001"
        Else
            kode = Val(hitung.Rows(0).Item("kode"))
            kode += 1
            If kode >= 1 And kode <= 9 Then
                kode_baru = prefix & "0000" & kode
            ElseIf kode >= 10 And kode <= 99 Then
                kode_baru = prefix & "000" & kode
            ElseIf kode >= 100 And kode <= 999 Then
                kode_baru = prefix & "000" & kode
            ElseIf kode >= 1000 And kode <= 9999 Then
                kode_baru = prefix & "000" & kode
            ElseIf kode >= 10000 And kode <= 99999 Then
                kode_baru = prefix & "00" & kode
            ElseIf kode >= 100000 And kode <= 999999 Then
                kode_baru = prefix & "0" & kode
            Else
                kode_baru = prefix & kode
            End If
        End If
        Return kode_baru
    End Function


End Class