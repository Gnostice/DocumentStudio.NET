using Gnostice.Controls.ASP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCore_MVC_Document_Viewer
{
    public class DocumentViewerServerEventHandler : ServerEventsHandler
    {
        public override void AfterDocumentSave(AfterDocumentSaveEventArgs documentSaveEventArgs)
        {

        }

        public override void BeforeDocumentLoad(BeforeDocumentLoadEventArgs documentLoadEventArgs)
        {
            // Here you can access document's unique identification.


        }

        public override void NeedUserSignatures(NeedUserSignaturesEventArgs needUserSignaturesEventArgs)
        {
            
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
            serverEventArgs.ViewerPreferences.FileOperations.AllowDownload = false;

            /* Interactive preferences */
            serverEventArgs.ViewerPreferences.Interactivity.AllowAnnotations = true;
            serverEventArgs.ViewerPreferences.Interactivity.AllowFormFilling = true;
            serverEventArgs.ViewerPreferences.Interactivity.AllowSigning = true;

            /* Rendering preferences */
            serverEventArgs.ViewerPreferences.Rendering.PrintingDPI = 120;
            serverEventArgs.ViewerPreferences.Rendering.ViewingDPI = 160;


            /* User force full permissions */
            serverEventArgs.ViewerPreferences.Security.ForceFullUserPermissions = false;
        }
    }
}
