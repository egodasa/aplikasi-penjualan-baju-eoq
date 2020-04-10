<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_Pengguna
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
        Me.DGpengguna = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGid_pengguna = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.level = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nohp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Bsimpan = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Tpassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tusername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Clevel = New System.Windows.Forms.ComboBox()
        Me.Tnohp = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Talamat = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DGpengguna, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGpengguna
        '
        Me.DGpengguna.AllowUserToAddRows = False
        Me.DGpengguna.AllowUserToDeleteRows = False
        Me.DGpengguna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGpengguna.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.DGid_pengguna, Me.username, Me.password, Me.level, Me.nohp, Me.alamat})
        Me.DGpengguna.Location = New System.Drawing.Point(41, 336)
        Me.DGpengguna.Name = "DGpengguna"
        Me.DGpengguna.ReadOnly = True
        Me.DGpengguna.Size = New System.Drawing.Size(555, 150)
        Me.DGpengguna.TabIndex = 55
        '
        'no
        '
        Me.no.HeaderText = "No"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        '
        'DGid_pengguna
        '
        Me.DGid_pengguna.HeaderText = "id_pengguna"
        Me.DGid_pengguna.Name = "DGid_pengguna"
        Me.DGid_pengguna.ReadOnly = True
        Me.DGid_pengguna.Visible = False
        '
        'username
        '
        Me.username.HeaderText = "Username"
        Me.username.Name = "username"
        Me.username.ReadOnly = True
        '
        'password
        '
        Me.password.HeaderText = "password"
        Me.password.Name = "password"
        Me.password.ReadOnly = True
        Me.password.Visible = False
        '
        'level
        '
        Me.level.HeaderText = "Level"
        Me.level.Name = "level"
        Me.level.ReadOnly = True
        '
        'nohp
        '
        Me.nohp.HeaderText = "Nohp"
        Me.nohp.Name = "nohp"
        Me.nohp.ReadOnly = True
        '
        'alamat
        '
        Me.alamat.HeaderText = "Alamat"
        Me.alamat.Name = "alamat"
        Me.alamat.ReadOnly = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(326, 290)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 23)
        Me.Button2.TabIndex = 53
        Me.Button2.Text = "HAPUS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(185, 290)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 23)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "EDIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Bsimpan
        '
        Me.Bsimpan.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bsimpan.Location = New System.Drawing.Point(41, 290)
        Me.Bsimpan.Name = "Bsimpan"
        Me.Bsimpan.Size = New System.Drawing.Size(125, 23)
        Me.Bsimpan.TabIndex = 51
        Me.Bsimpan.Text = "SIMPAN"
        Me.Bsimpan.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(38, 250)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 17)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Level"
        '
        'Tpassword
        '
        Me.Tpassword.Location = New System.Drawing.Point(140, 217)
        Me.Tpassword.Name = "Tpassword"
        Me.Tpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Tpassword.Size = New System.Drawing.Size(170, 20)
        Me.Tpassword.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 17)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Password"
        '
        'Tusername
        '
        Me.Tusername.Location = New System.Drawing.Point(140, 185)
        Me.Tusername.Name = "Tusername"
        Me.Tusername.Size = New System.Drawing.Size(170, 20)
        Me.Tusername.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(208, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(248, 28)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "INPUT DATA PENGGUNA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(118, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(420, 28)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Hp. 0812 1904 1567 - Hp. 0852 6983 4202"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(109, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(439, 28)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Desa Karya Mulya Jl.Lintas Bengkulu-Padang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(522, 54)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Toko Eman Perabot Jepara"
        '
        'Clevel
        '
        Me.Clevel.FormattingEnabled = True
        Me.Clevel.Location = New System.Drawing.Point(140, 250)
        Me.Clevel.Name = "Clevel"
        Me.Clevel.Size = New System.Drawing.Size(170, 21)
        Me.Clevel.TabIndex = 56
        '
        'Tnohp
        '
        Me.Tnohp.Location = New System.Drawing.Point(397, 185)
        Me.Tnohp.Name = "Tnohp"
        Me.Tnohp.Size = New System.Drawing.Size(199, 20)
        Me.Tnohp.TabIndex = 58
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(324, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 17)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Nohp"
        '
        'Talamat
        '
        Me.Talamat.Location = New System.Drawing.Point(397, 217)
        Me.Talamat.Multiline = True
        Me.Talamat.Name = "Talamat"
        Me.Talamat.Size = New System.Drawing.Size(199, 54)
        Me.Talamat.TabIndex = 60
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(324, 217)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 17)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Alamat"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(471, 290)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 23)
        Me.Button3.TabIndex = 54
        Me.Button3.Text = "KELUAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Data_Pengguna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.Controls.Add(Me.Talamat)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Tnohp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Clevel)
        Me.Controls.Add(Me.DGpengguna)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Bsimpan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Tpassword)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Tusername)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Data_Pengguna"
        Me.Size = New System.Drawing.Size(633, 515)
        CType(Me.DGpengguna, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGpengguna As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Bsimpan As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Tpassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Tusername As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Clevel As ComboBox
    Friend WithEvents Tnohp As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Talamat As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents DGid_pengguna As DataGridViewTextBoxColumn
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents password As DataGridViewTextBoxColumn
    Friend WithEvents level As DataGridViewTextBoxColumn
    Friend WithEvents nohp As DataGridViewTextBoxColumn
    Friend WithEvents alamat As DataGridViewTextBoxColumn
End Class
