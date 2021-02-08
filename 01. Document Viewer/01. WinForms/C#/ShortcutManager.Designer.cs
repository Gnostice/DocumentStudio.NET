namespace WinForms_CS_Document_Viewer
{
    partial class ShortcutManager
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
            this.cmbComponent = new System.Windows.Forms.ComboBox();
            this.lstBehaviour = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtShortcutKey = new System.Windows.Forms.TextBox();
            this.txtNewKey = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbComponent
            // 
            this.cmbComponent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComponent.FormattingEnabled = true;
            this.cmbComponent.Items.AddRange(new object[] {
            "Viewer"});
            this.cmbComponent.Location = new System.Drawing.Point(12, 12);
            this.cmbComponent.Name = "cmbComponent";
            this.cmbComponent.Size = new System.Drawing.Size(121, 21);
            this.cmbComponent.TabIndex = 0;
            // 
            // lstBehaviour
            // 
            this.lstBehaviour.FormattingEnabled = true;
            this.lstBehaviour.Items.AddRange(new object[] {
            "Begining Of Page",
            "End Of Page",
            "First Page",
            "Last Page",
            "Previous Page",
            "Next Page",
            "Zoom In",
            "Zoom Out",
            "Rotate Pages Clockwise",
            "Rotate Pages Anticlockwise",
            "Rotate Current Page Clockwise",
            "Rotate Current Page Anticlockwise"});
            this.lstBehaviour.Location = new System.Drawing.Point(139, 12);
            this.lstBehaviour.Name = "lstBehaviour";
            this.lstBehaviour.Size = new System.Drawing.Size(357, 95);
            this.lstBehaviour.TabIndex = 1;
            this.lstBehaviour.SelectedIndexChanged += new System.EventHandler(this.lstBehaviour_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shortcut Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Change Key";
            // 
            // txtShortcutKey
            // 
            this.txtShortcutKey.Location = new System.Drawing.Point(139, 113);
            this.txtShortcutKey.Name = "txtShortcutKey";
            this.txtShortcutKey.Size = new System.Drawing.Size(357, 20);
            this.txtShortcutKey.TabIndex = 4;
            // 
            // txtNewKey
            // 
            this.txtNewKey.Location = new System.Drawing.Point(139, 139);
            this.txtNewKey.Name = "txtNewKey";
            this.txtNewKey.Size = new System.Drawing.Size(276, 20);
            this.txtNewKey.TabIndex = 5;
            this.txtNewKey.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtNewKey_PreviewKeyDown);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(421, 137);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(421, 166);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // ShortcutManager
            // 
            this.AcceptButton = this.btnChange;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(511, 197);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtNewKey);
            this.Controls.Add(this.txtShortcutKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBehaviour);
            this.Controls.Add(this.cmbComponent);
            this.Name = "ShortcutManager";
            this.ShowInTaskbar = false;
            this.Text = "Shortcut Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbComponent;
        private System.Windows.Forms.ListBox lstBehaviour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtShortcutKey;
        private System.Windows.Forms.TextBox txtNewKey;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnExit;
    }
}