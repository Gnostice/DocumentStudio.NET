using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Gnostice.Core;
using Gnostice.Documents;
using Gnostice.Converter;
using Gnostice.Documents.Image;
using Gnostice.Documents.PDF;

namespace WPF_CS_Document_Converter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> inputFiles = new List<string>();
        private string errorMessage = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnInputFiles_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "All Files|*.pdf;*.docx;*.doc;*.jpg;*.png;*.bmp;*.gif;*.tif;*.tiff;*.emf;*.wmf;*.txt;*.xps;|PDF Files|*.pdf|Word Documents|*.docx;*.doc|Image Files|*.jpg;*.png;*.bmp;*.gif;*.tiff;*.tif;*.emf;*.wmf;|Text Files|*.txt;|XPS Files|*.xps;|All Files|*.*";
            if (ofd.ShowDialog() == true)
            {
                foreach (string fileName in ofd.FileNames)
                {
                    inputFiles.Add(fileName);
                    txtInput.Text += System.IO.Path.GetFileName(fileName);
                    if (txtInput.Text != string.Empty)
                        txtInput.Text += ", ";
                    if (txtOutputDirectory.Text == string.Empty)
                        txtOutputDirectory.Text = System.IO.Path.GetDirectoryName(fileName);
                }
            }
        }

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
			DocumentConverter docConvtr = new DocumentConverter();
            
			 // Setting option in converter to have OCR done or not; AllImages = OCR ON, Off = OCR Off
            docConvtr.Preferences.DigitizerSettings.DigitizationMode = Gnostice.Core.DigitizationEngine.DigitizationMode.AllImages;

			docConvtr.Preferences.DigitizerSettings.ImageEnhancementSettings.ImageEnhancementMode = Gnostice.Core.DigitizationEngine.ImageEnhancementMode.OFF;
            
			// for specifying english and french, string passed should be "fra+eng"; tessdata for languages is available for download at
            //https://code.google.com/p/tesseract-ocr/downloads/list?num=100&start=100
            // For languages with Unicode characters, adding of invisible text to PDF requires "Arial Unicode MS" font in systems fonts directory. If the font is not present, Helvetica is used which is a non Unicode font as a result, the invisible text added will be incorrect.
            docConvtr.Preferences.DigitizerSettings.OCRSettings.DocumentLanguage = "fra+eng";
						
			docConvtr.Error += docConvtr_Error;
			
            //bool merge = false;
            ConversionMode conversionMode = ConversionMode.ConvertToSeperateFiles;
            EncoderSettings EncoderSettings = null;
            string outputFormat = cmbOutputFormat.Text;
            if (outputFormat.CompareTo("TIFF Multipage") == 0)
            {
                outputFormat = "TIFF";
                EncoderSettings = new TIFFEncoderSettings();
                (EncoderSettings as TIFFEncoderSettings).MultiPage = true;
            }

            //if (chkMerge.IsChecked == true)
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
                    if (outputFormat == "PDF" && chkCreatePortfolio.IsChecked == true)
                    {
                        EncoderSettings = new PDFEncoderSettings();
                        (EncoderSettings as PDFEncoderSettings).PDFPortfolioSettings.PortfolioCreationMode = PortfolioCreationMode.OnlyWhenAttachmentsExist;
                    }
                    break;
                case 3:
                    conversionMode = ConversionMode.CreateNewFileAndAttachAllAsOriginal;
                    if (outputFormat == "PDF" && chkCreatePortfolio.IsChecked == true)
                    {
                        EncoderSettings = new PDFEncoderSettings();
                        (EncoderSettings as PDFEncoderSettings).PDFPortfolioSettings.PortfolioCreationMode = PortfolioCreationMode.Always;
                    }
                    break;
            }
            try
            {
                //docConvtr.ConvertToFile(inputFiles, outputFormat, txtOutputDirectory.Text, txtBaseName.Text, merge, null, EncoderSettings);
                docConvtr.ConvertToFile(inputFiles, outputFormat, txtOutputDirectory.Text, txtBaseName.Text, conversionMode, EncoderSettings);
                if (errorMessage != string.Empty)
                    errorMessage = "Conversion Completed..!!" + "\n\n" + errorMessage;
                else
                    errorMessage = "Conversion Completed..!!";
                MessageBox.Show(errorMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            errorMessage = string.Empty;
        }

        void docConvtr_Error(object sender, ConverterErrorEventArgs e)
        {
            errorMessage += inputFiles[e.InputDocumentIndex] + "\n" + e.ErrorMessage;
        }

        private void cmbOutputFormat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbOutputFormat != null && cmbConversionMode != null && chkCreatePortfolio != null)
                if (cmbOutputFormat.SelectedIndex == 0 && (cmbConversionMode.SelectedIndex == 2 || cmbConversionMode.SelectedIndex == 3))
                    chkCreatePortfolio.Visibility = System.Windows.Visibility.Visible;
                else
                    chkCreatePortfolio.Visibility = System.Windows.Visibility.Hidden;
        }

        private void cmbConversionMode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbOutputFormat != null && cmbConversionMode != null && chkCreatePortfolio != null)
                if (cmbOutputFormat.SelectedIndex == 0 && (cmbConversionMode.SelectedIndex == 2 || cmbConversionMode.SelectedIndex == 3))
                    chkCreatePortfolio.Visibility = System.Windows.Visibility.Visible;
                else
                    chkCreatePortfolio.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
