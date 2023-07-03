using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using Gnostice.Core;
using Gnostice.Documents;
using Gnostice.Converter;
using Gnostice.Documents.Image;
using Gnostice.Documents.PDF;

namespace XDocument_Converter_Demo
{
    public partial class Demo : Form
    {
        private bool Cancel = false;
        DocumentConverter DocConverter;
        List<string> inputDocuments;
        string outputFileFormat;
        //bool merge = false;
        ConversionMode conversionMode = ConversionMode.ConvertToSeperateFiles;
        string baseFileName;
        string outputDocDirectory;
        ConverterSettings converterSettings = null;
        EncoderSettings encoderSettings = null;
        string inputDocPassword = string.Empty;
        private int passwordAttempt;
        private int currentFileIndex = 0;
        private string errorMessage = string.Empty;

        public Demo()
        {
            InitializeComponent();
        }

        private void Demo_Load(object sender, EventArgs e)
        {
            cmbBxOutputFormat.SelectedIndex = 0;
            cmbConversionMode.SelectedIndex = 0;
            cmbDigitizationMode.SelectedIndex = 0;
        }

        private void EnableOrDisableButtons()
        {
            if (lstBxInputDocList.Items.Count == 0)
            {
                btnRemove.Enabled = false;
                btnUp.Enabled = false;
                btnDown.Enabled = false;
                btnConvert.Enabled = false;
                return;
            }
            else
            {
                btnRemove.Enabled = true;
                btnUp.Enabled = true;
                btnDown.Enabled = true;
                btnConvert.Enabled = true;
            }
            if (lstBxInputDocList.SelectedIndex == 0)
                btnUp.Enabled = false;
            else if (lstBxInputDocList.SelectedIndex == lstBxInputDocList.Items.Count - 1)
                btnDown.Enabled = false;
            else
            {
                btnUp.Enabled = true;
                btnDown.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add Files to Input List
            try
            {
                if (openFile.ShowDialog() == DialogResult.OK) // If Files were selected and OK is Clicked
                {
                    // Get all the Files selected
                    foreach (string fileName in openFile.FileNames)
                        lstBxInputDocList.Items.Add(fileName);
                    // Point to last file in the list
                    lstBxInputDocList.SelectedIndex = lstBxInputDocList.Items.Count - 1;
                    // Check for enabling or disabling of buttons
                    EnableOrDisableButtons();
                    lstBxInputDocList.Focus();
                    // If Output Folder is not specified set default directory
                    if (txtBxOutputFolder.Text == string.Empty)
                    {
                        txtBxOutputFolder.Text = System.IO.Path.GetDirectoryName(lstBxInputDocList.Items[lstBxInputDocList.Items.Count - 1].ToString());
                        folderBrowser.SelectedPath = txtBxOutputFolder.Text;
                    }
                }
            }
            catch
            {

            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            // Remove a file from List
            try
            {
                // Retaining SelectedIndex
                int selectedIndex = lstBxInputDocList.SelectedIndex;
                try
                {
                    // Remove Selected file from the List
                    lstBxInputDocList.Items.Remove(lstBxInputDocList.SelectedItem);
                    if (selectedIndex != 0)
                        lstBxInputDocList.SelectedIndex = selectedIndex;
                    else if (lstBxInputDocList.Items.Count != 0)
                        lstBxInputDocList.SelectedIndex = 0;
                }
                catch
                {
                    lstBxInputDocList.SelectedIndex = 0;
                }
                lstBxInputDocList.Focus();
                EnableOrDisableButtons();
            }
            catch
            {

            }
        }

        private void Up_Click(object sender, EventArgs e)
        {
            // Move Selected File 1 step Upwards
            int selectedIndex = lstBxInputDocList.SelectedIndex;
            object listItem = lstBxInputDocList.SelectedItem;
            if (selectedIndex != 0)
            {
                lstBxInputDocList.Items.Remove(lstBxInputDocList.SelectedItem);
                lstBxInputDocList.Items.Insert(selectedIndex - 1, listItem);
                lstBxInputDocList.SelectedIndex = selectedIndex - 1;
            }
            lstBxInputDocList.Focus();
            EnableOrDisableButtons();
        }

        private void Down_Click(object sender, EventArgs e)
        {
            // Move Selected File 1 step Downwards
            int selectedIndex = lstBxInputDocList.SelectedIndex;
            object listItem = lstBxInputDocList.SelectedItem;
            if (selectedIndex != lstBxInputDocList.Items.Count - 1)
            {
                lstBxInputDocList.Items.Remove(lstBxInputDocList.SelectedItem);
                lstBxInputDocList.Items.Insert(selectedIndex + 1, listItem);
                lstBxInputDocList.SelectedIndex = selectedIndex + 1;
            }
            lstBxInputDocList.Focus();
            EnableOrDisableButtons();
        }

        private void lstBxInputDocList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check for enabling or disabling of buttons
            EnableOrDisableButtons();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Select a directory to set as OutputDocDirectory
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                txtBxOutputFolder.Text = folderBrowser.SelectedPath;
                EnableOrDisableButtons();
            }
        }

