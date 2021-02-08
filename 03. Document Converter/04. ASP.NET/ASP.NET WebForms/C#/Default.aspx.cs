using System;
using System.IO;
using System.IO.Packaging;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using Gnostice.Documents;
using System.Configuration;
using Gnostice.Converter;
using Gnostice.Core;
using Gnostice.Documents.Image;
using Gnostice.Documents.PDF;

namespace ASP.NET_Web_Converter
{
    public partial class _Default : System.Web.UI.Page
    {
        private List<string> inputFileNames = new List<string>();
        private List<string> inputFiles = new List<string>();
        private Random rndm = new Random();
        private string outputFileFormat;
        //private bool merge;
        private ConversionMode conversionMode;
        private string baseFileName;
        private string outputDocDirectory;
        private ConverterSettings ConverterSettings = null;
        private EncoderSettings EncoderSettings = null;
        private string inputDocPassword;
        private DocumentConverter DocConverter;

        private string licenseKey = ConfigurationManager.AppSettings["LicenseKey"];
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["inputFileNames"] != null)
                inputFileNames = (List<string>)ViewState["inputFileNames"];
            if (ViewState["inputFiles"] != null)
                inputFiles = (List<string>)ViewState["inputFiles"];
            outputlink.Visible = false;
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            HttpFileCollection hfc = Request.Files;
            for (int i = 0; i < hfc.Count; i++)
            {
                HttpPostedFile hpf = hfc[i];
                if (hpf.ContentLength > 0)
                {
                    string fileExtention = string.Empty;
                    for (int j = hpf.FileName.Length - 1; hpf.FileName[j] != '.'; j--)
                        fileExtention = hpf.FileName[j] + fileExtention;
                    string currentFileNameToSave = ((DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalMilliseconds.ToString() + "_" + rndm.Next().ToString()).Replace('.', '_') + "." + fileExtention;
                    hpf.SaveAs(Server.MapPath("~/Uploads/") + currentFileNameToSave);
                    inputFileNames.Add(System.IO.Path.GetFileName(hpf.FileName));
                    inputFiles.Add(Server.MapPath("~/Uploads/") + currentFileNameToSave);
                }
            }
            ddlInputFiles.Items.Clear();
            foreach (string fileName in inputFileNames)
                ddlInputFiles.Items.Add(fileName);
            ViewState["inputFileNames"] = inputFileNames;
            ViewState["inputFiles"] = inputFiles;
            ddlOutputFormat.SelectedIndex = 0;
            EnableOrDisable();
        }

        private void EnableOrDisable()
        {
            if (ddlInputFiles.Items.Count == 0)
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
            if (ddlInputFiles.SelectedIndex == 0)
                btnUp.Enabled = false;
            else if (ddlInputFiles.SelectedIndex == ddlInputFiles.Items.Count - 1)
                btnDown.Enabled = false;
            else
            {
                btnUp.Enabled = true;
                btnDown.Enabled = true;
            }
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            // Remove a file from List
            try
            {
                // Retaining SelectedIndex
                int selectedIndex = ddlInputFiles.SelectedIndex;
                try
                {
                    // Remove Selected file from the List
                    inputFileNames.Remove(ddlInputFiles.Items[selectedIndex].ToString());
                    //inputFiles.Remove(ddlInputFiles.Items[selectedIndex].ToString());
                    inputFiles.RemoveAt(selectedIndex);
                    ddlInputFiles.Items.Remove(ddlInputFiles.SelectedItem);
                    if (selectedIndex != 0)
                        ddlInputFiles.SelectedIndex = selectedIndex;
                    else if (ddlInputFiles.Items.Count != 0)
                        ddlInputFiles.SelectedIndex = 0;
                }
                catch
                {
                    ddlInputFiles.SelectedIndex = 0;
                }
                ddlInputFiles.Focus();
                ViewState["inputFileNames"] = inputFileNames;
                ViewState["inputFiles"] = inputFiles;
                EnableOrDisable();
            }
            catch
            {

            }
        }

        protected void btnUp_Click(object sender, EventArgs e)
        {
            // Move Selected File 1 step Upwards
            int selectedIndex = ddlInputFiles.SelectedIndex;
            ListItem listItem = ddlInputFiles.SelectedItem;
            string lstItm = inputFileNames[selectedIndex];
            string listitem = inputFiles[selectedIndex];
            if (selectedIndex != 0)
            {
                inputFileNames.Insert(selectedIndex + 1, lstItm);
                inputFiles.Insert(selectedIndex + 1, listitem);
                inputFileNames.Remove(ddlInputFiles.Items[selectedIndex].ToString());
                //inputFiles.Remove(ddlInputFiles.Items[selectedIndex].ToString());
                inputFiles.RemoveAt(selectedIndex);
                ddlInputFiles.Items.Remove(ddlInputFiles.SelectedItem);
                ddlInputFiles.Items.Insert(selectedIndex - 1, listItem);
                ddlInputFiles.SelectedIndex = selectedIndex - 1;
            }
            ddlInputFiles.Focus();
            ViewState["inputFileNames"] = inputFileNames;
            ViewState["inputFiles"] = inputFiles;
            EnableOrDisable();
        }

