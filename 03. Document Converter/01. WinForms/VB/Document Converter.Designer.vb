<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Demo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Demo))
        Me.Input = New System.Windows.Forms.GroupBox()
        Me.lstBxInputDocList = New System.Windows.Forms.ListBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.Output = New System.Windows.Forms.GroupBox()
        Me.chkCreatePortfolio = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbConversionMode = New System.Windows.Forms.ComboBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtBxBaseFileName = New System.Windows.Forms.TextBox()
        Me.txtBxOutputFolder = New System.Windows.Forms.TextBox()
        Me.cmbBxOutputFormat = New System.Windows.Forms.ComboBox()
        Me.grpBxConvertion = New System.Windows.Forms.GroupBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.grpBxProgress = New System.Windows.Forms.GroupBox()
        Me.fileName = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.documents = New System.Windows.Forms.Label()
        Me.pages = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.prgsBrOverallProgress = New System.Windows.Forms.ProgressBar()
        Me.prgsBrPageProgress = New System.Windows.Forms.ProgressBar()
        Me.folderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.openFile = New System.Windows.Forms.OpenFileDialog()
        Me.Input.SuspendLayout()
        Me.Output.SuspendLayout()
        Me.grpBxConvertion.SuspendLayout()
        Me.grpBxProgress.SuspendLayout()
        Me.SuspendLayout()
        '
        'Input
        '
        Me.Input.Controls.Add(Me.lstBxInputDocList)
        Me.Input.Controls.Add(Me.label1)
        Me.Input.Controls.Add(Me.btnAdd)
        Me.Input.Controls.Add(Me.btnUp)
        Me.Input.Controls.Add(Me.btnDown)
        Me.Input.Controls.Add(Me.btnRemove)
        Me.Input.Location = New System.Drawing.Point(12, 12)
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(518, 195)
        Me.Input.TabIndex = 0
        Me.Input.TabStop = False
        Me.Input.Text = "Input:"
        '
        'lstBxInputDocList
        '
        Me.lstBxInputDocList.FormattingEnabled = True
        Me.lstBxInputDocList.Location = New System.Drawing.Point(7, 42)
        Me.lstBxInputDocList.Name = "lstBxInputDocList"
        Me.lstBxInputDocList.Size = New System.Drawing.Size(466, 147)
        Me.lstBxInputDocList.TabIndex = 2
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(6, 26)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(185, 13)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Ordered List of Documents to Convert"
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImage = Global.Document_Converter.My.Resources.Resources._1384536370_plus_32
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Green
        Me.btnAdd.Location = New System.Drawing.Point(479, 42)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(33, 32)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.BackgroundImage = Global.Document_Converter.My.Resources.Resources._1384536291_chevron_up
        Me.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUp.Enabled = False
        Me.btnUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUp.ForeColor = System.Drawing.Color.Green
        Me.btnUp.Location = New System.Drawing.Point(479, 118)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(33, 32)
        Me.btnUp.TabIndex = 3
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.BackgroundImage = Global.Document_Converter.My.Resources.Resources._1384536200_chevron_down
        Me.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDown.Enabled = False
        Me.btnDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDown.ForeColor = System.Drawing.Color.Green
        Me.btnDown.Location = New System.Drawing.Point(479, 156)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(33, 32)
        Me.btnDown.TabIndex = 4
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.BackgroundImage = Global.Document_Converter.My.Resources.Resources._1384536363_onebit_32
        Me.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRemove.Enabled = False
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.Red
        Me.btnRemove.Location = New System.Drawing.Point(479, 80)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(33, 32)
        Me.btnRemove.TabIndex = 1
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Output
        '
        Me.Output.Controls.Add(Me.chkCreatePortfolio)
        Me.Output.Controls.Add(Me.Label4)
        Me.Output.Controls.Add(Me.cmbConversionMode)
        Me.Output.Controls.Add(Me.label7)
        Me.Output.Controls.Add(Me.label6)
        Me.Output.Controls.Add(Me.label5)
        Me.Output.Controls.Add(Me.btnBrowse)
        Me.Output.Controls.Add(Me.txtBxBaseFileName)
        Me.Output.Controls.Add(Me.txtBxOutputFolder)
        Me.Output.Controls.Add(Me.cmbBxOutputFormat)
        Me.Output.Location = New System.Drawing.Point(12, 213)
        Me.Output.Name = "Output"
        Me.Output.Size = New System.Drawing.Size(517, 114)
        Me.Output.TabIndex = 1
        Me.Output.TabStop = False
        Me.Output.Text = "Output:"
        '
        'chkCreatePortfolio
        '
        Me.chkCreatePortfolio.AutoSize = True
        Me.chkCreatePortfolio.Checked = True
        Me.chkCreatePortfolio.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCreatePortfolio.Location = New System.Drawing.Point(414, 36)
        Me.chkCreatePortfolio.Name = "chkCreatePortfolio"
        Me.chkCreatePortfolio.Size = New System.Drawing.Size(98, 17)
        Me.chkCreatePortfolio.TabIndex = 7
        Me.chkCreatePortfolio.Text = "Create Portfolio"
        Me.chkCreatePortfolio.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(238, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Conversion Mode"
        '
        'cmbConversionMode
        '
        Me.cmbConversionMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbConversionMode.FormattingEnabled = True
        Me.cmbConversionMode.Items.AddRange(New Object() {"Convert To Single File", "Convert To Seperate Files", "Convert First File And Attach Rest As Original", "Create New File And Attach All As Original"})
        Me.cmbConversionMode.Location = New System.Drawing.Point(241, 33)
        Me.cmbConversionMode.Name = "cmbConversionMode"
        Me.cmbConversionMode.Size = New System.Drawing.Size(167, 21)
        Me.cmbConversionMode.TabIndex = 5
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(6, 69)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(71, 13)
        Me.label7.TabIndex = 4
        Me.label7.Text = "Output Folder"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(130, 17)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(81, 13)
        Me.label6.TabIndex = 3
        Me.label6.Text = "Base File Name"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(3, 18)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(39, 13)
        Me.label5.TabIndex = 2
        Me.label5.Text = "Format"
        '
        'btnBrowse
        '
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.Green
        Me.btnBrowse.Location = New System.Drawing.Point(478, 85)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(33, 20)
        Me.btnBrowse.TabIndex = 3
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtBxBaseFileName
        '
        Me.txtBxBaseFileName.Location = New System.Drawing.Point(133, 34)
        Me.txtBxBaseFileName.Name = "txtBxBaseFileName"
        Me.txtBxBaseFileName.Size = New System.Drawing.Size(102, 20)
        Me.txtBxBaseFileName.TabIndex = 1
        '
        'txtBxOutputFolder
        '
        Me.txtBxOutputFolder.Location = New System.Drawing.Point(6, 85)
        Me.txtBxOutputFolder.Name = "txtBxOutputFolder"
        Me.txtBxOutputFolder.Size = New System.Drawing.Size(467, 20)
        Me.txtBxOutputFolder.TabIndex = 4
        '
        'cmbBxOutputFormat
        '
        Me.cmbBxOutputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBxOutputFormat.FormattingEnabled = True
        Me.cmbBxOutputFormat.Items.AddRange(New Object() {"PDF", "DOCX", "RTF", "BMP", "JPEG", "PNG", "TIFF Single Page", "TIFF Multipage", "TXT", "HTML"})
        Me.cmbBxOutputFormat.Location = New System.Drawing.Point(6, 33)
        Me.cmbBxOutputFormat.Name = "cmbBxOutputFormat"
        Me.cmbBxOutputFormat.Size = New System.Drawing.Size(121, 21)
        Me.cmbBxOutputFormat.TabIndex = 0
        '
        'grpBxConvertion
        '
        Me.grpBxConvertion.Controls.Add(Me.btnConvert)
        Me.grpBxConvertion.Location = New System.Drawing.Point(12, 333)
        Me.grpBxConvertion.Name = "grpBxConvertion"
        Me.grpBxConvertion.Size = New System.Drawing.Size(517, 117)
        Me.grpBxConvertion.TabIndex = 2
        Me.grpBxConvertion.TabStop = False
        Me.grpBxConvertion.Text = "Start Conversion:"
        '
        'btnConvert
        '
        Me.btnConvert.Enabled = False
        Me.btnConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.ForeColor = System.Drawing.Color.Green
        Me.btnConvert.Location = New System.Drawing.Point(63, 33)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(392, 64)
        Me.btnConvert.TabIndex = 0
        Me.btnConvert.Text = "&Start"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'grpBxProgress
        '
        Me.grpBxProgress.Controls.Add(Me.fileName)
        Me.grpBxProgress.Controls.Add(Me.btnCancel)
        Me.grpBxProgress.Controls.Add(Me.documents)
        Me.grpBxProgress.Controls.Add(Me.pages)
        Me.grpBxProgress.Controls.Add(Me.label2)
        Me.grpBxProgress.Controls.Add(Me.label3)
        Me.grpBxProgress.Controls.Add(Me.prgsBrOverallProgress)
        Me.grpBxProgress.Controls.Add(Me.prgsBrPageProgress)
        Me.grpBxProgress.Location = New System.Drawing.Point(-517, 333)
        Me.grpBxProgress.Name = "grpBxProgress"
        Me.grpBxProgress.Size = New System.Drawing.Size(517, 117)
        Me.grpBxProgress.TabIndex = 3
        Me.grpBxProgress.TabStop = False
        Me.grpBxProgress.Text = "Conversion Progress:"
        '
        'fileName
        '
        Me.fileName.AutoSize = True
        Me.fileName.Location = New System.Drawing.Point(93, 20)
        Me.fileName.Name = "fileName"
        Me.fileName.Size = New System.Drawing.Size(0, 13)
        Me.fileName.TabIndex = 6
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Enabled = False
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Red
        Me.btnCancel.Location = New System.Drawing.Point(410, 36)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(101, 75)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'documents
        '
        Me.documents.AutoEllipsis = True
        Me.documents.AutoSize = True
        Me.documents.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.documents.Location = New System.Drawing.Point(369, 72)
        Me.documents.Name = "documents"
        Me.documents.Size = New System.Drawing.Size(0, 13)
        Me.documents.TabIndex = 4
        '
        'pages
        '
        Me.pages.AutoSize = True
        Me.pages.Location = New System.Drawing.Point(241, 20)
        Me.pages.Name = "pages"
        Me.pages.Size = New System.Drawing.Size(0, 13)
        Me.pages.TabIndex = 4
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(7, 72)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(60, 13)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Overall Job"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(7, 20)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(89, 13)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Now Converting: "
        '
        'prgsBrOverallProgress
        '
        Me.prgsBrOverallProgress.Location = New System.Drawing.Point(6, 88)
        Me.prgsBrOverallProgress.Name = "prgsBrOverallProgress"
        Me.prgsBrOverallProgress.Size = New System.Drawing.Size(398, 23)
        Me.prgsBrOverallProgress.TabIndex = 1
        '
        'prgsBrPageProgress
        '
        Me.prgsBrPageProgress.Location = New System.Drawing.Point(6, 36)
        Me.prgsBrPageProgress.Name = "prgsBrPageProgress"
        Me.prgsBrPageProgress.Size = New System.Drawing.Size(398, 23)
        Me.prgsBrPageProgress.TabIndex = 0
        '
        'openFile
        '
        Me.openFile.Filter = resources.GetString("openFile.Filter")
        Me.openFile.Multiselect = True
        '
        'Demo
        '
        Me.AcceptButton = Me.btnConvert
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(542, 459)
        Me.Controls.Add(Me.grpBxProgress)
        Me.Controls.Add(Me.grpBxConvertion)
        Me.Controls.Add(Me.Output)
        Me.Controls.Add(Me.Input)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Demo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gnostice Document Studio .NET - Document Converter"
        Me.Input.ResumeLayout(False)
        Me.Input.PerformLayout()
        Me.Output.ResumeLayout(False)
        Me.Output.PerformLayout()
        Me.grpBxConvertion.ResumeLayout(False)
        Me.grpBxProgress.ResumeLayout(False)
        Me.grpBxProgress.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Input As System.Windows.Forms.GroupBox
    Private WithEvents lstBxInputDocList As System.Windows.Forms.ListBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents btnAdd As System.Windows.Forms.Button
    Private WithEvents btnUp As System.Windows.Forms.Button
    Private WithEvents btnDown As System.Windows.Forms.Button
    Private WithEvents btnRemove As System.Windows.Forms.Button
    Private WithEvents Output As System.Windows.Forms.GroupBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents btnBrowse As System.Windows.Forms.Button
    Private WithEvents txtBxBaseFileName As System.Windows.Forms.TextBox
    Private WithEvents txtBxOutputFolder As System.Windows.Forms.TextBox
    Private WithEvents cmbBxOutputFormat As System.Windows.Forms.ComboBox
    Private WithEvents grpBxConvertion As System.Windows.Forms.GroupBox
    Private WithEvents btnConvert As System.Windows.Forms.Button
    Private WithEvents grpBxProgress As System.Windows.Forms.GroupBox
    Private WithEvents fileName As System.Windows.Forms.Label
    Private WithEvents btnCancel As System.Windows.Forms.Button
    Private WithEvents documents As System.Windows.Forms.Label
    Private WithEvents pages As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents prgsBrOverallProgress As System.Windows.Forms.ProgressBar
    Private WithEvents prgsBrPageProgress As System.Windows.Forms.ProgressBar
    Private WithEvents folderBrowser As System.Windows.Forms.FolderBrowserDialog
    Private WithEvents openFile As System.Windows.Forms.OpenFileDialog
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents cmbConversionMode As System.Windows.Forms.ComboBox
    Friend WithEvents chkCreatePortfolio As System.Windows.Forms.CheckBox

End Class
