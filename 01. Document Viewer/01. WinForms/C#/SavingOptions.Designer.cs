namespace WinForms_CS_Document_Viewer
{
    partial class SavingOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavingOptions));
            this.grpBxConverterSettings = new System.Windows.Forms.GroupBox();
            this.txtCustomPageRange = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbCustom = new System.Windows.Forms.RadioButton();
            this.rdbOdd = new System.Windows.Forms.RadioButton();
            this.rdbEven = new System.Windows.Forms.RadioButton();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOutputFormat = new System.Windows.Forms.ComboBox();
            this.grpBxEncoderSettings = new System.Windows.Forms.GroupBox();
            this.pnlPDFEncoderSettings = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPDFVersion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFontEmbedType = new System.Windows.Forms.ComboBox();
            this.pnlImageEncoderSettings = new System.Windows.Forms.Panel();
            this.pnlJPEGEncoderSettings = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.trkQualityLevel = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlTiffEncoderSettings = new System.Windows.Forms.Panel();
            this.chkMultipage = new System.Windows.Forms.CheckBox();
            this.cmbCompressionType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDPIY = new System.Windows.Forms.TextBox();
            this.txtDPIX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPageScalling = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlTxtEncoderSettings = new System.Windows.Forms.Panel();
            this.txtCustomPageBreak = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.chkBreakPages = new System.Windows.Forms.CheckBox();
            this.chkBreakParagraphs = new System.Windows.Forms.CheckBox();
            this.chkBreakLines = new System.Windows.Forms.CheckBox();
            this.cmbFileEncoding = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpBxConverterSettings.SuspendLayout();
            this.grpBxEncoderSettings.SuspendLayout();
            this.pnlPDFEncoderSettings.SuspendLayout();
            this.pnlImageEncoderSettings.SuspendLayout();
            this.pnlJPEGEncoderSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkQualityLevel)).BeginInit();
            this.pnlTiffEncoderSettings.SuspendLayout();
            this.pnlTxtEncoderSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxConverterSettings
            // 
            this.grpBxConverterSettings.Controls.Add(this.txtCustomPageRange);
            this.grpBxConverterSettings.Controls.Add(this.label3);
            this.grpBxConverterSettings.Controls.Add(this.rdbCustom);
            this.grpBxConverterSettings.Controls.Add(this.rdbOdd);
            this.grpBxConverterSettings.Controls.Add(this.rdbEven);
            this.grpBxConverterSettings.Controls.Add(this.rdbAll);
            this.grpBxConverterSettings.Controls.Add(this.label2);
            this.grpBxConverterSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxConverterSettings.Location = new System.Drawing.Point(12, 40);
            this.grpBxConverterSettings.Name = "grpBxConverterSettings";
            this.grpBxConverterSettings.Size = new System.Drawing.Size(248, 171);
            this.grpBxConverterSettings.TabIndex = 0;
            this.grpBxConverterSettings.TabStop = false;
            this.grpBxConverterSettings.Text = "Converter Params";
            // 
            // txtCustomPageRange
            // 
            this.txtCustomPageRange.Location = new System.Drawing.Point(21, 143);
            this.txtCustomPageRange.Name = "txtCustomPageRange";
            this.txtCustomPageRange.Size = new System.Drawing.Size(221, 20);
            this.txtCustomPageRange.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Custom Page Range";
            // 
            // rdbCustom
            // 
            this.rdbCustom.AutoSize = true;
            this.rdbCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCustom.Location = new System.Drawing.Point(21, 106);
            this.rdbCustom.Name = "rdbCustom";
            this.rdbCustom.Size = new System.Drawing.Size(60, 17);
            this.rdbCustom.TabIndex = 4;
            this.rdbCustom.Text = "Custom";
            this.rdbCustom.UseVisualStyleBackColor = true;
            // 
            // rdbOdd
            // 
            this.rdbOdd.AutoSize = true;
            this.rdbOdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOdd.Location = new System.Drawing.Point(21, 83);
            this.rdbOdd.Name = "rdbOdd";
            this.rdbOdd.Size = new System.Drawing.Size(45, 17);
            this.rdbOdd.TabIndex = 3;
            this.rdbOdd.Text = "Odd";
            this.rdbOdd.UseVisualStyleBackColor = true;
            // 
            // rdbEven
            // 
            this.rdbEven.AutoSize = true;
            this.rdbEven.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEven.Location = new System.Drawing.Point(21, 60);
            this.rdbEven.Name = "rdbEven";
            this.rdbEven.Size = new System.Drawing.Size(50, 17);
            this.rdbEven.TabIndex = 2;
            this.rdbEven.Text = "Even";
            this.rdbEven.UseVisualStyleBackColor = true;
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Checked = true;
            this.rdbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAll.Location = new System.Drawing.Point(21, 37);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(36, 17);
            this.rdbAll.TabIndex = 1;
            this.rdbAll.TabStop = true;
            this.rdbAll.Text = "All";
            this.rdbAll.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Page Range";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Save As";
            // 
            // cmbOutputFormat
            // 
            this.cmbOutputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOutputFormat.FormattingEnabled = true;
            this.cmbOutputFormat.Items.AddRange(new object[] {
            "PDF",
            "DOCX",
            "BMP",
            "PNG",
            "JPEG",
            "TIFF",
            "TXT",
            "HTML"});
            this.cmbOutputFormat.Location = new System.Drawing.Point(74, 13);
            this.cmbOutputFormat.Name = "cmbOutputFormat";
            this.cmbOutputFormat.Size = new System.Drawing.Size(138, 21);
            this.cmbOutputFormat.TabIndex = 2;
            this.cmbOutputFormat.SelectedIndexChanged += new System.EventHandler(this.cmbOutputFormat_SelectedIndexChanged);
            // 
            // grpBxEncoderSettings
            // 
            this.grpBxEncoderSettings.Controls.Add(this.pnlPDFEncoderSettings);
            this.grpBxEncoderSettings.Controls.Add(this.pnlImageEncoderSettings);
            this.grpBxEncoderSettings.Controls.Add(this.pnlTxtEncoderSettings);
            this.grpBxEncoderSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxEncoderSettings.Location = new System.Drawing.Point(13, 218);
            this.grpBxEncoderSettings.Name = "grpBxEncoderSettings";
            this.grpBxEncoderSettings.Size = new System.Drawing.Size(248, 472);
            this.grpBxEncoderSettings.TabIndex = 3;
            this.grpBxEncoderSettings.TabStop = false;
            this.grpBxEncoderSettings.Text = "Encoder Params";
            this.grpBxEncoderSettings.Visible = false;
            // 
            // pnlPDFEncoderSettings
            // 
            this.pnlPDFEncoderSettings.Controls.Add(this.label4);
            this.pnlPDFEncoderSettings.Controls.Add(this.cmbPDFVersion);
            this.pnlPDFEncoderSettings.Controls.Add(this.label5);
            this.pnlPDFEncoderSettings.Controls.Add(this.cmbFontEmbedType);
            this.pnlPDFEncoderSettings.Location = new System.Drawing.Point(0, 297);
            this.pnlPDFEncoderSettings.Name = "pnlPDFEncoderSettings";
            this.pnlPDFEncoderSettings.Size = new System.Drawing.Size(248, 52);
            this.pnlPDFEncoderSettings.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Font Embed Type";
            // 
            // cmbPDFVersion
            // 
            this.cmbPDFVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPDFVersion.FormattingEnabled = true;
            this.cmbPDFVersion.Items.AddRange(new object[] {
            "V1_4",
            "V1_5",
            "V1_6"});
            this.cmbPDFVersion.Location = new System.Drawing.Point(120, 30);
            this.cmbPDFVersion.Name = "cmbPDFVersion";
            this.cmbPDFVersion.Size = new System.Drawing.Size(121, 21);
            this.cmbPDFVersion.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "PDF Version";
            // 
            // cmbFontEmbedType
            // 
            this.cmbFontEmbedType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFontEmbedType.FormattingEnabled = true;
            this.cmbFontEmbedType.Items.AddRange(new object[] {
            "Full",
            "Subset",
            "None"});
            this.cmbFontEmbedType.Location = new System.Drawing.Point(120, 0);
            this.cmbFontEmbedType.Name = "cmbFontEmbedType";
            this.cmbFontEmbedType.Size = new System.Drawing.Size(121, 21);
            this.cmbFontEmbedType.TabIndex = 1;
            // 
            // pnlImageEncoderSettings
            // 
            this.pnlImageEncoderSettings.Controls.Add(this.pnlJPEGEncoderSettings);
            this.pnlImageEncoderSettings.Controls.Add(this.pnlTiffEncoderSettings);
            this.pnlImageEncoderSettings.Controls.Add(this.txtDPIY);
            this.pnlImageEncoderSettings.Controls.Add(this.txtDPIX);
            this.pnlImageEncoderSettings.Controls.Add(this.label8);
            this.pnlImageEncoderSettings.Controls.Add(this.label7);
            this.pnlImageEncoderSettings.Controls.Add(this.cmbPageScalling);
            this.pnlImageEncoderSettings.Controls.Add(this.label6);
            this.pnlImageEncoderSettings.Location = new System.Drawing.Point(0, 17);
            this.pnlImageEncoderSettings.Name = "pnlImageEncoderSettings";
            this.pnlImageEncoderSettings.Size = new System.Drawing.Size(248, 274);
            this.pnlImageEncoderSettings.TabIndex = 4;
            this.pnlImageEncoderSettings.Visible = false;
            // 
            // pnlJPEGEncoderSettings
            // 
            this.pnlJPEGEncoderSettings.Controls.Add(this.label12);
            this.pnlJPEGEncoderSettings.Controls.Add(this.label11);
            this.pnlJPEGEncoderSettings.Controls.Add(this.trkQualityLevel);
            this.pnlJPEGEncoderSettings.Controls.Add(this.label10);
            this.pnlJPEGEncoderSettings.Location = new System.Drawing.Point(0, 149);
            this.pnlJPEGEncoderSettings.Name = "pnlJPEGEncoderSettings";
            this.pnlJPEGEncoderSettings.Size = new System.Drawing.Size(248, 69);
            this.pnlJPEGEncoderSettings.TabIndex = 6;
            this.pnlJPEGEncoderSettings.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(217, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "100";
            // 
            // trkQualityLevel
            // 
            this.trkQualityLevel.Location = new System.Drawing.Point(23, 19);
            this.trkQualityLevel.Maximum = 100;
            this.trkQualityLevel.Name = "trkQualityLevel";
            this.trkQualityLevel.Size = new System.Drawing.Size(188, 45);
            this.trkQualityLevel.TabIndex = 2;
            this.trkQualityLevel.Value = 100;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Quality Level";
            // 
            // pnlTiffEncoderSettings
            // 
            this.pnlTiffEncoderSettings.Controls.Add(this.chkMultipage);
            this.pnlTiffEncoderSettings.Controls.Add(this.cmbCompressionType);
            this.pnlTiffEncoderSettings.Controls.Add(this.label9);
            this.pnlTiffEncoderSettings.Location = new System.Drawing.Point(0, 224);
            this.pnlTiffEncoderSettings.Name = "pnlTiffEncoderSettings";
            this.pnlTiffEncoderSettings.Size = new System.Drawing.Size(248, 60);
            this.pnlTiffEncoderSettings.TabIndex = 5;
            // 
            // chkMultipage
            // 
            this.chkMultipage.AutoSize = true;
            this.chkMultipage.Checked = true;
            this.chkMultipage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMultipage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMultipage.Location = new System.Drawing.Point(7, 27);
            this.chkMultipage.Name = "chkMultipage";
            this.chkMultipage.Size = new System.Drawing.Size(81, 17);
            this.chkMultipage.TabIndex = 9;
            this.chkMultipage.Text = "Multipage";
            this.chkMultipage.UseVisualStyleBackColor = true;
            // 
            // cmbCompressionType
            // 
            this.cmbCompressionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompressionType.FormattingEnabled = true;
            this.cmbCompressionType.Items.AddRange(new object[] {
            "None",
            "CCITT4",
            "LZW",
            "CCITT3",
            "Rle"});
            this.cmbCompressionType.Location = new System.Drawing.Point(120, 0);
            this.cmbCompressionType.Name = "cmbCompressionType";
            this.cmbCompressionType.Size = new System.Drawing.Size(121, 21);
            this.cmbCompressionType.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Compression Type";
            // 
            // txtDPIY
            // 
            this.txtDPIY.Location = new System.Drawing.Point(120, 53);
            this.txtDPIY.Name = "txtDPIY";
            this.txtDPIY.Size = new System.Drawing.Size(121, 20);
            this.txtDPIY.TabIndex = 5;
            this.txtDPIY.Text = "96";
            // 
            // txtDPIX
            // 
            this.txtDPIX.Location = new System.Drawing.Point(120, 27);
            this.txtDPIX.Name = "txtDPIX";
            this.txtDPIX.Size = new System.Drawing.Size(121, 20);
            this.txtDPIX.TabIndex = 4;
            this.txtDPIX.Text = "96";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "DPI-Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "DPI-X";
            // 
            // cmbPageScalling
            // 
            this.cmbPageScalling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPageScalling.FormattingEnabled = true;
            this.cmbPageScalling.Items.AddRange(new object[] {
            "None",
            "UseRenderingResolution"});
            this.cmbPageScalling.Location = new System.Drawing.Point(120, 0);
            this.cmbPageScalling.Name = "cmbPageScalling";
            this.cmbPageScalling.Size = new System.Drawing.Size(121, 21);
            this.cmbPageScalling.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Page Scalling";
            // 
            // pnlTxtEncoderSettings
            // 
            this.pnlTxtEncoderSettings.Controls.Add(this.txtCustomPageBreak);
            this.pnlTxtEncoderSettings.Controls.Add(this.label14);
            this.pnlTxtEncoderSettings.Controls.Add(this.chkBreakPages);
            this.pnlTxtEncoderSettings.Controls.Add(this.chkBreakParagraphs);
            this.pnlTxtEncoderSettings.Controls.Add(this.chkBreakLines);
            this.pnlTxtEncoderSettings.Controls.Add(this.cmbFileEncoding);
            this.pnlTxtEncoderSettings.Controls.Add(this.label13);
            this.pnlTxtEncoderSettings.Location = new System.Drawing.Point(0, 355);
            this.pnlTxtEncoderSettings.Name = "pnlTxtEncoderSettings";
            this.pnlTxtEncoderSettings.Size = new System.Drawing.Size(248, 115);
            this.pnlTxtEncoderSettings.TabIndex = 7;
            this.pnlTxtEncoderSettings.Visible = false;
            // 
            // txtCustomPageBreak
            // 
            this.txtCustomPageBreak.Location = new System.Drawing.Point(120, 93);
            this.txtCustomPageBreak.Name = "txtCustomPageBreak";
            this.txtCustomPageBreak.Size = new System.Drawing.Size(121, 20);
            this.txtCustomPageBreak.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(4, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Page Break Text";
            // 
            // chkBreakPages
            // 
            this.chkBreakPages.AutoSize = true;
            this.chkBreakPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBreakPages.Location = new System.Drawing.Point(7, 73);
            this.chkBreakPages.Name = "chkBreakPages";
            this.chkBreakPages.Size = new System.Drawing.Size(98, 17);
            this.chkBreakPages.TabIndex = 11;
            this.chkBreakPages.Text = "Break Pages";
            this.chkBreakPages.UseVisualStyleBackColor = true;
            // 
            // chkBreakParagraphs
            // 
            this.chkBreakParagraphs.AutoSize = true;
            this.chkBreakParagraphs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBreakParagraphs.Location = new System.Drawing.Point(7, 50);
            this.chkBreakParagraphs.Name = "chkBreakParagraphs";
            this.chkBreakParagraphs.Size = new System.Drawing.Size(127, 17);
            this.chkBreakParagraphs.TabIndex = 10;
            this.chkBreakParagraphs.Text = "Break Paragraphs";
            this.chkBreakParagraphs.UseVisualStyleBackColor = true;
            // 
            // chkBreakLines
            // 
            this.chkBreakLines.AutoSize = true;
            this.chkBreakLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBreakLines.Location = new System.Drawing.Point(7, 27);
            this.chkBreakLines.Name = "chkBreakLines";
            this.chkBreakLines.Size = new System.Drawing.Size(93, 17);
            this.chkBreakLines.TabIndex = 9;
            this.chkBreakLines.Text = "Break Lines";
            this.chkBreakLines.UseVisualStyleBackColor = true;
            // 
            // cmbFileEncoding
            // 
            this.cmbFileEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFileEncoding.FormattingEnabled = true;
            this.cmbFileEncoding.Items.AddRange(new object[] {
            "UTF_8",
            "US_ASCII",
            "UTF_16BE",
            "UTF_16LE",
            "ISO_8859_1"});
            this.cmbFileEncoding.Location = new System.Drawing.Point(120, 0);
            this.cmbFileEncoding.Name = "cmbFileEncoding";
            this.cmbFileEncoding.Size = new System.Drawing.Size(121, 21);
            this.cmbFileEncoding.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "File Encoding";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(98, 694);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.Location = new System.Drawing.Point(179, 694);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SavingOptions
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(272, 734);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpBxEncoderSettings);
            this.Controls.Add(this.cmbOutputFormat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpBxConverterSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SavingOptions";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Saving Options";
            this.grpBxConverterSettings.ResumeLayout(false);
            this.grpBxConverterSettings.PerformLayout();
            this.grpBxEncoderSettings.ResumeLayout(false);
            this.pnlPDFEncoderSettings.ResumeLayout(false);
            this.pnlPDFEncoderSettings.PerformLayout();
            this.pnlImageEncoderSettings.ResumeLayout(false);
            this.pnlImageEncoderSettings.PerformLayout();
            this.pnlJPEGEncoderSettings.ResumeLayout(false);
            this.pnlJPEGEncoderSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkQualityLevel)).EndInit();
            this.pnlTiffEncoderSettings.ResumeLayout(false);
            this.pnlTiffEncoderSettings.PerformLayout();
            this.pnlTxtEncoderSettings.ResumeLayout(false);
            this.pnlTxtEncoderSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxConverterSettings;
        private System.Windows.Forms.TextBox txtCustomPageRange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbCustom;
        private System.Windows.Forms.RadioButton rdbOdd;
        private System.Windows.Forms.RadioButton rdbEven;
        private System.Windows.Forms.RadioButton rdbAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOutputFormat;
        private System.Windows.Forms.GroupBox grpBxEncoderSettings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFontEmbedType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPDFVersion;
        private System.Windows.Forms.Panel pnlPDFEncoderSettings;
        private System.Windows.Forms.Panel pnlImageEncoderSettings;
        private System.Windows.Forms.Panel pnlTiffEncoderSettings;
        private System.Windows.Forms.Panel pnlJPEGEncoderSettings;
        private System.Windows.Forms.Panel pnlTxtEncoderSettings;
        private System.Windows.Forms.TextBox txtDPIY;
        private System.Windows.Forms.TextBox txtDPIX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPageScalling;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar trkQualityLevel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkMultipage;
        private System.Windows.Forms.ComboBox cmbCompressionType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCustomPageBreak;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chkBreakPages;
        private System.Windows.Forms.CheckBox chkBreakParagraphs;
        private System.Windows.Forms.CheckBox chkBreakLines;
        private System.Windows.Forms.ComboBox cmbFileEncoding;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}