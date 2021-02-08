Imports Gnostice.Core.Graphics
Imports Gnostice.Core.Viewer

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim PageLayout4 As Gnostice.Core.Viewer.PageLayout = New Gnostice.Core.Viewer.PageLayout()
        Dim FormatterSettings4 As Gnostice.Documents.FormatterSettings = New Gnostice.Documents.FormatterSettings()
        Dim SpreadSheetFormatterSettings4 As Gnostice.Documents.Spreadsheet.SpreadSheetFormatterSettings = New Gnostice.Documents.Spreadsheet.SpreadSheetFormatterSettings()
        Dim PageSettings7 As Gnostice.Documents.PageSettings = New Gnostice.Documents.PageSettings()
        Dim Margins7 As Gnostice.Documents.Margins = New Gnostice.Documents.Margins()
        Dim SheetOptions7 As Gnostice.Documents.Spreadsheet.SheetOptions = New Gnostice.Documents.Spreadsheet.SheetOptions()
        Dim SheetOptions8 As Gnostice.Documents.Spreadsheet.SheetOptions = New Gnostice.Documents.Spreadsheet.SheetOptions()
        Dim TxtFormatterSettings4 As Gnostice.Documents.TXTFormatterSettings = New Gnostice.Documents.TXTFormatterSettings()
        Dim PageSettings8 As Gnostice.Documents.PageSettings = New Gnostice.Documents.PageSettings()
        Dim Margins8 As Gnostice.Documents.Margins = New Gnostice.Documents.Margins()
        Dim RenderingSettings4 As Gnostice.Core.Graphics.RenderingSettings = New Gnostice.Core.Graphics.RenderingSettings()
        Dim ImageRenderingSettings4 As Gnostice.Core.Graphics.ImageRenderingSettings = New Gnostice.Core.Graphics.ImageRenderingSettings()
        Dim ResolutionSettings4 As Gnostice.Core.Graphics.ResolutionSettings = New Gnostice.Core.Graphics.ResolutionSettings()
        Dim ShapeRenderingSettings4 As Gnostice.Core.Graphics.ShapeRenderingSettings = New Gnostice.Core.Graphics.ShapeRenderingSettings()
        Dim TextRenderingSettings4 As Gnostice.Core.Graphics.TextRenderingSettings = New Gnostice.Core.Graphics.TextRenderingSettings()
        Dim ViewerSettings4 As Gnostice.Core.Viewer.ViewerSettings = New Gnostice.Core.Viewer.ViewerSettings()
        Dim Zoom4 As Gnostice.Core.Viewer.Zoom = New Gnostice.Core.Viewer.Zoom()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsOpen = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnFirstPage = New System.Windows.Forms.ToolStripButton()
        Me.btnPrvPage = New System.Windows.Forms.ToolStripButton()
        Me.txtGoToPage = New System.Windows.Forms.ToolStripTextBox()
        Me.btnNxtPage = New System.Windows.Forms.ToolStripButton()
        Me.btnLastPage = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsActSize = New System.Windows.Forms.ToolStripButton()
        Me.tsFitPage = New System.Windows.Forms.ToolStripButton()
        Me.tsFitWidth = New System.Windows.Forms.ToolStripButton()
        Me.tsZoomOut = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtZoom = New System.Windows.Forms.ToolStripComboBox()
        Me.tsZoomIn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton13 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton14 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtSearchText = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.WholeWordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaseSensitiveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WrapAroundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.odOpenDoc = New System.Windows.Forms.OpenFileDialog()
        Me.DocumentViewer1 = New Gnostice.Controls.WinForms.DocumentViewer()
        Me.toolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolStrip1
        '
        Me.toolStrip1.AutoSize = False
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsOpen, Me.btnPrint, Me.toolStripSeparator10, Me.btnFirstPage, Me.btnPrvPage, Me.txtGoToPage, Me.btnNxtPage, Me.btnLastPage, Me.toolStripSeparator4, Me.tsActSize, Me.tsFitPage, Me.tsFitWidth, Me.tsZoomOut, Me.toolStripSeparator7, Me.txtZoom, Me.tsZoomIn, Me.ToolStripSeparator3, Me.ToolStripButton11, Me.ToolStripButton12, Me.ToolStripButton13, Me.ToolStripButton14, Me.ToolStripSeparator6, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripButton7, Me.ToolStripButton8, Me.ToolStripSeparator2, Me.ToolStripSeparator5, Me.ToolStripLabel1, Me.txtSearchText, Me.ToolStripSplitButton1, Me.ToolStripButton9, Me.ToolStripButton10})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.toolStrip1.Size = New System.Drawing.Size(1980, 50)
        Me.toolStrip1.TabIndex = 5
        Me.toolStrip1.Text = "toolStrip1"
        '
        'tsOpen
        '
        Me.tsOpen.Image = Global.Multi_formatViewer.My.Resources.Resources.open_document24_h
        Me.tsOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsOpen.Name = "tsOpen"
        Me.tsOpen.Size = New System.Drawing.Size(110, 37)
        Me.tsOpen.Text = "Open"
        Me.tsOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tsOpen.ToolTipText = "Open"
        '
        'btnPrint
        '
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(68, 37)
        Me.btnPrint.Text = "Print"
        '
        'toolStripSeparator10
        '
        Me.toolStripSeparator10.Name = "toolStripSeparator10"
        Me.toolStripSeparator10.Size = New System.Drawing.Size(6, 43)
        '
        'btnFirstPage
        '
        Me.btnFirstPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFirstPage.Image = Global.Multi_formatViewer.My.Resources.Resources.first
        Me.btnFirstPage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFirstPage.Name = "btnFirstPage"
        Me.btnFirstPage.Size = New System.Drawing.Size(46, 37)
        Me.btnFirstPage.Text = "toolStripButton1"
        Me.btnFirstPage.ToolTipText = "Go To First Page"
        '
        'btnPrvPage
        '
        Me.btnPrvPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrvPage.Image = Global.Multi_formatViewer.My.Resources.Resources.resultset_previous
        Me.btnPrvPage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrvPage.Name = "btnPrvPage"
        Me.btnPrvPage.Size = New System.Drawing.Size(46, 37)
        Me.btnPrvPage.ToolTipText = "Goto Previous Page"
        '
        'txtGoToPage
        '
        Me.txtGoToPage.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtGoToPage.Name = "txtGoToPage"
        Me.txtGoToPage.Size = New System.Drawing.Size(96, 43)
        '
        'btnNxtPage
        '
        Me.btnNxtPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNxtPage.Image = Global.Multi_formatViewer.My.Resources.Resources.resultset_next
        Me.btnNxtPage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNxtPage.Name = "btnNxtPage"
        Me.btnNxtPage.Size = New System.Drawing.Size(46, 37)
        Me.btnNxtPage.Text = "toolStripButton1"
        Me.btnNxtPage.ToolTipText = "Goto Next Page"
        '
        'btnLastPage
        '
        Me.btnLastPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnLastPage.Image = Global.Multi_formatViewer.My.Resources.Resources.last
        Me.btnLastPage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLastPage.Name = "btnLastPage"
        Me.btnLastPage.Size = New System.Drawing.Size(46, 37)
        Me.btnLastPage.ToolTipText = "Go To Last Page"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(6, 43)
        '
        'tsActSize
        '
        Me.tsActSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.tsActSize.Image = Global.Multi_formatViewer.My.Resources.Resources.arrow_inout
        Me.tsActSize.ImageTransparentColor = System.Drawing.Color.White
        Me.tsActSize.Name = "tsActSize"
        Me.tsActSize.Size = New System.Drawing.Size(167, 37)
        Me.tsActSize.Text = "Actual Size"
        '
        'tsFitPage
        '
        Me.tsFitPage.Image = Global.Multi_formatViewer.My.Resources.Resources.arrow_out
        Me.tsFitPage.ImageTransparentColor = System.Drawing.Color.White
        Me.tsFitPage.Name = "tsFitPage"
        Me.tsFitPage.Size = New System.Drawing.Size(135, 37)
        Me.tsFitPage.Text = "Fit Page"
        '
        'tsFitWidth
        '
        Me.tsFitWidth.Image = Global.Multi_formatViewer.My.Resources.Resources.FitWidth
        Me.tsFitWidth.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.tsFitWidth.Name = "tsFitWidth"
        Me.tsFitWidth.Size = New System.Drawing.Size(148, 37)
        Me.tsFitWidth.Text = "Fit Width"
        '
        'tsZoomOut
        '
        Me.tsZoomOut.Image = Global.Multi_formatViewer.My.Resources.Resources.zoomout24_h
        Me.tsZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsZoomOut.Name = "tsZoomOut"
        Me.tsZoomOut.Size = New System.Drawing.Size(161, 37)
        Me.tsZoomOut.Text = "Zoom Out"
        '
        'toolStripSeparator7
        '
        Me.toolStripSeparator7.Name = "toolStripSeparator7"
        Me.toolStripSeparator7.Size = New System.Drawing.Size(6, 43)
        '
        'txtZoom
        '
        Me.txtZoom.DropDownWidth = 75
        Me.txtZoom.Items.AddRange(New Object() {"10%", "25%", "50%", "75%", "100%", "125%", "200%", "400%", "800%", "1600%", "3200%", "6400%"})
        Me.txtZoom.Name = "txtZoom"
        Me.txtZoom.Size = New System.Drawing.Size(75, 43)
        Me.txtZoom.Text = "10%"
        '
        'tsZoomIn
        '
        Me.tsZoomIn.Image = Global.Multi_formatViewer.My.Resources.Resources.zoomin24_h
        Me.tsZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsZoomIn.Name = "tsZoomIn"
        Me.tsZoomIn.Size = New System.Drawing.Size(141, 37)
        Me.tsZoomIn.Text = "Zoom In"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 43)
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), System.Drawing.Image)
        Me.ToolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.Size = New System.Drawing.Size(46, 44)
        Me.ToolStripButton11.Text = "ToolStripButton11"
        '
        'ToolStripButton12
        '
        Me.ToolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton12.Image = CType(resources.GetObject("ToolStripButton12.Image"), System.Drawing.Image)
        Me.ToolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.Size = New System.Drawing.Size(46, 37)
        Me.ToolStripButton12.Text = "ToolStripButton12"
        '
        'ToolStripButton13
        '
        Me.ToolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton13.Image = CType(resources.GetObject("ToolStripButton13.Image"), System.Drawing.Image)
        Me.ToolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton13.Name = "ToolStripButton13"
        Me.ToolStripButton13.Size = New System.Drawing.Size(46, 37)
        Me.ToolStripButton13.Text = "ToolStripButton13"
        '
        'ToolStripButton14
        '
        Me.ToolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton14.Image = CType(resources.GetObject("ToolStripButton14.Image"), System.Drawing.Image)
        Me.ToolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton14.Name = "ToolStripButton14"
        Me.ToolStripButton14.Size = New System.Drawing.Size(46, 37)
        Me.ToolStripButton14.Text = "ToolStripButton14"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 43)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Multi_formatViewer.My.Resources.Resources.arrow_turn_left
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(46, 37)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.ToolTipText = "Rotate AntiClockwise 90"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.Multi_formatViewer.My.Resources.Resources.arrow_turn_right
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(46, 37)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        Me.ToolStripButton2.ToolTipText = "Rotate Clockwise 90"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(46, 37)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(46, 37)
        Me.ToolStripButton4.Text = "ToolStripButton4"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 43)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(46, 37)
        Me.ToolStripButton5.Text = "ToolStripButton5"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(46, 37)
        Me.ToolStripButton6.Text = "ToolStripButton6"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(46, 37)
        Me.ToolStripButton7.Text = "ToolStripButton7"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(46, 37)
        Me.ToolStripButton8.Text = "ToolStripButton8"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 43)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 43)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(86, 32)
        Me.ToolStripLabel1.Text = "Search"
        '
        'txtSearchText
        '
        Me.txtSearchText.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearchText.Name = "txtSearchText"
        Me.txtSearchText.Size = New System.Drawing.Size(100, 39)
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WholeWordToolStripMenuItem, Me.CaseSensitiveToolStripMenuItem, Me.WrapAroundToolStripMenuItem})
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(59, 36)
        Me.ToolStripSplitButton1.Text = "ToolStripSplitButton1"
        '
        'WholeWordToolStripMenuItem
        '
        Me.WholeWordToolStripMenuItem.Name = "WholeWordToolStripMenuItem"
        Me.WholeWordToolStripMenuItem.Size = New System.Drawing.Size(294, 44)
        Me.WholeWordToolStripMenuItem.Text = "WholeWord"
        '
        'CaseSensitiveToolStripMenuItem
        '
        Me.CaseSensitiveToolStripMenuItem.Name = "CaseSensitiveToolStripMenuItem"
        Me.CaseSensitiveToolStripMenuItem.Size = New System.Drawing.Size(294, 44)
        Me.CaseSensitiveToolStripMenuItem.Text = "CaseSensitive"
        '
        'WrapAroundToolStripMenuItem
        '
        Me.WrapAroundToolStripMenuItem.Name = "WrapAroundToolStripMenuItem"
        Me.WrapAroundToolStripMenuItem.Size = New System.Drawing.Size(294, 44)
        Me.WrapAroundToolStripMenuItem.Text = "WrapAround"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(69, 36)
        Me.ToolStripButton9.Text = "Next"
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
        Me.ToolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.Size = New System.Drawing.Size(109, 36)
        Me.ToolStripButton10.Text = "Previous"
        '
        'DocumentViewer1
        '
        Me.DocumentViewer1.AllowInteractivity = False
        Me.DocumentViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DocumentViewer1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.DocumentViewer1.BorderWidth = 0!
        Me.DocumentViewer1.HScrollBar.Enabled = False
        Me.DocumentViewer1.HScrollBar.LargeChange = 40.0!
        Me.DocumentViewer1.HScrollBar.Maximum = 0!
        Me.DocumentViewer1.HScrollBar.Minimum = 0!
        Me.DocumentViewer1.HScrollBar.SmallChange = 20.0!
        Me.DocumentViewer1.HScrollBar.Value = 0!
        Me.DocumentViewer1.HScrollBar.Visibility = Gnostice.Core.Viewer.ScrollBarVisibility.Always
        Me.DocumentViewer1.HScrollBar.Visible = False
        Me.DocumentViewer1.Location = New System.Drawing.Point(0, 54)
        Me.DocumentViewer1.Margin = New System.Windows.Forms.Padding(6)
        Me.DocumentViewer1.MouseMode = Gnostice.Core.DOM.CursorPreferences.Pan
        Me.DocumentViewer1.Name = "DocumentViewer1"
        Me.DocumentViewer1.NavigationPane.BackColor = System.Drawing.SystemColors.ControlDark
        Me.DocumentViewer1.NavigationPane.Visibility = Gnostice.Core.Viewer.Visibility.[Auto]
        Me.DocumentViewer1.NavigationPane.WidthPercentage = 20
        Me.DocumentViewer1.Orientation = Gnostice.Core.Viewer.ViewerOrientation.Vertical
        Me.DocumentViewer1.PageBreakWidth = 10.0!
        PageLayout4.Columns = 1
        PageLayout4.HorizontalSpacing = 5.0R
        PageLayout4.LayoutMode = Gnostice.Core.Viewer.PageLayoutMode.SinglePage
        PageLayout4.ScrollMode = Gnostice.Core.Viewer.ScrollMode.Continuous
        PageLayout4.ShowCoverPage = False
        PageLayout4.VerticalSpacing = 5.0R
        Me.DocumentViewer1.PageLayout = PageLayout4
        Me.DocumentViewer1.PageRotation = Gnostice.Core.Viewer.RotationAngle.Zero
        SpreadSheetFormatterSettings4.FormattingMode = Gnostice.Core.DOM.FormattingMode.PreferDocumentSettings
        PageSettings7.Height = 11.6929!
        Margins7.Bottom = 1.0!
        Margins7.Footer = 0!
        Margins7.Header = 0!
        Margins7.Left = 1.0!
        Margins7.Right = 1.0!
        Margins7.Top = 1.0!
        PageSettings7.Margin = Margins7
        PageSettings7.Orientation = Gnostice.Core.Graphics.Orientation.Portrait
        PageSettings7.PageSize = Gnostice.Documents.PageSize.A4
        PageSettings7.Width = 8.2677!
        SpreadSheetFormatterSettings4.PageSettings = PageSettings7
        SheetOptions7.Print = False
        SheetOptions7.View = True
        SpreadSheetFormatterSettings4.ShowGridlines = SheetOptions7
        SheetOptions8.Print = False
        SheetOptions8.View = True
        SpreadSheetFormatterSettings4.ShowHeadings = SheetOptions8
        FormatterSettings4.SpreadSheet = SpreadSheetFormatterSettings4
        PageSettings8.Height = 11.6929!
        Margins8.Bottom = 1.0!
        Margins8.Footer = 0!
        Margins8.Header = 0!
        Margins8.Left = 1.0!
        Margins8.Right = 1.0!
        Margins8.Top = 1.0!
        PageSettings8.Margin = Margins8
        PageSettings8.Orientation = Gnostice.Core.Graphics.Orientation.Portrait
        PageSettings8.PageSize = Gnostice.Documents.PageSize.A4
        PageSettings8.Width = 8.2677!
        TxtFormatterSettings4.PageSettings = PageSettings8
        FormatterSettings4.TXT = TxtFormatterSettings4
        Me.DocumentViewer1.Preferences.FormatterSettings = FormatterSettings4
        Me.DocumentViewer1.Preferences.KeyNavigation = True
        ImageRenderingSettings4.InterpolationMode = Gnostice.Core.Graphics.InterpolationMode.NearestNeighbor
        RenderingSettings4.Image = ImageRenderingSettings4
        ResolutionSettings4.DpiX = 96.0!
        ResolutionSettings4.DpiY = 96.0!
        ResolutionSettings4.ResolutionMode = Gnostice.Core.Graphics.ResolutionMode.UseSource
        RenderingSettings4.Resolution = ResolutionSettings4
        ShapeRenderingSettings4.CompositingMode = Gnostice.Core.Graphics.CompositingMode.SourceOver
        ShapeRenderingSettings4.CompositingQuality = Gnostice.Core.Graphics.CompositingQuality.[Default]
        ShapeRenderingSettings4.PixelOffsetMode = Gnostice.Core.Graphics.PixelOffsetMode.HighQuality
        ShapeRenderingSettings4.SmoothingMode = Gnostice.Core.Graphics.SmoothingMode.AntiAlias
        RenderingSettings4.Shape = ShapeRenderingSettings4
        TextRenderingSettings4.TextContrast = 4
        TextRenderingSettings4.TextRenderingHint = Gnostice.Core.Graphics.TextRenderingHint.AntiAlias
        RenderingSettings4.Text = TextRenderingSettings4
        Me.DocumentViewer1.Preferences.RenderingSettings = RenderingSettings4
        Me.DocumentViewer1.Preferences.Units = Gnostice.Core.Graphics.MeasurementUnit.Inches
        ViewerSettings4.AllowInteractivity = False
        ViewerSettings4.LowestRenderingDPI = 0!
        ViewerSettings4.MouseMode = Gnostice.Core.DOM.CursorPreferences.Pan
        ViewerSettings4.Orientation = Gnostice.Core.Viewer.ViewerOrientation.Vertical
        ViewerSettings4.PageBreakWidth = 10.0!
        ViewerSettings4.PageLayout = PageLayout4
        ViewerSettings4.Rotation = Gnostice.Core.Viewer.RotationAngle.Zero
        Zoom4.InternalZoomMode = Gnostice.Core.Viewer.ZoomMode.ActualSize
        Zoom4.InternalZoomPercent = 100.0R
        Zoom4.ZoomMode = Gnostice.Core.Viewer.ZoomMode.ActualSize
        Zoom4.ZoomPercent = 100.0R
        ViewerSettings4.Zoom = Zoom4
        Me.DocumentViewer1.Preferences.ViewerSettings = ViewerSettings4
        Me.DocumentViewer1.Size = New System.Drawing.Size(1980, 771)
        Me.DocumentViewer1.TabIndex = 6
        Me.DocumentViewer1.VScrollBar.Enabled = False
        Me.DocumentViewer1.VScrollBar.LargeChange = 40.0!
        Me.DocumentViewer1.VScrollBar.Maximum = 0!
        Me.DocumentViewer1.VScrollBar.Minimum = 0!
        Me.DocumentViewer1.VScrollBar.SmallChange = 20.0!
        Me.DocumentViewer1.VScrollBar.Value = 0!
        Me.DocumentViewer1.VScrollBar.Visibility = Gnostice.Core.Viewer.ScrollBarVisibility.Always
        Me.DocumentViewer1.VScrollBar.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1980, 823)
        Me.Controls.Add(Me.DocumentViewer1)
        Me.Controls.Add(Me.toolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "Gnostice Document Studio .NET - Document Viewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents tsOpen As System.Windows.Forms.ToolStripButton
    Private WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents btnFirstPage As System.Windows.Forms.ToolStripButton
    Private WithEvents btnPrvPage As System.Windows.Forms.ToolStripButton
    Private WithEvents txtGoToPage As System.Windows.Forms.ToolStripTextBox
    Private WithEvents btnNxtPage As System.Windows.Forms.ToolStripButton
    Private WithEvents btnLastPage As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents tsActSize As System.Windows.Forms.ToolStripButton
    Private WithEvents tsFitPage As System.Windows.Forms.ToolStripButton
    Private WithEvents tsFitWidth As System.Windows.Forms.ToolStripButton
    Private WithEvents tsZoomOut As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents tsZoomIn As System.Windows.Forms.ToolStripButton
    Private WithEvents odOpenDoc As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DocumentViewer1 As Gnostice.Controls.WinForms.DocumentViewer
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtZoom As ToolStripComboBox
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txtSearchText As ToolStripTextBox
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents ToolStripButton9 As ToolStripButton
    Friend WithEvents ToolStripButton10 As ToolStripButton
    Friend WithEvents ToolStripButton11 As ToolStripButton
    Friend WithEvents ToolStripButton12 As ToolStripButton
    Friend WithEvents ToolStripButton13 As ToolStripButton
    Friend WithEvents ToolStripButton14 As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents WholeWordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CaseSensitiveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WrapAroundToolStripMenuItem As ToolStripMenuItem
End Class
