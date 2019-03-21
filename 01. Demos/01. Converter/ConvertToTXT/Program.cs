using Gnostice.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConvertoTXT
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
            string outputFormat = "txt";

            // List of files as input for the document Converter
            List<string> inputFiles = Directory.GetFiles(inputPath).ToList();

            // Single input file
            string inputFile = inputPath + "input.docx";

            // Single output file
            string outputFile = outputPath + "output." + outputFormat;

            #region Simple Conversion

            // Converting sample input file to TXT format
            docConverter.ConvertToFile(inputFile, outputFile);

            #endregion

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

            #region One to One Conversion

            // Converts all 
            //ConversionMode.ConvertToSeparateFiles=>Many to many conversion
            //Convert list of files in inputFiles into a single output file by specifying Conversion mode as ConversionMode.ConvertToSeperateFiles

            docConverter.ConvertToFile(inputFiles, outputFormat, outputPath, "ConvertToTXT_OneToOne_Multiple", ConversionMode.ConvertToSeperateFiles);
            #endregion

            #region Convert to single file

            //ConversionMode.ConverToSingleFile => Convert all the input files and merge it to a single file
            //Converts list of files in inputFiles into a single output file by specifying Conversion mode as ConversionMode.ConvertToSingleFile

            docConverter.ConvertToFile(inputFiles, outputFormat, outputPath, "ConvertToTXT_ManyToOne", ConversionMode.ConvertToSingleFile);

            #endregion

            #region Converting file using ConverterSettings

            // Instantiate ConverterSettings
            ConverterSettings cp = new ConverterSettings();

            // Converter Parameter : PageRange
            // 4 different types of page ranges
            // PageRange.All => Converts all pages in input file  
            // PageRange.Even => Converts Pages with even page number 
            // PageRange.Odd => Converts Pages with odd page number
            // PageRange.Custom => Converts set of pages from input file. ** page range should be specified in CustomPageRange

            // Convert all even pages in input file
            cp.PageRange = PageRange.Even;

            docConverter.ConvertToFile(inputFile, outputFormat, outputPath, "ConvertToTXT_WithConverterSettings_Even", ConversionMode.ConvertToSeperateFiles, null, cp);

            // Convert specific pages from input file, say one needs to convert  pages 1,4,8,9,10,11,12 from input file
            cp.PageRange = PageRange.Custom;
            cp.CustomPageRange = "1,4,8-12"; // **PageRange should be set to PageRange.Custom

            docConverter.ConvertToFile(inputFile, outputFormat, outputPath, "ConvertToTXT_WithConverterSettings_Custom", ConversionMode.ConvertToSeperateFiles, null, cp);
            #endregion

            #region TXT Encoder Parameters

            // For encoding file into TXT textEncoderParams have to be specified
            TextEncoderSettings txtEncoderParams = new TextEncoderSettings();

            txtEncoderParams.ByteOrderMarkBytes = new byte[0];

            // Types of file Encoding Files 'FileEncoding'
            // FileEncoding.ISO_8859_1=> encoding files in ISO 8859-1
            // FileEncoding.US_ASCII=>Encoding files in US ASCII
            // FileEncoding.UTF_16BE=> Encoding files in UTF 16BE
            // FileEncoding.UTF_16LE=> Encoding files in UTF 16LE
            // FileEncoding.UTF_8=> Encoding files in UTF 8 (default file encoding)
            txtEncoderParams.FileEncoding = FileEncoding.UTF_8;

            // 6 members of TextFormatter
            // TextFormatter.BreakLines=> break point at every line
            // TextFormatter.BreakPages=>break point at every page
            // TextFormatter.BreakParagraphs=>break point at every paragraph
            // TextFormatter.CustomPageBreak=>to enable  cutom break point
            // TextFormatter.CustomPageBreakText=>set the custom break point
            // TextFormatter.FILE_SEPARATOR_CHAR=>set the file separator character
            // TextFormatter.PageBreakText=>set the page break text
            // For setting break point to every line
            txtEncoderParams.TextFormatter.CustomPageBreak = true;
            txtEncoderParams.TextFormatter.CustomPageBreakText = "<<Page Break>>";

            // txtEncoderParams.UseByteOrderMark=>to use byte order mark
            txtEncoderParams.UseByteOrderMark = true;

            docConverter.ConvertToFile(inputFile, "txt", outputPath, "ConvertToTXT_WithEncoderSettings", ConversionMode.ConvertToSeperateFiles, txtEncoderParams, cp);

            #endregion
        }

        private static void docConverter_Error(object sender, ConverterErrorEventArgs e)
        {
            Console.WriteLine(e.ErrorMessage);
        }
    }
}
