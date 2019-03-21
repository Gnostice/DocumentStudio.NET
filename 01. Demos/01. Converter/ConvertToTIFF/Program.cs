using Gnostice.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace ConvertToTIFF
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

            // List of files as input for the document Converter
            List<string> inputFiles = Directory.GetFiles(inputPath).ToList();

            // Output Format
            string outputFormat = "tiff";

            // Single input file
            string inputFile = inputPath + "input.docx";

            // Single output file
            string outputFile = outputPath + "output." + outputFormat;

            #region Simple Conversion

            // Converting sample input file to TIFF format
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

            docConverter.ConvertToFile(inputFiles, outputFormat, outputPath, "ConvertToTIFF_OneToOne_Multiple", ConversionMode.ConvertToSeperateFiles);

            #endregion

            #region Convert to single file

            //ConversionMode.ConverToSingleFile => Convert all the input files and merge it to a single file
            //Converts list of files in inputFiles into a single output file by specifying Conversion mode as ConversionMode.ConvertToSingleFile

            docConverter.ConvertToFile(inputFiles, outputFormat, outputPath, "ConvertToTIFF_ManyToOne", ConversionMode.ConvertToSingleFile);

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
            // Convert all odd pages in input file
            cp.PageRange = PageRange.Odd;

            docConverter.ConvertToFile(inputFile, outputFormat, outputPath, "ConvertToTIFF_WithConverterSettings_Even", ConversionMode.ConvertToSeperateFiles, null, cp);

            // Convert specific pages from input file, say one need to convert 1,3,5,6,7,10 pages from input file
            cp.PageRange = PageRange.Custom;
            cp.CustomPageRange = "1,3,5-7,10"; // **PageRange should be set to PageRange.Custom

            docConverter.ConvertToFile(inputFile, outputFormat, outputPath, "ConvertToTIFF_WithConverterSettings_Custom", ConversionMode.ConvertToSeperateFiles, null, cp);
            #endregion

            #region TIFF Encoder settings

            // TIFF encoder formats
            TIFFEncoderSettings tiffEncoderFormats = new TIFFEncoderSettings();

            // Compression Type
            // 4 types
            // TiffCompressionType.None => No Compression
            // TiffCompressionType.CCIT3 => Group 3 compression
            // TiffCompressionType.CCIT4 => Group 4 compression
            // TiffCompressionType.Rle => Run length compression
            // TiffCompressionType.Lzw => Lempel–Ziv–Welch lossless data compression
            tiffEncoderFormats.CompressionType = TiffCompressionType.None;


            // Page Scaling
            // 2 types of page scaling
            // PageScaling.None => No page scaling
            // PageScalling.UseRenderingResolution => scaling to the rendering resolution
            tiffEncoderFormats.PageScalling = PageScalling.None;

            // Rendering Settings

            // The compositing mode CompositingMode determines whether pixels from a source image overwrite or are combined with background pixels.
            // 2 compositing modes
            // System.Drawing.Drawing2D.CompositingMode.SourceOver =>  Specifies that when a color is rendered, it is blended with the background color. The blend is determined by the alpha component of the color being rendered.
            // System.Drawing.Drawing2d.Compositing.SourceCopy => Specifies that when a color is rendered, it overwrites the background color.

            tiffEncoderFormats.RenderingSettings.Image.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;

            //The composition quality CompositingQuality sets the rendering quality of composited images drawn 
            // 6 compositing quality types
            // CompositingQuality.AssumeLinear => Assume linear values
            // CompositingQuality.Default => Default quality
            // CompositingQuality.GammaCorrected => Use Gamma correction
            // CompositingQuality.HighQuality => High quality low speed compositing
            // CompositingQuality.HighSpeed => High speed low quality compositing
            // CompositingQuality.Invalid => Invalid quality
            tiffEncoderFormats.RenderingSettings.Image.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.Default;

            // The Interpolation mode  sets the interpolation mode associated with this image
            // 9 Interpolation modes
            // InterpolationMode.Bicubic => Specifies bicubic interpolation. No prefiltering is done. This mode is not suitable for shrinking an image below 25 percent of its original size.
            // InterpolationMode.Bilinear => Specifies bilinear interpolation. No prefiltering is done. This mode is not suitable for shrinking an image below 50 percent of its original size.
            // InterpolationMode.Default => Specifies default mode.
            // InterpolationMode.High => Specifies high quality interpolation.
            // InterpolationMode.HighQualityBicubic => Specifies high-quality, bicubic interpolation. Prefiltering is performed to ensure high-quality shrinking. This mode produces the highest quality transformed images.
            // InterpolationMode.HighQualityBilinear => Specifies high-quality, bilinear interpolation. Prefiltering is performed to ensure high-quality shrinking.
            // InterpolationMode.Invalid => Equivalent to the Invalid element of the QualityMode enumeration.
            // InterpolationMode.Low => Specifies low quality interpolation.
            // InterpolationMode.NearestNeighbor => Specifies nearest-neighbor interpolation.
            tiffEncoderFormats.RenderingSettings.Image.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;

            // The pixel offset mode  sets a value specifying how pixels are offset during rendering of this image
            // 6 pixel offset modes
            // PixelOffsetMode.Half => Specifies that pixels are offset by -.5 units, both horizontally and vertically, for high speed antialiasing.
            // PixelOffsetMode.Default => Specifies the default mode
            // PixelOffsetMode.None => Specifies no pixel offset
            // PixelOffsetMode.HighQuality => High quality low speed rendering
            // PixelOffsetMode.HighSpeed => High speed low quality rendenring
            // PixelOffsetMode.Invalid => Specifies an invalid mode
            tiffEncoderFormats.RenderingSettings.Image.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Default;

            // The smoothing mode specifies whether lines, curves, and the edges of filled areas use smoothing (also called antialiasing)
            // 6 Line Smoothening modes for line art
            // System.Drawing.Drawing2D.SmoothingMode.AntiAlias => Specifies antialiased rendering. 
            // System.Drawing.Drawing2D.SmoothingMode.Default => Specifies no antialiasing.
            // System.Drawing.Drawing2D.SmoothingMode.HighQuality => Specifies antialiased rendering. 
            // System.Drawing.Drawing2D.SmoothingMode.HighSpeed => Specifies no antialiasing. 
            // System.Drawing.Drawing2D.SmoothingMode.Invalid => Specifies an invalid mode. 
            // System.Drawing.Drawing2D.SmoothingMode.None => Specifies no antialiasing. 
            tiffEncoderFormats.RenderingSettings.LineArt.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;


            // Text Contarst
            tiffEncoderFormats.RenderingSettings.Text.TextContrast = 5;

            // Text Rendering Hint
            // 6 types of text rendering hints
            // System.Drawing.Text.TextRenderingHint.SystemDefault => Each character is drawn using its glyph bitmap, with the system default rendering hint. The text will be drawn using whatever font-smoothing settings the user has selected for the system.
            // System.Drawing.Text.TextRenderingHint.AntiAlias => Each character is drawn using its antialiased glyph bitmap without hinting. Better quality due to antialiasing. Stem width differences may be noticeable because hinting is turned off.
            // System.Drawing.Text.TextRenderingHint.AntiAliasGridFit =>   Each character is drawn using its antialiased glyph bitmap with hinting. Much better quality due to antialiasing, but at a higher performance cost.
            // System.Drawing.Text.TextRenderingHint.ClearTypeGridFit => Each character is drawn using its glyph ClearType bitmap with hinting. The highest quality setting. Used to take advantage of ClearType font features.
            // System.Drawing.Text.TextRenderingHint.SingleBitPerPixelPerGridFit => Each character is drawn using its glyph bitmap. Hinting is used to improve character appearance on stems and curvature.
            // System.Drawing.Text.TextRenderingHint.SingleBitPerPixel => Each character is drawn using its glyph bitmap. Hinting is not used.
            tiffEncoderFormats.RenderingSettings.Text.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;

            // Rendering Settings resolution
            tiffEncoderFormats.RenderingSettings.Resolution.DPI = 96f;
            tiffEncoderFormats.RenderingSettings.Resolution.DpiX = 96f;
            tiffEncoderFormats.RenderingSettings.Resolution.DpiY = 96f;

            // Resolution Mode 
            // 3 types of resolution modes
            // ResolutionMode.UseSource => use source resolution
            // ResolutionMode.UseDevice => use device resolution
            // ResolutionMode.UseSpecifiedDPI => use DPI specified in  pngEncoderFormats.RenderingSettings.Resolution.DPI
            tiffEncoderFormats.RenderingSettings.Resolution.ResolutionMode = ResolutionMode.UseSource;

            // Resolution Settings resolution
            tiffEncoderFormats.ResolutionSettings.DPI = 96f;
            tiffEncoderFormats.ResolutionSettings.DpiX = 96f;
            tiffEncoderFormats.ResolutionSettings.DpiY = 96f;

            // Resolution Settings Resolution Mode
            // 3 types of resolution modes
            // ResolutionMode.UseSource => use source resolution
            // ResolutionMode.UseDevice => use device resolution
            // ResolutionMode.UseSpecifiedDPI => use DPI specified in  pngEncoderFormats.RenderingSettings.Resolution.DPI
            tiffEncoderFormats.ResolutionSettings.ResolutionMode = ResolutionMode.UseSource;

            // Multipage TIFF conversion 
            // MultiPage => convert and combine each page in a multipage file into a single file 

            tiffEncoderFormats.MultiPage = true;

            docConverter.ConvertToFile(inputFile, outputFormat, outputPath, "ConvertToTIFF_WithEncoderSettings_into_MultiPageTIFFFile", ConversionMode.ConvertToSeperateFiles, tiffEncoderFormats);
            
            //Singlepage TIFF conversion
            //Converts a file containing multiple pages into separate files for each page

            tiffEncoderFormats.MultiPage = false;

            docConverter.ConvertToFile(inputFile, outputFormat, outputPath, "ConvertToTIFF_WithEncoderSettings_into_SinglePageTIFFFile", ConversionMode.ConvertToSeperateFiles, tiffEncoderFormats);
            
            #endregion

        }

        private static void docConverter_Error(object sender, ConverterErrorEventArgs e)
        {
            Console.WriteLine(e.ErrorMessage);
        }

    }
}
