namespace WinForms_CS_Document_Viewer
{
    partial class Print
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPages = new System.Windows.Forms.ComboBox();
            this.cmbPageSizing = new System.Windows.Forms.ComboBox();
            this.cmbPagePosition = new System.Windows.Forms.ComboBox();
            this.chkLandscape = new System.Windows.Forms.CheckBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pages";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Page Sizing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Page Position";
            // 
            // cmbPages
            // 
            this.cmbPages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPages.FormattingEnabled = true;
            this.cmbPages.Items.AddRange(new object[] {
            "All Pages",
            "Current Page"});
            this.cmbPages.Location = new System.Drawing.Point(103, 12);
            this.cmbPages.Name = "cmbPages";
            this.cmbPages.Size = new System.Drawing.Size(169, 21);
            this.cmbPages.TabIndex = 3;
            // 
            // cmbPageSizing
            // 
            this.cmbPageSizing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPageSizing.FormattingEnabled = true;
            this.cmbPageSizing.Items.AddRange(new object[] {
            "Original Size",
            "Fit",
            "Shrink Oversized Pages"});
            this.cmbPageSizing.Location = new System.Drawing.Point(103, 50);
            this.cmbPageSizing.Name = "cmbPageSizing";
            this.cmbPageSizing.Size = new System.Drawing.Size(169, 21);
            this.cmbPageSizing.TabIndex = 4;
            // 
            // cmbPagePosition
            // 
            this.cmbPagePosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPagePosition.FormattingEnabled = true;
            this.cmbPagePosition.Items.AddRange(new object[] {
            "Original Position",
            "Centered"});
            this.cmbPagePosition.Location = new System.Drawing.Point(103, 89);
            this.cmbPagePosition.Name = "cmbPagePosition";
            this.cmbPagePosition.Size = new System.Drawing.Size(169, 21);
            this.cmbPagePosition.TabIndex = 5;
            // 
            // chkLandscape
            // 
            this.chkLandscape.AutoSize = true;
            this.chkLandscape.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLandscape.Location = new System.Drawing.Point(15, 134);
            this.chkLandscape.Name = "chkLandscape";
            this.chkLandscape.Size = new System.Drawing.Size(88, 17);
            this.chkLandscape.TabIndex = 6;
            this.chkLandscape.Text = "Landscape";
            this.chkLandscape.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrint.Location = new System.Drawing.Point(196, 158);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(115, 158);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Print
            // 
            this.AcceptButton = this.btnPrint;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 193);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.chkLandscape);
            this.Controls.Add(this.cmbPagePosition);
            this.Controls.Add(this.cmbPageSizing);
            this.Controls.Add(this.cmbPages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Print";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Print";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPages;
        private System.Windows.Forms.ComboBox cmbPageSizing;
        private System.Windows.Forms.ComboBox cmbPagePosition;
        private System.Windows.Forms.CheckBox chkLandscape;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCancel;
    }
}