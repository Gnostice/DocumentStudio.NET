Imports Gnostice.Core.Graphics
Imports Gnostice.Core.Viewer

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DocumentPrinterDemo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim FormatterSettings1 As Gnostice.Documents.FormatterSettings = New Gnostice.Documents.FormatterSettings()
        Dim SpreadSheetFormatterSettings1 As Gnostice.Documents.Spreadsheet.SpreadSheetFormatterSettings = New Gnostice.Documents.Spreadsheet.SpreadSheetFormatterSettings()
        Dim PageSettings1 As Gnostice.Documents.PageSettings = New Gnostice.Documents.PageSettings()
        Dim Margins1 As Gnostice.Documents.Margins = New Gnostice.Documents.Margins()
        Dim SheetOptions1 As Gnostice.Documents.Spreadsheet.SheetOptions = New Gnostice.Documents.Spreadsheet.SheetOptions()
        Dim SheetOptions2 As Gnostice.Documents.Spreadsheet.SheetOptions = New Gnostice.Documents.Spreadsheet.SheetOptions()
        Dim TxtFormatterSettings1 As Gnostice.Documents.TXTFormatterSettings = New Gnostice.Documents.TXTFormatterSettings()
        Dim PageSettings2 As Gnostice.Documents.PageSettings = New Gnostice.Documents.PageSettings()
        Dim Margins2 As Gnostice.Documents.Margins = New Gnostice.Documents.Margins()
        Dim RenderingSettings1 As RenderingSettings = New RenderingSettings()
        Dim ImageRenderingSettings1 As ImageRenderingSettings = New ImageRenderingSettings()
        Dim ShapeRenderingSettings1 As ShapeRenderingSettings = New ShapeRenderingSettings()
        Dim ResolutionSettings1 As ResolutionSettings = New ResolutionSettings()
        Dim TextRenderingSettings1 As TextRenderingSettings = New TextRenderingSettings()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DocumentPrinterDemo))
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtInputFilePath = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.lblSelectedPrinter = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtPageRange = New System.Windows.Forms.TextBox()
        Me.rdbtnSeletedRange = New System.Windows.Forms.RadioButton()
        Me.rdbtnEven = New System.Windows.Forms.RadioButton()
        Me.rdbtnOdd = New System.Windows.Forms.RadioButton()
        Me.rdbtnAll = New System.Windows.Forms.RadioButton()
        Me.copies = New System.Windows.Forms.NumericUpDown()
        Me.label3 = New System.Windows.Forms.Label()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbScaling = New System.Windows.Forms.ComboBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.cmbVerticalPositioning = New System.Windows.Forms.ComboBox()
        Me.cmbHorizontalPositioning = New System.Windows.Forms.ComboBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.chckAutoRotate = New System.Windows.Forms.CheckBox()
        Me.documentViewer = New Gnostice.Controls.WinForms.DocumentViewer()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.browseFile = New System.Windows.Forms.OpenFileDialog()
        Me.printDialog1 = New System.Windows.Forms.PrintDialog()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.panel1.SuspendLayout()
        CType(Me.copies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox3.SuspendLayout()
        Me.groupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 3
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 309.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.label1, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.txtInputFilePath, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.btnBrowse, 2, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.groupBox1, 0, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.groupBox2, 0, 3)
        Me.tableLayoutPanel1.Controls.Add(Me.groupBox3, 0, 4)
        Me.tableLayoutPanel1.Controls.Add(Me.documentViewer, 1, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.btnPrint, 0, 5)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 7
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(647, 450)
        Me.tableLayoutPanel1.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label1.Location = New System.Drawing.Point(3, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(303, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Input File Name:"
        '
        'txtInputFilePath
        '
        Me.txtInputFilePath.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tableLayoutPanel1.SetColumnSpan(Me.txtInputFilePath, 2)
        Me.txtInputFilePath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtInputFilePath.Location = New System.Drawing.Point(3, 16)
        Me.txtInputFilePath.Name = "txtInputFilePath"
        Me.txtInputFilePath.ReadOnly = True
        Me.txtInputFilePath.Size = New System.Drawing.Size(585, 20)
        Me.txtInputFilePath.TabIndex = 0
        '
        'btnBrowse
        '
        Me.btnBrowse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.Green
        Me.btnBrowse.Location = New System.Drawing.Point(594, 16)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(50, 20)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btnSetup)
        Me.groupBox1.Controls.Add(Me.lblSelectedPrinter)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupBox1.Location = New System.Drawing.Point(3, 42)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(303, 58)
        Me.groupBox1.TabIndex = 2
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Print Setup:"
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(220, 27)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(75, 23)
        Me.btnSetup.TabIndex = 0
        Me.btnSetup.Text = "&Setup..."
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'lblSelectedPrinter
        '
        Me.lblSelectedPrinter.AutoSize = True
        Me.lblSelectedPrinter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedPrinter.ForeColor = System.Drawing.Color.Blue
        Me.lblSelectedPrinter.Location = New System.Drawing.Point(10, 37)
        Me.lblSelectedPrinter.MaximumSize = New System.Drawing.Size(195, 0)
        Me.lblSelectedPrinter.Name = "lblSelectedPrinter"
        Me.lblSelectedPrinter.Size = New System.Drawing.Size(0, 13)
        Me.lblSelectedPrinter.TabIndex = 1
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(7, 20)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(85, 13)
        Me.label2.TabIndex = 0
        Me.label2.Text = "Selected Printer:"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.panel1)
        Me.groupBox2.Controls.Add(Me.copies)
        Me.groupBox2.Controls.Add(Me.label3)
        Me.groupBox2.Location = New System.Drawing.Point(3, 106)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(303, 120)
        Me.groupBox2.TabIndex = 3
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Pages to Print:"
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.label4)
        Me.panel1.Controls.Add(Me.txtPageRange)
        Me.panel1.Controls.Add(Me.rdbtnSeletedRange)
        Me.panel1.Controls.Add(Me.rdbtnEven)
        Me.panel1.Controls.Add(Me.rdbtnOdd)
        Me.panel1.Controls.Add(Me.rdbtnAll)
        Me.panel1.Location = New System.Drawing.Point(3, 19)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(292, 64)
        Me.panel1.TabIndex = 3
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(109, 47)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(116, 13)
        Me.label4.TabIndex = 8
        Me.label4.Text = "(Example: 1, 3-5, 8, 12)"
        '
        'txtPageRange
        '
        Me.txtPageRange.Location = New System.Drawing.Point(112, 24)
        Me.txtPageRange.Name = "txtPageRange"
        Me.txtPageRange.Size = New System.Drawing.Size(172, 20)
        Me.txtPageRange.TabIndex = 7
        '
        'rdbtnSeletedRange
        '
        Me.rdbtnSeletedRange.AutoSize = True
        Me.rdbtnSeletedRange.Location = New System.Drawing.Point(2, 25)
        Me.rdbtnSeletedRange.Name = "rdbtnSeletedRange"
        Me.rdbtnSeletedRange.Size = New System.Drawing.Size(105, 17)
        Me.rdbtnSeletedRange.TabIndex = 6
        Me.rdbtnSeletedRange.Text = "Selected Range:"
        Me.rdbtnSeletedRange.UseVisualStyleBackColor = True
        '
        'rdbtnEven
        '
        Me.rdbtnEven.AutoSize = True
        Me.rdbtnEven.Location = New System.Drawing.Point(162, 3)
        Me.rdbtnEven.Name = "rdbtnEven"
        Me.rdbtnEven.Size = New System.Drawing.Size(83, 17)
        Me.rdbtnEven.TabIndex = 4
        Me.rdbtnEven.Text = "Even Pages"
        Me.rdbtnEven.UseVisualStyleBackColor = True
        '
        'rdbtnOdd
        '
        Me.rdbtnOdd.AutoSize = True
        Me.rdbtnOdd.Location = New System.Drawing.Point(78, 3)
        Me.rdbtnOdd.Name = "rdbtnOdd"
        Me.rdbtnOdd.Size = New System.Drawing.Size(78, 17)
        Me.rdbtnOdd.TabIndex = 5
        Me.rdbtnOdd.Text = "Odd Pages"
        Me.rdbtnOdd.UseVisualStyleBackColor = True
        '
        'rdbtnAll
        '
        Me.rdbtnAll.AutoSize = True
        Me.rdbtnAll.Checked = True
        Me.rdbtnAll.Location = New System.Drawing.Point(3, 3)
        Me.rdbtnAll.Name = "rdbtnAll"
        Me.rdbtnAll.Size = New System.Drawing.Size(69, 17)
        Me.rdbtnAll.TabIndex = 0
        Me.rdbtnAll.TabStop = True
        Me.rdbtnAll.Text = "All Pages"
        Me.rdbtnAll.UseVisualStyleBackColor = True
        '
        'copies
        '
        Me.copies.Location = New System.Drawing.Point(54, 89)
        Me.copies.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.copies.Name = "copies"
        Me.copies.Size = New System.Drawing.Size(120, 20)
        Me.copies.TabIndex = 7
        Me.copies.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(6, 91)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(42, 13)
        Me.label3.TabIndex = 6
        Me.label3.Text = "Copies:"
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.cmbScaling)
        Me.groupBox3.Controls.Add(Me.label7)
        Me.groupBox3.Controls.Add(Me.groupBox4)
        Me.groupBox3.Controls.Add(Me.chckAutoRotate)
        Me.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupBox3.Location = New System.Drawing.Point(3, 232)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(303, 158)
        Me.groupBox3.TabIndex = 4
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Printing Preferences:"
        '
        'cmbScaling
        '
        Me.cmbScaling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbScaling.FormattingEnabled = True
        Me.cmbScaling.Items.AddRange(New Object() {"Original size - print without scaling", "Fit document page to printer paper always", "Shrink only oversized page to fit printer paper"})
        Me.cmbScaling.Location = New System.Drawing.Point(7, 131)
        Me.cmbScaling.Name = "cmbScaling"
        Me.cmbScaling.Size = New System.Drawing.Size(288, 21)
        Me.cmbScaling.TabIndex = 2
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(4, 115)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(73, 13)
        Me.label7.TabIndex = 2
        Me.label7.Text = "Page Scaling:"
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.label6)
        Me.groupBox4.Controls.Add(Me.cmbVerticalPositioning)
        Me.groupBox4.Controls.Add(Me.cmbHorizontalPositioning)
        Me.groupBox4.Controls.Add(Me.label5)
        Me.groupBox4.Location = New System.Drawing.Point(7, 44)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(288, 68)
        Me.groupBox4.TabIndex = 1
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Page Positioning:"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(146, 21)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(42, 13)
        Me.label6.TabIndex = 2
        Me.label6.Text = "Vertical"
        '
        'cmbVerticalPositioning
        '
        Me.cmbVerticalPositioning.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVerticalPositioning.FormattingEnabled = True
        Me.cmbVerticalPositioning.Items.AddRange(New Object() {"Top of paper", "Center of paper", "Bottom of paper"})
        Me.cmbVerticalPositioning.Location = New System.Drawing.Point(149, 37)
        Me.cmbVerticalPositioning.Name = "cmbVerticalPositioning"
        Me.cmbVerticalPositioning.Size = New System.Drawing.Size(133, 21)
        Me.cmbVerticalPositioning.TabIndex = 1
        '
        'cmbHorizontalPositioning
        '
        Me.cmbHorizontalPositioning.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHorizontalPositioning.FormattingEnabled = True
        Me.cmbHorizontalPositioning.Items.AddRange(New Object() {"Left of paper", "Center of paper", "Right of paper"})
        Me.cmbHorizontalPositioning.Location = New System.Drawing.Point(10, 37)
        Me.cmbHorizontalPositioning.Name = "cmbHorizontalPositioning"
        Me.cmbHorizontalPositioning.Size = New System.Drawing.Size(133, 21)
        Me.cmbHorizontalPositioning.TabIndex = 0
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(7, 20)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(54, 13)
        Me.label5.TabIndex = 0
        Me.label5.Text = "Horizontal"
        '
        'chckAutoRotate
        '
        Me.chckAutoRotate.AutoSize = True
        Me.chckAutoRotate.Checked = True
        Me.chckAutoRotate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chckAutoRotate.Location = New System.Drawing.Point(7, 19)
        Me.chckAutoRotate.Name = "chckAutoRotate"
        Me.chckAutoRotate.Size = New System.Drawing.Size(202, 17)
        Me.chckAutoRotate.TabIndex = 0
        Me.chckAutoRotate.Text = "Automatically rotate landscape pages"
        Me.chckAutoRotate.UseVisualStyleBackColor = True
        '
        'documentViewer
        '
        Me.documentViewer.BackColor = System.Drawing.SystemColors.ControlDark
        'Me.documentViewer.BorderWidth = 10
        'Me.documentViewer.CurrentPage = 0
        'Me.documentViewer.HScrollBar.LargeChange = 40
        'Me.documentViewer.HScrollBar.SmallChange = 20
        'Me.documentViewer.HScrollBar.Value = 0
        'Me.documentViewer.HScrollBar.Visibility = Gnostice.Documents.Controls.WinForms.ScrollBarVisibility.Always
        Me.documentViewer.Location = New System.Drawing.Point(312, 42)
        Me.documentViewer.Name = "documentViewer"
        Me.documentViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.SetColumnSpan(Me.documentViewer, 2)
        '
        '
        '
        'Me.documentViewer.NavigationPane.ActivePage = Nothing
        'Me.documentViewer.NavigationPane.Location = New System.Drawing.Point(0, 0)
        'Me.documentViewer.NavigationPane.Name = ""
        'Me.documentViewer.NavigationPane.TabIndex = 0
        'Me.documentViewer.NavigationPane.Visibility = Gnostice.Documents.Controls.WinForms.Visibility.[Auto]
        'Me.documentViewer.NavigationPane.WidthPercentage = 20
        Me.documentViewer.PageLayout = New PageLayout
        Me.documentViewer.PageRotation = RotationAngle.Zero
        'SpreadSheetFormatterSettings1.FormattingMode = Gnostice.DOM.FormattingMode.PreferDocumentSettings
        'SpreadSheetFormatterSettings1.PageOrder = Gnostice.Documents.Spreadsheet.LayoutDirection.BackwardN
        PageSettings1.Height = 11.6929!
        Margins1.Bottom = 1.0!
        Margins1.Footer = 0!
        Margins1.Header = 0!
        Margins1.Left = 1.0!
        Margins1.Right = 1.0!
        Margins1.Top = 1.0!
        PageSettings1.Margin = Margins1
        PageSettings1.Orientation = Orientation.Portrait
        PageSettings1.PageSize = Gnostice.Documents.PageSize.A4
        PageSettings1.Width = 8.2677!
        SpreadSheetFormatterSettings1.PageSettings = PageSettings1
        SheetOptions1.Print = False
        SheetOptions1.View = True
        SpreadSheetFormatterSettings1.ShowGridlines = SheetOptions1
        SheetOptions2.Print = False
        SheetOptions2.View = True
        SpreadSheetFormatterSettings1.ShowHeadings = SheetOptions2
        FormatterSettings1.SpreadSheet = SpreadSheetFormatterSettings1
        TxtFormatterSettings1.Font = New Font("Calibri", 12.0!)
        PageSettings2.Height = 11.6929!
        Margins2.Bottom = 1.0!
        Margins2.Footer = 0!
        Margins2.Header = 0!
        Margins2.Left = 1.0!
        Margins2.Right = 1.0!
        Margins2.Top = 1.0!
        PageSettings2.Margin = Margins2
        PageSettings2.Orientation = Orientation.Portrait
        PageSettings2.PageSize = Gnostice.Documents.PageSize.A4
        PageSettings2.Width = 8.2677!
        TxtFormatterSettings1.PageSettings = PageSettings2
        FormatterSettings1.TXT = TxtFormatterSettings1
        'Me.documentViewer.Preferences.FormatterSettings = FormatterSettings1
        'Me.documentViewer.Preferences.KeyNavigation = True
        ShapeRenderingSettings1.CompositingMode = CompositingMode.SourceOver
        ShapeRenderingSettings1.CompositingQuality = CompositingQuality.HighQuality
        ShapeRenderingSettings1.PixelOffsetMode = PixelOffsetMode.HighQuality
        ShapeRenderingSettings1.SmoothingMode = SmoothingMode.HighQuality
        RenderingSettings1.Shape = ShapeRenderingSettings1
        ImageRenderingSettings1.InterpolationMode = InterpolationMode.HighQualityBicubic
        RenderingSettings1.Image = ImageRenderingSettings1
        ResolutionSettings1.DpiX = 96.0!
        ResolutionSettings1.DpiY = 96.0!
        ResolutionSettings1.ResolutionMode = ResolutionMode.UseSource
        RenderingSettings1.Resolution = ResolutionSettings1
        TextRenderingSettings1.TextContrast = 0
        TextRenderingSettings1.TextRenderingHint = TextRenderingHint.AntiAlias
        RenderingSettings1.Text = TextRenderingSettings1
        'Me.documentViewer.Preferences.RenderingSettings = RenderingSettings1
        'Me.documentViewer.Preferences.Units = Gnostice.Graphics.MeasurementUnit.Inches
        Me.tableLayoutPanel1.SetRowSpan(Me.documentViewer, 5)
        Me.documentViewer.Size = New System.Drawing.Size(332, 405)
        Me.documentViewer.TabIndex = 6
        'Me.documentViewer.VScrollBar.LargeChange = 40
        'Me.documentViewer.VScrollBar.SmallChange = 20
        'Me.documentViewer.VScrollBar.Value = 0
        'Me.documentViewer.VScrollBar.Visibility = Gnostice.Documents.Controls.WinForms.ScrollBarVisibility.Always
        Me.documentViewer.Zoom.ZoomMode = ZoomMode.FitWidth
        Me.documentViewer.Zoom.ZoomPercent = 100.0R
        '
        'btnPrint
        '
        Me.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(3, 396)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(303, 50)
        Me.btnPrint.TabIndex = 5
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'browseFile
        '
        Me.browseFile.Filter = resources.GetString("browseFile.Filter")
        '
        'DocumentPrinterDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 470)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DocumentPrinterDemo"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gnostice Document Studio .NET - Document Printer"
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel1.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.copies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txtInputFilePath As System.Windows.Forms.TextBox
    Private WithEvents btnBrowse As System.Windows.Forms.Button
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents btnSetup As System.Windows.Forms.Button
    Private WithEvents lblSelectedPrinter As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents rdbtnEven As System.Windows.Forms.RadioButton
    Private WithEvents rdbtnOdd As System.Windows.Forms.RadioButton
    Private WithEvents rdbtnAll As System.Windows.Forms.RadioButton
    Private WithEvents copies As System.Windows.Forms.NumericUpDown
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents cmbScaling As System.Windows.Forms.ComboBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents cmbVerticalPositioning As System.Windows.Forms.ComboBox
    Private WithEvents cmbHorizontalPositioning As System.Windows.Forms.ComboBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents chckAutoRotate As System.Windows.Forms.CheckBox
    Private WithEvents documentViewer As Gnostice.Controls.WinForms.DocumentViewer
    Private WithEvents btnPrint As System.Windows.Forms.Button
    Private WithEvents browseFile As System.Windows.Forms.OpenFileDialog
    Private WithEvents printDialog1 As System.Windows.Forms.PrintDialog
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents txtPageRange As System.Windows.Forms.TextBox
    Private WithEvents rdbtnSeletedRange As System.Windows.Forms.RadioButton

End Class
