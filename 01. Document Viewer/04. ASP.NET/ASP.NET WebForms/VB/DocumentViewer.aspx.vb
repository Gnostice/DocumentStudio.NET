Imports Gnostice.Controls.ASP

Public Class DocumentViewer
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim appLicenseKey As String = ConfigurationManager.AppSettings("LicenseKey")

        'Gnostice.Documents.Framework.ActivateLicense(appLicenseKey)

        Dim vc As ViewerController = New ViewerController()

        Dim docPath As String = Server.MapPath("~\\App_Data\\") + "html5documentviewerarticle.pdf"

        Dim docURI As String = vc.LoadDocument(docPath)

        Page.ClientScript.RegisterHiddenField("hidden_document_field_id", docURI)

    End Sub

End Class