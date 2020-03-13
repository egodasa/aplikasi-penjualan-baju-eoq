<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_Eoq
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Bsimpan = New System.Windows.Forms.Button()
        Me.Tnama_barang = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Trop = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Teoq = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DGeoq = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode_eoq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.biaya_pesan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.biaya_simpan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jml_kebutuhan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eoq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.frekuensi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Ckode_barang = New System.Windows.Forms.ComboBox()
        Me.Tkode_eoq = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Tjml_kebutuhan = New System.Windows.Forms.TextBox()
        Me.Twaktu = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Tbiaya_pesan = New System.Windows.Forms.TextBox()
        Me.Tbiaya_simpan = New System.Windows.Forms.TextBox()
        Me.Tstock_cadangan = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Tleadtime = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Thari = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        CType(Me.DGeoq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(33, 366)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 23)
        Me.Button2.TabIndex = 85
        Me.Button2.Text = "HAPUS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Bsimpan
        '
        Me.Bsimpan.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bsimpan.Location = New System.Drawing.Point(511, 366)
        Me.Bsimpan.Name = "Bsimpan"
        Me.Bsimpan.Size = New System.Drawing.Size(125, 23)
        Me.Bsimpan.TabIndex = 83
        Me.Bsimpan.Text = "SIMPAN"
        Me.Bsimpan.UseVisualStyleBackColor = True
        '
        'Tnama_barang
        '
        Me.Tnama_barang.Location = New System.Drawing.Point(145, 251)
        Me.Tnama_barang.Name = "Tnama_barang"
        Me.Tnama_barang.ReadOnly = True
        Me.Tnama_barang.Size = New System.Drawing.Size(162, 20)
        Me.Tnama_barang.TabIndex = 81
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 17)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Nama Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 17)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Kode Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(149, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(377, 28)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "PROSES ECONOMIC ORDER QUANTITY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(137, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(420, 28)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Hp. 0812 1904 1567 - Hp. 0852 6983 4202"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(128, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(439, 28)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Desa Karya Mulya Jl.Lintas Bengkulu-Padang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(169, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 54)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Toko Ririn Busana"
        '
        'Trop
        '
        Me.Trop.Location = New System.Drawing.Point(438, 335)
        Me.Trop.Name = "Trop"
        Me.Trop.Size = New System.Drawing.Size(198, 20)
        Me.Trop.TabIndex = 97
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(313, 334)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 17)
        Me.Label15.TabIndex = 96
        Me.Label15.Text = "Frekuensi"
        '
        'Teoq
        '
        Me.Teoq.Location = New System.Drawing.Point(438, 307)
        Me.Teoq.Name = "Teoq"
        Me.Teoq.Size = New System.Drawing.Size(198, 20)
        Me.Teoq.TabIndex = 93
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(313, 306)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 17)
        Me.Label12.TabIndex = 92
        Me.Label12.Text = "Jumlah EOQ"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(488, 247)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 17)
        Me.Label11.TabIndex = 91
        Me.Label11.Text = "/Bulan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(313, 247)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 17)
        Me.Label10.TabIndex = 90
        Me.Label10.Text = "Jumlah Kebutuhan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 310)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 17)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "Biaya Simpan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 278)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 17)
        Me.Label7.TabIndex = 88
        Me.Label7.Text = "Biaya Pesan"
        '
        'DGeoq
        '
        Me.DGeoq.AllowUserToAddRows = False
        Me.DGeoq.AllowUserToDeleteRows = False
        Me.DGeoq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGeoq.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.kode_eoq, Me.kode_barang, Me.nama_barang, Me.biaya_pesan, Me.biaya_simpan, Me.jml_kebutuhan, Me.eoq, Me.frekuensi})
        Me.DGeoq.Location = New System.Drawing.Point(32, 404)
        Me.DGeoq.Name = "DGeoq"
        Me.DGeoq.ReadOnly = True
        Me.DGeoq.Size = New System.Drawing.Size(604, 150)
        Me.DGeoq.TabIndex = 87
        '
        'no
        '
        Me.no.HeaderText = "No"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        '
        'kode_eoq
        '
        Me.kode_eoq.HeaderText = "Kode EOQ"
        Me.kode_eoq.Name = "kode_eoq"
        Me.kode_eoq.ReadOnly = True
        '
        'kode_barang
        '
        Me.kode_barang.HeaderText = "Kode Barang"
        Me.kode_barang.Name = "kode_barang"
        Me.kode_barang.ReadOnly = True
        '
        'nama_barang
        '
        Me.nama_barang.HeaderText = "Nama Barang"
        Me.nama_barang.Name = "nama_barang"
        Me.nama_barang.ReadOnly = True
        '
        'biaya_pesan
        '
        Me.biaya_pesan.HeaderText = "Biaya Pesan"
        Me.biaya_pesan.Name = "biaya_pesan"
        Me.biaya_pesan.ReadOnly = True
        '
        'biaya_simpan
        '
        Me.biaya_simpan.HeaderText = "Biaya Simpan"
        Me.biaya_simpan.Name = "biaya_simpan"
        Me.biaya_simpan.ReadOnly = True
        '
        'jml_kebutuhan
        '
        Me.jml_kebutuhan.HeaderText = "Jumlah Kebutuhan"
        Me.jml_kebutuhan.Name = "jml_kebutuhan"
        Me.jml_kebutuhan.ReadOnly = True
        '
        'eoq
        '
        Me.eoq.HeaderText = "Jumlah EOQ"
        Me.eoq.Name = "eoq"
        Me.eoq.ReadOnly = True
        '
        'frekuensi
        '
        Me.frekuensi.HeaderText = "Frekuensi"
        Me.frekuensi.Name = "frekuensi"
        Me.frekuensi.ReadOnly = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(511, 275)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(125, 25)
        Me.Button4.TabIndex = 101
        Me.Button4.Text = "HITUNG"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Ckode_barang
        '
        Me.Ckode_barang.FormattingEnabled = True
        Me.Ckode_barang.Location = New System.Drawing.Point(145, 219)
        Me.Ckode_barang.Name = "Ckode_barang"
        Me.Ckode_barang.Size = New System.Drawing.Size(162, 21)
        Me.Ckode_barang.TabIndex = 102
        '
        'Tkode_eoq
        '
        Me.Tkode_eoq.Location = New System.Drawing.Point(145, 190)
        Me.Tkode_eoq.Name = "Tkode_eoq"
        Me.Tkode_eoq.Size = New System.Drawing.Size(162, 20)
        Me.Tkode_eoq.TabIndex = 104
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 17)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "Kode EOQ"
        '
        'Tjml_kebutuhan
        '
        Me.Tjml_kebutuhan.Location = New System.Drawing.Point(437, 247)
        Me.Tjml_kebutuhan.Name = "Tjml_kebutuhan"
        Me.Tjml_kebutuhan.Size = New System.Drawing.Size(43, 20)
        Me.Tjml_kebutuhan.TabIndex = 105
        '
        'Twaktu
        '
        Me.Twaktu.CustomFormat = "MM yyyy"
        Me.Twaktu.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Twaktu.Location = New System.Drawing.Point(437, 219)
        Me.Twaktu.Name = "Twaktu"
        Me.Twaktu.Size = New System.Drawing.Size(199, 20)
        Me.Twaktu.TabIndex = 106
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(313, 219)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 17)
        Me.Label13.TabIndex = 107
        Me.Label13.Text = "Waktu Kebutuhan"
        '
        'Tbiaya_pesan
        '
        Me.Tbiaya_pesan.Location = New System.Drawing.Point(145, 279)
        Me.Tbiaya_pesan.Name = "Tbiaya_pesan"
        Me.Tbiaya_pesan.Size = New System.Drawing.Size(162, 20)
        Me.Tbiaya_pesan.TabIndex = 108
        '
        'Tbiaya_simpan
        '
        Me.Tbiaya_simpan.Location = New System.Drawing.Point(145, 308)
        Me.Tbiaya_simpan.Name = "Tbiaya_simpan"
        Me.Tbiaya_simpan.Size = New System.Drawing.Size(162, 20)
        Me.Tbiaya_simpan.TabIndex = 109
        '
        'Tstock_cadangan
        '
        Me.Tstock_cadangan.Location = New System.Drawing.Point(145, 335)
        Me.Tstock_cadangan.Name = "Tstock_cadangan"
        Me.Tstock_cadangan.Size = New System.Drawing.Size(162, 20)
        Me.Tstock_cadangan.TabIndex = 111
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(30, 337)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 17)
        Me.Label14.TabIndex = 110
        Me.Label14.Text = "Stock Cadangan"
        '
        'Tleadtime
        '
        Me.Tleadtime.Location = New System.Drawing.Point(438, 187)
        Me.Tleadtime.Name = "Tleadtime"
        Me.Tleadtime.Size = New System.Drawing.Size(198, 20)
        Me.Tleadtime.TabIndex = 113
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(313, 187)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 17)
        Me.Label16.TabIndex = 112
        Me.Label16.Text = "Leadtime"
        '
        'Thari
        '
        Me.Thari.Location = New System.Drawing.Point(538, 247)
        Me.Thari.Name = "Thari"
        Me.Thari.Size = New System.Drawing.Size(43, 20)
        Me.Thari.TabIndex = 115
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(589, 247)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(47, 17)
        Me.Label17.TabIndex = 114
        Me.Label17.Text = "/Bulan"
        '
        'Data_Eoq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.HotPink
        Me.Controls.Add(Me.Thari)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Tleadtime)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Tstock_cadangan)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Tbiaya_simpan)
        Me.Controls.Add(Me.Tbiaya_pesan)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Twaktu)
        Me.Controls.Add(Me.Tjml_kebutuhan)
        Me.Controls.Add(Me.Tkode_eoq)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Ckode_barang)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Bsimpan)
        Me.Controls.Add(Me.Tnama_barang)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Trop)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Teoq)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DGeoq)
        Me.Name = "Data_Eoq"
        Me.Size = New System.Drawing.Size(673, 579)
        CType(Me.DGeoq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Bsimpan As Button
    Friend WithEvents Tnama_barang As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Trop As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Teoq As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DGeoq As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents Ckode_barang As ComboBox
    Friend WithEvents Tkode_eoq As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents kode_eoq As DataGridViewTextBoxColumn
    Friend WithEvents kode_barang As DataGridViewTextBoxColumn
    Friend WithEvents nama_barang As DataGridViewTextBoxColumn
    Friend WithEvents biaya_pesan As DataGridViewTextBoxColumn
    Friend WithEvents biaya_simpan As DataGridViewTextBoxColumn
    Friend WithEvents jml_kebutuhan As DataGridViewTextBoxColumn
    Friend WithEvents eoq As DataGridViewTextBoxColumn
    Friend WithEvents frekuensi As DataGridViewTextBoxColumn
    Friend WithEvents Tjml_kebutuhan As TextBox
    Friend WithEvents Twaktu As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Tbiaya_pesan As TextBox
    Friend WithEvents Tbiaya_simpan As TextBox
    Friend WithEvents Tstock_cadangan As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Tleadtime As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Thari As TextBox
    Friend WithEvents Label17 As Label
End Class