        private void performConversion()
        {
            // New thread to perform conversion
            try
            {
                DocConverter.ConvertToFile(inputDocuments, outputFileFormat, outputDocDirectory, baseFileName, conversionMode, encoderSettings, converterSettings, inputDocPassword);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // Restore Default for next Conversion
            Cancel = false;
            Animate(false);
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => pages.Text = string.Empty));
                this.Invoke(new Action(() => fileName.Text = string.Empty));
                this.Invoke(new Action(() => documents.Text = string.Empty));
                this.Invoke(new Action(() => btnConvert.Enabled = true));
                this.Invoke(new Action(() => btnCancel.Enabled = false));
                this.Invoke(new Action(() => prgsBrPageProgress.Value = 0));
                this.Invoke(new Action(() => prgsBrOverallProgress.Value = 0));
            }
            else
            {
                pages.Text = string.Empty;
                fileName.Text = string.Empty;
                documents.Text = string.Empty;
                btnConvert.Enabled = true;
                btnCancel.Enabled = false;
                prgsBrPageProgress.Value = 0;
                prgsBrOverallProgress.Value = 0;
            }
            // Exit from Current Thread
            Application.ExitThread();
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            btnConvert.Enabled = false;
            errorMessage = string.Empty;
            // Hide the Start Button and show the Progress Bars
            Animate(true);
            btnCancel.Enabled = true;
            // Input Documents
            inputDocuments = new List<string>();
            foreach (string fileName in lstBxInputDocList.Items)
                inputDocuments.Add(fileName);
            //Output Directory
            outputFileFormat = cmbBxOutputFormat.Text.ToLower();
            // Output File Format
            if (outputFileFormat == "tiff single page" || outputFileFormat == "tiff multipage")
                outputFileFormat = "tiff";
            // Default name for converted files
            baseFileName = txtBxBaseFileName.Text;
            outputDocDirectory = txtBxOutputFolder.Text;
            converterSettings = null;
            encoderSettings = null;
            // If Conversion os to TIFF set encoder Params
            if (cmbBxOutputFormat.Text == "TIFF Single Page")
            {
                encoderSettings = new TIFFEncoderSettings();
                (encoderSettings as TIFFEncoderSettings).MultiPage = false;
            }
            else if (cmbBxOutputFormat.Text == "TIFF Multipage")
            {
                encoderSettings = new TIFFEncoderSettings();
                (encoderSettings as TIFFEncoderSettings).MultiPage = true;
            }
            //// Merging of files
            //merge = false;
            //if (chckBxMerge.Checked == true)
            //    merge = true;
            // Conversion Mode
            switch (cmbConversionMode.SelectedIndex)
            {
                case 0:
                    conversionMode = ConversionMode.ConvertToSingleFile;
                    break;
                case 1:
                    conversionMode = ConversionMode.ConvertToSeperateFiles;
                    break;
                case 2:
                    conversionMode = ConversionMode.ConvertFirstFileAndAttachRestAsOriginal;
                    if (cmbBxOutputFormat.Text == "PDF" && chkCreatePortfolio.Checked)
                    {
                        encoderSettings = new PDFEncoderSettings();
                        (encoderSettings as PDFEncoderSettings).PDFPortfolioSettings.PortfolioCreationMode = PortfolioCreationMode.OnlyWhenAttachmentsExist;
                    }
                    break;
                case 3:
                    conversionMode = ConversionMode.CreateNewFileAndAttachAllAsOriginal;
                    if (cmbBxOutputFormat.Text == "PDF" && chkCreatePortfolio.Checked)
                    {
                        encoderSettings = new PDFEncoderSettings();
                        (encoderSettings as PDFEncoderSettings).PDFPortfolioSettings.PortfolioCreationMode = PortfolioCreationMode.Always;
                    }
                    break;
            }
            inputDocPassword = string.Empty;
            // Instance of Document Converter
            DocConverter = new DocumentConverter();
            // Event Handlers
            DocConverter.BeginJob += new EventHandler<ConverterBeginJobEventArgs>(DocConverter_StartJob);
            DocConverter.BeginDocument += new EventHandler<ConverterBeginDocumentEventArgs>(DocConverter_StartDocument);
            DocConverter.BeginPage += new EventHandler<ConverterBeginPageEventArgs>(DocConverter_StartPage);
            DocConverter.EndPage += new EventHandler<ConverterEndPageEventArgs>(DocConverter_EndPage);
            DocConverter.EndDocument += new EventHandler<ConverterEndDocumentEventArgs>(DocConverter_EndDocument);
            DocConverter.EndJob += new EventHandler<ConverterEndJobEventArgs>(DocConverter_EndJob);
            DocConverter.NeedPassword += new EventHandler<NeedPasswordEventArgs>(DocConverter_NeedPassword);
            DocConverter.Error += new EventHandler<ConverterErrorEventArgs>(DocConverter_Error);

