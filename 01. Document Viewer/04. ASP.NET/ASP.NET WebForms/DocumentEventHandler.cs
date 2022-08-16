using Gnostice.Controls.ASP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTML5_DocumentViewer
{
    public class DocumentEventHandler : ServerEventsHandler
    {
        public override void AfterDocumentSave(AfterDocumentSaveEventArgs documentSaveEventArgs)
        {
            //You can uncomment following code to save saved document to server. 
            //string filePath = HttpContext.Current.Server.MapPath("~\\App_Data\\") + "savedDocument.pdf";
            //FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate);
            //documentSaveEventArgs.DocStream.CopyTo(stream);
            //stream.Dispose();
        }

        public override void BeforeDocumentLoad(BeforeDocumentLoadEventArgs documentLoadEventArgs)
        {
            // Here you can access document's unique identification.


        }

        public override void NeedUsername(NeedUsernameEventArgs userNameEventArgs)
        {
            //Set user identification for document viewer.
            userNameEventArgs.UserName = "Anonymous";
        }

        public override void OnServerStart(OnServerStartEventArgs serverEventArgs)
        {
            //Set document viewer preferences.

            /* Digitization preferences */
            serverEventArgs.ViewerPreferences.Digitization.Enabled = true;
            serverEventArgs.ViewerPreferences.Digitization.RecognizeLanguages = "eng";

            /* File operation preferences */
            serverEventArgs.ViewerPreferences.FileOperations.AllowUpload = true;
            serverEventArgs.ViewerPreferences.FileOperations.AllowSave = true;
            serverEventArgs.ViewerPreferences.FileOperations.AllowPrinting = true;
            serverEventArgs.ViewerPreferences.FileOperations.AllowDownloadAs = true;
            serverEventArgs.ViewerPreferences.FileOperations.AllowDownload = true;

            /* Interactive preferences */
            serverEventArgs.ViewerPreferences.Interactivity.AllowAnnotations = true;
            serverEventArgs.ViewerPreferences.Interactivity.AllowFormFilling = true;

            /* Rendering preferences */
            serverEventArgs.ViewerPreferences.Rendering.PrintingDPI = 120;
            serverEventArgs.ViewerPreferences.Rendering.ViewingDPI = 100;

            /* User force full permissions */
            serverEventArgs.ViewerPreferences.Security.ForceFullUserPermissions = false;
        }
    }
}