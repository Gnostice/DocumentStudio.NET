namespace XDocument_Converter_Demo
{
    partial class Demo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Demo));
            this.Input = new System.Windows.Forms.GroupBox();
            this.lstBxInputDocList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.GroupBox();
            this.grpBxOCRSettings = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbDigitizationMode = new System.Windows.Forms.ComboBox();
            this.chkCreatePortfolio = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbConversionMode = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtBxBaseFileName = new System.Windows.Forms.TextBox();
            this.txtBxOutputFolder = new System.Windows.Forms.TextBox();
            this.cmbBxOutputFormat = new System.Windows.Forms.ComboBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.grpBxConvertion = new System.Windows.Forms.GroupBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.grpBxProgress = new System.Windows.Forms.GroupBox();
            this.fileName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.documents = new System.Windows.Forms.Label();
            this.pages = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prgsBrOverallProgress = new System.Windows.Forms.ProgressBar();
            this.prgsBrPageProgress = new System.Windows.Forms.ProgressBar();
            this.grpBxPreparing = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Input.SuspendLayout();
            this.Output.SuspendLayout();
            this.grpBxOCRSettings.SuspendLayout();
            this.grpBxConvertion.SuspendLayout();
            this.grpBxProgress.SuspendLayout();
            this.grpBxPreparing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Controls.Add(this.lstBxInputDocList);
            this.Input.Controls.Add(this.label1);
            this.Input.Controls.Add(this.btnAdd);
            this.Input.Controls.Add(this.btnUp);
            this.Input.Controls.Add(this.btnDown);
            this.Input.Controls.Add(this.btnRemove);
            this.Input.Location = new System.Drawing.Point(12, 12);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(518, 195);
            this.Input.TabIndex = 0;
            this.Input.TabStop = false;
            this.Input.Text = "Input:";
            // 
            // lstBxInputDocList
            // 
            this.lstBxInputDocList.FormattingEnabled = true;
            this.lstBxInputDocList.Location = new System.Drawing.Point(7, 42);
            this.lstBxInputDocList.Name = "lstBxInputDocList";
            this.lstBxInputDocList.Size = new System.Drawing.Size(466, 147);
            this.lstBxInputDocList.TabIndex = 2;
            this.lstBxInputDocList.SelectedIndexChanged += new System.EventHandler(this.lstBxInputDocList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ordered List of Documents to Convert";
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::Document_Converter_Demo.Properties.Resources._1384536370_plus_32;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Green;
            this.btnAdd.Location = new System.Drawing.Point(479, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(33, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackgroundImage = global::Document_Converter_Demo.Properties.Resources._1384536291_chevron_up;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUp.Enabled = false;
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.ForeColor = System.Drawing.Color.Green;
            this.btnUp.Location = new System.Drawing.Point(479, 118);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(33, 32);
            this.btnUp.TabIndex = 3;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.Up_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackgroundImage = global::Document_Converter_Demo.Properties.Resources._1384536200_chevron_down;
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDown.Enabled = false;
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.ForeColor = System.Drawing.Color.Green;
            this.btnDown.Location = new System.Drawing.Point(479, 156);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(33, 32);
            this.btnDown.TabIndex = 4;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.Down_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackgroundImage = global::Document_Converter_Demo.Properties.Resources._1384536363_onebit_32;
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemove.Enabled = false;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Red;
            this.btnRemove.Location = new System.Drawing.Point(479, 80);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(33, 32);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Output
            // 
            this.Output.Controls.Add(this.grpBxOCRSettings);
            this.Output.Controls.Add(this.chkCreatePortfolio);
            this.Output.Controls.Add(this.label8);
            this.Output.Controls.Add(this.cmbConversionMode);
            this.Output.Controls.Add(this.label7);
            this.Output.Controls.Add(this.label6);
            this.Output.Controls.Add(this.label5);
            this.Output.Controls.Add(this.btnBrowse);
            this.Output.Controls.Add(this.txtBxBaseFileName);
            this.Output.Controls.Add(this.txtBxOutputFolder);
            this.Output.Controls.Add(this.cmbBxOutputFormat);
            this.Output.Location = new System.Drawing.Point(12, 213);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(517, 159);
            this.Output.TabIndex = 1;
            this.Output.TabStop = false;
            this.Output.Text = "Output:";
            // 
            // grpBxOCRSettings
            // 
            this.grpBxOCRSettings.Controls.Add(this.label9);
            this.grpBxOCRSettings.Controls.Add(this.cmbDigitizationMode);
            this.grpBxOCRSettings.Location = new System.Drawing.Point(9, 61);
            this.grpBxOCRSettings.Name = "grpBxOCRSettings";
            this.grpBxOCRSettings.Size = new System.Drawing.Size(500, 50);
            this.grpBxOCRSettings.TabIndex = 8;
            this.grpBxOCRSettings.TabStop = false;
            this.grpBxOCRSettings.Text = "OCR Settings";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Digitization Mode";
            // 
            // cmbDigitizationMode
            // 
            this.cmbDigitizationMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDigitizationMode.FormattingEnabled = true;
            this.cmbDigitizationMode.Items.AddRange(new object[] {
            "Off",
            "All Images"});
            this.cmbDigitizationMode.Location = new System.Drawing.Point(100, 19);
            this.cmbDigitizationMode.Name = "cmbDigitizationMode";
            this.cmbDigitizationMode.Size = new System.Drawing.Size(113, 21);
            this.cmbDigitizationMode.TabIndex = 1;
            // 
            // chkCreatePortfolio
            // 
            this.chkCreatePortfolio.AutoSize = true;
            this.chkCreatePortfolio.Checked = true;
            this.chkCreatePortfolio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCreatePortfolio.Location = new System.Drawing.Point(411, 35);
            this.chkCreatePortfolio.Name = "chkCreatePortfolio";
            this.chkCreatePortfolio.Size = new System.Drawing.Size(98, 17);
            this.chkCreatePortfolio.TabIndex = 7;
            this.chkCreatePortfolio.Text = "Create Portfolio";
            this.chkCreatePortfolio.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Conversion Mode";
            // 
            // cmbConversionMode
            // 
            this.cmbConversionMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConversionMode.FormattingEnabled = true;
            this.cmbConversionMode.Items.AddRange(new object[] {
            "Convert To Single File",
            "Convert To Seperate Files",
            "Convert First File And Attach Rest",
            "Create New File And Attach All"});
            this.cmbConversionMode.Location = new System.Drawing.Point(217, 32);
            this.cmbConversionMode.Name = "cmbConversionMode";
            this.cmbConversionMode.Size = new System.Drawing.Size(188, 21);
            this.cmbConversionMode.TabIndex = 5;
            this.cmbConversionMode.SelectedIndexChanged += new System.EventHandler(this.cmbConversionMode_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Output Folder";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Base File Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Format";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.Green;
            this.btnBrowse.Location = new System.Drawing.Point(478, 130);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(33, 20);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtBxBaseFileName
            // 
            this.txtBxBaseFileName.Location = new System.Drawing.Point(125, 33);
            this.txtBxBaseFileName.Name = "txtBxBaseFileName";
            this.txtBxBaseFileName.Size = new System.Drawing.Size(86, 20);
            this.txtBxBaseFileName.TabIndex = 1;
            // 
            // txtBxOutputFolder
            // 
            this.txtBxOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxOutputFolder.Location = new System.Drawing.Point(6, 130);
            this.txtBxOutputFolder.Name = "txtBxOutputFolder";
            this.txtBxOutputFolder.Size = new System.Drawing.Size(467, 20);
            this.txtBxOutputFolder.TabIndex = 4;
            // 
            // cmbBxOutputFormat
            // 
            this.cmbBxOutputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxOutputFormat.FormattingEnabled = true;
            this.cmbBxOutputFormat.Items.AddRange(new object[] {
            "PDF",
            "DOCX",
            "RTF",
            "BMP",
            "JPEG",
            "PNG",
            "TIFF Single Page",
            "TIFF Multipage",
            "TXT",
            "HTML"});
            this.cmbBxOutputFormat.Location = new System.Drawing.Point(6, 33);
            this.cmbBxOutputFormat.Name = "cmbBxOutputFormat";
            this.cmbBxOutputFormat.Size = new System.Drawing.Size(113, 21);
            this.cmbBxOutputFormat.TabIndex = 0;
            this.cmbBxOutputFormat.SelectedIndexChanged += new System.EventHandler(this.cmbBxOutputFormat_SelectedIndexChanged);
            // 
            // openFile
            // 
            this.openFile.Filter = resources.GetString("openFile.Filter");
            this.openFile.Multiselect = true;
            // 
            // grpBxConvertion
            // 
            this.grpBxConvertion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxConvertion.Controls.Add(this.btnConvert);
            this.grpBxConvertion.Location = new System.Drawing.Point(12, 378);
            this.grpBxConvertion.Name = "grpBxConvertion";
            this.grpBxConvertion.Size = new System.Drawing.Size(517, 117);
            this.grpBxConvertion.TabIndex = 2;
            this.grpBxConvertion.TabStop = false;
            this.grpBxConvertion.Text = "Start Conversion:";
            // 
            // btnConvert
            // 
            this.btnConvert.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnConvert.Enabled = false;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.Color.Green;
            this.btnConvert.Location = new System.Drawing.Point(63, 33);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(392, 64);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "&Start";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // grpBxProgress
            // 
            this.grpBxProgress.Controls.Add(this.fileName);
            this.grpBxProgress.Controls.Add(this.btnCancel);
            this.grpBxProgress.Controls.Add(this.documents);
            this.grpBxProgress.Controls.Add(this.pages);
            this.grpBxProgress.Controls.Add(this.label2);
            this.grpBxProgress.Controls.Add(this.label3);
            this.grpBxProgress.Controls.Add(this.prgsBrOverallProgress);
            this.grpBxProgress.Controls.Add(this.prgsBrPageProgress);
            this.grpBxProgress.Location = new System.Drawing.Point(-517, 378);
            this.grpBxProgress.Name = "grpBxProgress";
            this.grpBxProgress.Size = new System.Drawing.Size(517, 117);
            this.grpBxProgress.TabIndex = 4;
            this.grpBxProgress.TabStop = false;
            this.grpBxProgress.Text = "Conversion Progress:";
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Location = new System.Drawing.Point(93, 20);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(0, 13);
            this.fileName.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(410, 36);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 75);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // documents
            // 
            this.documents.AutoEllipsis = true;
            this.documents.AutoSize = true;
            this.documents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.documents.Location = new System.Drawing.Point(369, 72);
            this.documents.Name = "documents";
            this.documents.Size = new System.Drawing.Size(0, 13);
            this.documents.TabIndex = 4;
            // 
            // pages
            // 
            this.pages.AutoSize = true;
            this.pages.Location = new System.Drawing.Point(241, 20);
            this.pages.Name = "pages";
            this.pages.Size = new System.Drawing.Size(0, 13);
            this.pages.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Overall Job";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Now Converting: ";
            // 
            // prgsBrOverallProgress
            // 
            this.prgsBrOverallProgress.Location = new System.Drawing.Point(6, 88);
            this.prgsBrOverallProgress.Name = "prgsBrOverallProgress";
            this.prgsBrOverallProgress.Size = new System.Drawing.Size(398, 23);
            this.prgsBrOverallProgress.TabIndex = 1;
            // 
            // prgsBrPageProgress
            // 
            this.prgsBrPageProgress.Location = new System.Drawing.Point(6, 36);
            this.prgsBrPageProgress.Name = "prgsBrPageProgress";
            this.prgsBrPageProgress.Size = new System.Drawing.Size(398, 23);
            this.prgsBrPageProgress.TabIndex = 0;
            // 
            // grpBxPreparing
            // 
            this.grpBxPreparing.Controls.Add(this.label4);
            this.grpBxPreparing.Controls.Add(this.pictureBox1);
            this.grpBxPreparing.Location = new System.Drawing.Point(541, 333);
            this.grpBxPreparing.Name = "grpBxPreparing";
            this.grpBxPreparing.Size = new System.Drawing.Size(517, 117);
            this.grpBxPreparing.TabIndex = 9;
            this.grpBxPreparing.TabStop = false;
            this.grpBxPreparing.Text = "Conversion Progress:";
            this.grpBxPreparing.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Please Wait...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Document_Converter_Demo.Properties.Resources._1384802769_icon_sandclock;
            this.pictureBox1.Location = new System.Drawing.Point(227, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Demo
            // 
            this.AcceptButton = this.btnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(542, 504);
            this.Controls.Add(this.grpBxProgress);
            this.Controls.Add(this.grpBxConvertion);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Demo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gnostice Document Studio .NET - Document Converter";
            this.Load += new System.EventHandler(this.Demo_Load);
            this.Input.ResumeLayout(false);
            this.Input.PerformLayout();
            this.Output.ResumeLayout(false);
            this.Output.PerformLayout();
            this.grpBxOCRSettings.ResumeLayout(false);
            this.grpBxOCRSettings.PerformLayout();
            this.grpBxConvertion.ResumeLayout(false);
            this.grpBxProgress.ResumeLayout(false);
            this.grpBxProgress.PerformLayout();
            this.grpBxPreparing.ResumeLayout(false);
            this.grpBxPreparing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Input;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox Output;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.ListBox lstBxInputDocList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtBxOutputFolder;
        private System.Windows.Forms.TextBox txtBxBaseFileName;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.GroupBox grpBxConvertion;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.GroupBox grpBxProgress;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label documents;
        private System.Windows.Forms.Label pages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar prgsBrOverallProgress;
        private System.Windows.Forms.ProgressBar prgsBrPageProgress;
        private System.Windows.Forms.GroupBox grpBxPreparing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBxOutputFormat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbConversionMode;
        private System.Windows.Forms.CheckBox chkCreatePortfolio;
        private System.Windows.Forms.GroupBox grpBxOCRSettings;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbDigitizationMode;
    }
}

