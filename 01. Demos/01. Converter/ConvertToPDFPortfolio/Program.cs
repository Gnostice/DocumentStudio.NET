using Gnostice.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConvertToPDFPortfolio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Activate Gnostice product
            Framework.ActivateLicense("4AF4-263D-70A5-F5C8-57E6-045C-ED92-5369");

            // Instantiate DocumentConverter
            DocumentConverter docConverter = new DocumentConverter();

            // Subscribe to Error event
            docConverter.Error += docConverter_Error;

            // Input Directory
            string inputPath = @"../../../../../03. Sample Files/";

            // Output Directory
            string outputPath = @"../../../../../04. Output/";

            // Output Format
            string outputFormat = "pdf";

            // List of files as input for the document Converter
            List<string> inputFiles = Directory.GetFiles(inputPath).ToList();

            // public List<string> ConvertToFile(
            // object input, => accepts string (file name) or Stream (file stream) or List<string> or List<Stream>
            // string outputFileFormat,  => expected output file format
            // string outputDir, => directory in which the output files are to be stored
            // string baseFileName = "", => name of the output converted file
            // ConversionMode conversionmode, => ConversionMode.ConvertToSeparateFiles to create a separated file for each converted input file
            // ConverterSettings converterSettings = null, => specifiy the range of pages to be converted
            // EncoderSettings encoderSettings = null, => set the information for encoding the document
            // string inputDocPassword = "" => password for the input document
            // );

            #region PDF Encoder Settings

            // For encoding into PDF portfolios files PdfEncoderParams have to be specified
            PDFEncoderSettings pdfEncoderParams = new PDFEncoderSettings();

            // 3 conditions of creating PDF portfolio
            // PortfolioCreationMode.Always => Always creates a portfolio
            // PortfolioCreationMode.Off => Does not create a portfolio
            // PortfolioCreationMode.OnlyWhenAttachmentsExist => Creates a portfolio only when there is more than one document
            // PortfolioCreationMode.WhenInputIsPortfolio => creates a portfolio when the input is a portfolio
            pdfEncoderParams.PDFPortfolioSettings.PortfolioCreationMode = PortfolioCreationMode.Always;

            // 3 views of the PDF portfolio
            // PortfolioLayoutMode.Details => Shows the details of the various files in the portfolio
            // PortfolioLayoutMode.Hide => Hides the details of the  various files in the portfolio
            // PortfolioLayoutMode.Tile => Dispays the  attached documents in the form of tiles
            pdfEncoderParams.PDFPortfolioSettings.PortfolioLayoutMode = PortfolioLayoutMode.Tile;

            #endregion

            #region Covert first file and attach remaining in their original forms

            // ConversionMode.ConvertFirstFileAndAttachRestAsOriginal => Converts first file and attaches remaining as originals
            docConverter.ConvertToFile(inputFiles, outputFormat, outputPath, "ConvertToPDFPortfolio_ConvertFirstFileAndAttachRestAsOriginal", ConversionMode.CreateNewFileAndAttachAllAsOriginal, pdfEncoderParams);

            #endregion

            #region Attach all originals

            //ConversionMode.ConverToSingleFile =>creates a new file and attaches all files in their original form without converting any file

            docConverter.ConvertToFile(inputFiles, outputFormat, outputPath, "ConvertToPDFPortfolio_CreateNewFileAndAttachAllAsOriginal", ConversionMode.CreateNewFileAndAttachAllAsOriginal, pdfEncoderParams);

            #endregion

            #region Converting file using ConverterSettings

            // Instantiate ConverterSettings
            ConverterSettings cp = new ConverterSettings();

            // Converter Parameter : PageRange
            // 4 different types of page ranges
            // PageRange.All => Converts all pages in first input file  
            // PageRange.Even => Converts Pages with even page number in the first input file
            // PageRange.Odd => Converts Pages with odd page number in the first input file
            // PageRange.Custom => Converts set of pages from first input file. ** page range should be specified in CustomPageRange

            // Convert all even pages in first input file
            cp.PageRange = PageRange.Even;

            docConverter.ConvertToFile(inputFiles, outputFormat, outputPath, "ConvertToPDFPortfolio_WithConverterSettings_Even", ConversionMode.ConvertFirstFileAndAttachRestAsOriginal, pdfEncoderParams, cp);

            // Convert specific pages from input file, say one need to convert 1,3,5,6,7,10 pages from input file
            cp.PageRange = PageRange.Custom;
            cp.CustomPageRange = "1,3,5-7,10"; // **PageRange should be set to PageRange.Custom

            docConverter.ConvertToFile(inputFiles, outputFormat, outputPath, "ConvertToPDFPortfolio_WithConverterSettings_Custom", ConversionMode.ConvertFirstFileAndAttachRestAsOriginal, pdfEncoderParams, cp);
            #endregion

        }

        private static void docConverter_Error(object sender, ConverterErrorEventArgs e)
        {
            Console.WriteLine(e.ErrorMessage);
        }
    }
}