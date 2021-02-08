using System;
using Gnostice.Core.Viewer;

namespace WinForms_CS_Document_Viewer
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Gnostice.Core.Viewer.PageLayout pageLayout1 = new Gnostice.Core.Viewer.PageLayout();
            Gnostice.Documents.FormatterSettings formatterSettings1 = new Gnostice.Documents.FormatterSettings();
            Gnostice.Documents.Spreadsheet.SpreadSheetFormatterSettings spreadSheetFormatterSettings1 = new Gnostice.Documents.Spreadsheet.SpreadSheetFormatterSettings();
            Gnostice.Documents.PageSettings pageSettings1 = new Gnostice.Documents.PageSettings();
            Gnostice.Documents.Margins margins1 = new Gnostice.Documents.Margins();
            Gnostice.Documents.Spreadsheet.SheetOptions sheetOptions1 = new Gnostice.Documents.Spreadsheet.SheetOptions();
            Gnostice.Documents.Spreadsheet.SheetOptions sheetOptions2 = new Gnostice.Documents.Spreadsheet.SheetOptions();
            Gnostice.Documents.TXTFormatterSettings txtFormatterSettings1 = new Gnostice.Documents.TXTFormatterSettings();
            Gnostice.Documents.PageSettings pageSettings2 = new Gnostice.Documents.PageSettings();
            Gnostice.Documents.Margins margins2 = new Gnostice.Documents.Margins();
            Gnostice.Core.Graphics.RenderingSettings renderingSettings1 = new Gnostice.Core.Graphics.RenderingSettings();
            Gnostice.Core.Graphics.ImageRenderingSettings imageRenderingSettings1 = new Gnostice.Core.Graphics.ImageRenderingSettings();
            Gnostice.Core.Graphics.ResolutionSettings resolutionSettings1 = new Gnostice.Core.Graphics.ResolutionSettings();
            Gnostice.Core.Graphics.ShapeRenderingSettings shapeRenderingSettings1 = new Gnostice.Core.Graphics.ShapeRenderingSettings();
            Gnostice.Core.Graphics.TextRenderingSettings textRenderingSettings1 = new Gnostice.Core.Graphics.TextRenderingSettings();
            Gnostice.Core.Viewer.ViewerSettings viewerSettings1 = new Gnostice.Core.Viewer.ViewerSettings();
            Gnostice.Core.Viewer.Zoom zoom1 = new Gnostice.Core.Viewer.Zoom();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageRotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateClockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateAntiClockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateCurrentPageClockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateCurrentPageAnticlockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageNavigationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pageLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singlePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singlePageContinuousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoPageContinuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.allowPageShiftingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCoverPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.showHideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageLayoutOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigationPaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shortcutManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFirst = new System.Windows.Forms.ToolStripButton();
            this.btnPrevious = new System.Windows.Forms.ToolStripButton();
            this.txtCurrentPage = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.lblPageCount = new System.Windows.Forms.ToolStripLabel();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.btnLast = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnZoomOut = new System.Windows.Forms.ToolStripButton();
            this.cmbZoomPercent = new System.Windows.Forms.ToolStripComboBox();
            this.btnZoomIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRotateClockwise = new System.Windows.Forms.ToolStripButton();
            this.btnRotateAnticlockwise = new System.Windows.Forms.ToolStripButton();
            this.btnRotateCurrentPageClockwise = new System.Windows.Forms.ToolStripButton();
            this.btnRotateCurrentPageAnticlockwise = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSingleNonContinuous = new System.Windows.Forms.ToolStripButton();
            this.btnSingleContinuous = new System.Windows.Forms.ToolStripButton();
            this.btnTwoPageNonContinuous = new System.Windows.Forms.ToolStripButton();
            this.btnTwoPageContinuous = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.btnArrow = new System.Windows.Forms.ToolStripButton();
            this.btnPan = new System.Windows.Forms.ToolStripButton();
            this.AreaSelectionClickEventHandler = new System.Windows.Forms.ToolStripButton();
            this.btnMarquee = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.btnHorizontal = new System.Windows.Forms.ToolStripButton();
            this.btnVertical = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.lblSearch = new System.Windows.Forms.ToolStripLabel();
            this.txtSearchText = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.wholeWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caseSensitiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wrapAroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNextSearch = new System.Windows.Forms.ToolStripButton();
            this.btnPrevSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripPageLayoutOptions = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmbLayoutMode = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.txtColumns = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cmbScrollMode = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.txtHorizontalSpacing = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.txtVerticalSpacing = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.btnShowCoverPage = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.DocumentViewer1 = new Gnostice.Controls.WinForms.DocumentViewer();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStripPageLayoutOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2003, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.printToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.open;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.ToolTipText = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.print;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.ToolTipText = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.Save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.ToolTipText = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.close;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.ToolTipText = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pageRotationToolStripMenuItem,
            this.pageNavigationToolStripMenuItem,
            this.toolStripSeparator1,
            this.pageLayoutToolStripMenuItem,
            this.zoomToolStripMenuItem,
            this.toolStripSeparator2,
            this.showHideToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // pageRotationToolStripMenuItem
            // 
            this.pageRotationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotateClockwiseToolStripMenuItem,
            this.rotateAntiClockwiseToolStripMenuItem,
            this.rotateCurrentPageClockwiseToolStripMenuItem,
            this.rotateCurrentPageAnticlockwiseToolStripMenuItem});
            this.pageRotationToolStripMenuItem.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.rotate;
            this.pageRotationToolStripMenuItem.Name = "pageRotationToolStripMenuItem";
            this.pageRotationToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.pageRotationToolStripMenuItem.Text = "Rotate Page";
            // 
            // rotateClockwiseToolStripMenuItem
            // 
            this.rotateClockwiseToolStripMenuItem.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.rotate_clockwise;
            this.rotateClockwiseToolStripMenuItem.Name = "rotateClockwiseToolStripMenuItem";
            this.rotateClockwiseToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.rotateClockwiseToolStripMenuItem.Text = "Rotate Clockwise";
            this.rotateClockwiseToolStripMenuItem.ToolTipText = "Rotate Clockwise";
            this.rotateClockwiseToolStripMenuItem.Click += new System.EventHandler(this.btnRotateClockwise_Click);
            // 
            // rotateAntiClockwiseToolStripMenuItem
            // 
            this.rotateAntiClockwiseToolStripMenuItem.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.rotate_anticlockwise;
            this.rotateAntiClockwiseToolStripMenuItem.Name = "rotateAntiClockwiseToolStripMenuItem";
            this.rotateAntiClockwiseToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.rotateAntiClockwiseToolStripMenuItem.Text = "Rotate AntiClockwise";
            this.rotateAntiClockwiseToolStripMenuItem.ToolTipText = "Rotate AntiClockwise";
            this.rotateAntiClockwiseToolStripMenuItem.Click += new System.EventHandler(this.btnRotateAnticlockwise_Click);
            // 
            // rotateCurrentPageClockwiseToolStripMenuItem
            // 
            this.rotateCurrentPageClockwiseToolStripMenuItem.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.rotate_clockwise_extra;
            this.rotateCurrentPageClockwiseToolStripMenuItem.Name = "rotateCurrentPageClockwiseToolStripMenuItem";
            this.rotateCurrentPageClockwiseToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.rotateCurrentPageClockwiseToolStripMenuItem.Text = "Rotate Current Page Clockwise";
            this.rotateCurrentPageClockwiseToolStripMenuItem.ToolTipText = "Rotate Current Page Clockwise";
            this.rotateCurrentPageClockwiseToolStripMenuItem.Click += new System.EventHandler(this.btnRotateCurrentPageClockwise_Click);
            // 
            // rotateCurrentPageAnticlockwiseToolStripMenuItem
            // 
            this.rotateCurrentPageAnticlockwiseToolStripMenuItem.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.rotate_anticlockwise_extra;
            this.rotateCurrentPageAnticlockwiseToolStripMenuItem.Name = "rotateCurrentPageAnticlockwiseToolStripMenuItem";
            this.rotateCurrentPageAnticlockwiseToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.rotateCurrentPageAnticlockwiseToolStripMenuItem.Text = "Rotate Current Page Anticlockwise";
            this.rotateCurrentPageAnticlockwiseToolStripMenuItem.ToolTipText = "Rotate Current Page Anticlockwise";
            this.rotateCurrentPageAnticlockwiseToolStripMenuItem.Click += new System.EventHandler(this.btnRotateCurrentPageAnticlockwise_Click);
            // 
            // pageNavigationToolStripMenuItem
            // 
            this.pageNavigationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstPageToolStripMenuItem,
            this.lastPageToolStripMenuItem,
            this.previousPageToolStripMenuItem,
            this.nextPageToolStripMenuItem});
            this.pageNavigationToolStripMenuItem.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.navigation;
            this.pageNavigationToolStripMenuItem.Name = "pageNavigationToolStripMenuItem";
            this.pageNavigationToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.pageNavigationToolStripMenuItem.Text = "Page Navigation";
            // 
            // firstPageToolStripMenuItem
            // 
            this.firstPageToolStripMenuItem.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.first;
            this.firstPageToolStripMenuItem.Name = "firstPageToolStripMenuItem";
            this.firstPageToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.firstPageToolStripMenuItem.Text = "First Page";
            this.firstPageToolStripMenuItem.ToolTipText = "First Page";
            this.firstPageToolStripMenuItem.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // lastPageToolStripMenuItem
            // 
            this.lastPageToolStripMenuItem.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.last;
            this.lastPageToolStripMenuItem.Name = "lastPageToolStripMenuItem";
            this.lastPageToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.lastPageToolStripMenuItem.Text = "Last Page";
            this.lastPageToolStripMenuItem.ToolTipText = "Last Page";
            this.lastPageToolStripMenuItem.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // previousPageToolStripMenuItem
            // 
            this.previousPageToolStripMenuItem.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.previous;
            this.previousPageToolStripMenuItem.Name = "previousPageToolStripMenuItem";
            this.previousPageToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.previousPageToolStripMenuItem.Text = "Previous Page";
            this.previousPageToolStripMenuItem.ToolTipText = "Previous Page";
            this.previousPageToolStripMenuItem.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // nextPageToolStripMenuItem
            // 
            this.nextPageToolStripMenuItem.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.next;
            this.nextPageToolStripMenuItem.Name = "nextPageToolStripMenuItem";
            this.nextPageToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.nextPageToolStripMenuItem.Text = "Next Page";
            this.nextPageToolStripMenuItem.ToolTipText = "Next Page";
            this.nextPageToolStripMenuItem.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // pageLayoutToolStripMenuItem
            // 
            this.pageLayoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singlePageToolStripMenuItem,
            this.singlePageContinuousToolStripMenuItem,
            this.twoPageToolStripMenuItem,
            this.twoPageContinuesToolStripMenuItem,
            this.toolStripSeparator3,
            this.allowPageShiftingToolStripMenuItem,
            this.showCoverPageToolStripMenuItem});
            this.pageLayoutToolStripMenuItem.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.page_layout;
            this.pageLayoutToolStripMenuItem.Name = "pageLayoutToolStripMenuItem";
            this.pageLayoutToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.pageLayoutToolStripMenuItem.Text = "Page Layout";
            // 
            // singlePageToolStripMenuItem
            // 
            this.singlePageToolStripMenuItem.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.SinglePageLayout;
            this.singlePageToolStripMenuItem.Name = "singlePageToolStripMenuItem";
            this.singlePageToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.singlePageToolStripMenuItem.Text = "Single Page ";
            this.singlePageToolStripMenuItem.ToolTipText = "Single Page ";
            this.singlePageToolStripMenuItem.Click += new System.EventHandler(this.btnTwoPageNonContinuous_Click);
            // 
            // singlePageContinuousToolStripMenuItem
            // 
            this.singlePageContinuousToolStripMenuItem.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.ContinuousLayout;
            this.singlePageContinuousToolStripMenuItem.Name = "singlePageContinuousToolStripMenuItem";
            this.singlePageContinuousToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.singlePageContinuousToolStripMenuItem.Text = "Single Page Continuous";
            this.singlePageContinuousToolStripMenuItem.ToolTipText = "Single Page Continuous";
            this.singlePageContinuousToolStripMenuItem.Click += new System.EventHandler(this.btnSingleContinuous_Click);
            // 
            // twoPageToolStripMenuItem
            // 
            this.twoPageToolStripMenuItem.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.SideBySideLayout;
            this.twoPageToolStripMenuItem.Name = "twoPageToolStripMenuItem";
            this.twoPageToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.twoPageToolStripMenuItem.Text = "Two Page";
            this.twoPageToolStripMenuItem.ToolTipText = "Two Page";
            this.twoPageToolStripMenuItem.Click += new System.EventHandler(this.btnTwoPageNonContinuous_Click);
            // 
            // twoPageContinuesToolStripMenuItem
            // 
            this.twoPageContinuesToolStripMenuItem.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.SideBySideLayoutContinuous;
            this.twoPageContinuesToolStripMenuItem.Name = "twoPageContinuesToolStripMenuItem";
            this.twoPageContinuesToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.twoPageContinuesToolStripMenuItem.Text = "Two Page Continues";
            this.twoPageContinuesToolStripMenuItem.ToolTipText = "Two Page Continues";
            this.twoPageContinuesToolStripMenuItem.Click += new System.EventHandler(this.btnTwoPageContinuous_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(197, 6);
            // 
            // allowPageShiftingToolStripMenuItem
            // 
            this.allowPageShiftingToolStripMenuItem.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.tick;
            this.allowPageShiftingToolStripMenuItem.Name = "allowPageShiftingToolStripMenuItem";
            this.allowPageShiftingToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.allowPageShiftingToolStripMenuItem.Text = "Allow Page Shifting";
            this.allowPageShiftingToolStripMenuItem.ToolTipText = "Allow Page Shifting";
            this.allowPageShiftingToolStripMenuItem.Click += new System.EventHandler(this.allowPageShiftingToolStripMenuItem_Click);
            // 
            // showCoverPageToolStripMenuItem
            // 
            this.showCoverPageToolStripMenuItem.Name = "showCoverPageToolStripMenuItem";
            this.showCoverPageToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.showCoverPageToolStripMenuItem.Text = "Show Cover Page";
            this.showCoverPageToolStripMenuItem.ToolTipText = "Show Cover Page";
            this.showCoverPageToolStripMenuItem.Click += new System.EventHandler(this.btnShowCoverPage_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem});
            this.zoomToolStripMenuItem.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.zoom;
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.zoom_in;
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            this.zoomInToolStripMenuItem.ToolTipText = "Zoom In";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.zoom_out;
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            this.zoomOutToolStripMenuItem.ToolTipText = "Zoom Out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(158, 6);
            // 
            // showHideToolStripMenuItem
            // 
            this.showHideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pageLayoutOptionToolStripMenuItem,
            this.navigationPaneToolStripMenuItem});
            this.showHideToolStripMenuItem.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.setting;
            this.showHideToolStripMenuItem.Name = "showHideToolStripMenuItem";
            this.showHideToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.showHideToolStripMenuItem.Text = "Show / Hide";
            // 
            // pageLayoutOptionToolStripMenuItem
            // 
            this.pageLayoutOptionToolStripMenuItem.Name = "pageLayoutOptionToolStripMenuItem";
            this.pageLayoutOptionToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.pageLayoutOptionToolStripMenuItem.Text = "Page Layout Option";
            this.pageLayoutOptionToolStripMenuItem.ToolTipText = "Page Layout Option";
            this.pageLayoutOptionToolStripMenuItem.Click += new System.EventHandler(this.pageLayoutOptionToolStripMenuItem_Click);
            // 
            // navigationPaneToolStripMenuItem
            // 
            this.navigationPaneToolStripMenuItem.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.tick;
            this.navigationPaneToolStripMenuItem.Name = "navigationPaneToolStripMenuItem";
            this.navigationPaneToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.navigationPaneToolStripMenuItem.Text = "Navigation Pane";
            this.navigationPaneToolStripMenuItem.ToolTipText = "Navigation Pane";
            this.navigationPaneToolStripMenuItem.Click += new System.EventHandler(this.navigationPaneToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shortcutManagerToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // shortcutManagerToolStripMenuItem
            // 
            this.shortcutManagerToolStripMenuItem.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.Keyboard;
            this.shortcutManagerToolStripMenuItem.Name = "shortcutManagerToolStripMenuItem";
            this.shortcutManagerToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.shortcutManagerToolStripMenuItem.Text = "Shortcut Manager";
            this.shortcutManagerToolStripMenuItem.ToolTipText = "Shortcut Manager";
            this.shortcutManagerToolStripMenuItem.Click += new System.EventHandler(this.shortcutManagerToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnPrint,
            this.btnSave,
            this.toolStripSeparator4,
            this.btnFirst,
            this.btnPrevious,
            this.txtCurrentPage,
            this.toolStripLabel6,
            this.lblPageCount,
            this.btnNext,
            this.btnLast,
            this.toolStripSeparator5,
            this.btnZoomOut,
            this.cmbZoomPercent,
            this.btnZoomIn,
            this.toolStripSeparator6,
            this.btnRotateClockwise,
            this.btnRotateAnticlockwise,
            this.btnRotateCurrentPageClockwise,
            this.btnRotateCurrentPageAnticlockwise,
            this.toolStripSeparator7,
            this.btnSingleNonContinuous,
            this.btnSingleContinuous,
            this.btnTwoPageNonContinuous,
            this.btnTwoPageContinuous,
            this.toolStripSeparator13,
            this.btnArrow,
            this.btnPan,
            this.AreaSelectionClickEventHandler,
            this.btnMarquee,
            this.toolStripSeparator14,
            this.btnHorizontal,
            this.btnVertical,
            this.toolStripSeparator15,
            this.lblSearch,
            this.txtSearchText,
            this.toolStripSplitButton1,
            this.btnNextSearch,
            this.btnPrevSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(2003, 33);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnOpen
            // 
            this.btnOpen.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.open;
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Margin = new System.Windows.Forms.Padding(5);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(56, 23);
            this.btnOpen.Text = "Open";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.print;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Margin = new System.Windows.Forms.Padding(5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(52, 23);
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.Save;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(51, 23);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // btnFirst
            // 
            this.btnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFirst.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.first;
            this.btnFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(23, 23);
            this.btnFirst.Text = "toolStripButton4";
            this.btnFirst.ToolTipText = "First Page";
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrevious.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.previous;
            this.btnPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(23, 23);
            this.btnPrevious.Text = "toolStripButton5";
            this.btnPrevious.ToolTipText = "Previous Page";
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // txtCurrentPage
            //             
            this.txtCurrentPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCurrentPage.Name = "txtCurrentPage";
            this.txtCurrentPage.Size = new System.Drawing.Size(50, 23);
            this.txtCurrentPage.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCurrentPage.ToolTipText = "Current Page";
            this.txtCurrentPage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCurrentPage_KeyDown);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(12, 30);
            this.toolStripLabel6.Text = "/";
            // 
            // lblPageCount
            // 
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(13, 30);
            this.lblPageCount.Text = "0";
            // 
            // btnNext
            // 
            this.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNext.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.next;
            this.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(23, 23);
            this.btnNext.Text = "toolStripButton6";
            this.btnNext.ToolTipText = "Next Page";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLast.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.last;
            this.btnLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(23, 23);
            this.btnLast.Text = "toolStripButton7";
            this.btnLast.ToolTipText = "Last Page";
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 23);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomOut.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.zoom_out;
            this.btnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(23, 23);
            this.btnZoomOut.Text = "Zoom Out";
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // cmbZoomPercent
            // 
            this.cmbZoomPercent.Items.AddRange(new object[] {
            "10%",
            "25%",
            "50%",
            "75%",
            "100%",
            "125%",
            "200%",
            "400%",
            "800%",
            "1600%",
            "3200%",
            "6400%"});
            this.cmbZoomPercent.Name = "cmbZoomPercent";
            this.cmbZoomPercent.Size = new System.Drawing.Size(100, 23);
            this.cmbZoomPercent.Text = "100%";
            this.cmbZoomPercent.ToolTipText = "Zoom Percent";
            this.cmbZoomPercent.SelectedIndexChanged += new System.EventHandler(this.cmbZoomPercent_SelectedIndexChanged);
            this.cmbZoomPercent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbZoomPercent_KeyDown);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomIn.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.zoom_in;
            this.btnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(23, 23);
            this.btnZoomIn.Text = "Zoom In";
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 23);
            // 
            // btnRotateClockwise
            // 
            this.btnRotateClockwise.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRotateClockwise.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.rotate_clockwise;
            this.btnRotateClockwise.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRotateClockwise.Name = "btnRotateClockwise";
            this.btnRotateClockwise.Size = new System.Drawing.Size(23, 23);
            this.btnRotateClockwise.Text = "toolStripButton10";
            this.btnRotateClockwise.ToolTipText = "Rotate Clockwise";
            this.btnRotateClockwise.Click += new System.EventHandler(this.btnRotateClockwise_Click);
            // 
            // btnRotateAnticlockwise
            // 
            this.btnRotateAnticlockwise.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRotateAnticlockwise.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.rotate_anticlockwise;
            this.btnRotateAnticlockwise.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRotateAnticlockwise.Name = "btnRotateAnticlockwise";
            this.btnRotateAnticlockwise.Size = new System.Drawing.Size(23, 23);
            this.btnRotateAnticlockwise.Text = "toolStripButton11";
            this.btnRotateAnticlockwise.ToolTipText = "Rotate Anticlockwise";
            this.btnRotateAnticlockwise.Click += new System.EventHandler(this.btnRotateAnticlockwise_Click);
            // 
            // btnRotateCurrentPageClockwise
            // 
            this.btnRotateCurrentPageClockwise.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRotateCurrentPageClockwise.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.rotate_clockwise_extra;
            this.btnRotateCurrentPageClockwise.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRotateCurrentPageClockwise.Name = "btnRotateCurrentPageClockwise";
            this.btnRotateCurrentPageClockwise.Size = new System.Drawing.Size(23, 23);
            this.btnRotateCurrentPageClockwise.Text = "toolStripButton12";
            this.btnRotateCurrentPageClockwise.ToolTipText = "Rotate Current Page Clockwise";
            this.btnRotateCurrentPageClockwise.Click += new System.EventHandler(this.btnRotateCurrentPageClockwise_Click);
            // 
            // btnRotateCurrentPageAnticlockwise
            // 
            this.btnRotateCurrentPageAnticlockwise.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRotateCurrentPageAnticlockwise.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.rotate_anticlockwise_extra;
            this.btnRotateCurrentPageAnticlockwise.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRotateCurrentPageAnticlockwise.Name = "btnRotateCurrentPageAnticlockwise";
            this.btnRotateCurrentPageAnticlockwise.Size = new System.Drawing.Size(23, 23);
            this.btnRotateCurrentPageAnticlockwise.Text = "toolStripButton13";
            this.btnRotateCurrentPageAnticlockwise.ToolTipText = "Rotate Current Page Anticlockwise";
            this.btnRotateCurrentPageAnticlockwise.Click += new System.EventHandler(this.btnRotateCurrentPageAnticlockwise_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 23);
            // 
            // btnSingleNonContinuous
            // 
            this.btnSingleNonContinuous.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSingleNonContinuous.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.SinglePageLayout;
            this.btnSingleNonContinuous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSingleNonContinuous.Name = "btnSingleNonContinuous";
            this.btnSingleNonContinuous.Size = new System.Drawing.Size(23, 23);
            this.btnSingleNonContinuous.Text = "toolStripButton14";
            this.btnSingleNonContinuous.ToolTipText = "Single Page Non Continuous";
            this.btnSingleNonContinuous.Click += new System.EventHandler(this.btnSingleNonContinuous_Click);
            // 
            // btnSingleContinuous
            // 
            this.btnSingleContinuous.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSingleContinuous.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.ContinuousLayout;
            this.btnSingleContinuous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSingleContinuous.Name = "btnSingleContinuous";
            this.btnSingleContinuous.Size = new System.Drawing.Size(23, 23);
            this.btnSingleContinuous.Text = "toolStripButton15";
            this.btnSingleContinuous.ToolTipText = "Single Page Continuous";
            this.btnSingleContinuous.Click += new System.EventHandler(this.btnSingleContinuous_Click);
            // 
            // btnTwoPageNonContinuous
            // 
            this.btnTwoPageNonContinuous.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTwoPageNonContinuous.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.SideBySideLayout;
            this.btnTwoPageNonContinuous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTwoPageNonContinuous.Name = "btnTwoPageNonContinuous";
            this.btnTwoPageNonContinuous.Size = new System.Drawing.Size(23, 23);
            this.btnTwoPageNonContinuous.Text = "toolStripButton16";
            this.btnTwoPageNonContinuous.ToolTipText = "Two Page Non Continuous";
            this.btnTwoPageNonContinuous.Click += new System.EventHandler(this.btnTwoPageNonContinuous_Click);
            // 
            // btnTwoPageContinuous
            // 
            this.btnTwoPageContinuous.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTwoPageContinuous.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.SideBySideLayoutContinuous;
            this.btnTwoPageContinuous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTwoPageContinuous.Name = "btnTwoPageContinuous";
            this.btnTwoPageContinuous.Size = new System.Drawing.Size(23, 23);
            this.btnTwoPageContinuous.Text = "toolStripButton17";
            this.btnTwoPageContinuous.ToolTipText = "Two Page Continuous";
            this.btnTwoPageContinuous.Click += new System.EventHandler(this.btnTwoPageContinuous_Click);
            // 
            // toolStripSeparator13
            // 
			this.toolStripSeparator13.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 33);
            // 
            // btnArrow
            // 
            this.btnArrow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnArrow.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.ArrowCursor;
            this.btnArrow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnArrow.Name = "btnArrow";
            this.btnArrow.Size = new System.Drawing.Size(23, 30);
            this.btnArrow.Text = "Selection Tool";
			this.btnArrow.ToolTipText = "Text Selection Tool";
            this.btnArrow.Click += new System.EventHandler(this.btnArrow_Click);
            // 
            // btnPan
            // 
            this.btnPan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPan.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.HandCursor;
            this.btnPan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPan.Name = "btnPan";
            this.btnPan.Size = new System.Drawing.Size(23, 30);
            this.btnPan.Text = "Pan Tool";
			this.btnPan.ToolTipText = "Pan Tool";
            this.btnPan.Click += new System.EventHandler(this.btnPan_Click);
            // 
            // AreaSelectionClickEventHandler
            // 
            this.AreaSelectionClickEventHandler.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AreaSelectionClickEventHandler.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.AreaSelection;
            this.AreaSelectionClickEventHandler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AreaSelectionClickEventHandler.Name = "AreaSelectionClickEventHandler";
            this.AreaSelectionClickEventHandler.Size = new System.Drawing.Size(23, 30);
            this.AreaSelectionClickEventHandler.Text = "AreaSelection";
			this.AreaSelectionClickEventHandler.ToolTipText = "AreaSelection Tool";
            this.AreaSelectionClickEventHandler.Click += new System.EventHandler(this.AreaSelectionButton1_Click);
            // 
            // btnMarquee
            // 
            this.btnMarquee.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMarquee.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.MarqueeZoom;
            this.btnMarquee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMarquee.Name = "btnMarquee";
            this.btnMarquee.Size = new System.Drawing.Size(23, 30);
            this.btnMarquee.Text = "Marquee Zoom";
			this.btnMarquee.ToolTipText = "Marquee Zoom Tool";
            this.btnMarquee.Click += new System.EventHandler(this.btnMarquee_Click);
            // 
            // toolStripSeparator14
            // 
			this.toolStripSeparator14.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 33);
            // 
            // btnHorizontal
            // 
            this.btnHorizontal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHorizontal.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.HOrientation;
            this.btnHorizontal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHorizontal.Name = "btnHorizontal";
            this.btnHorizontal.Size = new System.Drawing.Size(23, 30);
            this.btnHorizontal.Text = "Horizontal Orientation";
			this.btnHorizontal.ToolTipText = "Horizontal Orientation";
            this.btnHorizontal.Click += new System.EventHandler(this.btnHorizontal_Click);
            // 
            // btnVertical
            // 
            this.btnVertical.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnVertical.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.VOrientation;
            this.btnVertical.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVertical.Name = "btnVertical";
            this.btnVertical.Size = new System.Drawing.Size(23, 30);
            this.btnVertical.Text = "Vertical Orientation";
			this.btnVertical.ToolTipText = "Vertical Orientation";
            this.btnVertical.Click += new System.EventHandler(this.btnVertical_Click);
            // 
            // toolStripSeparator15
            // 
			this.toolStripSeparator15.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 33);
            // 
            // lblSearch
            // 
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(42, 30);
            this.lblSearch.Text = "Search";
            // 
            // txtSearchText
            // 
            this.txtSearchText.Name = "txtSearchText";
			this.txtSearchText.ToolTipText = "Input Text";
            this.txtSearchText.Size = new System.Drawing.Size(100, 33);
            this.txtSearchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchText_KeyDown);
            this.txtSearchText.Validated += new System.EventHandler(this.txtSearchText_Validated);
            this.txtSearchText.TextChanged += new System.EventHandler(this.txtSearchText_TextChanged);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownButtonWidth = 35;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wholeWorldToolStripMenuItem,
            this.caseSensitiveToolStripMenuItem,
            this.wrapAroundToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::WinForms_CS_Document_Viewer.Properties.Resources.setting;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
			this.toolStripSplitButton1.ToolTipText = "Search Options";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 30);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // wholeWorldToolStripMenuItem
            // 
            this.wholeWorldToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wholeWorldToolStripMenuItem.CheckOnClick = true;
            this.wholeWorldToolStripMenuItem.Name = "wholeWorldToolStripMenuItem";
            this.wholeWorldToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wholeWorldToolStripMenuItem.Text = "WholeWord";
            this.wholeWorldToolStripMenuItem.CheckedChanged += new System.EventHandler(this.wholeWorldToolStripMenuItem_CheckedChanged);
            // 
            // caseSensitiveToolStripMenuItem
            // 
            this.caseSensitiveToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.caseSensitiveToolStripMenuItem.CheckOnClick = true;
            this.caseSensitiveToolStripMenuItem.Name = "caseSensitiveToolStripMenuItem";
            this.caseSensitiveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.caseSensitiveToolStripMenuItem.Text = "CaseSensitive";
            this.caseSensitiveToolStripMenuItem.CheckedChanged += new System.EventHandler(this.caseSensitiveToolStripMenuItem_CheckedChanged);
            // 
            // wrapAroundToolStripMenuItem
            // 
            this.wrapAroundToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wrapAroundToolStripMenuItem.CheckOnClick = true;
            this.wrapAroundToolStripMenuItem.Name = "wrapAroundToolStripMenuItem";
            this.wrapAroundToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wrapAroundToolStripMenuItem.Text = "WrapAround";
            this.wrapAroundToolStripMenuItem.CheckedChanged += new System.EventHandler(this.wrapAroundToolStripMenuItem_CheckedChanged);
            // 
            // btnNextSearch
            // 
            this.btnNextSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNextSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnNextSearch.Image")));
            this.btnNextSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNextSearch.Name = "btnNextSearch";
			this.btnNextSearch.ToolTipText = "Next Search";
            this.btnNextSearch.Size = new System.Drawing.Size(35, 30);
            this.btnNextSearch.Text = "Next";
            this.btnNextSearch.Click += new System.EventHandler(this.btnNextSearch_Click);
            // 
            // btnPrevSearch
            // 
            this.btnPrevSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPrevSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevSearch.Image")));
            this.btnPrevSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrevSearch.Name = "btnPrevSearch";
			this.btnPrevSearch.ToolTipText = "Previous Search";
            this.btnPrevSearch.Size = new System.Drawing.Size(56, 30);
            this.btnPrevSearch.Text = "Previous";
            this.btnPrevSearch.Click += new System.EventHandler(this.btnPrevSearch_Click);
            // 
            // toolStripPageLayoutOptions
            // 
            this.toolStripPageLayoutOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripPageLayoutOptions.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripPageLayoutOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cmbLayoutMode,
            this.toolStripSeparator8,
            this.toolStripLabel3,
            this.txtColumns,
            this.toolStripSeparator9,
            this.toolStripLabel2,
            this.cmbScrollMode,
            this.toolStripSeparator10,
            this.toolStripLabel4,
            this.txtHorizontalSpacing,
            this.toolStripSeparator11,
            this.toolStripLabel5,
            this.txtVerticalSpacing,
            this.toolStripSeparator12,
            this.btnShowCoverPage});
            this.toolStripPageLayoutOptions.Location = new System.Drawing.Point(0, 477);
            this.toolStripPageLayoutOptions.Name = "toolStripPageLayoutOptions";
            this.toolStripPageLayoutOptions.Size = new System.Drawing.Size(1203, 25);
            this.toolStripPageLayoutOptions.TabIndex = 2;
            this.toolStripPageLayoutOptions.Text = "toolStrip2";
            this.toolStripPageLayoutOptions.Visible = false;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(77, 22);
            this.toolStripLabel1.Text = "Layout Mode";
            // 
            // cmbLayoutMode
            // 
            this.cmbLayoutMode.Items.AddRange(new object[] {
            "Single Page",
            "Two Page",
            "Auto Fit Pages In Window",
            "Specified Columns"});
            this.cmbLayoutMode.Name = "cmbLayoutMode";
            this.cmbLayoutMode.Size = new System.Drawing.Size(121, 25);
            this.cmbLayoutMode.Text = "Single Page";
            this.cmbLayoutMode.SelectedIndexChanged += new System.EventHandler(this.cmbLayoutMode_SelectedIndexChanged);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabel3.Text = "Columns";
            this.toolStripLabel3.ToolTipText = "Columns";
            // 
            // txtColumns
            // 
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(100, 25);
            this.txtColumns.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtColumns_KeyDown);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(70, 22);
            this.toolStripLabel2.Text = "Scroll Mode";
            this.toolStripLabel2.ToolTipText = "Scroll Mode";
            // 
            // cmbScrollMode
            // 
            this.cmbScrollMode.Items.AddRange(new object[] {
            "Continuous",
            "Non Continuous",
            "Non Page Shifting"});
            this.cmbScrollMode.Name = "cmbScrollMode";
            this.cmbScrollMode.Size = new System.Drawing.Size(121, 25);
            this.cmbScrollMode.Text = "Continuous";
            this.cmbScrollMode.SelectedIndexChanged += new System.EventHandler(this.cmbScrollMode_SelectedIndexChanged);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(107, 22);
            this.toolStripLabel4.Text = "Horizontal Spacing";
            this.toolStripLabel4.ToolTipText = "Horizontal Spacing";
            // 
            // txtHorizontalSpacing
            // 
            this.txtHorizontalSpacing.Name = "txtHorizontalSpacing";
            this.txtHorizontalSpacing.Size = new System.Drawing.Size(100, 25);
            this.txtHorizontalSpacing.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHorizontalSpacing_KeyDown);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(90, 22);
            this.toolStripLabel5.Text = "Vertical Spacing";
            this.toolStripLabel5.ToolTipText = "Vertical Spacing";
            // 
            // txtVerticalSpacing
            // 
            this.txtVerticalSpacing.Name = "txtVerticalSpacing";
            this.txtVerticalSpacing.Size = new System.Drawing.Size(100, 25);
            this.txtVerticalSpacing.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVerticalSpacing_KeyDown);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // btnShowCoverPage
            // 
            this.btnShowCoverPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowCoverPage.Name = "btnShowCoverPage";
            this.btnShowCoverPage.Size = new System.Drawing.Size(103, 22);
            this.btnShowCoverPage.Text = "Show Cover Page";
            this.btnShowCoverPage.Click += new System.EventHandler(this.btnShowCoverPage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.pdf";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = resources.GetString("openFileDialog1.Filter");
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "*.pdf";
            this.saveFileDialog1.Filter = "PDF (*.pdf)|*.pdf|Word Document (*.docx)|*.docx|JPG (*.jpg)|*.jpg|TIFF (*.tiff)|*" +
    ".tiff|PNG (*.png)|*.png|BMP (*.bmp)|*.bmp|Text (*.txt)|*.txt|HTML (*.html)|*.htm" +
    "l";
            // 
            // DocumentViewer1
            // 
            this.DocumentViewer1.AllowDrop = true;
            this.DocumentViewer1.AllowInteractivity = false;
            this.DocumentViewer1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DocumentViewer1.BorderWidth = 10F;
            this.DocumentViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentViewer1.HScrollBar.Enabled = false;
            this.DocumentViewer1.HScrollBar.LargeChange = 40F;
            this.DocumentViewer1.HScrollBar.Maximum = 0F;
            this.DocumentViewer1.HScrollBar.Minimum = 0F;
            this.DocumentViewer1.HScrollBar.SmallChange = 20F;
            this.DocumentViewer1.HScrollBar.Value = 0F;
            this.DocumentViewer1.HScrollBar.Visibility = Gnostice.Core.Viewer.ScrollBarVisibility.Always;
            this.DocumentViewer1.HScrollBar.Visible = false;
            this.DocumentViewer1.Location = new System.Drawing.Point(0, 57);
            this.DocumentViewer1.MouseMode = Gnostice.Core.DOM.CursorPreferences.Pan;
            this.DocumentViewer1.Name = "DocumentViewer1";
            this.DocumentViewer1.NavigationPane.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DocumentViewer1.NavigationPane.Visibility = Gnostice.Core.Viewer.Visibility.Auto;
            this.DocumentViewer1.NavigationPane.WidthPercentage = 20;
            this.DocumentViewer1.Orientation = Gnostice.Core.Viewer.ViewerOrientation.Vertical;
            this.DocumentViewer1.PageBreakWidth = 10F;
            pageLayout1.Columns = 1;
            pageLayout1.HorizontalSpacing = 5D;
            pageLayout1.LayoutMode = Gnostice.Core.Viewer.PageLayoutMode.SinglePage;
            pageLayout1.ScrollMode = Gnostice.Core.Viewer.ScrollMode.Continuous;
            pageLayout1.ShowCoverPage = false;
            pageLayout1.VerticalSpacing = 5D;
            this.DocumentViewer1.PageLayout = pageLayout1;
            this.DocumentViewer1.PageRotation = Gnostice.Core.Viewer.RotationAngle.Zero;
            spreadSheetFormatterSettings1.FormattingMode = Gnostice.Core.DOM.FormattingMode.PreferDocumentSettings;
            pageSettings1.Height = 11.6929F;
            margins1.Bottom = 1F;
            margins1.Footer = 0F;
            margins1.Header = 0F;
            margins1.Left = 1F;
            margins1.Right = 1F;
            margins1.Top = 1F;
            pageSettings1.Margin = margins1;
            pageSettings1.Orientation = Gnostice.Core.Graphics.Orientation.Portrait;
            pageSettings1.PageSize = Gnostice.Documents.PageSize.A4;
            pageSettings1.Width = 8.2677F;
            spreadSheetFormatterSettings1.PageSettings = pageSettings1;
            sheetOptions1.Print = false;
            sheetOptions1.View = true;
            spreadSheetFormatterSettings1.ShowGridlines = sheetOptions1;
            sheetOptions2.Print = false;
            sheetOptions2.View = true;
            spreadSheetFormatterSettings1.ShowHeadings = sheetOptions2;
            formatterSettings1.SpreadSheet = spreadSheetFormatterSettings1;
            pageSettings2.Height = 11.6929F;
            margins2.Bottom = 1F;
            margins2.Footer = 0F;
            margins2.Header = 0F;
            margins2.Left = 1F;
            margins2.Right = 1F;
            margins2.Top = 1F;
            pageSettings2.Margin = margins2;
            pageSettings2.Orientation = Gnostice.Core.Graphics.Orientation.Portrait;
            pageSettings2.PageSize = Gnostice.Documents.PageSize.A4;
            pageSettings2.Width = 8.2677F;
            txtFormatterSettings1.PageSettings = pageSettings2;
            formatterSettings1.TXT = txtFormatterSettings1;
            this.DocumentViewer1.Preferences.FormatterSettings = formatterSettings1;
            this.DocumentViewer1.Preferences.KeyNavigation = true;
            imageRenderingSettings1.InterpolationMode = Gnostice.Core.Graphics.InterpolationMode.NearestNeighbor;
            renderingSettings1.Image = imageRenderingSettings1;
            resolutionSettings1.DpiX = 96F;
            resolutionSettings1.DpiY = 96F;
            resolutionSettings1.ResolutionMode = Gnostice.Core.Graphics.ResolutionMode.UseSource;
            renderingSettings1.Resolution = resolutionSettings1;
            shapeRenderingSettings1.CompositingMode = Gnostice.Core.Graphics.CompositingMode.SourceOver;
            shapeRenderingSettings1.CompositingQuality = Gnostice.Core.Graphics.CompositingQuality.Default;
            shapeRenderingSettings1.PixelOffsetMode = Gnostice.Core.Graphics.PixelOffsetMode.HighQuality;
            shapeRenderingSettings1.SmoothingMode = Gnostice.Core.Graphics.SmoothingMode.AntiAlias;
            renderingSettings1.Shape = shapeRenderingSettings1;
            textRenderingSettings1.TextContrast = 4;
            textRenderingSettings1.TextRenderingHint = Gnostice.Core.Graphics.TextRenderingHint.AntiAlias;
            renderingSettings1.Text = textRenderingSettings1;
            this.DocumentViewer1.Preferences.RenderingSettings = renderingSettings1;
            this.DocumentViewer1.Preferences.Units = Gnostice.Core.Graphics.MeasurementUnit.Inches;
            viewerSettings1.AllowInteractivity = false;
            viewerSettings1.LowestRenderingDPI = 0F;
            viewerSettings1.MouseMode = Gnostice.Core.DOM.CursorPreferences.Pan;
            viewerSettings1.Orientation = Gnostice.Core.Viewer.ViewerOrientation.Vertical;
            viewerSettings1.PageBreakWidth = 10F;
            viewerSettings1.PageLayout = pageLayout1;
            viewerSettings1.Rotation = Gnostice.Core.Viewer.RotationAngle.Zero;
            zoom1.InternalZoomMode = Gnostice.Core.Viewer.ZoomMode.ActualSize;
            zoom1.InternalZoomPercent = 100D;
            zoom1.ZoomMode = Gnostice.Core.Viewer.ZoomMode.ActualSize;
            zoom1.ZoomPercent = 100D;
            viewerSettings1.Zoom = zoom1;
            this.DocumentViewer1.Preferences.ViewerSettings = viewerSettings1;
            this.DocumentViewer1.Size = new System.Drawing.Size(2003, 907);
            this.DocumentViewer1.TabIndex = 3;
            this.DocumentViewer1.VScrollBar.Enabled = false;
            this.DocumentViewer1.VScrollBar.LargeChange = 40F;
            this.DocumentViewer1.VScrollBar.Maximum = 0F;
            this.DocumentViewer1.VScrollBar.Minimum = 0F;
            this.DocumentViewer1.VScrollBar.SmallChange = 20F;
            this.DocumentViewer1.VScrollBar.Value = 0F;
            this.DocumentViewer1.VScrollBar.Visibility = Gnostice.Core.Viewer.ScrollBarVisibility.Always;
            this.DocumentViewer1.VScrollBar.Visible = false;
            this.DocumentViewer1.PageChanged += new System.EventHandler<Gnostice.Core.Viewer.PageChangedEventArgs>(this.DocumentViewer1_PageChanged);
            this.DocumentViewer1.ZoomChanged += new System.EventHandler<Gnostice.Core.Viewer.ZoomChangedEventArgs>(this.DocumentViewer1_ZoomChanged);
            this.DocumentViewer1.MouseUp += new System.EventHandler<Gnostice.Core.Viewer.MouseActivityEventArgs>(this.DocumentViewer1_MouseUp);
            this.DocumentViewer1.MouseDown += new System.EventHandler<Gnostice.Core.Viewer.MouseActivityEventArgs>(this.DocumentViewer1_MouseDown);
            this.DocumentViewer1.MouseMove += new System.EventHandler<Gnostice.Core.Viewer.MouseActivityEventArgs>(this.DocumentViewer1_MouseMove);
            this.DocumentViewer1.LastPageRead += new System.EventHandler<Gnostice.Core.LoadCompletedEventArgs>(this.DocumentViewer1_LastPageRead);
            this.DocumentViewer1.PageCountChanged += new System.EventHandler<Gnostice.Core.Viewer.PageCountChangedEventArgs>(this.DocumentViewer1_PageCountChanged);
            this.DocumentViewer1.DragDrop += new System.Windows.Forms.DragEventHandler(this.DocumentViewer1_DragDrop);
            this.DocumentViewer1.DragEnter += new System.Windows.Forms.DragEventHandler(this.DocumentViewer1_DragEnter);
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(2003, 964);
            this.Controls.Add(this.DocumentViewer1);
            this.Controls.Add(this.toolStripPageLayoutOptions);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gnostice Document Studio .NET - WinForms Document Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.DocumentViewer1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.DocumentViewer1_DragEnter);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripPageLayoutOptions.ResumeLayout(false);
            this.toolStripPageLayoutOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageRotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageNavigationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem pageLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem showHideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shortcutManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateClockwiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateAntiClockwiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateCurrentPageClockwiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateCurrentPageAnticlockwiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singlePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singlePageContinuousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twoPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twoPageContinuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allowPageShiftingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCoverPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageLayoutOptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigationPaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnFirst;
        private System.Windows.Forms.ToolStripButton btnPrevious;
        private System.Windows.Forms.ToolStripTextBox txtCurrentPage;
        private System.Windows.Forms.ToolStripButton btnNext;
        private System.Windows.Forms.ToolStripButton btnLast;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnZoomOut;
        private System.Windows.Forms.ToolStripComboBox cmbZoomPercent;
        private System.Windows.Forms.ToolStripButton btnZoomIn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnRotateClockwise;
        private System.Windows.Forms.ToolStripButton btnRotateAnticlockwise;
        private System.Windows.Forms.ToolStripButton btnRotateCurrentPageClockwise;
        private System.Windows.Forms.ToolStripButton btnRotateCurrentPageAnticlockwise;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btnSingleNonContinuous;
        private System.Windows.Forms.ToolStripButton btnSingleContinuous;
        private System.Windows.Forms.ToolStripButton btnTwoPageNonContinuous;
        private System.Windows.Forms.ToolStripButton btnTwoPageContinuous;
        private System.Windows.Forms.ToolStrip toolStripPageLayoutOptions;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cmbLayoutMode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox txtColumns;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cmbScrollMode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox txtHorizontalSpacing;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripTextBox txtVerticalSpacing;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton btnShowCoverPage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripButton btnArrow;
        private System.Windows.Forms.ToolStripButton btnPan;
        private System.Windows.Forms.ToolStripButton btnMarquee;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripButton btnHorizontal;
        private System.Windows.Forms.ToolStripButton btnVertical;
        private Gnostice.Controls.WinForms.DocumentViewer DocumentViewer1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripLabel lblPageCount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripButton AreaSelectionClickEventHandler;
        private System.Windows.Forms.ToolStripLabel lblSearch;
        private System.Windows.Forms.ToolStripTextBox txtSearchText;
        private System.Windows.Forms.ToolStripButton btnNextSearch;
        private System.Windows.Forms.ToolStripButton btnPrevSearch;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem wholeWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caseSensitiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wrapAroundToolStripMenuItem;
    }
}

