using Gnostice.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace ConvertToJPEG
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
            string outputFormat = "jpg";

            // List of files as input for the document Converter
            List<string> inputFiles = Directory.GetFiles(inputPath).ToList();

            // Single input file
            string inputFile = inputPath + "input.docx";

            // Single output file
            string outputFile = outputPath + "output." + outputFormat;

            #region Simple Conversion

            // Converting sample input file to JPEG format
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
            // ConversionMode.ConvertToSeparateFiles=>Many to many conversion
            // Convert list of files in inputFiles into a single output file by specifying Conversion mode as ConversionMode.ConvertToSeperateFiles

            docConverter.ConvertToFile(inputFiles, outputFormat, outputPath, "ConvertToJPEG_OneToOne_Multiple", ConversionMode.ConvertToSeperateFiles);

            #endregion

            #region Convert to single file

            //ConversionMode.ConverToSingleFile => Convert all the input files and merge it to a single file
            //Converts list of files in inputFiles into a single output file by specifying Conversion mode as ConversionMode.ConvertToSingleFile

            docConverter.ConvertToFile(inputFiles, outputFormat, outputPath, "ConvertToJPEG_ManyToOne", ConversionMode.ConvertToSingleFile);

            #endregion

            #region Converting file using ConverterSettings

            // Instantiate ConverterSettings
            ConverterSettings cp = new ConverterSettings();

            //Converter Parameter : PageRange
            // 4 different types of page ranges
            // PageRange.All => Converts all pages in input file 
            // PageRange.Even => Converts Pages with even page number 
            // PageRange.Odd => Converts Pages with odd page number
            // PageRange.Custom => Converts set of pages from input file. ** page range should be specified in CustomPageRange
            // Convert all odd pages in input file
            cp.PageRange = PageRange.Odd;

            docConverter.ConvertToFile(inputFile, outputFormat, outputPath, "ConvertToJPEG_WithConverterSettings_Even", ConversionMode.ConvertToSeperateFiles, null, cp);

            // Convert specific pages from input file, say one need to convert 1,3,5,6,7,10 pages from input file
            cp.PageRange = PageRange.Custom;
            cp.CustomPageRange = "1,3,5-7,10"; // **PageRange should be set to PageRange.Custom

            docConverter.ConvertToFile(inputFile, outputFormat, outputPath, "ConvertToJPEG_WithConverterSettings_Custom", ConversionMode.ConvertToSeperateFiles, null, cp);
            #endregion

            #region JPEG encoder formats

            JPEGEncoderSettings jpegEncoderFormats = new JPEGEncoderSettings();

            // Page Scaling
            // 2 modes
            // PageScaling.None
            // PageScalling.UseRenderingResolution
            jpegEncoderFormats.PageScalling = PageScalling.None;

            //Quality level in percentage of the quality of the original file
            jpegEncoderFormats.QualityLevel = 10;

            // Rendering Setting level
            // The compositing mode CompositingMode determines whether pixels from a source image overwrite or are combined with background pixels.
            // 2 compositing modes
            // CompositingMode.SourceOver =>  Specifies that when a color is rendered, it is blended with the background color. The blend is determined by the alpha component of the color being rendered.
            // Compositing.SourceCopy => Specifies that when a color is rendered, it overwrites the background color.
            jpegEncoderFormats.RenderingSettings.Image.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;

            // The composition quality CompositingQuality sets the rendering quality of composited images drawn 
            // 6 compositing quality types
            // CompositingQuality.AssumeLinear => Assume linear values
            // CompositingQuality.Default => Default quality
            // CompositingQuality.GammaCorrected => Use Gamma correction
            // CompositingQuality.HighQuality => High quality low speed compositing
            // CompositingQuality.HighSpeed => High speed low quality compositing
            // CompositingQuality.Invalid => Invalid quality
            jpegEncoderFormats.RenderingSettings.Image.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.Default;

            // The Interpolation mode  sets the interpolation mode associated with this jpeg file
            // 9 Interpolation modes
            // InterpolationMode.Bicubic => Specifies bicubic interpolation. No prefiltering is done.  This mode is not suitable for shrinking an image below 25 percent of its original size.
            // InterpolationMode.Bilinear => Specifies bilinear interpolation. No prefiltering is done. This mode is not suitable for shrinking an image below 50 percent of its original size.
            // InterpolationMode.Default => Specifies default mode.
            // InterpolationMode.High => Specifies high quality interpolation.
            // InterpolationMode.HighQualityBicubic => Specifies high-quality, bicubic interpolation. Prefiltering is performed to ensure high-quality shrinking. This mode produces the highest quality transformed images.
            // InterpolationMode.HighQualityBilinear => Specifies high-quality, bilinear interpolation. Prefiltering is performed to ensure high-quality shrinking.
            // InterpolationMode.Invalid => Equivalent to the Invalid element of the QualityMode enumeration.
            // InterpolationMode.Low => Specifies low quality interpolation.
            // InterpolationMode.NearestNeighbor => Specifies nearest-neighbor interpolation
            jpegEncoderFormats.RenderingSettings.Image.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;

            // The pixel offset mode  sets a value specifying how pixels are offset during rendering of this jpeg file
            // 6 pixel offset modes
            // PixelOffsetMode.Half => Specifies that pixels are offset by -.5 units, both horizontally and vertically, for high speed antialiasing.
            // PixelOffsetMode.Default => Specifies the default mode
            // PixelOffsetMode.None => Specifies no pixel offset
            // PixelOffsetMode.HighQuality => High quality low speed rendering
            // PixelOffsetMode.HighSpeed => High speed low quality rendenring
            // PixelOffsetMode.Invalid => Specifies an invalid mode
            jpegEncoderFormats.RenderingSettings.Image.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Default;

            // The smoothing mode specifies whether lines, curves, and the edges of filled areas use smoothing (also called antialiasing)
            // 6 Line Smoothening modes for line art
            // SmoothingMode.AntiAlias => Specifies antialiased rendering. 
            // SmoothingMode.Default => Specifies no antialiasing. 
            // SmoothingMode.HighQuality => Specifies antialiased rendering. 
            // SmoothingMode.HighSpeed => Specifies no antialiasing. 
            // SmoothingMode.Invalid => Specifies an invalid mode. 
            // SmoothingMode.None => Specifies no antialiasing.
            jpegEncoderFormats.RenderingSettings.LineArt.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;


            //Text Contarst
            jpegEncoderFormats.RenderingSettings.Text.TextContrast = 5;

            // Text Rendering Hint
            // 6 types of text rendering hints
            // TextRenderingHint.SystemDefault => Each character is drawn using its glyph bitmap, with the system default rendering hint. The text will be drawn using whatever font-smoothing settings the user has selected for the system.
            // TextRenderingHint.AntiAlias => Each character is drawn using its antialiased glyph bitmap without hinting. Better quality due to antialiasing. Stem width differences may be noticeable because hinting is turned off.
            // TextRenderingHint.AntiAliasGridFit =>   Each character is drawn using its antialiased glyph bitmap with hinting. Much better quality due to antialiasing, but at a higher performance cost.
            // TextRenderingHint.ClearTypeGridFit => Each character is drawn using its glyph ClearType bitmap with hinting. The highest quality setting. Used to take advantage of ClearType font features.
            // TextRenderingHint.SingleBitPerPixelPerGridFit => Each character is drawn using its glyph bitmap. Hinting is used to improve character appearance on stems and curvature.
            // TextRenderingHint.SingleBitPerPixel => Each character is drawn using its glyph bitmap. Hinting is not used.
            jpegEncoderFormats.RenderingSettings.Text.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;

            // Rendering Settings resolution
            jpegEncoderFormats.RenderingSettings.Resolution.DPI = 96f;
            jpegEncoderFormats.RenderingSettings.Resolution.DpiX = 96f;
            jpegEncoderFormats.RenderingSettings.Resolution.DpiY = 69f;

            // Resolution Mode
            // 3 types of resolution modes
            // ResolutionMode.UseSource => use source resolution
            // ResolutionMode.UseDevice => use device resolution
            // ResolutionMode.UseSpecifiedDPI => use DPI specified in  pngEncoderFormats.RenderingSettings.Resolution.DPI
            jpegEncoderFormats.RenderingSettings.Resolution.ResolutionMode = ResolutionMode.UseSource;

            // Resolution Settings
            jpegEncoderFormats.ResolutionSettings.DPI = 96f;
            jpegEncoderFormats.ResolutionSettings.DpiX = 96f;
            jpegEncoderFormats.ResolutionSettings.DpiY = 96f;

            // 3 types of resolution modes
            // ResolutionMode.UseSource => use source resolution
            // ResolutionMode.UseDevice => use device resolution
            // ResolutionMode.UseSpecifiedDPI => use DPI specified in  pngEncoderFormats.RenderingSettings.Resolution.DPI
            jpegEncoderFormats.ResolutionSettings.ResolutionMode = ResolutionMode.UseSource;

            docConverter.ConvertToFile(inputFile, outputFormat, outputPath, "ConvertToJPEG_WithEncoderSettings", ConversionMode.ConvertToSingleFile, jpegEncoderFormats);

            #endregion
        }

        private static void docConverter_Error(object sender, ConverterErrorEventArgs e)
        {
            Console.WriteLine(e.ErrorMessage);
        }
    }
}
