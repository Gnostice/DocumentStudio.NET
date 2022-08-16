using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Gnostice.MailMerge;

namespace MailMergeDemo
{
    public partial class Form1 : Form
    {
        MailMerge mailMerge = new MailMerge();
        DataSet dataSet = new DataSet();
        SaveToFileAction saveToFileAction = new SaveToFileAction();
        EMailAction emailAction = new EMailAction();
        public Form1()
        {
            mailMerge.Error += mailMerge_Error;
            mailMerge.EndJob += mailMerge_EndJob;

            InitializeComponent();
            grpMailMergeClass.Location = new Point(12, 6);
            grpMailMergeClass.Visible = true;

            cmbCleanUpOptions.DataSource = Enum.GetValues(typeof(MailMergeCleanupOptions));
            cmbMailFormat.DataSource = Enum.GetValues(typeof(MailFormat));
            cmbMergeInstanceBreakTYpe.DataSource = Enum.GetValues(typeof(MergeInstanceBreakType));
            cmbUseMergedDocumentAs.DataSource = Enum.GetValues(typeof(MergedDocumentOptions));

            cmbPostMergeAction.SelectedIndex = 0;
            cmbCleanUpOptions.SelectedIndex = 1;
            cmbMailFormat.SelectedIndex = 0;
            cmbMergeInstanceBreakTYpe.SelectedIndex = 0;
            cmbOutputFileFormat.SelectedIndex = 0;
            cmbUseMergedDocumentAs.SelectedIndex = 0;

            dataGridViewMergeFields.Columns.Clear();
        }

        void mailMerge_EndJob(object sender, MailMergeEndJobEventArgs e)
        {
            MessageBox.Show("Mail merge completion details:\nCancelled : " + e.Result.CancelledCount + "\nFailed : " + e.Result.FailedCount + "\nSkipped : " + e.Result.SkippedCount + "\nSucceeded : " + e.Result.SucceededCount + "\nTotal : " + e.Result.TotalCount);
        }

        void mailMerge_Error(object sender, MailMergeErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            grpMailMergeClass.Visible = false;
            grpPostMergeAction.Location = new Point(12, 6);
            grpPostMergeAction.Visible = true;
            pnlEmailAction.Visible = false;
            pnlSaveToFile.Visible = true;
            cmbPostMergeAction.SelectedIndex = 0;

            if (cmbCleanUpOptions.SelectedIndex == 0)
                mailMerge.MailMergeCleanupOptions = MailMergeCleanupOptions.None;
            else
                mailMerge.MailMergeCleanupOptions = MailMergeCleanupOptions.RemoveUnmappedFields;

            if (cmbMergeInstanceBreakTYpe.SelectedIndex == 0)
                mailMerge.MergeInstanceBreakType = MergeInstanceBreakType.Document;
            else if (cmbMergeInstanceBreakTYpe.SelectedIndex == 1)
                mailMerge.MergeInstanceBreakType = MergeInstanceBreakType.Page;
            else
                mailMerge.MergeInstanceBreakType = MergeInstanceBreakType.Paragraph;


        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            grpPostMergeAction.Visible = false;
            grpMailMergeClass.Location = new Point(12, 6);
            grpMailMergeClass.Visible = true;
        }

