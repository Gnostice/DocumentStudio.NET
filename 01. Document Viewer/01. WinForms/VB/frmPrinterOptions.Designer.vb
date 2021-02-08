<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrinterOptions
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
        Me.chkLandscape = New System.Windows.Forms.CheckBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.cbPagePosition = New System.Windows.Forms.ComboBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.cbPageSize = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.cbPages = New System.Windows.Forms.ComboBox()
        Me.button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chkLandscape
        '
        Me.chkLandscape.AutoSize = True
        Me.chkLandscape.Location = New System.Drawing.Point(164, 111)
        Me.chkLandscape.Name = "chkLandscape"
        Me.chkLandscape.Size = New System.Drawing.Size(79, 17)
        Me.chkLandscape.TabIndex = 18
        Me.chkLandscape.Text = "Landscape"
        Me.chkLandscape.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(11, 78)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(89, 13)
        Me.label3.TabIndex = 17
        Me.label3.Text = "Page Positioning:"
        '
        'cbPagePosition
        '
        Me.cbPagePosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPagePosition.FormattingEnabled = True
        Me.cbPagePosition.Items.AddRange(New Object() {"Original Position", "Centered"})
        Me.cbPagePosition.Location = New System.Drawing.Point(105, 75)
        Me.cbPagePosition.Name = "cbPagePosition"
        Me.cbPagePosition.Size = New System.Drawing.Size(138, 21)
        Me.cbPagePosition.TabIndex = 16
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(11, 47)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(66, 13)
        Me.label2.TabIndex = 15
        Me.label2.Text = "Page Sizing:"
        '
        'cbPageSize
        '
        Me.cbPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPageSize.FormattingEnabled = True
        Me.cbPageSize.Items.AddRange(New Object() {"Original Size", "Fit", "Shrink Oversized Pages"})
        Me.cbPageSize.Location = New System.Drawing.Point(105, 44)
        Me.cbPageSize.Name = "cbPageSize"
        Me.cbPageSize.Size = New System.Drawing.Size(138, 21)
        Me.cbPageSize.TabIndex = 14
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(11, 17)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(40, 13)
        Me.label1.TabIndex = 13
        Me.label1.Text = "Pages:"
        '
        'cbPages
        '
        Me.cbPages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPages.FormattingEnabled = True
        Me.cbPages.Items.AddRange(New Object() {"All Pages", "Current Page"})
        Me.cbPages.Location = New System.Drawing.Point(105, 14)
        Me.cbPages.Name = "cbPages"
        Me.cbPages.Size = New System.Drawing.Size(138, 21)
        Me.cbPages.TabIndex = 12
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(168, 156)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 23)
        Me.button2.TabIndex = 11
        Me.button2.Text = "OK"
        Me.button2.UseVisualStyleBackColor = True
        '
        'frmPrinterOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 195)
        Me.Controls.Add(Me.chkLandscape)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.cbPagePosition)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.cbPageSize)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.cbPages)
        Me.Controls.Add(Me.button2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrinterOptions"
        Me.Text = "Print Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents chkLandscape As System.Windows.Forms.CheckBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents cbPagePosition As System.Windows.Forms.ComboBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents cbPageSize As System.Windows.Forms.ComboBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents cbPages As System.Windows.Forms.ComboBox
    Private WithEvents button2 As System.Windows.Forms.Button
End Class
