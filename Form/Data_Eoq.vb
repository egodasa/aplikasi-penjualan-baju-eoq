Public Class Data_Eoq
    Dim data_barang As DataTable
    Public Sub BukaForm()
        data_barang = Aplikasi.Db.JalankanDanAmbilData("SELECT * FROM barang")
        Ckode_barang.DataSource = data_barang
        Ckode_barang.DisplayMember = "kode_barang"
        Ckode_barang.ValueMember = "kode_barang"
        Tkode_eoq.Text = Aplikasi.GenerateKode("eoq", "kode_eoq", "E")
        TampilDetailBarang()
        AmbilDataEoq()
        AmbilJumlahKebutuhan()
    End Sub
    Public Sub ResetForm()
        Tkode_eoq.Clear()
        Ckode_barang.SelectedIndex = -1
        Tnama_barang.Clear()
        Tbiaya_pesan.Clear()
        Tbiaya_simpan.Clear()
        Twaktu.ResetText()
        Tjml_kebutuhan.Clear()
        Teoq.Clear()
        Trop.Clear()
        Tstock_cadangan.Clear()
        Tleadtime.Clear()
    End Sub
    Public Sub TampilDetailBarang()
        If Ckode_barang.SelectedIndex = -1 Then
            Tnama_barang.Clear()
        Else
            Tnama_barang.Text = data_barang.Rows(Ckode_barang.SelectedIndex).Item("nama_barang")
            Tbiaya_pesan.Text = data_barang.Rows(Ckode_barang.SelectedIndex).Item("biaya_pesan")
            Tbiaya_simpan.Text = data_barang.Rows(Ckode_barang.SelectedIndex).Item("biaya_simpan")
            Tstock_cadangan.Text = data_barang.Rows(Ckode_barang.SelectedIndex).Item("stock_cadangan")
            Tleadtime.Text = data_barang.Rows(Ckode_barang.SelectedIndex).Item("leadtime")
        End If
    End Sub
    Public Sub HitungEoq()
        Dim biaya_pemesanan As Double = Val(Tbiaya_pesan.Text)
        Dim biaya_simpan As Double = Val(Tbiaya_simpan.Text)
        Dim kebutuhan As Integer = Val(Tjml_kebutuhan.Text)
        Dim eoq As Double
        eoq = Math.Sqrt((2 * biaya_pemesanan * kebutuhan) / biaya_simpan)
        Teoq.Text = eoq
    End Sub
    Public Sub HitungRop()
        Dim hari As Double = Val(Thari.Text)
        Dim leadtime As Double = Val(Tleadtime.Text)
        Dim stock As Double = Val(Tstock_cadangan.Text)
        Trop.Text = hari * leadtime * stock
    End Sub

    Private Sub AmbilJumlahKebutuhan()
        Dim bulan As String = Twaktu.Value.ToString("yyyy-MM")
        Dim kode_barang As String = Ckode_barang.SelectedValue
        Dim penjualan As DataTable
        penjualan = Aplikasi.Db.JalankanDanAmbilData("SELECT IFNULL(SUM(detail_penjualan.jumlah), 0) AS jumlah FROM detail_penjualan JOIN penjualan ON detail_penjualan.no_nota = penjualan.no_nota WHERE LEFT(penjualan.tgl_jual, 7) = '" & bulan & "' AND detail_penjualan.kode_barang = '" & kode_barang & "'")
        Tjml_kebutuhan.Text = penjualan.Rows(0).Item("jumlah")
        Thari.Text = Val(penjualan.Rows(0).Item("jumlah")) / 30
    End Sub
    Private Sub EventAmbilJumlahKebutuhan(ByVal sender As Object, ByVal e As EventArgs) Handles Twaktu.ValueChanged
        AmbilJumlahKebutuhan()
    End Sub

    Private Sub AksiHitungEoq(sender As Object, e As EventArgs) Handles Button4.Click
        HitungEoq()
        HitungRop()
    End Sub

    Private Sub AksiTampilDetailBarang(sender As Object, e As EventArgs) Handles Ckode_barang.SelectionChangeCommitted
        TampilDetailBarang()
    End Sub

    Private Sub AmbilDataEoq()
        DGeoq.Rows.Clear()
        DGeoq.DataSource = Nothing
        Dim data_eoq As DataTable = Aplikasi.Db.JalankanDanAmbilData("SELECT eoq.*, barang.nama_barang, barang.stock FROM eoq JOIN barang ON eoq.kode_barang = barang.kode_barang")
        Dim nomor As Int16 = 1
        For Each row As DataRow In data_eoq.Rows
            DGeoq.Rows.Add(New String() {
            nomor.ToString,
            row.Item("kode_eoq"),
            row.Item("kode_barang"),
            row.Item("nama_barang"),
            row.Item("biaya_pesan"),
            row.Item("biaya_simpan"),
            row.Item("jml_kebutuhan"),
            row.Item("jml_eoq"),
            row.Item("frekuensi")
            })
            nomor += 1
        Next row
    End Sub

    Private Sub AksiHapusEoq(sender As Object, e As EventArgs) Handles Button2.Click
        Dim kode_eoq As String = DGeoq.Rows(DGeoq.CurrentRow.Index).Cells("kode_eoq").Value
        Aplikasi.Db.JalankanSql("DELETE FROM eoq WHERE kode_eoq = '" & kode_eoq & "'")
        If Aplikasi.Db.ApakahError = True Then
            MessageBox.Show("Error " & Aplikasi.Db.AmbilPesanError)
        Else
            MessageBox.Show("Data berhasil disimpan!")
            AmbilDataEoq()
        End If
    End Sub

    Private Sub AksiSimpanEoq(sender As Object, e As EventArgs) Handles Bsimpan.Click
        Dim kode_eoq As String = Tkode_eoq.Text
        Dim kode_barang As String = Ckode_barang.SelectedValue
        Dim biaya_pesan As String = Tbiaya_pesan.Text
        Dim biaya_simpan As String = Tbiaya_simpan.Text
        Dim jml_kebutuhan As String = Tjml_kebutuhan.Text
        Dim jml_eoq As String = Teoq.Text
        Dim frekuensi As String = Trop.Text
        Dim sql As String = "INSERT INTO eoq VALUES ('" & kode_eoq & "', '" & kode_barang & "','" & biaya_pesan & "', '" & biaya_simpan & "', '" & jml_kebutuhan & "', '" & jml_eoq & "','" & frekuensi & "')"
        Aplikasi.Db.JalankanSql(sql)
        If Aplikasi.Db.AmbilPesanError = True Then
            MessageBox.Show("Error " & Aplikasi.Db.AmbilPesanError)
        Else
            MessageBox.Show("Data berhasil disimpan!")
            ResetForm()
            AmbilDataEoq()
        End If
    End Sub


End Class
