namespace MailMergeDemo
{
    partial class Form1
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
            Gnostice.Core.Graphics.RenderingSettings renderingSettings1 = new Gnostice.Core.Graphics.RenderingSettings();
            Gnostice.Core.Graphics.ImageRenderingSettings imageRenderingSettings1 = new Gnostice.Core.Graphics.ImageRenderingSettings();
            Gnostice.Core.Graphics.ShapeRenderingSettings shapeRenderingSettings1 = new Gnostice.Core.Graphics.ShapeRenderingSettings();
            Gnostice.Core.Graphics.ResolutionSettings resolutionSettings1 = new Gnostice.Core.Graphics.ResolutionSettings();
            Gnostice.Core.Graphics.TextRenderingSettings textRenderingSettings1 = new Gnostice.Core.Graphics.TextRenderingSettings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.documentViewer1 = new Gnostice.Controls.WinForms.DocumentViewer();
            this.grpMailMergeClass = new System.Windows.Forms.GroupBox();
            this.cmbDataTableName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.cmbMergeInstanceBreakTYpe = new System.Windows.Forms.ComboBox();
            this.cmbCleanUpOptions = new System.Windows.Forms.ComboBox();
            this.lblMergeInstanceBreakType = new System.Windows.Forms.Label();
            this.lblCleanUpOptions = new System.Windows.Forms.Label();
            this.lblFieldMapping = new System.Windows.Forms.Label();
            this.dataGridViewMergeFields = new System.Windows.Forms.DataGridView();
            this.btnDataSource = new System.Windows.Forms.Button();
            this.txtDataSource = new System.Windows.Forms.TextBox();
            this.lblDataSource = new System.Windows.Forms.Label();
            this.btnInputTemplate = new System.Windows.Forms.Button();
            this.txtInputTemplate = new System.Windows.Forms.TextBox();
            this.lblInputTemplate = new System.Windows.Forms.Label();
            this.grpPostMergeAction = new System.Windows.Forms.GroupBox();
            this.cmbOutputFileFormat = new System.Windows.Forms.ComboBox();
            this.pnlSaveToFile = new System.Windows.Forms.Panel();
            this.lblOutputFileName = new System.Windows.Forms.Label();
            this.txtOutputFileName = new System.Windows.Forms.TextBox();
            this.btnBrowseOutputDirectory = new System.Windows.Forms.Button();
            this.txtOutputDirectory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.pnlEmailAction = new System.Windows.Forms.Panel();
            this.cmbUseMergedDocumentAs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkEnableSSL = new System.Windows.Forms.CheckBox();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.grpMessage = new System.Windows.Forms.GroupBox();
            this.cmbMailFormat = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstAttachments = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBCC = new System.Windows.Forms.TextBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.txtTO = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.rtbBody = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPostMergeAction = new System.Windows.Forms.ComboBox();
            this.lblPostMergeAction = new System.Windows.Forms.Label();
            this.lblOutputFileFormat = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.grpMailMergeClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMergeFields)).BeginInit();
            this.grpPostMergeAction.SuspendLayout();
            this.pnlSaveToFile.SuspendLayout();
            this.pnlEmailAction.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grpMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // documentViewer1
            // 
            this.documentViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.documentViewer1.BackColor = System.Drawing.SystemColors.ControlDark;
            /*this.documentViewer1.BorderWidth = 10;
            this.documentViewer1.CurrentPage = 0;
            this.documentViewer1.HScrollBar.LargeChange = 40;
            this.documentViewer1.HScrollBar.SmallChange = 20;
            this.documentViewer1.HScrollBar.Value = 0;
            this.documentViewer1.HScrollBar.Visibility = Gnostice.Core.Viewer.ScrollBarVisibility.Always;*/
            this.documentViewer1.Location = new System.Drawing.Point(453, 12);
            this.documentViewer1.Name = "documentViewer1";
            // 
            // 
            // 
            /*this.documentViewer1.NavigationPane.ActivePage = null;
            this.documentViewer1.NavigationPane.Location = new System.Drawing.Point(0, 0);
            this.documentViewer1.NavigationPane.Name = "";
            this.documentViewer1.NavigationPane.TabIndex = 0;
            this.documentViewer1.NavigationPane.Visibility = Gnostice.Core.Viewer.Visibility.Never;*/
            this.documentViewer1.PageLayout = null;
            this.documentViewer1.PageRotation = Gnostice.Core.Viewer.RotationAngle.Zero;
            //this.documentViewer1.Preferences.KeyNavigation = true;
            shapeRenderingSettings1.CompositingMode = Gnostice.Core.Graphics.CompositingMode.SourceOver;
            shapeRenderingSettings1.CompositingQuality = Gnostice.Core.Graphics.CompositingQuality.Default;
            shapeRenderingSettings1.PixelOffsetMode = Gnostice.Core.Graphics.PixelOffsetMode.Default;
            shapeRenderingSettings1.SmoothingMode = Gnostice.Core.Graphics.SmoothingMode.AntiAlias;
            renderingSettings1.Shape = shapeRenderingSettings1;
            imageRenderingSettings1.InterpolationMode = Gnostice.Core.Graphics.InterpolationMode.Bilinear;
            renderingSettings1.Image = imageRenderingSettings1;
            resolutionSettings1.DpiX = 96F;
            resolutionSettings1.DpiY = 96F;
            resolutionSettings1.ResolutionMode = Gnostice.Core.Graphics.ResolutionMode.UseSource;
            renderingSettings1.Resolution = resolutionSettings1;
            textRenderingSettings1.TextContrast = 3;
            textRenderingSettings1.TextRenderingHint = Gnostice.Core.Graphics.TextRenderingHint.AntiAlias;
            renderingSettings1.Text = textRenderingSettings1;
            //this.documentViewer1.Preferences.RenderingSettings = renderingSettings1;
            this.documentViewer1.Size = new System.Drawing.Size(469, 638);
            this.documentViewer1.TabIndex = 0;
            /*this.documentViewer1.VScrollBar.LargeChange = 40;
            this.documentViewer1.VScrollBar.SmallChange = 20;
            this.documentViewer1.VScrollBar.Value = 0;
            this.documentViewer1.VScrollBar.Visibility = Gnostice.Core.Viewer.ScrollBarVisibility.Always;*/
            this.documentViewer1.Zoom.ZoomPercent = 100D;
            this.documentViewer1.Zoom.ZoomMode = Gnostice.Core.Viewer.ZoomMode.FitWidth;
            // 
            // grpMailMergeClass
            // 
            this.grpMailMergeClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpMailMergeClass.Controls.Add(this.cmbDataTableName);
            this.grpMailMergeClass.Controls.Add(this.label1);
            this.grpMailMergeClass.Controls.Add(this.btnNext);
            this.grpMailMergeClass.Controls.Add(this.cmbMergeInstanceBreakTYpe);
            this.grpMailMergeClass.Controls.Add(this.cmbCleanUpOptions);
            this.grpMailMergeClass.Controls.Add(this.lblMergeInstanceBreakType);
            this.grpMailMergeClass.Controls.Add(this.lblCleanUpOptions);
            this.grpMailMergeClass.Controls.Add(this.lblFieldMapping);
            this.grpMailMergeClass.Controls.Add(this.dataGridViewMergeFields);
            this.grpMailMergeClass.Controls.Add(this.btnDataSource);
            this.grpMailMergeClass.Controls.Add(this.txtDataSource);
            this.grpMailMergeClass.Controls.Add(this.lblDataSource);
            this.grpMailMergeClass.Controls.Add(this.btnInputTemplate);
            this.grpMailMergeClass.Controls.Add(this.txtInputTemplate);
            this.grpMailMergeClass.Controls.Add(this.lblInputTemplate);
            this.grpMailMergeClass.Location = new System.Drawing.Point(474, 12);
            this.grpMailMergeClass.Name = "grpMailMergeClass";
            this.grpMailMergeClass.Size = new System.Drawing.Size(435, 646);
            this.grpMailMergeClass.TabIndex = 1;
            this.grpMailMergeClass.TabStop = false;
            this.grpMailMergeClass.Visible = false;
            // 
            // cmbDataTableName
            // 
            this.cmbDataTableName.FormattingEnabled = true;
            this.cmbDataTableName.Location = new System.Drawing.Point(90, 102);
            this.cmbDataTableName.Name = "cmbDataTableName";
            this.cmbDataTableName.Size = new System.Drawing.Size(256, 21);
            this.cmbDataTableName.TabIndex = 14;
            this.cmbDataTableName.SelectedIndexChanged += new System.EventHandler(this.cmbDataTableName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Data Table *";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNext.Location = new System.Drawing.Point(354, 617);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cmbMergeInstanceBreakTYpe
            // 
            this.cmbMergeInstanceBreakTYpe.FormattingEnabled = true;
            this.cmbMergeInstanceBreakTYpe.Location = new System.Drawing.Point(159, 571);
            this.cmbMergeInstanceBreakTYpe.Name = "cmbMergeInstanceBreakTYpe";
            this.cmbMergeInstanceBreakTYpe.Size = new System.Drawing.Size(270, 21);
            this.cmbMergeInstanceBreakTYpe.TabIndex = 11;
            // 
            // cmbCleanUpOptions
            // 
            this.cmbCleanUpOptions.FormattingEnabled = true;
            this.cmbCleanUpOptions.Location = new System.Drawing.Point(159, 529);
            this.cmbCleanUpOptions.Name = "cmbCleanUpOptions";
            this.cmbCleanUpOptions.Size = new System.Drawing.Size(270, 21);
            this.cmbCleanUpOptions.TabIndex = 10;
            // 
            // lblMergeInstanceBreakType
            // 
            this.lblMergeInstanceBreakType.AutoSize = true;
            this.lblMergeInstanceBreakType.Location = new System.Drawing.Point(6, 574);
            this.lblMergeInstanceBreakType.Name = "lblMergeInstanceBreakType";
            this.lblMergeInstanceBreakType.Size = new System.Drawing.Size(139, 13);
            this.lblMergeInstanceBreakType.TabIndex = 9;
            this.lblMergeInstanceBreakType.Text = "Merge Instance Break Type";
            // 
            // lblCleanUpOptions
            // 
            this.lblCleanUpOptions.AutoSize = true;
            this.lblCleanUpOptions.Location = new System.Drawing.Point(6, 532);
            this.lblCleanUpOptions.Name = "lblCleanUpOptions";
            this.lblCleanUpOptions.Size = new System.Drawing.Size(90, 13);
            this.lblCleanUpOptions.TabIndex = 8;
            this.lblCleanUpOptions.Text = "Clean Up Options";
            // 
            // lblFieldMapping
            // 
            this.lblFieldMapping.AutoSize = true;
            this.lblFieldMapping.Location = new System.Drawing.Point(6, 152);
            this.lblFieldMapping.Name = "lblFieldMapping";
            this.lblFieldMapping.Size = new System.Drawing.Size(73, 13);
            this.lblFieldMapping.TabIndex = 7;
            this.lblFieldMapping.Text = "Field Mapping";
            // 
            // dataGridViewMergeFields
            // 
            this.dataGridViewMergeFields.AllowUserToAddRows = false;
            this.dataGridViewMergeFields.AllowUserToDeleteRows = false;
            this.dataGridViewMergeFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMergeFields.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMergeFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMergeFields.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewMergeFields.Location = new System.Drawing.Point(9, 168);
            this.dataGridViewMergeFields.MultiSelect = false;
            this.dataGridViewMergeFields.Name = "dataGridViewMergeFields";
            this.dataGridViewMergeFields.ReadOnly = true;
            this.dataGridViewMergeFields.RowHeadersVisible = false;
            this.dataGridViewMergeFields.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMergeFields.Size = new System.Drawing.Size(420, 340);
            this.dataGridViewMergeFields.TabIndex = 6;
            // 
            // btnDataSource
            // 
            this.btnDataSource.Location = new System.Drawing.Point(354, 60);
            this.btnDataSource.Name = "btnDataSource";
            this.btnDataSource.Size = new System.Drawing.Size(75, 23);
            this.btnDataSource.TabIndex = 5;
            this.btnDataSource.Text = "Browse";
            this.btnDataSource.UseVisualStyleBackColor = true;
            this.btnDataSource.Click += new System.EventHandler(this.btnDataSource_Click);
            // 
            // txtDataSource
            // 
            this.txtDataSource.Location = new System.Drawing.Point(90, 61);
            this.txtDataSource.Name = "txtDataSource";
            this.txtDataSource.Size = new System.Drawing.Size(256, 20);
            this.txtDataSource.TabIndex = 4;
            // 
            // lblDataSource
            // 
            this.lblDataSource.AutoSize = true;
            this.lblDataSource.Location = new System.Drawing.Point(6, 65);
            this.lblDataSource.Name = "lblDataSource";
            this.lblDataSource.Size = new System.Drawing.Size(74, 13);
            this.lblDataSource.TabIndex = 3;
            this.lblDataSource.Text = "Data Source *";
            // 
            // btnInputTemplate
            // 
            this.btnInputTemplate.Location = new System.Drawing.Point(354, 19);
            this.btnInputTemplate.Name = "btnInputTemplate";
            this.btnInputTemplate.Size = new System.Drawing.Size(75, 23);
            this.btnInputTemplate.TabIndex = 2;
            this.btnInputTemplate.Text = "Browse";
            this.btnInputTemplate.UseVisualStyleBackColor = true;
            this.btnInputTemplate.Click += new System.EventHandler(this.btnInputTemplate_Click);
            // 
            // txtInputTemplate
            // 
            this.txtInputTemplate.Location = new System.Drawing.Point(92, 20);
            this.txtInputTemplate.Name = "txtInputTemplate";
            this.txtInputTemplate.Size = new System.Drawing.Size(256, 20);
            this.txtInputTemplate.TabIndex = 1;
            this.txtInputTemplate.TextChanged += new System.EventHandler(this.txtInputTemplate_TextChanged);
            // 
            // lblInputTemplate
            // 
            this.lblInputTemplate.AutoSize = true;
            this.lblInputTemplate.Location = new System.Drawing.Point(6, 24);
            this.lblInputTemplate.Name = "lblInputTemplate";
            this.lblInputTemplate.Size = new System.Drawing.Size(85, 13);
            this.lblInputTemplate.TabIndex = 0;
            this.lblInputTemplate.Text = "Input Template *";
            // 
            // grpPostMergeAction
            // 
            this.grpPostMergeAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpPostMergeAction.Controls.Add(this.cmbOutputFileFormat);
            this.grpPostMergeAction.Controls.Add(this.pnlSaveToFile);
            this.grpPostMergeAction.Controls.Add(this.btnMerge);
            this.grpPostMergeAction.Controls.Add(this.btnPrevious);
            this.grpPostMergeAction.Controls.Add(this.pnlEmailAction);
            this.grpPostMergeAction.Controls.Add(this.cmbPostMergeAction);
            this.grpPostMergeAction.Controls.Add(this.lblPostMergeAction);
            this.grpPostMergeAction.Controls.Add(this.lblOutputFileFormat);
            this.grpPostMergeAction.Location = new System.Drawing.Point(12, 6);
            this.grpPostMergeAction.Name = "grpPostMergeAction";
            this.grpPostMergeAction.Size = new System.Drawing.Size(435, 646);
            this.grpPostMergeAction.TabIndex = 4;
            this.grpPostMergeAction.TabStop = false;
            this.grpPostMergeAction.Visible = false;
            // 
            // cmbOutputFileFormat
            // 
            this.cmbOutputFileFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOutputFileFormat.FormattingEnabled = true;
            this.cmbOutputFileFormat.Items.AddRange(new object[] {
            "PDF",
            "DOCX",
            "BMP",
            "JPEG",
            "PNG",
            "TIFF",
            "Multipage TIFF",
            "TXT",
            "HTML"});
            this.cmbOutputFileFormat.Location = new System.Drawing.Point(108, 48);
            this.cmbOutputFileFormat.Name = "cmbOutputFileFormat";
            this.cmbOutputFileFormat.Size = new System.Drawing.Size(320, 21);
            this.cmbOutputFileFormat.TabIndex = 17;
            // 
            // pnlSaveToFile
            // 
            this.pnlSaveToFile.Controls.Add(this.lblOutputFileName);
            this.pnlSaveToFile.Controls.Add(this.txtOutputFileName);
            this.pnlSaveToFile.Controls.Add(this.btnBrowseOutputDirectory);
            this.pnlSaveToFile.Controls.Add(this.txtOutputDirectory);
            this.pnlSaveToFile.Controls.Add(this.label3);
            this.pnlSaveToFile.Location = new System.Drawing.Point(6, 75);
            this.pnlSaveToFile.Name = "pnlSaveToFile";
            this.pnlSaveToFile.Size = new System.Drawing.Size(422, 88);
            this.pnlSaveToFile.TabIndex = 2;
            this.pnlSaveToFile.Visible = false;
            // 
            // lblOutputFileName
            // 
            this.lblOutputFileName.AutoSize = true;
            this.lblOutputFileName.Location = new System.Drawing.Point(3, 49);
            this.lblOutputFileName.Name = "lblOutputFileName";
            this.lblOutputFileName.Size = new System.Drawing.Size(89, 13);
            this.lblOutputFileName.TabIndex = 6;
            this.lblOutputFileName.Text = "Output File Name";
            // 
            // txtOutputFileName
            // 
            this.txtOutputFileName.Location = new System.Drawing.Point(102, 46);
            this.txtOutputFileName.Name = "txtOutputFileName";
            this.txtOutputFileName.Size = new System.Drawing.Size(320, 20);
            this.txtOutputFileName.TabIndex = 0;
            this.txtOutputFileName.Text = "MergedOutput";
            // 
            // btnBrowseOutputDirectory
            // 
            this.btnBrowseOutputDirectory.Location = new System.Drawing.Point(373, 12);
            this.btnBrowseOutputDirectory.Name = "btnBrowseOutputDirectory";
            this.btnBrowseOutputDirectory.Size = new System.Drawing.Size(49, 23);
            this.btnBrowseOutputDirectory.TabIndex = 5;
            this.btnBrowseOutputDirectory.Text = "...";
            this.btnBrowseOutputDirectory.UseVisualStyleBackColor = true;
            this.btnBrowseOutputDirectory.Click += new System.EventHandler(this.btnBrowseOutputDirectory_Click);
            // 
            // txtOutputDirectory
            // 
            this.txtOutputDirectory.Location = new System.Drawing.Point(102, 15);
            this.txtOutputDirectory.Name = "txtOutputDirectory";
            this.txtOutputDirectory.Size = new System.Drawing.Size(264, 20);
            this.txtOutputDirectory.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Output Directory *";
            // 
            // btnMerge
            // 
            this.btnMerge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMerge.Location = new System.Drawing.Point(354, 617);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(75, 23);
            this.btnMerge.TabIndex = 16;
            this.btnMerge.Text = "Merge";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevious.Location = new System.Drawing.Point(10, 617);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 15;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // pnlEmailAction
            // 
            this.pnlEmailAction.Controls.Add(this.cmbUseMergedDocumentAs);
            this.pnlEmailAction.Controls.Add(this.label2);
            this.pnlEmailAction.Controls.Add(this.groupBox4);
            this.pnlEmailAction.Controls.Add(this.grpMessage);
            this.pnlEmailAction.Location = new System.Drawing.Point(6, 75);
            this.pnlEmailAction.Name = "pnlEmailAction";
            this.pnlEmailAction.Size = new System.Drawing.Size(422, 536);
            this.pnlEmailAction.TabIndex = 3;
            // 
            // cmbUseMergedDocumentAs
            // 
            this.cmbUseMergedDocumentAs.FormattingEnabled = true;
            this.cmbUseMergedDocumentAs.Location = new System.Drawing.Point(141, 502);
            this.cmbUseMergedDocumentAs.Name = "cmbUseMergedDocumentAs";
            this.cmbUseMergedDocumentAs.Size = new System.Drawing.Size(265, 21);
            this.cmbUseMergedDocumentAs.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "UseMerged Document As";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkEnableSSL);
            this.groupBox4.Controls.Add(this.txtDomain);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txtPassword);
            this.groupBox4.Controls.Add(this.txtUserName);
            this.groupBox4.Controls.Add(this.txtPort);
            this.groupBox4.Controls.Add(this.txtHost);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Location = new System.Drawing.Point(4, 366);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(415, 128);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SMTP Server Settings";
            // 
            // chkEnableSSL
            // 
            this.chkEnableSSL.AutoSize = true;
            this.chkEnableSSL.Checked = true;
            this.chkEnableSSL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableSSL.Location = new System.Drawing.Point(285, 44);
            this.chkEnableSSL.Name = "chkEnableSSL";
            this.chkEnableSSL.Size = new System.Drawing.Size(82, 17);
            this.chkEnableSSL.TabIndex = 21;
            this.chkEnableSSL.Text = "Enable SSL";
            this.chkEnableSSL.UseVisualStyleBackColor = true;
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(72, 43);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(200, 20);
            this.txtDomain.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Domain";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(72, 96);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(330, 20);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.Text = "gnostice123";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(72, 70);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(330, 20);
            this.txtUserName.TabIndex = 8;
            this.txtUserName.Text = "gnostice.test@gmail.com";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(314, 18);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(88, 20);
            this.txtPort.TabIndex = 7;
            this.txtPort.Text = "587";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(72, 18);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(200, 20);
            this.txtHost.TabIndex = 6;
            this.txtHost.Text = "smtp.gmail.com";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 99);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Password*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "User Name*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Host*";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(282, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(30, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Port*";
            // 
            // grpMessage
            // 
            this.grpMessage.Controls.Add(this.cmbMailFormat);
            this.grpMessage.Controls.Add(this.label12);
            this.grpMessage.Controls.Add(this.txtSubject);
            this.grpMessage.Controls.Add(this.label11);
            this.grpMessage.Controls.Add(this.btnRemove);
            this.grpMessage.Controls.Add(this.lstAttachments);
            this.grpMessage.Controls.Add(this.btnAdd);
            this.grpMessage.Controls.Add(this.label10);
            this.grpMessage.Controls.Add(this.txtBCC);
            this.grpMessage.Controls.Add(this.txtCC);
            this.grpMessage.Controls.Add(this.txtTO);
            this.grpMessage.Controls.Add(this.txtFrom);
            this.grpMessage.Controls.Add(this.rtbBody);
            this.grpMessage.Controls.Add(this.label9);
            this.grpMessage.Controls.Add(this.label8);
            this.grpMessage.Controls.Add(this.label7);
            this.grpMessage.Controls.Add(this.label6);
            this.grpMessage.Controls.Add(this.label4);
            this.grpMessage.Location = new System.Drawing.Point(4, 2);
            this.grpMessage.Name = "grpMessage";
            this.grpMessage.Size = new System.Drawing.Size(415, 358);
            this.grpMessage.TabIndex = 3;
            this.grpMessage.TabStop = false;
            this.grpMessage.Text = "Message";
            // 
            // cmbMailFormat
            // 
            this.cmbMailFormat.FormattingEnabled = true;
            this.cmbMailFormat.Location = new System.Drawing.Point(80, 328);
            this.cmbMailFormat.Name = "cmbMailFormat";
            this.cmbMailFormat.Size = new System.Drawing.Size(322, 21);
            this.cmbMailFormat.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 328);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Mail Format";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(55, 122);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(347, 20);
            this.txtSubject.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Subject";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(327, 296);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lstAttachments
            // 
            this.lstAttachments.FormattingEnabled = true;
            this.lstAttachments.Location = new System.Drawing.Point(80, 263);
            this.lstAttachments.Name = "lstAttachments";
            this.lstAttachments.Size = new System.Drawing.Size(241, 56);
            this.lstAttachments.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(327, 263);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Attachments";
            // 
            // txtBCC
            // 
            this.txtBCC.Location = new System.Drawing.Point(55, 96);
            this.txtBCC.Name = "txtBCC";
            this.txtBCC.Size = new System.Drawing.Size(347, 20);
            this.txtBCC.TabIndex = 9;
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(55, 70);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(347, 20);
            this.txtCC.TabIndex = 8;
            // 
            // txtTO
            // 
            this.txtTO.Location = new System.Drawing.Point(55, 44);
            this.txtTO.Name = "txtTO";
            this.txtTO.Size = new System.Drawing.Size(347, 20);
            this.txtTO.TabIndex = 7;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(55, 18);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(347, 20);
            this.txtFrom.TabIndex = 6;
            // 
            // rtbBody
            // 
            this.rtbBody.Location = new System.Drawing.Point(44, 152);
            this.rtbBody.Name = "rtbBody";
            this.rtbBody.Size = new System.Drawing.Size(358, 104);
            this.rtbBody.TabIndex = 5;
            this.rtbBody.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Body";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "BCC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "CC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "To*";
            // 
            // cmbPostMergeAction
            // 
            this.cmbPostMergeAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPostMergeAction.FormattingEnabled = true;
            this.cmbPostMergeAction.Items.AddRange(new object[] {
            "Save To File",
            "Email Action"});
            this.cmbPostMergeAction.Location = new System.Drawing.Point(108, 20);
            this.cmbPostMergeAction.Name = "cmbPostMergeAction";
            this.cmbPostMergeAction.Size = new System.Drawing.Size(320, 21);
            this.cmbPostMergeAction.TabIndex = 1;
            this.cmbPostMergeAction.SelectedIndexChanged += new System.EventHandler(this.cmbPostMergeAction_SelectedIndexChanged);
            // 
            // lblPostMergeAction
            // 
            this.lblPostMergeAction.AutoSize = true;
            this.lblPostMergeAction.Location = new System.Drawing.Point(9, 23);
            this.lblPostMergeAction.Name = "lblPostMergeAction";
            this.lblPostMergeAction.Size = new System.Drawing.Size(94, 13);
            this.lblPostMergeAction.TabIndex = 0;
            this.lblPostMergeAction.Text = "Post Merge Action";
            // 
            // lblOutputFileFormat
            // 
            this.lblOutputFileFormat.AutoSize = true;
            this.lblOutputFileFormat.Location = new System.Drawing.Point(9, 51);
            this.lblOutputFileFormat.Name = "lblOutputFileFormat";
            this.lblOutputFileFormat.Size = new System.Drawing.Size(93, 13);
            this.lblOutputFileFormat.TabIndex = 0;
            this.lblOutputFileFormat.Text = "Output File Format";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "All Files|*.docx;*.doc;*.dotm;";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "All Files|*.xml;";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(934, 662);
            this.Controls.Add(this.grpPostMergeAction);
            this.Controls.Add(this.grpMailMergeClass);
            this.Controls.Add(this.documentViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Merge";
            this.grpMailMergeClass.ResumeLayout(false);
            this.grpMailMergeClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMergeFields)).EndInit();
            this.grpPostMergeAction.ResumeLayout(false);
            this.grpPostMergeAction.PerformLayout();
            this.pnlSaveToFile.ResumeLayout(false);
            this.pnlSaveToFile.PerformLayout();
            this.pnlEmailAction.ResumeLayout(false);
            this.pnlEmailAction.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grpMessage.ResumeLayout(false);
            this.grpMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Gnostice.Controls.WinForms.DocumentViewer documentViewer1;
        private System.Windows.Forms.GroupBox grpMailMergeClass;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox cmbMergeInstanceBreakTYpe;
        private System.Windows.Forms.ComboBox cmbCleanUpOptions;
        private System.Windows.Forms.Label lblMergeInstanceBreakType;
        private System.Windows.Forms.Label lblCleanUpOptions;
        private System.Windows.Forms.Label lblFieldMapping;
        private System.Windows.Forms.DataGridView dataGridViewMergeFields;
        private System.Windows.Forms.Button btnDataSource;
        private System.Windows.Forms.TextBox txtDataSource;
        private System.Windows.Forms.Label lblDataSource;
        private System.Windows.Forms.Button btnInputTemplate;
        private System.Windows.Forms.TextBox txtInputTemplate;
        private System.Windows.Forms.Label lblInputTemplate;
        private System.Windows.Forms.GroupBox grpPostMergeAction;
        private System.Windows.Forms.ComboBox cmbOutputFileFormat;
        private System.Windows.Forms.Panel pnlSaveToFile;
        private System.Windows.Forms.Label lblOutputFileName;
        private System.Windows.Forms.TextBox txtOutputFileName;
        private System.Windows.Forms.Button btnBrowseOutputDirectory;
        private System.Windows.Forms.TextBox txtOutputDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Panel pnlEmailAction;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkEnableSSL;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox grpMessage;
        private System.Windows.Forms.ComboBox cmbMailFormat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lstAttachments;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBCC;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.TextBox txtTO;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.RichTextBox rtbBody;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPostMergeAction;
        private System.Windows.Forms.Label lblPostMergeAction;
        private System.Windows.Forms.Label lblOutputFileFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDataTableName;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox cmbUseMergedDocumentAs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

