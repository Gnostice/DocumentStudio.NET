Imports System.Web.Mvc
Imports Gnostice.Controls.ASP

Public Class DocumentViewerController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult

        Dim vc As ViewerController = New ViewerController()

        Dim docPath As String = Server.MapPath("~\\App_Data\\") + "html5documentviewerarticle.pdf"

        Dim docURI As String = vc.LoadDocument(docPath)

        ViewBag.documentURI = docURI

        Return View()
    End Function

End Class
