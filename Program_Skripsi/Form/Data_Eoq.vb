Public Class Data_Eoq
    Dim data_barang As DataTable
    Public Sub BukaForm()
        data_barang = Aplikasi.Db.JalankanDanAmbilData("SELECT * FROM barang")
    End Sub
    Public Sub ResetForm()

    End Sub
End Class