        protected void btnDown_Click(object sender, EventArgs e)
        {
            // Move Selected File 1 step Upwards
            int selectedIndex = ddlInputFiles.SelectedIndex;
            ListItem listItem = ddlInputFiles.SelectedItem;
            string lstItm = inputFileNames[selectedIndex];
            string listitem = inputFiles[selectedIndex];
            if (selectedIndex != ddlInputFiles.Items.Count - 1)
            {
                inputFileNames.Remove(ddlInputFiles.Items[selectedIndex].ToString());
                //inputFiles.Remove(ddlInputFiles.Items[selectedIndex].ToString());
                inputFiles.RemoveAt(selectedIndex);
                ddlInputFiles.Items.Remove(ddlInputFiles.SelectedItem);
                ddlInputFiles.Items.Insert(selectedIndex + 1, listItem);
                inputFileNames.Insert(selectedIndex + 1, lstItm);
                inputFiles.Insert(selectedIndex + 1, listitem);
                ddlInputFiles.SelectedIndex = selectedIndex + 1;
            }
            ddlInputFiles.Focus();
            ViewState["inputFileNames"] = inputFileNames;
            ViewState["inputFiles"] = inputFiles;
            EnableOrDisable();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            outputlink.Visible = false;
            lblError.Visible = false;
            outputFileFormat = ddlOutputFormat.Items[ddlOutputFormat.SelectedIndex].ToString().ToLower();// SelectedValue;
            // Output File Format
            if (outputFileFormat == "tiff single page" || outputFileFormat == "tiff multipage")
                outputFileFormat = "tiff";
            // Default name for converted files
            baseFileName = txtBaseFileName.Text;
            string ZipFileName = rndm.Next().ToString();
            outputDocDirectory = Server.MapPath("~/Converted/Temp/");
            ConverterSettings = null;
            EncoderSettings = null;
            // If Conversion os to TIFF set encoder Params
            if (ddlOutputFormat.Text == "TIFF Single Page")
            {
                EncoderSettings = new TIFFEncoderSettings();
                (EncoderSettings as TIFFEncoderSettings).MultiPage = false;
            }
            else if (ddlOutputFormat.Text == "TIFF Multipage")
            {
                EncoderSettings = new TIFFEncoderSettings();
                (EncoderSettings as TIFFEncoderSettings).MultiPage = true;
            }
            //// Merging of files
            //merge = false;
            //if (MergeFiles.Checked == true)
            //    merge = true;
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
                    if (ddlOutputFormat.Text == "PDF" && chkCreatePortfolio.Checked)
                    {
                        EncoderSettings = new PDFEncoderSettings();
                        (EncoderSettings as PDFEncoderSettings).PDFPortfolioSettings.PortfolioCreationMode = PortfolioCreationMode.OnlyWhenAttachmentsExist;
                    }
                    break;
                case 3:
                    conversionMode = ConversionMode.CreateNewFileAndAttachAllAsOriginal;
                    if (ddlOutputFormat.Text == "PDF" && chkCreatePortfolio.Checked)
                    {
                        EncoderSettings = new PDFEncoderSettings();
                        (EncoderSettings as PDFEncoderSettings).PDFPortfolioSettings.PortfolioCreationMode = PortfolioCreationMode.Always;
                    }
                    break;
            }
            inputDocPassword = string.Empty;
            DocConverter = new DocumentConverter();
			
			// Setting option in converter to have OCR done or not; AllImages = OCR ON, Off = OCR Off
            DocConverter.Preferences.DigitizerSettings.DigitizationMode =
                Gnostice.Core.DigitizationEngine.DigitizationMode.AllImages;

            try
            {
                //List<string> outputList = DocConverter.ConvertToFile(inputFiles, outputFileFormat, outputDocDirectory, baseFileName, merge, ConverterSettings, EncoderSettings, inputDocPassword);
                List<string> outputList = DocConverter.ConvertToFile(inputFiles, outputFileFormat, outputDocDirectory, baseFileName, conversionMode, EncoderSettings, ConverterSettings, inputDocPassword);
                foreach (string OutputFile in outputList)
                    AddFileToZip(Server.MapPath("~/Converted/") + ZipFileName + ".zip", OutputFile);
                outputlink.NavigateUrl = "~/Converted/" + ZipFileName + ".zip";
                outputlink.Visible = true;
                this.Dispose();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
                lblError.Visible = true;
                outputlink.Visible = false;
            }
            finally
            {
                DocConverter.Dispose();
            }
        }

        private static void AddFileToZip(string zipFilename, string fileToAdd)
        {
            using (Package zip = System.IO.Packaging.Package.Open(zipFilename, FileMode.OpenOrCreate))
            {
                string destFilename = ".\\" + Path.GetFileName(fileToAdd);
                Uri uri = PackUriHelper.CreatePartUri(new Uri(destFilename, UriKind.Relative));
                if (zip.PartExists(uri))
                {
                    zip.DeletePart(uri);
                }
                PackagePart part = zip.CreatePart(uri, "", CompressionOption.Normal);
                using (FileStream fileStream = new FileStream(fileToAdd, FileMode.Open, FileAccess.Read))
                {
                    using (Stream dest = part.GetStream())
                    {
                        CopyStream(fileStream, dest);
                    }
                }
            }
        }

        private static void CopyStream(System.IO.FileStream inputStream, System.IO.Stream outputStream)
        {
            long bufferSize = inputStream.Length;
            byte[] buffer = new byte[bufferSize];
            int bytesRead = 0;
            long bytesWritten = 0;
            while ((bytesRead = inputStream.Read(buffer, 0, buffer.Length)) != 0)
            {
                outputStream.Write(buffer, 0, bytesRead);
                bytesWritten += bufferSize;
            }
        }
    }
}
