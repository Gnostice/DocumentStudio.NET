using Gnostice.Converter;
using Gnostice.Core;
using Gnostice.Core.DOM;
using Gnostice.Core.Image;
using Gnostice.Documents;
using Gnostice.Documents.Image;
using Gnostice.Documents.PDF;
using Gnostice.Documents.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_CS_Document_Viewer
{
    public partial class SavingOptions : Form
    {
        private string OutputFileName = string.Empty;
        private string InputFileName = string.Empty;
        private string converterErrorMessage = string.Empty;

        public SavingOptions()
        {
            InitializeComponent();
            cmbOutputFormat.SelectedIndex = 0;
        }

        public SavingOptions(string inputFileName, string outputFileName)
        {
            InitializeComponent();
            this.OutputFileName = outputFileName;
            this.InputFileName = inputFileName;

            cmbCompressionType.SelectedIndex = 0;
            cmbFileEncoding.SelectedIndex = 0;
            cmbFontEmbedType.SelectedIndex = 0;
            cmbPageScalling.SelectedIndex = 0;
            cmbPDFVersion.SelectedIndex = 2;

            switch (System.IO.Path.GetExtension(outputFileName).ToLower())
            {
                case ".pdf": cmbOutputFormat.SelectedIndex = 0; break;
                case ".docx": cmbOutputFormat.SelectedIndex = 1; break;
                case ".bmp": cmbOutputFormat.SelectedIndex = 2; break;
                case ".png": cmbOutputFormat.SelectedIndex = 3; break;
                case ".jpg": cmbOutputFormat.SelectedIndex = 4; break;
                case ".tiff": cmbOutputFormat.SelectedIndex = 5; break;
                case ".txt": cmbOutputFormat.SelectedIndex = 6; break;
                case ".html": cmbOutputFormat.SelectedIndex = 7; break;
            }
        }

        private void cmbOutputFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpBxEncoderSettings.Visible = false;
            pnlImageEncoderSettings.Visible = false;
            pnlJPEGEncoderSettings.Visible = false;
            pnlPDFEncoderSettings.Visible = false;
            pnlTiffEncoderSettings.Visible = false;
            pnlTxtEncoderSettings.Visible = false;

            switch (cmbOutputFormat.SelectedIndex)
            {
                case 0: // PDF
                    pnlPDFEncoderSettings.Location = new Point(0, 17);
                    grpBxEncoderSettings.Size = new Size(248, pnlPDFEncoderSettings.Size.Height + 17);
                    grpBxEncoderSettings.Visible = true;
                    pnlPDFEncoderSettings.Visible = true;
                    break;
                case 1: // DOCX
                    break;
                case 2: // BMP
                case 3: // PNG
                case 4: // JPEG
                case 5: // TIFF
                    pnlImageEncoderSettings.Location = new Point(0, 17);
                    pnlImageEncoderSettings.Size = new System.Drawing.Size(248, 147);
                    grpBxEncoderSettings.Size = new Size(248, pnlImageEncoderSettings.Size.Height + 17);
                    grpBxEncoderSettings.Visible = true;
                    pnlImageEncoderSettings.Visible = true;

                    if (cmbOutputFormat.SelectedIndex == 4)
                    {
                        //JPEG
                        pnlJPEGEncoderSettings.Visible = true;
                        pnlJPEGEncoderSettings.Location = new Point(0, 149);
                        pnlImageEncoderSettings.Size = new System.Drawing.Size(248, pnlImageEncoderSettings.Size.Height + pnlJPEGEncoderSettings.Size.Height);
                        grpBxEncoderSettings.Size = new Size(248, pnlJPEGEncoderSettings.Size.Height + 149);
                    }

                    if (cmbOutputFormat.SelectedIndex == 5)
                    {
                        //TIFF
                        pnlTiffEncoderSettings.Visible = true;
                        pnlTiffEncoderSettings.Location = new Point(0, 149);
                        pnlImageEncoderSettings.Size = new System.Drawing.Size(248, pnlImageEncoderSettings.Size.Height + pnlTiffEncoderSettings.Size.Height);
                        grpBxEncoderSettings.Size = new Size(248, pnlTiffEncoderSettings.Size.Height + 149);
                    }
                    break;
                case 6: // TXT
                    pnlTxtEncoderSettings.Location = new Point(0, 17);
                    grpBxEncoderSettings.Size = new Size(248, pnlTxtEncoderSettings.Size.Height + 17);
                    grpBxEncoderSettings.Visible = true;
                    pnlTxtEncoderSettings.Visible = true;
                    break;
                case 7: // HTML
                    break;
            }

            grpBxEncoderSettings.Update();
            pnlImageEncoderSettings.Update();
            pnlJPEGEncoderSettings.Update();
            pnlPDFEncoderSettings.Update();
            pnlTiffEncoderSettings.Update();
            pnlTxtEncoderSettings.Update();

            if (cmbOutputFormat.SelectedIndex != 1 && cmbOutputFormat.SelectedIndex != 7)
            {
                btnSave.Location = new Point(btnSave.Location.X, 218 + grpBxEncoderSettings.Size.Height + 7);
                btnCancel.Location = new Point(btnCancel.Location.X, 218 + grpBxEncoderSettings.Size.Height + 7);
            }
            else
            {
                btnSave.Location = new Point(btnSave.Location.X, 218);
                btnCancel.Location = new Point(btnCancel.Location.X, 218);
            }

            this.Height = btnSave.Location.Y + btnSave.Size.Height + 45;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (OutputFileName != string.Empty)
            {
                ConverterSettings converterSettigns = GetConverterSettings();
                EncoderSettings encoderSettings = GetEncoderSettings();

                int lastIndex = OutputFileName.LastIndexOf(System.IO.Path.GetExtension(OutputFileName));

                switch (cmbOutputFormat.SelectedIndex)
                {
                    case 0: // PDF
                        OutputFileName = OutputFileName.Substring(0, lastIndex) + ".pdf";
                        break;
                    case 1: // DOCX
                        OutputFileName = OutputFileName.Substring(0, lastIndex) + ".docx";
                        break;
                    case 6: // Text
                        OutputFileName = OutputFileName.Substring(0, lastIndex) + ".txt";
                        break;
                    case 7: // HTML
                        OutputFileName = OutputFileName.Substring(0, lastIndex) + ".html";
                        break;
                    case 2: // BMP
                        OutputFileName = OutputFileName.Substring(0, lastIndex) + ".bmp";
                        break;
                    case 3: // PNG
                        OutputFileName = OutputFileName.Substring(0, lastIndex) + ".png";
                        break;
                    case 4: // JPEG
                        OutputFileName = OutputFileName.Substring(0, lastIndex) + ".jpeg";
                        break;
                    case 5: // TIFF
                        OutputFileName = OutputFileName.Substring(0, lastIndex) + ".tiff";
                        break;
                    default:
                        break;
                }

                DocumentConverter docConvtr = new DocumentConverter();
                docConvtr.Error += docConvtr_Error;

                converterErrorMessage = string.Empty;
                docConvtr.ConvertToFile(InputFileName, OutputFileName, encoderSettings, converterSettigns);

                if (converterErrorMessage == string.Empty)
                    MessageBox.Show("File is saved as " + OutputFileName);
                else
                    MessageBox.Show(converterErrorMessage);
            }
            this.Close();
            OutputFileName = string.Empty;
        }

        void docConvtr_Error(object sender, ConverterErrorEventArgs e)
        {
            converterErrorMessage += e.ErrorMessage;
        }

        private ConverterSettings GetConverterSettings()
        {
            ConverterSettings converterSettings = new ConverterSettings();

            if (rdbAll.Checked)
                converterSettings.PageRange = PageRange.All;
            else if (rdbEven.Checked)
                converterSettings.PageRange = PageRange.Even;
            else if (rdbOdd.Checked)
                converterSettings.PageRange = PageRange.Odd;
            else
                converterSettings.PageRange = PageRange.Custom;
            converterSettings.CustomPageRange = txtCustomPageRange.Text;

            return converterSettings;
        }

        private EncoderSettings GetEncoderSettings()
        {
            switch (cmbOutputFormat.SelectedIndex)
            {
                case 0: // PDF
                    PDFEncoderSettings pdfEncoderSettings = new PDFEncoderSettings();
                    switch (cmbFontEmbedType.SelectedIndex)
                    {
                        case 0:
                            pdfEncoderSettings.FontEmbedType = FontEmbedType.Full;
                            break;
                        case 1:
                            pdfEncoderSettings.FontEmbedType = FontEmbedType.None;
                            break;
                        case 2:
                            pdfEncoderSettings.FontEmbedType = FontEmbedType.Subset;
                            break;
                    }
                    switch (cmbPDFVersion.SelectedIndex)
                    {
                        case 0:
                            pdfEncoderSettings.PDFVersion = Gnostice.Documents.PDF.PDFVersion.V1_4;
                            break;
                        case 1:
                            pdfEncoderSettings.PDFVersion = Gnostice.Documents.PDF.PDFVersion.V1_5;
                            break;
                        case 2:
                            pdfEncoderSettings.PDFVersion = Gnostice.Documents.PDF.PDFVersion.V1_6;
                            break;
                    }
                    return pdfEncoderSettings;
                case 6: // Text
                    TextEncoderSettings textEncoderSettings = new TextEncoderSettings();
                    switch (cmbFileEncoding.SelectedIndex)
                    {
                        case 0:
                            textEncoderSettings.FileEncoding = FileEncoding.UTF_8;
                            break;
                        case 1:
                            textEncoderSettings.FileEncoding = FileEncoding.US_ASCII;
                            break;
                        case 2:
                            textEncoderSettings.FileEncoding = FileEncoding.UTF_16BE;
                            break;
                        case 3:
                            textEncoderSettings.FileEncoding = FileEncoding.UTF_16LE;
                            break;
                        case 4:
                            textEncoderSettings.FileEncoding = FileEncoding.ISO_8859_1;
                            break;
                    }

                    if (chkBreakLines.Checked)
                        textEncoderSettings.TextFormatter.BreakLines = true;
                    else
                        textEncoderSettings.TextFormatter.BreakLines = false;

                    if (chkBreakPages.Checked)
                        textEncoderSettings.TextFormatter.BreakPages = true;
                    else
                        textEncoderSettings.TextFormatter.BreakPages = false;

                    if (chkBreakParagraphs.Checked)
                        textEncoderSettings.TextFormatter.BreakParagraphs = true;
                    else
                        textEncoderSettings.TextFormatter.BreakParagraphs = false;

                    if (txtCustomPageBreak.Text != string.Empty)
                    {
                        textEncoderSettings.TextFormatter.CustomPageBreak = true;
                        textEncoderSettings.TextFormatter.CustomPageBreakText = txtCustomPageBreak.Text;
                    }
                    return textEncoderSettings;
                case 2: // BMP
                    BMPEncoderSettings bmpEncoderSettings = new BMPEncoderSettings();

                    switch (cmbPageScalling.SelectedIndex)
                    {
                        case 0:
                            bmpEncoderSettings.PageScaling = PageScaling.None;
                            break;
                        case 1:
                            bmpEncoderSettings.PageScaling = PageScaling.UseRenderingResolution;
                            break;
                    }

                    bmpEncoderSettings.RenderingSettings = new Gnostice.    Core.Graphics.RenderingSettings();

                    //if (chkSmoothImages.Checked)
                    //    bmpEncoderSettings.RenderingSettings.SmoothImages = true;
                    //else
                    //    bmpEncoderSettings.RenderingSettings.SmoothImages = false;

                    //if (chkSmoothLineart.Checked)
                    //    bmpEncoderSettings.RenderingSettings.SmoothLineart = true;
                    //else
                    //    bmpEncoderSettings.RenderingSettings.SmoothLineart = false;

                    //if (chkSmoothText.Checked)
                    //    bmpEncoderSettings.RenderingSettings.SmoothText = true;
                    //else
                    //    bmpEncoderSettings.RenderingSettings.SmoothText = false;

                    try
                    {
                        bmpEncoderSettings.ResolutionSettings = new Gnostice.Core.Graphics.ResolutionSettings();
                        bmpEncoderSettings.ResolutionSettings.DpiX = float.Parse(txtDPIX.Text);
                        bmpEncoderSettings.ResolutionSettings.DpiY = float.Parse(txtDPIY.Text);
                    }
                    catch { bmpEncoderSettings.ResolutionSettings = new Gnostice.Core.Graphics.ResolutionSettings(); }

                    return bmpEncoderSettings;
                case 3: // PNG
                    PNGEncoderSettings pngEncoderSettings = new PNGEncoderSettings();

                    switch (cmbPageScalling.SelectedIndex)
                    {
                        case 0:
                            pngEncoderSettings.PageScaling = PageScaling.None;
                            break;
                        case 1:
                            pngEncoderSettings.PageScaling = PageScaling.UseRenderingResolution;
                            break;
                    }

                    pngEncoderSettings.RenderingSettings = new Gnostice.Core.Graphics.RenderingSettings();

                    //if (chkSmoothImages.Checked)
                    //    pngEncoderSettings.RenderingSettings.SmoothImages = true;
                    //else
                    //    pngEncoderSettings.RenderingSettings.SmoothImages = false;

                    //if (chkSmoothLineart.Checked)
                    //    pngEncoderSettings.RenderingSettings.SmoothLineart = true;
                    //else
                    //    pngEncoderSettings.RenderingSettings.SmoothLineart = false;

                    //if (chkSmoothText.Checked)
                    //    pngEncoderSettings.RenderingSettings.SmoothText = true;
                    //else
                    //    pngEncoderSettings.RenderingSettings.SmoothText = false;

                    try
                    {
                        pngEncoderSettings.ResolutionSettings = new Gnostice.Core.Graphics.ResolutionSettings();
                        pngEncoderSettings.ResolutionSettings.DpiX = float.Parse(txtDPIX.Text);
                        pngEncoderSettings.ResolutionSettings.DpiY = float.Parse(txtDPIY.Text);
                    }
                    catch { pngEncoderSettings.ResolutionSettings = new Gnostice.Core.Graphics.ResolutionSettings(); }

                    return pngEncoderSettings;
                case 4: // JPEG
                    JPEGEncoderSettings jpegEncoderSettings = new JPEGEncoderSettings();

                    switch (cmbPageScalling.SelectedIndex)
                    {
                        case 0:
                            jpegEncoderSettings.PageScaling = PageScaling.None;
                            break;
                        case 1:
                            jpegEncoderSettings.PageScaling = PageScaling.UseRenderingResolution;
                            break;
                    }

                    jpegEncoderSettings.RenderingSettings = new Gnostice.Core.Graphics.RenderingSettings();

                    //if (chkSmoothImages.Checked)
                    //    jpegEncoderSettings.RenderingSettings.SmoothImages = true;
                    //else
                    //    jpegEncoderSettings.RenderingSettings.SmoothImages = false;

                    //if (chkSmoothLineart.Checked)
                    //    jpegEncoderSettings.RenderingSettings.SmoothLineart = true;
                    //else
                    //    jpegEncoderSettings.RenderingSettings.SmoothLineart = false;

                    //if (chkSmoothText.Checked)
                    //    jpegEncoderSettings.RenderingSettings.SmoothText = true;
                    //else
                    //    jpegEncoderSettings.RenderingSettings.SmoothText = false;

                    try
                    {
                        jpegEncoderSettings.ResolutionSettings = new Gnostice.Core.Graphics.ResolutionSettings();
                        jpegEncoderSettings.ResolutionSettings.DpiX = float.Parse(txtDPIX.Text);
                        jpegEncoderSettings.ResolutionSettings.DpiY = float.Parse(txtDPIY.Text);
                    }
                    catch { jpegEncoderSettings.ResolutionSettings = new Gnostice.Core.Graphics.ResolutionSettings(); }

                    jpegEncoderSettings.QualityLevel = (long)trkQualityLevel.Value;
                    return jpegEncoderSettings;
                case 5: // TIFF
                    TIFFEncoderSettings tiffEncoderSettings = new TIFFEncoderSettings();

                    switch (cmbPageScalling.SelectedIndex)
                    {
                        case 0:
                            tiffEncoderSettings.PageScaling = PageScaling.None;
                            break;
                        case 1:
                            tiffEncoderSettings.PageScaling = PageScaling.UseRenderingResolution;
                            break;
                    }

                    tiffEncoderSettings.RenderingSettings = new Gnostice.Core.Graphics.RenderingSettings();

                    //if (chkSmoothImages.Checked)
                    //    tiffEncoderSettings.RenderingSettings.SmoothImages = true;
                    //else
                    //    tiffEncoderSettings.RenderingSettings.SmoothImages = false;

                    //if (chkSmoothLineart.Checked)
                    //    tiffEncoderSettings.RenderingSettings.SmoothLineart = true;
                    //else
                    //    tiffEncoderSettings.RenderingSettings.SmoothLineart = false;

                    //if (chkSmoothText.Checked)
                    //    tiffEncoderSettings.RenderingSettings.SmoothText = true;
                    //else
                    //    tiffEncoderSettings.RenderingSettings.SmoothText = false;

                    try
                    {
                        tiffEncoderSettings.ResolutionSettings = new Gnostice.Core.Graphics.ResolutionSettings();
                        tiffEncoderSettings.ResolutionSettings.DpiX = float.Parse(txtDPIX.Text);
                        tiffEncoderSettings.ResolutionSettings.DpiY = float.Parse(txtDPIY.Text);
                    }
                    catch { tiffEncoderSettings.ResolutionSettings = new Gnostice.Core.Graphics.ResolutionSettings(); }

                    switch (cmbCompressionType.SelectedIndex)
                    {
                        case 0:
                            tiffEncoderSettings.CompressionType = TiffCompressionType.None;
                            break;
                        case 1:
                            tiffEncoderSettings.CompressionType = TiffCompressionType.CCITT_T6;
                            break;
                        case 2:
                            tiffEncoderSettings.CompressionType = TiffCompressionType.LZW;
                            break;
                        case 3:
                            tiffEncoderSettings.CompressionType = TiffCompressionType.CCITT_T4;
                            break;
                        case 4:
                            tiffEncoderSettings.CompressionType = TiffCompressionType.CCITT_RLE;
                            break;
                    }

                    if (chkMultipage.Checked)
                        tiffEncoderSettings.MultiPage = true;
                    else
                        tiffEncoderSettings.MultiPage = false;

                    return tiffEncoderSettings;
                default:
                    return null;
            }
        }
    }
}
