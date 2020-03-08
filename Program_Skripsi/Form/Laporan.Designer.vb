<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan
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
        Me.WBlaporan = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'WBlaporan
        '
        Me.WBlaporan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WBlaporan.Location = New System.Drawing.Point(0, 0)
        Me.WBlaporan.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WBlaporan.Name = "WBlaporan"
        Me.WBlaporan.Size = New System.Drawing.Size(692, 503)
        Me.WBlaporan.TabIndex = 0
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(692, 503)
        Me.WebBrowser1.TabIndex = 1
        '
        'Laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.WBlaporan)
        Me.Name = "Laporan"
        Me.Size = New System.Drawing.Size(692, 503)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WBlaporan As WebBrowser
    Friend WithEvents WebBrowser1 As WebBrowser
End Class
