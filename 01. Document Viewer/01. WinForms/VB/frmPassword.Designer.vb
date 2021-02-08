<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPassword
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
        Me.btncncl = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btncncl
        '
        Me.btncncl.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncncl.Location = New System.Drawing.Point(131, 49)
        Me.btncncl.Name = "btncncl"
        Me.btncncl.Size = New System.Drawing.Size(75, 23)
        Me.btncncl.TabIndex = 9
        Me.btncncl.Text = "Cancel"
        Me.btncncl.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Location = New System.Drawing.Point(14, 49)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 8
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(11, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(53, 13)
        Me.label1.TabIndex = 7
        Me.label1.Text = "Password"
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(70, 15)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.Size = New System.Drawing.Size(137, 20)
        Me.txtPwd.TabIndex = 6
        '
        'frmPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(225, 85)
        Me.Controls.Add(Me.btncncl)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.txtPwd)
        Me.MaximizeBox = False
        Me.Name = "frmPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btncncl As System.Windows.Forms.Button
    Private WithEvents btnOK As System.Windows.Forms.Button
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txtPwd As System.Windows.Forms.TextBox
End Class