            if (grpBxOCRSettings.Enabled)
            {
                if (cmbDigitizationMode.SelectedIndex == 0)
                {
                    DocConverter.Preferences.DigitizerSettings.DigitizationMode = Gnostice.Core.DigitizationEngine.DigitizationMode.Off;
                }
                else
                {
                    DocConverter.Preferences.DigitizerSettings.DigitizationMode = Gnostice.Core.DigitizationEngine.DigitizationMode.AllImages;
                }
            }
            try
            {
                // Create a new Thread to Convert files
                Thread conversion = new Thread(performConversion);
                conversion.Start();
            }
            catch (Exception ex)
            {
                DocConverter.Dispose();
                MessageBox.Show(ex.Message);
            }
        }

        void DocConverter_NeedPassword(object sender, NeedPasswordEventArgs e)
        {
            passwordAttempt++;
            if (passwordAttempt >= 4)
            {
                e.Cancel = true;
                return;
            }
            inputDocPassword = ShowNeedPasswordDialog("Please enter password to open '" + System.IO.Path.GetFileName(lstBxInputDocList.Items[currentFileIndex].ToString()) + "'", "Gnostice Document Studio .NET - Need Password");
            e.Password = inputDocPassword;
        }

        void DocConverter_Error(object sender, ConverterErrorEventArgs e)
        {
            errorMessage += "\r\n\r\n";
            errorMessage += inputDocuments[e.InputDocumentIndex];
            errorMessage += "\r\n" + e.ErrorMessage;
        }

        private string ShowNeedPasswordDialog(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 430;
            prompt.Height = 125;
            prompt.Text = caption;
            prompt.ControlBox = false;
            prompt.FormBorderStyle = FormBorderStyle.Fixed3D;
            prompt.StartPosition = FormStartPosition.CenterScreen;
            Label textLabel = new Label() { Left = 10, Top = 10, Text = text, AutoSize = true };
            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox() { Left = 10, Top = 30, Width = 400, PasswordChar = '*' };
            Button confirmation = new Button() { Text = "&Ok", Left = 190, Width = 100, Top = 60 };
            Button cancel = new Button() { Text = "&Cancel", Left = 310, Width = 100, Top = 60 };
            textBox.TabIndex = 0;
            confirmation.TabIndex = 1;
            cancel.TabIndex = 2;
            prompt.AcceptButton = confirmation;
            prompt.CancelButton = cancel;
            confirmation.Click += (sender, e) => { prompt.Close(); };
            cancel.Click += (sender, e) => { textBox.Text = string.Empty; prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(cancel);
            prompt.Controls.Add(textLabel);
            prompt.ShowDialog();
            return textBox.Text;
        }

        private void Animate(bool flag)
        {
            // To Show Progress Bar
            int speed = 8;
            if (flag)
            {
                for (int i = 0; i <= 529; i += speed)
                {
                    grpBxProgress.Left += speed;
                    this.Update();
                }
            }
            else // Hide Progress Bar
            {
                for (int i = 0; i <= 529; i += speed)
                {
                    this.Invoke(new Action(() => grpBxProgress.Left -= speed));
                    this.Invoke(new Action(() => this.Update()));
                }
            }
        }

        void DocConverter_EndJob(object sender, ConverterEndJobEventArgs e)
        {
            // 
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => prgsBrPageProgress.Value = 100));
                this.Invoke(new Action(() => prgsBrOverallProgress.Value = 100));
                this.Invoke(new Action(() => this.Update()));
            }
            else
            {
                prgsBrPageProgress.Value = 100;
                prgsBrOverallProgress.Value = 100;
                this.Update();
            }
            if (e.JobCanceled) // If Conversion is completed Successfully
                MessageBox.Show("operation Canceled" + errorMessage);
            else
                MessageBox.Show("Conversion Completed" + errorMessage);
            errorMessage = string.Empty;
            DocConverter.Dispose();
        }

        void DocConverter_EndDocument(object sender, ConverterEndDocumentEventArgs e)
        {
            // Calculate and Fill the progressbar
            int totalDocument = e.JobInfo.InputDocumentCount;
            int inputIndex = e.InputDocument.InputIndex;
            int percent = inputIndex * 100 / totalDocument;
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => prgsBrOverallProgress.Value = percent));
                this.Invoke(new Action(() => this.Update()));
            }
            else
            {
                prgsBrOverallProgress.Value = percent;
                this.Update();
            }
        }

        void DocConverter_EndPage(object sender, ConverterEndPageEventArgs e)
        {
            // Fill Overall and Current Job Progress Bar
            int pageCount = e.InputDocument.PageCount;
            int pageNumber = e.InputPageNumber;
            int totalDocument = e.JobInfo.InputDocumentCount;
            int inputIndex = e.InputDocument.InputIndex;
            int percent = pageNumber * 100 / pageCount;
            int percentage = inputIndex * 100 / totalDocument;
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => prgsBrPageProgress.Value = percent));
                this.Invoke(new Action(() => prgsBrOverallProgress.Value = percentage + percent / totalDocument));
                this.Invoke(new Action(() => this.Update()));
            }
            else
            {
                // Progress bar for current Job
                prgsBrPageProgress.Value = percent;

                // Update Overall Progress bar alone with pages.
                prgsBrOverallProgress.Value = percentage + percent / totalDocument;
                this.Update();
            }
        }

        void DocConverter_StartPage(object sender, ConverterBeginPageEventArgs e)
        {
            // Update current page Number to be converted
            e.Cancel = Cancel;
            int pageCount = e.InputDocument.PageCount;
            int pageNumber = e.InputPageNumber;
            string message = "Page(s) done: " + pageNumber + " of " + pageCount;
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => pages.Text = message));
                this.Invoke(new Action(() => pages.Location = new Point(404 - pages.Width, pages.Location.Y)));
                this.Invoke(new Action(() => this.Update()));
            }
            else
            {
                pages.Text = message;
                pages.Location = new Point(404 - pages.Width, pages.Location.Y);
                this.Update();
            }
        }

        void DocConverter_StartDocument(object sender, ConverterBeginDocumentEventArgs e)
        {
            //set the current file name  
            e.Cancel = Cancel;
            currentFileIndex++;
            passwordAttempt = 0;
            int totalDocument = e.JobInfo.InputDocumentCount;
            int inputIndex = e.InputDocument.InputIndex;
            string currentFileName = e.InputDocument.FileName;
            string message = "Document(s) done : " + inputIndex + " of " + totalDocument;
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => documents.Text = message));
                int startPosition = 404 - documents.Width;
                this.Invoke(new Action(() => documents.Location = new Point(startPosition, documents.Location.Y)));
                int len = (startPosition - 15 - fileName.Location.X) / 5;
                if (currentFileName.Length > len)
                {
                    string filename = @"...\" + System.IO.Path.GetFileNameWithoutExtension(currentFileName) + System.IO.Path.GetExtension(currentFileName);
                    int remainingCharacters = len - filename.Length;
                    if (remainingCharacters > 0)
                        currentFileName = currentFileName.Substring(0, remainingCharacters - 1) + filename;
                    else
                        currentFileName = filename.Substring(0, len);
                }
                // this.Invoke(new Action(() => fileName.MaximumSize=new Size(startPosition - 0-93,13)));
                this.Invoke(new Action(() => fileName.Text = currentFileName));
                this.Invoke(new Action(() => this.Update()));
            }
            else
            {
                documents.Text = message;
                int startPosition = 404 - documents.Width;
                documents.Location = new Point(startPosition, documents.Location.Y);
                int len = (startPosition - 15 - fileName.Location.X) / 5;
                if (currentFileName.Length > len)
                {
                    string filename = @"...\" + System.IO.Path.GetFileNameWithoutExtension(currentFileName) + System.IO.Path.GetExtension(currentFileName);
                    int remainingCharacters = len - filename.Length;
                    if (remainingCharacters > 0)
                        currentFileName = currentFileName.Substring(0, remainingCharacters - 1) + filename;
                    else
                        currentFileName = filename.Substring(0, len);
                }
                //  fileName.MaximumSize = new Size(startPosition - 15 - 93, 13);
                fileName.Text = currentFileName;
                this.Update();
            }
        }

        void DocConverter_StartJob(object sender, ConverterBeginJobEventArgs e)
        {
            e.Cancel = Cancel;
            currentFileIndex = 0;
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => prgsBrPageProgress.Value = 0));
                this.Invoke(new Action(() => prgsBrOverallProgress.Value = 0));
                this.Invoke(new Action(() => this.Update()));
            }
            else
            {
                prgsBrPageProgress.Value = 0;
                prgsBrOverallProgress.Value = 0;
                this.Update();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Cancel the Operation
            Cancel = true;
        }

        private void cmbBxOutputFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxOutputFormat.Text == "PDF" && (cmbConversionMode.SelectedIndex == 2 || cmbConversionMode.SelectedIndex == 3))
                chkCreatePortfolio.Enabled = true;
            else
                chkCreatePortfolio.Enabled = false;

            if (cmbBxOutputFormat.Text == "PDF")
                grpBxOCRSettings.Enabled = true;
            else
                grpBxOCRSettings.Enabled = false;
        }

        private void cmbConversionMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxOutputFormat.Text == "PDF" && (cmbConversionMode.SelectedIndex == 2 || cmbConversionMode.SelectedIndex == 3))
                chkCreatePortfolio.Enabled = true;
            else
                chkCreatePortfolio.Enabled = false;
        }
    }
}
