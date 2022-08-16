using System;
using System.Web.UI;

namespace del_PDFSignDemo
{
    public partial class Viewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Gnostice.Controls.ASP.ViewerController viewerController = new Gnostice.Controls.ASP.ViewerController();
            // Load the file present under App_Data folder
            string filenameWithPath = System.IO.Path.Combine(Server.MapPath("."), "App_Data", "Agreement.pdf");
            string documentUri = viewerController.LoadDocument(filenameWithPath);
            Page.ClientScript.RegisterHiddenField("hidden_document_field_uri", documentUri);
        }
    }
}