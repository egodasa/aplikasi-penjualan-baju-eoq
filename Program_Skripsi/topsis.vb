Public Class topsis
    Public Sub Hitung()
        Dim hasil As New DataTable
        hasil.Columns.Add("nm_member", GetType(String))
        hasil.Columns.Add("hasil", GetType(Decimal))

        Dim db As New Db()
        Dim data_r As DataTable = db.JalankanDanAmbilData("SELECT 
nm_member, 
(c1 / (select SQRT(SUM(c1*c1)) AS normalisasi_c1 FROM tb_perhitungan)) * 5 AS c1,
(c2 / (select SQRT(SUM(c2*c2)) AS normalisasi_c2 FROM tb_perhitungan)) * 3 AS c2,
(c3 / (select SQRT(SUM(c3*c3)) AS normalisasi_c3 FROM tb_perhitungan)) * 4 AS c3,
(c4 / (select SQRT(SUM(c4*c4)) AS normalisasi_c4 FROM tb_perhitungan)) * 5 AS c4,
(c5 / (select SQRT(SUM(c5*c5)) AS normalisasi_c5 FROM tb_perhitungan)) * 5 AS c5,
(c6 / (select SQRT(SUM(c6*c6)) AS normalisasi_c6 FROM tb_perhitungan)) * 5 AS c6,
(c7 / (select SQRT(SUM(c7*c7)) AS normalisasi_c7 FROM tb_perhitungan)) * 5 AS c7
 FROM tb_perhitungan")

        Dim matriks_ideal As DataTable = db.JalankanDanAmbilData("SELECT 
(MAX(hasil.c1)) AS y_plus_c1,
(MIN(hasil.c1)) AS y_minus_c1,
(MAX(hasil.c2)) AS y_plus_c2,
(MIN(hasil.c2)) AS y_minus_c2,
(MAX(hasil.c3)) AS y_plus_c3,
(MIN(hasil.c3)) AS y_minus_c3,
(MAX(hasil.c4)) AS y_plus_c4,
(MIN(hasil.c4)) AS y_minus_c4,
(MAX(hasil.c5)) AS y_plus_c5,
(MIN(hasil.c5)) AS y_minus_c5,
(MAX(hasil.c6)) AS y_plus_c6,
(MIN(hasil.c6)) AS y_minus_c6,
(MAX(hasil.c7)) AS y_plus_c7,
(MIN(hasil.c7)) AS y_minus_c7 
FROM (SELECT 
nm_member, 
(c1 / (select SQRT(SUM(c1*c1)) AS normalisasi_c1 FROM tb_perhitungan)) * 5 AS c1,
(c2 / (select SQRT(SUM(c2*c2)) AS normalisasi_c2 FROM tb_perhitungan)) * 3 AS c2,
(c3 / (select SQRT(SUM(c3*c3)) AS normalisasi_c3 FROM tb_perhitungan)) * 4 AS c3,
(c4 / (select SQRT(SUM(c4*c4)) AS normalisasi_c4 FROM tb_perhitungan)) * 5 AS c4,
(c5 / (select SQRT(SUM(c5*c5)) AS normalisasi_c5 FROM tb_perhitungan)) * 5 AS c5,
(c6 / (select SQRT(SUM(c6*c6)) AS normalisasi_c6 FROM tb_perhitungan)) * 5 AS c6,
(c7 / (select SQRT(SUM(c7*c7)) AS normalisasi_c7 FROM tb_perhitungan)) * 5 AS c7 
FROM tb_perhitungan) hasil")

        Dim jarak_ideal_plus As DataTable = db.JalankanDanAmbilData("SELECT 
nm_member,
sqrt(pow((((c1 / (select SQRT(SUM(c1*c1)) AS normalisasi_c1 FROM tb_perhitungan)) * 5) - " & matriks_ideal.Rows(0).Item("y_plus_c1") & "),2) +
pow((((c2 / (select SQRT(SUM(c2*c2)) AS normalisasi_c2 FROM tb_perhitungan)) * 3) - " & matriks_ideal.Rows(0).Item("y_plus_c2") & "),2) +
pow((((c3 / (select SQRT(SUM(c3*c3)) AS normalisasi_c3 FROM tb_perhitungan)) * 4) - " & matriks_ideal.Rows(0).Item("y_plus_c3") & "),2) +
pow((((c4 / (select SQRT(SUM(c4*c4)) AS normalisasi_c4 FROM tb_perhitungan)) * 5) - " & matriks_ideal.Rows(0).Item("y_plus_c4") & "),2) +
pow((((c5 / (select SQRT(SUM(c5*c5)) AS normalisasi_c5 FROM tb_perhitungan)) * 5) - " & matriks_ideal.Rows(0).Item("y_plus_c5") & "),2) +
pow((((c6 / (select SQRT(SUM(c6*c6)) AS normalisasi_c6 FROM tb_perhitungan)) * 5) - " & matriks_ideal.Rows(0).Item("y_plus_c6") & "),2) +
pow((((c7 / (select SQRT(SUM(c7*c7)) AS normalisasi_c7 FROM tb_perhitungan)) * 5) - " & matriks_ideal.Rows(0).Item("y_plus_c7") & "),2)) AS d
FROM tb_perhitungan")
        Console.WriteLine("JARAK IDEAL PLUS")
        Console.WriteLine("Nama Member           Nilai D+")

        For Each row As DataRow In jarak_ideal_plus.Rows
            Console.WriteLine(row.Item("nm_member") & " " & row.Item("d"))
        Next row

        Dim jarak_ideal_minus As DataTable = db.JalankanDanAmbilData("SELECT 
nm_member,
sqrt(pow((((c1 / (select SQRT(SUM(c1*c1)) AS normalisasi_c1 FROM tb_perhitungan)) * 5) - " & matriks_ideal.Rows(0).Item("y_minus_c1") & "),2) +
pow((((c2 / (select SQRT(SUM(c2*c2)) AS normalisasi_c2 FROM tb_perhitungan)) * 3) - " & matriks_ideal.Rows(0).Item("y_minus_c2") & "),2) +
pow((((c3 / (select SQRT(SUM(c3*c3)) AS normalisasi_c3 FROM tb_perhitungan)) * 4) - " & matriks_ideal.Rows(0).Item("y_minus_c3") & "),2) +
pow((((c4 / (select SQRT(SUM(c4*c4)) AS normalisasi_c4 FROM tb_perhitungan)) * 5) - " & matriks_ideal.Rows(0).Item("y_minus_c4") & "),2) +
pow((((c5 / (select SQRT(SUM(c5*c5)) AS normalisasi_c5 FROM tb_perhitungan)) * 5) - " & matriks_ideal.Rows(0).Item("y_minus_c5") & "),2) +
pow((((c6 / (select SQRT(SUM(c6*c6)) AS normalisasi_c6 FROM tb_perhitungan)) * 5) - " & matriks_ideal.Rows(0).Item("y_minus_c6") & "),2) +
pow((((c7 / (select SQRT(SUM(c7*c7)) AS normalisasi_c7 FROM tb_perhitungan)) * 5) - " & matriks_ideal.Rows(0).Item("y_minus_c7") & "),2)) AS d
FROM tb_perhitungan")
        Console.WriteLine("JARAK IDEAL MINUS")
        Console.WriteLine("Nama Member           Nilai D-")

        For Each row As DataRow In jarak_ideal_minus.Rows
            Console.WriteLine(row.Item("nm_member") & " " & row.Item("d"))
        Next row
        Dim d_plus As Decimal
        Dim d_minus As Decimal
        Dim d_hasil As Decimal
        For index As Integer = 0 To (jarak_ideal_minus.Rows.Count - 1)
            d_plus = jarak_ideal_plus.Rows(index).Item("d")
            d_minus = jarak_ideal_minus.Rows(index).Item("d")
            d_hasil = d_minus / (d_minus + d_plus)
            hasil.Rows.Add(jarak_ideal_minus.Rows(index).Item("nm_member"), d_hasil)
        Next

        Console.WriteLine("HASIL PERHITUNGAN")
        Console.WriteLine("Nama Member           Nilai")

        For Each row As DataRow In hasil.Rows
            db.JalankanSql("INSERT INTO tb_hasil (nm_peserta, nilai) VALUES ('" & row.Item("nm_member") & "', '" & row.Item("hasil") & "')")
            Console.WriteLine(row.Item("nm_member") & " " & row.Item("hasil"))
        Next row

        Console.ReadKey()
    End Sub


End Class