        private void cmbPostMergeAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPostMergeAction.SelectedIndex == 1)
            {
                pnlEmailAction.Visible = true;
                pnlSaveToFile.Visible = false;
            }
            else
            {
                pnlEmailAction.Visible = false;
                pnlSaveToFile.Visible = true;
            }
            btnMerge.Enabled = true;
        }

        private void btnInputTemplate_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    documentViewer1.LoadDocument(openFileDialog1.FileName);
                }
                catch
                { }
                mailMerge.TemplateFileName = openFileDialog1.FileName;
                txtInputTemplate.Text = openFileDialog1.FileName;
                txtOutputDirectory.Text = Path.GetDirectoryName(openFileDialog1.FileName);
                folderBrowserDialog1.SelectedPath = txtOutputDirectory.Text;
            }
        }

        private void txtInputTemplate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                documentViewer1.LoadDocument(txtInputTemplate.Text);
                mailMerge.TemplateFileName = txtInputTemplate.Text;
            }
            catch { }
        }

        private void btnDataSource_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtDataSource.Text = openFileDialog2.FileName;
                    //if (Path.GetExtension(openFileDialog1.FileName) == ".mdb")
                    //{
                    //    string sConnectionString;
                    //    sConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + openFileDialog1.FileName;


                    //    var cn = new OleDbConnection(sConnectionString);
                    //    cn.Open();

                    //    DataTable schema = cn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    //    foreach (DataRow row in schema.Rows)
                    //    {
                    //        DataTable dt = new DataTable(row.Table.TableName);
                    //        OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM " + row.Table.TableName, cn);

                    //        adapter.Fill(dt);
                    //        dataSet.Tables.Add(dt);
                    //    }
                    //    cn.Close();
                    //}
                    //else
                    //{
                    dataSet = new DataSet();
                    dataSet.ReadXml(openFileDialog2.FileName);
                    //}
                    cmbDataTableName.Items.Clear();
                    foreach (DataTable table in dataSet.Tables)
                    {
                        cmbDataTableName.Items.Add(table.TableName);
                    }
                    cmbDataTableName.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cmbDataTableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            mailMerge.DataSource = dataSet.Tables[cmbDataTableName.SelectedIndex];

            dataGridViewMergeFields.Columns.Clear();

            dataGridViewMergeFields.Columns.Add(new DataGridViewTextBoxColumn());
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
            comboBoxColumn.HeaderText = "Data Source Column";

            foreach (DataColumn column in dataSet.Tables[cmbDataTableName.SelectedIndex].Columns)
            {
                comboBoxColumn.Items.Add(column.ColumnName);
            }
            comboBoxColumn.Items.Add("Leave Unmapped");
            dataGridViewMergeFields.Columns.Add(comboBoxColumn);
            dataGridViewMergeFields.ReadOnly = false;

            //DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            //cmb.HeaderText = "Select Data";
            //cmb.Name = "cmb";
            //cmb.MaxDropDownItems = 4;
            //cmb.Items.Add("True");
            //cmb.Items.Add("False");
            //dataGridView1.Columns.Add(cmb);

            int i = 0;
            foreach (var keyvalus in mailMerge.FieldMapping)
            {
                dataGridViewMergeFields.Rows.Add();
                dataGridViewMergeFields.Rows[i].Cells[0].Value = keyvalus.Key;

                dataGridViewMergeFields.Rows[i++].Cells[1].Value = keyvalus.Value;
            }

            //dataGridViewMergeFields.DataSource = dt;
            //dataGridViewMergeFields.ReadOnly = false;
            foreach (DataGridViewRow row in dataGridViewMergeFields.Rows)
            {
                row.Cells[0].ReadOnly = true;
                dataGridViewMergeFields.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridViewMergeFields.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }

        private void btnBrowseOutputDirectory_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = txtOutputDirectory.Text;
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtOutputDirectory.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lstAttachments.Items.Add(openFileDialog1.FileName);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                lstAttachments.Items.RemoveAt(lstAttachments.SelectedIndex);
            }
            catch { }
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewMergeFields.Rows)
            {
                if (mailMerge.FieldMapping.ContainsField(row.Cells[0].Value.ToString()))
                {
                    if (row.Cells[1].Value.ToString() != "Leave Unmapped")
                    {
                        mailMerge.FieldMapping[row.Cells[0].Value.ToString()] = row.Cells[1].Value.ToString();
                    }
                }
                else if (row.Cells[1].Value.ToString() != "Leave Unmapped")
                {
                    mailMerge.FieldMapping.Add(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
                }
            }

            if (cmbPostMergeAction.SelectedIndex == 0)
            {
                saveToFileAction.OutputDirectory = txtOutputDirectory.Text;
                saveToFileAction.OutputFileName = txtOutputFileName.Text;
                saveToFileAction.FileFormat = cmbOutputFileFormat.SelectedItem.ToString();
                mailMerge.Merge(saveToFileAction);
            }
            else
            {
                
                var message = new Gnostice.MailMerge.Message();
                foreach (var item in lstAttachments.Items)
                {
                    message.Attachments.Add(new System.Net.Mail.Attachment(item.ToString()));
                }
                if (txtFrom.Text == string.Empty)
                    message.From = txtUserName.Text;
                else
                    message.From = txtFrom.Text;
                message.To.Add(txtTO.Text);
                message.CC.Add(txtCC.Text);
                message.BCC.Add(txtBCC.Text);
                message.Body = rtbBody.Text;
                message.Subject = txtSubject.Text;

                if (cmbMailFormat.SelectedIndex == 0)
                    message.MailFormat = MailFormat.PlainText;
                else
                    message.MailFormat = MailFormat.Html;

                emailAction.Message = message;

                SMTPServerSettings smtpServerSettings = new SMTPServerSettings();
                if (chkEnableSSL.Checked)
                    smtpServerSettings.EnableSsl = true;
                else
                    smtpServerSettings.EnableSsl = false;
                smtpServerSettings.CustomNetworkCredential = new System.Net.NetworkCredential();
                //smtpServerSettings.CustomNetworkCredential.Domain = txtDomain.Text;
                smtpServerSettings.CustomNetworkCredential.UserName = txtUserName.Text;
                smtpServerSettings.CustomNetworkCredential.Password = txtPassword.Text;
                smtpServerSettings.Host = txtHost.Text;
                smtpServerSettings.Port = int.Parse(txtPort.Text);

                emailAction.SMTPServerSettings = smtpServerSettings;
                emailAction.FileFormat = cmbOutputFileFormat.SelectedItem.ToString();

                if (cmbUseMergedDocumentAs.SelectedIndex == 0)
                    emailAction.UseMergedDocumentAs = MergedDocumentOptions.Attachment;
                else
                    emailAction.UseMergedDocumentAs = MergedDocumentOptions.Body;

                mailMerge.Merge(emailAction);
            }
        }
    }
}
