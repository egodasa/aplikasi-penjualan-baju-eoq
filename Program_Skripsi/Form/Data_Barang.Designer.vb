<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_Barang
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
        Me.Tsatuan = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Tleadtime = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DGbarang = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.biaya_pesan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.biaya_simpan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jml_kebutuhan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.leadtime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock_cadangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.satuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Bsimpan = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Tnama_barang = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tkode_barang = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tbiaya_pesan = New System.Windows.Forms.NumericUpDown()
        Me.Tbiaya_simpan = New System.Windows.Forms.NumericUpDown()
        Me.Tjml_kebutuhan = New System.Windows.Forms.NumericUpDown()
        Me.Tharga_barang = New System.Windows.Forms.NumericUpDown()
        Me.Tstock = New System.Windows.Forms.NumericUpDown()
        Me.Tcadangan = New System.Windows.Forms.NumericUpDown()
        CType(Me.DGbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbiaya_pesan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbiaya_simpan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tjml_kebutuhan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tharga_barang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tstock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tcadangan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tsatuan
        '
        Me.Tsatuan.Location = New System.Drawing.Point(433, 283)
        Me.Tsatuan.Name = "Tsatuan"
        Me.Tsatuan.Size = New System.Drawing.Size(170, 20)
        Me.Tsatuan.TabIndex = 67
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(306, 283)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 17)
        Me.Label15.TabIndex = 66
        Me.Label15.Text = "Satuan"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(20, 283)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 17)
        Me.Label14.TabIndex = 64
        Me.Label14.Text = "Cadangan"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(20, 255)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 17)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "Stock Barang"
        '
        'Tleadtime
        '
        Me.Tleadtime.Location = New System.Drawing.Point(433, 255)
        Me.Tleadtime.Name = "Tleadtime"
        Me.Tleadtime.Size = New System.Drawing.Size(170, 20)
        Me.Tleadtime.TabIndex = 61
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(306, 255)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 17)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "Leadtime"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(553, 226)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 17)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "/Tahun"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(306, 226)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 17)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Jumlah Kebutuhan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(306, 193)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 17)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Biaya Simpan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(306, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 17)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Biaya Pesan"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(515, 439)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 62)
        Me.Button4.TabIndex = 52
        Me.Button4.Text = "CETAK"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DGbarang
        '
        Me.DGbarang.AllowUserToAddRows = False
        Me.DGbarang.AllowUserToDeleteRows = False
        Me.DGbarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGbarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.kode_barang, Me.nama_barang, Me.harga_barang, Me.stock, Me.biaya_pesan, Me.biaya_simpan, Me.jml_kebutuhan, Me.leadtime, Me.stock_cadangan, Me.satuan})
        Me.DGbarang.Location = New System.Drawing.Point(23, 351)
        Me.DGbarang.Name = "DGbarang"
        Me.DGbarang.ReadOnly = True
        Me.DGbarang.Size = New System.Drawing.Size(486, 150)
        Me.DGbarang.TabIndex = 51
        '
        'no
        '
        Me.no.HeaderText = "No"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
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
        'harga_barang
        '
        Me.harga_barang.HeaderText = "Harga Barang"
        Me.harga_barang.Name = "harga_barang"
        Me.harga_barang.ReadOnly = True
        '
        'stock
        '
        Me.stock.HeaderText = "Stock"
        Me.stock.Name = "stock"
        Me.stock.ReadOnly = True
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
        'leadtime
        '
        Me.leadtime.HeaderText = "Leadtime"
        Me.leadtime.Name = "leadtime"
        Me.leadtime.ReadOnly = True
        '
        'stock_cadangan
        '
        Me.stock_cadangan.HeaderText = "Stock Cadangan"
        Me.stock_cadangan.Name = "stock_cadangan"
        Me.stock_cadangan.ReadOnly = True
        '
        'satuan
        '
        Me.satuan.HeaderText = "Satuan"
        Me.satuan.Name = "satuan"
        Me.satuan.ReadOnly = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(453, 313)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 23)
        Me.Button3.TabIndex = 50
        Me.Button3.Text = "KELUAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(308, 313)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 23)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "HAPUS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(167, 313)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 23)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "EDIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Bsimpan
        '
        Me.Bsimpan.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bsimpan.Location = New System.Drawing.Point(23, 313)
        Me.Bsimpan.Name = "Bsimpan"
        Me.Bsimpan.Size = New System.Drawing.Size(125, 23)
        Me.Bsimpan.TabIndex = 47
        Me.Bsimpan.Text = "SIMPAN"
        Me.Bsimpan.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 17)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Harga Barang"
        '
        'Tnama_barang
        '
        Me.Tnama_barang.Location = New System.Drawing.Point(122, 193)
        Me.Tnama_barang.Name = "Tnama_barang"
        Me.Tnama_barang.Size = New System.Drawing.Size(170, 20)
        Me.Tnama_barang.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 17)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Nama Barang"
        '
        'Tkode_barang
        '
        Me.Tkode_barang.Location = New System.Drawing.Point(122, 161)
        Me.Tkode_barang.Name = "Tkode_barang"
        Me.Tkode_barang.Size = New System.Drawing.Size(170, 20)
        Me.Tkode_barang.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 17)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Kode Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(207, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 28)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "INPUT DATA BARANG"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(117, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(420, 28)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Hp. 0812 1904 1567 - Hp. 0852 6983 4202"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(108, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(439, 28)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Desa Karya Mulya Jl.Lintas Bengkulu-Padang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(149, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 54)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Toko Ririn Busana"
        '
        'Tbiaya_pesan
        '
        Me.Tbiaya_pesan.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.Tbiaya_pesan.InterceptArrowKeys = False
        Me.Tbiaya_pesan.Location = New System.Drawing.Point(433, 160)
        Me.Tbiaya_pesan.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.Tbiaya_pesan.Name = "Tbiaya_pesan"
        Me.Tbiaya_pesan.Size = New System.Drawing.Size(170, 20)
        Me.Tbiaya_pesan.TabIndex = 68
        '
        'Tbiaya_simpan
        '
        Me.Tbiaya_simpan.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.Tbiaya_simpan.InterceptArrowKeys = False
        Me.Tbiaya_simpan.Location = New System.Drawing.Point(433, 193)
        Me.Tbiaya_simpan.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.Tbiaya_simpan.Name = "Tbiaya_simpan"
        Me.Tbiaya_simpan.Size = New System.Drawing.Size(170, 20)
        Me.Tbiaya_simpan.TabIndex = 69
        '
        'Tjml_kebutuhan
        '
        Me.Tjml_kebutuhan.Location = New System.Drawing.Point(434, 226)
        Me.Tjml_kebutuhan.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.Tjml_kebutuhan.Name = "Tjml_kebutuhan"
        Me.Tjml_kebutuhan.Size = New System.Drawing.Size(113, 20)
        Me.Tjml_kebutuhan.TabIndex = 70
        '
        'Tharga_barang
        '
        Me.Tharga_barang.Location = New System.Drawing.Point(122, 226)
        Me.Tharga_barang.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.Tharga_barang.Name = "Tharga_barang"
        Me.Tharga_barang.Size = New System.Drawing.Size(170, 20)
        Me.Tharga_barang.TabIndex = 71
        '
        'Tstock
        '
        Me.Tstock.Location = New System.Drawing.Point(122, 255)
        Me.Tstock.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.Tstock.Name = "Tstock"
        Me.Tstock.Size = New System.Drawing.Size(170, 20)
        Me.Tstock.TabIndex = 72
        '
        'Tcadangan
        '
        Me.Tcadangan.Location = New System.Drawing.Point(122, 284)
        Me.Tcadangan.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.Tcadangan.Name = "Tcadangan"
        Me.Tcadangan.Size = New System.Drawing.Size(170, 20)
        Me.Tcadangan.TabIndex = 73
        '
        'Data_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.Tcadangan)
        Me.Controls.Add(Me.Tstock)
        Me.Controls.Add(Me.Tharga_barang)
        Me.Controls.Add(Me.Tjml_kebutuhan)
        Me.Controls.Add(Me.Tbiaya_simpan)
        Me.Controls.Add(Me.Tbiaya_pesan)
        Me.Controls.Add(Me.Tsatuan)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Tleadtime)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DGbarang)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Bsimpan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Tnama_barang)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Tkode_barang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Data_Barang"
        Me.Size = New System.Drawing.Size(623, 515)
        CType(Me.DGbarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbiaya_pesan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbiaya_simpan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tjml_kebutuhan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tharga_barang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tstock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tcadangan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tsatuan As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Tleadtime As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents DGbarang As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Bsimpan As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Tnama_barang As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Tkode_barang As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Tbiaya_pesan As NumericUpDown
    Friend WithEvents Tbiaya_simpan As NumericUpDown
    Friend WithEvents Tjml_kebutuhan As NumericUpDown
    Friend WithEvents Tharga_barang As NumericUpDown
    Friend WithEvents Tstock As NumericUpDown
    Friend WithEvents Tcadangan As NumericUpDown
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents kode_barang As DataGridViewTextBoxColumn
    Friend WithEvents nama_barang As DataGridViewTextBoxColumn
    Friend WithEvents harga_barang As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
    Friend WithEvents biaya_pesan As DataGridViewTextBoxColumn
    Friend WithEvents biaya_simpan As DataGridViewTextBoxColumn
    Friend WithEvents jml_kebutuhan As DataGridViewTextBoxColumn
    Friend WithEvents leadtime As DataGridViewTextBoxColumn
    Friend WithEvents stock_cadangan As DataGridViewTextBoxColumn
    Friend WithEvents satuan As DataGridViewTextBoxColumn
End Class
