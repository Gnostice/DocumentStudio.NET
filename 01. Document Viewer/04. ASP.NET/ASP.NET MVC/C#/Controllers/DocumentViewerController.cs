using Gnostice.Controls.ASP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Razor_CS_Document_Viewer.Controllers
{
    public class DocumentViewerController : Controller
    {
        //
        // GET: /DocumentViewer/
        public ActionResult Index()
        {
            string documentpath = Server.MapPath(".") + "\\App_Data\\sampleFormDocument.pdf";
            ViewerController vc = new ViewerController();
            string documentURI=vc.LoadDocument(documentpath);
            ViewBag.docURI = documentURI;
            return View();
        }

    }
}
