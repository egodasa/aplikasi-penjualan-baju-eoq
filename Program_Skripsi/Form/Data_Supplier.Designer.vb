<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_Supplier
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
        Me.DGsupplier = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode_supplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_supplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nohp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Bsimpan = New System.Windows.Forms.Button()
        Me.Tnohp = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Talamat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Tnama_supplier = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tkode_supplier = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGsupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGsupplier
        '
        Me.DGsupplier.AllowUserToAddRows = False
        Me.DGsupplier.AllowUserToDeleteRows = False
        Me.DGsupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGsupplier.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.kode_supplier, Me.nama_supplier, Me.nohp, Me.alamat})
        Me.DGsupplier.Location = New System.Drawing.Point(13, 312)
        Me.DGsupplier.Name = "DGsupplier"
        Me.DGsupplier.ReadOnly = True
        Me.DGsupplier.Size = New System.Drawing.Size(555, 150)
        Me.DGsupplier.TabIndex = 38
        '
        'no
        '
        Me.no.HeaderText = "No"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        '
        'kode_supplier
        '
        Me.kode_supplier.HeaderText = "Kode Supplier"
        Me.kode_supplier.Name = "kode_supplier"
        Me.kode_supplier.ReadOnly = True
        '
        'nama_supplier
        '
        Me.nama_supplier.HeaderText = "nama_supplier"
        Me.nama_supplier.Name = "nama_supplier"
        Me.nama_supplier.ReadOnly = True
        '
        'nohp
        '
        Me.nohp.HeaderText = "NOHP"
        Me.nohp.Name = "nohp"
        Me.nohp.ReadOnly = True
        '
        'alamat
        '
        Me.alamat.HeaderText = "Alamat"
        Me.alamat.Name = "alamat"
        Me.alamat.ReadOnly = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(443, 266)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 23)
        Me.Button3.TabIndex = 37
        Me.Button3.Text = "KELUAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(298, 266)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 23)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "HAPUS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(157, 266)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 23)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "EDIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Bsimpan
        '
        Me.Bsimpan.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bsimpan.Location = New System.Drawing.Point(13, 266)
        Me.Bsimpan.Name = "Bsimpan"
        Me.Bsimpan.Size = New System.Drawing.Size(125, 23)
        Me.Bsimpan.TabIndex = 34
        Me.Bsimpan.Text = "SIMPAN"
        Me.Bsimpan.UseVisualStyleBackColor = True
        '
        'Tnohp
        '
        Me.Tnohp.Location = New System.Drawing.Point(112, 226)
        Me.Tnohp.Name = "Tnohp"
        Me.Tnohp.Size = New System.Drawing.Size(170, 20)
        Me.Tnohp.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 17)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "No Telphone"
        '
        'Talamat
        '
        Me.Talamat.Location = New System.Drawing.Point(316, 181)
        Me.Talamat.Multiline = True
        Me.Talamat.Name = "Talamat"
        Me.Talamat.Size = New System.Drawing.Size(252, 65)
        Me.Talamat.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(313, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Alamat"
        '
        'Tnama_supplier
        '
        Me.Tnama_supplier.Location = New System.Drawing.Point(112, 193)
        Me.Tnama_supplier.Name = "Tnama_supplier"
        Me.Tnama_supplier.Size = New System.Drawing.Size(170, 20)
        Me.Tnama_supplier.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 17)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Nama Supplier"
        '
        'Tkode_supplier
        '
        Me.Tkode_supplier.Location = New System.Drawing.Point(112, 161)
        Me.Tkode_supplier.Name = "Tkode_supplier"
        Me.Tkode_supplier.Size = New System.Drawing.Size(170, 20)
        Me.Tkode_supplier.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 17)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Kode Supplier"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(197, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(226, 28)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "INPUT DATA SUPPLIER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(107, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(420, 28)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Hp. 0812 1904 1567 - Hp. 0852 6983 4202"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(98, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(439, 28)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Desa Karya Mulya Jl.Lintas Bengkulu-Padang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(139, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 54)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Toko Ririn Busana"
        '
        'Data_Supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.DGsupplier)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Bsimpan)
        Me.Controls.Add(Me.Tnohp)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Talamat)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Tnama_supplier)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Tkode_supplier)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Data_Supplier"
        Me.Size = New System.Drawing.Size(591, 487)
        CType(Me.DGsupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGsupplier As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Bsimpan As Button
    Friend WithEvents Tnohp As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Talamat As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Tnama_supplier As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Tkode_supplier As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents kode_supplier As DataGridViewTextBoxColumn
    Friend WithEvents nama_supplier As DataGridViewTextBoxColumn
    Friend WithEvents nohp As DataGridViewTextBoxColumn
    Friend WithEvents alamat As DataGridViewTextBoxColumn
End Class
