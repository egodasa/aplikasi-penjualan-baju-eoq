<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aplikasi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Tpassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tusername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Breset = New System.Windows.Forms.Button()
        Me.Bsimpan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Tpassword
        '
        Me.Tpassword.Location = New System.Drawing.Point(202, 250)
        Me.Tpassword.Name = "Tpassword"
        Me.Tpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Tpassword.Size = New System.Drawing.Size(190, 20)
        Me.Tpassword.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(202, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password"
        '
        'Tusername
        '
        Me.Tusername.Location = New System.Drawing.Point(202, 201)
        Me.Tusername.Name = "Tusername"
        Me.Tusername.Size = New System.Drawing.Size(190, 20)
        Me.Tusername.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(199, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Username"
        '
        'Breset
        '
        Me.Breset.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Breset.Location = New System.Drawing.Point(202, 286)
        Me.Breset.Name = "Breset"
        Me.Breset.Size = New System.Drawing.Size(75, 23)
        Me.Breset.TabIndex = 16
        Me.Breset.Text = "Keluar"
        Me.Breset.UseVisualStyleBackColor = True
        '
        'Bsimpan
        '
        Me.Bsimpan.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bsimpan.Location = New System.Drawing.Point(317, 286)
        Me.Bsimpan.Name = "Bsimpan"
        Me.Bsimpan.Size = New System.Drawing.Size(75, 23)
        Me.Bsimpan.TabIndex = 15
        Me.Bsimpan.Text = "Login"
        Me.Bsimpan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(184, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 28)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Telp. 0821 6936 5792"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(38, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(551, 28)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Simpang Bypass Lampu Merah, Lubuk Begalung, Padang "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(80, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(440, 54)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Toko Eman Jati Jepara"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(232, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 21)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "LOGIN APLIKASI"
        '
        'Aplikasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(611, 348)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Breset)
        Me.Controls.Add(Me.Bsimpan)
        Me.Controls.Add(Me.Tpassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Tusername)
        Me.Controls.Add(Me.Label4)
        Me.MaximumSize = New System.Drawing.Size(1000, 1000)
        Me.Name = "Aplikasi"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tpassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Tusername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Breset As Button
    Friend WithEvents Bsimpan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
