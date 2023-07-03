using Gnostice.Controls.ASP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_Razor_CS_Document_Viewer
{
    public class DocumentEventHandler : ServerEventsHandler
    {
        public override void AfterDocumentSave(AfterDocumentSaveEventArgs documentSaveEventArgs)
        {
            //You can uncomment following code to save saved document to server. 
            //string filePath = documentSaveEventArgs.HttpContext.Server.MapPath("~\\App_Data\\") + "tempsavedDocument.pdf";
            //FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate);
            //documentSaveEventArgs.DocStream.Position = 0;
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