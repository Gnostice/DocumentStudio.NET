using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gnostice.Documents;
using System.IO;
using System.IO.Packaging;
using System.Configuration;
using Gnostice.Converter;
using Gnostice.Documents.Image;
using Gnostice.Core;
using Gnostice.Documents.PDF;

namespace ASP.NET_MVC_Razor_CS_Document_Converter.Controllers
{
    public class ConverterController : Controller
    {
        //
        // GET: /Converter/

        private string errorMessage = string.Empty;

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string convert)
        {
            List<string> inputFiles = new List<string>();
            HttpFileCollectionBase hfc = Request.Files;
            for (int i = 0; i < hfc.Count; i++)
            {
                HttpPostedFileBase hpf = hfc[i];
                if (hpf.ContentLength > 0)
                {
                    hpf.SaveAs(Server.MapPath("~/App_DAta/") + System.IO.Path.GetFileName(hpf.FileName));
                    inputFiles.Add(Server.MapPath("~/App_DAta/") + System.IO.Path.GetFileName(hpf.FileName));
                }
            }
            string cmbOutputFormat = Request.Params["cmbOutputFormat"];
            
			string licenseKey = ConfigurationManager.AppSettings["LicenseKey"];
			
			DocumentConverter docConvtr = new DocumentConverter();
			
			// Setting option in converter to have OCR done or not; AllImages = OCR ON, Off = OCR Off
            docConvtr.Preferences.DigitizerSettings.DigitizationMode =
                Gnostice.Core.DigitizationEngine.DigitizationMode.AllImages;

            docConvtr.Error += docConvtr_Error;
            //bool merge = false;
            ConversionMode conversionMode = ConversionMode.ConvertToSeperateFiles;
            Random rndm = new Random();
            string ZipFileName = rndm.Next().ToString();
            EncoderSettings EncoderSettings = null;
            string outputFormat = cmbOutputFormat;
            if (outputFormat.CompareTo("TIFF Multipage") == 0)
            {
                outputFormat = "TIFF";
                EncoderSettings = new TIFFEncoderSettings();
                (EncoderSettings as TIFFEncoderSettings).MultiPage = true;
            }
            bool portfolio = false;
            try
            {
                if (Request.Params["chkCreatePortfolio"] != null)
                    portfolio = true;
            }
            catch
            {
                portfolio = false;
            }
            string tempConversionMode = Request.Params["cmbConversionMode"];
            switch (tempConversionMode)
            {
                case "Convert To Single File":
                    conversionMode = ConversionMode.ConvertToSingleFile;
                    break;
                case "Convert To Seperate Files":
                    conversionMode = ConversionMode.ConvertToSeperateFiles;
                    break;
                case "Convert First File And Attach Rest As Original":
                    conversionMode = ConversionMode.ConvertFirstFileAndAttachRestAsOriginal;
                    if (cmbOutputFormat == "PDF" && portfolio)
                    {
                        EncoderSettings = new PDFEncoderSettings();
                        (EncoderSettings as PDFEncoderSettings).PDFPortfolioSettings.PortfolioCreationMode = PortfolioCreationMode.OnlyWhenAttachmentsExist;
                    }
                    break;
                case "Create New File And Attach All As Original":
                    conversionMode = ConversionMode.CreateNewFileAndAttachAllAsOriginal;
                    if (cmbOutputFormat == "PDF" && portfolio)
                    {
                        EncoderSettings = new PDFEncoderSettings();
                        (EncoderSettings as PDFEncoderSettings).PDFPortfolioSettings.PortfolioCreationMode = PortfolioCreationMode.Always;
                    }
                    break;
            }
            try
            {
                //List<string> outputList = docConvtr.ConvertToFile(inputFiles, outputFormat, Server.MapPath("~/App_Data/"), Request.Params["txtBaseFileName"], merge, null, EncoderSettings);
                List<string> outputList = docConvtr.ConvertToFile(inputFiles, outputFormat, Server.MapPath("~/App_Data/Temp/"), Request.Params["txtBaseFileName"], conversionMode, EncoderSettings);
                foreach (string OutputFile in outputList)
                    AddFileToZip(Server.MapPath("~/Converted/") + ZipFileName + ".zip", OutputFile);

                if (errorMessage != string.Empty)
                    errorMessage = "Conversion Completed..!!" + "\n\n" + errorMessage;
                else
                    errorMessage = "Conversion Completed..!!";
                ViewBag.Message = errorMessage;
                ViewBag.URL = "Converted/" + ZipFileName + ".zip";
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
            }
            return View();
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

        void docConvtr_Error(object sender, ConverterErrorEventArgs e)
        {
            errorMessage += e.ErrorMessage;
        }
    }
}
