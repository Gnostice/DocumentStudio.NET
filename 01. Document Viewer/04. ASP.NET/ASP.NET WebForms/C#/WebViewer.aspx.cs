using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Gnostice.Controls.ASP;

namespace ASP.NET_DocumentViewer
{
    public partial class WebViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String sDocID, sDocPath;
            ViewerController vc = new ViewerController();
            sDocPath = Server.MapPath(".") + "\\App_Data\\sampleFormDocument.pdf";
            sDocID = vc.LoadDocument(sDocPath);
            Page.ClientScript.RegisterHiddenField("hidden_document_field_id", sDocID);
        }
    }
}