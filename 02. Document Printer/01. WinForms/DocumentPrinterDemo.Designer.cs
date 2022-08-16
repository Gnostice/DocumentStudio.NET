using Gnostice.Controls.WinForms;
using Gnostice.Core.DOM;
using Gnostice.Core.Graphics;
using Gnostice.Core.Viewer;

namespace Printer_Demo
{
    partial class DocumentPrinterDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentPrinterDemo));
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
            Gnostice.Core.Graphics.TextRenderingSettings textRenderingSettings1 = new Gnostice.Core.Graphics.TextRenderingSettings();
            Gnostice.Core.Graphics.ShapeRenderingSettings shapeRenderingSettings1 = new Gnostice.Core.Graphics.ShapeRenderingSettings();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSetup = new System.Windows.Forms.Button();
            this.lblSelectedPrinter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.copies = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPageRange = new System.Windows.Forms.TextBox();
            this.rdbtnSeletedRange = new System.Windows.Forms.RadioButton();
            this.rdbtnEven = new System.Windows.Forms.RadioButton();
            this.rdbtnOdd = new System.Windows.Forms.RadioButton();
            this.rdbtnAll = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbScaling = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbVerticalPositioning = new System.Windows.Forms.ComboBox();
            this.cmbHorizontalPositioning = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chckAutoRotate = new System.Windows.Forms.CheckBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.browseFile = new System.Windows.Forms.OpenFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.documentViewer = new Gnostice.Controls.WinForms.DocumentViewer();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copies)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 309F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtInputFilePath, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBrowse, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.documentViewer, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnPrint, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(647, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input File Name:";
            // 
            // txtInputFilePath
            // 
            this.txtInputFilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel1.SetColumnSpan(this.txtInputFilePath, 2);
            this.txtInputFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInputFilePath.Location = new System.Drawing.Point(3, 16);
            this.txtInputFilePath.Name = "txtInputFilePath";
            this.txtInputFilePath.ReadOnly = true;
            this.txtInputFilePath.Size = new System.Drawing.Size(585, 20);
            this.txtInputFilePath.TabIndex = 0;
            this.txtInputFilePath.Click += new System.EventHandler(this.TxtInputFilePath_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.Green;
            this.btnBrowse.Location = new System.Drawing.Point(594, 16);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(50, 20);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSetup);
            this.groupBox1.Controls.Add(this.lblSelectedPrinter);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 58);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Print Setup:";
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(220, 27);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(75, 23);
            this.btnSetup.TabIndex = 0;
            this.btnSetup.Text = "&Setup...";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.BtnSetup_Click);
            // 
            // lblSelectedPrinter
            // 
            this.lblSelectedPrinter.AutoSize = true;
            this.lblSelectedPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedPrinter.ForeColor = System.Drawing.Color.Blue;
            this.lblSelectedPrinter.Location = new System.Drawing.Point(10, 37);
            this.lblSelectedPrinter.MaximumSize = new System.Drawing.Size(195, 0);
            this.lblSelectedPrinter.Name = "lblSelectedPrinter";
            this.lblSelectedPrinter.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedPrinter.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selected Printer:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.copies);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(3, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 120);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pages to Print:";
            // 
            // copies
            // 
            this.copies.Location = new System.Drawing.Point(54, 89);
            this.copies.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.copies.Name = "copies";
            this.copies.Size = new System.Drawing.Size(120, 20);
            this.copies.TabIndex = 7;
            this.copies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Copies:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPageRange);
            this.panel1.Controls.Add(this.rdbtnSeletedRange);
            this.panel1.Controls.Add(this.rdbtnEven);
            this.panel1.Controls.Add(this.rdbtnOdd);
            this.panel1.Controls.Add(this.rdbtnAll);
            this.panel1.Location = new System.Drawing.Point(3, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 64);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "(Example: 1, 3-5, 8, 12)";
            // 
            // txtPageRange
            // 
            this.txtPageRange.Location = new System.Drawing.Point(114, 24);
            this.txtPageRange.Name = "txtPageRange";
            this.txtPageRange.Size = new System.Drawing.Size(172, 20);
            this.txtPageRange.TabIndex = 7;
            // 
            // rdbtnSeletedRange
            // 
            this.rdbtnSeletedRange.AutoSize = true;
            this.rdbtnSeletedRange.Location = new System.Drawing.Point(2, 26);
            this.rdbtnSeletedRange.Name = "rdbtnSeletedRange";
            this.rdbtnSeletedRange.Size = new System.Drawing.Size(105, 17);
            this.rdbtnSeletedRange.TabIndex = 6;
            this.rdbtnSeletedRange.Text = "Selected Range:";
            this.rdbtnSeletedRange.UseVisualStyleBackColor = true;
            // 
            // rdbtnEven
            // 
            this.rdbtnEven.AutoSize = true;
            this.rdbtnEven.Location = new System.Drawing.Point(162, 3);
            this.rdbtnEven.Name = "rdbtnEven";
            this.rdbtnEven.Size = new System.Drawing.Size(83, 17);
            this.rdbtnEven.TabIndex = 4;
            this.rdbtnEven.Text = "Even Pages";
            this.rdbtnEven.UseVisualStyleBackColor = true;
            // 
            // rdbtnOdd
            // 
            this.rdbtnOdd.AutoSize = true;
            this.rdbtnOdd.Location = new System.Drawing.Point(78, 3);
            this.rdbtnOdd.Name = "rdbtnOdd";
            this.rdbtnOdd.Size = new System.Drawing.Size(78, 17);
            this.rdbtnOdd.TabIndex = 5;
            this.rdbtnOdd.Text = "Odd Pages";
            this.rdbtnOdd.UseVisualStyleBackColor = true;
            // 
            // rdbtnAll
            // 
            this.rdbtnAll.AutoSize = true;
            this.rdbtnAll.Checked = true;
            this.rdbtnAll.Location = new System.Drawing.Point(3, 3);
            this.rdbtnAll.Name = "rdbtnAll";
            this.rdbtnAll.Size = new System.Drawing.Size(69, 17);
            this.rdbtnAll.TabIndex = 0;
            this.rdbtnAll.TabStop = true;
            this.rdbtnAll.Text = "All Pages";
            this.rdbtnAll.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbScaling);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.chckAutoRotate);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 158);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Printing Preferences:";
            // 
            // cmbScaling
            // 
            this.cmbScaling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScaling.FormattingEnabled = true;
            this.cmbScaling.Items.AddRange(new object[] {
            "Original size - print without scaling",
            "Fit document page to printer paper always",
            "Shrink only oversized page to fit printer paper"});
            this.cmbScaling.Location = new System.Drawing.Point(7, 131);
            this.cmbScaling.Name = "cmbScaling";
            this.cmbScaling.Size = new System.Drawing.Size(288, 21);
            this.cmbScaling.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Page Scaling:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.cmbVerticalPositioning);
            this.groupBox4.Controls.Add(this.cmbHorizontalPositioning);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(7, 44);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(288, 68);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Page Positioning:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Vertical";
            // 
            // cmbVerticalPositioning
            // 
            this.cmbVerticalPositioning.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVerticalPositioning.FormattingEnabled = true;
            this.cmbVerticalPositioning.Items.AddRange(new object[] {
            "Top of paper",
            "Center of paper",
            "Bottom of paper"});
            this.cmbVerticalPositioning.Location = new System.Drawing.Point(149, 37);
            this.cmbVerticalPositioning.Name = "cmbVerticalPositioning";
            this.cmbVerticalPositioning.Size = new System.Drawing.Size(133, 21);
            this.cmbVerticalPositioning.TabIndex = 1;
            // 
            // cmbHorizontalPositioning
            // 
            this.cmbHorizontalPositioning.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorizontalPositioning.FormattingEnabled = true;
            this.cmbHorizontalPositioning.Items.AddRange(new object[] {
            "Left of paper",
            "Center of paper",
            "Right of paper"});
            this.cmbHorizontalPositioning.Location = new System.Drawing.Point(10, 37);
            this.cmbHorizontalPositioning.Name = "cmbHorizontalPositioning";
            this.cmbHorizontalPositioning.Size = new System.Drawing.Size(133, 21);
            this.cmbHorizontalPositioning.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Horizontal";
            // 
            // chckAutoRotate
            // 
            this.chckAutoRotate.AutoSize = true;
            this.chckAutoRotate.Checked = true;
            this.chckAutoRotate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckAutoRotate.Location = new System.Drawing.Point(7, 19);
            this.chckAutoRotate.Name = "chckAutoRotate";
            this.chckAutoRotate.Size = new System.Drawing.Size(202, 17);
            this.chckAutoRotate.TabIndex = 0;
            this.chckAutoRotate.Text = "Automatically rotate landscape pages";
            this.chckAutoRotate.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(3, 396);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(303, 50);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // browseFile
            // 
            this.browseFile.Filter = resources.GetString("browseFile.Filter");
            // 
            // documentViewer
            // 
            this.documentViewer.BackColor = System.Drawing.SystemColors.ControlDark;
            //this.documentViewer.BorderWidth = 10;
            this.tableLayoutPanel1.SetColumnSpan(this.documentViewer, 2);
            //this.documentViewer.CurrentPage = 0;
            this.documentViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            /*this.documentViewer.HScrollBar.LargeChange = 40;
            this.documentViewer.HScrollBar.SmallChange = 20;
            this.documentViewer.HScrollBar.Value = 0;
            this.documentViewer.HScrollBar.Visibility = ScrollBarVisibility.Always;*/
            this.documentViewer.Location = new System.Drawing.Point(312, 42);
            this.documentViewer.Name = "documentViewer";
            // 
            // 
            // 
            /*this.documentViewer.NavigationPane.ActivePage = null;
            this.documentViewer.NavigationPane.Location = new System.Drawing.Point(0, 0);
            this.documentViewer.NavigationPane.Name = "";
            this.documentViewer.NavigationPane.TabIndex = 0;
            this.documentViewer.NavigationPane.Visibility = Visibility.Auto;
            this.documentViewer.NavigationPane.WidthPercentage = 20;
            this.documentViewer.VScrollBar.LargeChange = 40;
            this.documentViewer.VScrollBar.SmallChange = 20;
            this.documentViewer.VScrollBar.Value = 0;
            this.documentViewer.VScrollBar.Visibility = ScrollBarVisibility.Always;*/
            this.documentViewer.Zoom.ZoomMode = ZoomMode.FitWidth;
            this.documentViewer.Zoom.ZoomPercent = 100D;
            this.documentViewer.Click += new System.EventHandler(this.DocumentViewer_Click);
            this.documentViewer.PageLayout = new PageLayout();
            this.documentViewer.PageRotation = RotationAngle.Zero;
            spreadSheetFormatterSettings1.FormattingMode = FormattingMode.PreferDocumentSettings;
            //spreadSheetFormatterSettings1.PageOrder = Gnostice.Documents.Spreadsheet.LayoutDirection.BackwardN;
            pageSettings1.Height = 11.6929F;
            margins1.Bottom = 1F;
            margins1.Footer = 0F;
            margins1.Header = 0F;
            margins1.Left = 1F;
            margins1.Right = 1F;
            margins1.Top = 1F;
            pageSettings1.Margin = margins1;
            pageSettings1.Orientation = Orientation.Portrait;
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
            txtFormatterSettings1.Font = new Font("Calibri", 12F);
            pageSettings2.Height = 11.6929F;
            margins2.Bottom = 1F;
            margins2.Footer = 0F;
            margins2.Header = 0F;
            margins2.Left = 1F;
            margins2.Right = 1F;
            margins2.Top = 1F;
            pageSettings2.Margin = margins2;
            pageSettings2.Orientation = Orientation.Portrait;
            pageSettings2.PageSize = Gnostice.Documents.PageSize.A4;
            pageSettings2.Width = 8.2677F;
            txtFormatterSettings1.PageSettings = pageSettings2;
            formatterSettings1.TXT = txtFormatterSettings1;
            //this.documentViewer.Preferences.FormatterSettings = formatterSettings1;
            //this.documentViewer.Preferences.KeyNavigation = true;
            shapeRenderingSettings1.CompositingMode = CompositingMode.SourceOver;
            shapeRenderingSettings1.CompositingQuality = CompositingQuality.Default;
            shapeRenderingSettings1.PixelOffsetMode = PixelOffsetMode.Default;
            shapeRenderingSettings1.SmoothingMode = SmoothingMode.AntiAlias;
            renderingSettings1.Shape = shapeRenderingSettings1;
            imageRenderingSettings1.InterpolationMode = InterpolationMode.Bilinear;
            renderingSettings1.Image = imageRenderingSettings1;
            resolutionSettings1.DpiX = 96F;
            resolutionSettings1.DpiY = 96F;
            resolutionSettings1.ResolutionMode = ResolutionMode.UseSource;
            renderingSettings1.Resolution = resolutionSettings1;
            textRenderingSettings1.TextContrast = 3;
            textRenderingSettings1.TextRenderingHint = TextRenderingHint.AntiAlias;
            renderingSettings1.Text = textRenderingSettings1;
            //this.documentViewer.Preferences.RenderingSettings = renderingSettings1;
            //this.documentViewer.Preferences.Units = MeasurementUnit.Inches;
            this.tableLayoutPanel1.SetRowSpan(this.documentViewer, 5);
            this.documentViewer.Size = new System.Drawing.Size(332, 405);
            this.documentViewer.TabIndex = 6;
            // 
            // DocumentPrinterDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 470);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DocumentPrinterDemo";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gnostice Document Studio .NET - Document Printer";
            this.Load += new System.EventHandler(this.DocumentPrinter_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copies)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Label lblSelectedPrinter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbtnAll;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbScaling;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbVerticalPositioning;
        private System.Windows.Forms.ComboBox cmbHorizontalPositioning;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chckAutoRotate;
        private System.Windows.Forms.OpenFileDialog browseFile;
        private System.Windows.Forms.PrintDialog printDialog1;
        private Gnostice.Controls.WinForms.DocumentViewer documentViewer;
        private System.Windows.Forms.RadioButton rdbtnOdd;
        private System.Windows.Forms.RadioButton rdbtnEven;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown copies;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPageRange;
        private System.Windows.Forms.RadioButton rdbtnSeletedRange;
        private System.Windows.Forms.Label label4;
    }
}

