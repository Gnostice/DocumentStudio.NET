Imports System.IO
Imports Gnostice.Controls.ASP

Public Class DocumentEventHandler
    Inherits ServerEventsHandler

    Public Overrides Sub OnServerStart(serverStartEventArgs As OnServerStartEventArgs)
        'Document viewer preferences.

        'Digitization preferences 
        serverStartEventArgs.ViewerPreferences.Digitization.Enabled = True
        serverStartEventArgs.ViewerPreferences.Digitization.RecognizeLanguages = "eng"

        'File operation preferences
        serverStartEventArgs.ViewerPreferences.FileOperations.AllowUpload = True
        serverStartEventArgs.ViewerPreferences.FileOperations.AllowSave = True
        serverStartEventArgs.ViewerPreferences.FileOperations.AllowPrinting = True
        serverStartEventArgs.ViewerPreferences.FileOperations.AllowDownloadAs = True
        serverStartEventArgs.ViewerPreferences.FileOperations.AllowDownload = True

        'Interactive preferences
        serverStartEventArgs.ViewerPreferences.Interactivity.AllowAnnotations = True
        serverStartEventArgs.ViewerPreferences.Interactivity.AllowFormFilling = True

        'Rendering preferences
        serverStartEventArgs.ViewerPreferences.Rendering.PrintingDPI = 120
        serverStartEventArgs.ViewerPreferences.Rendering.ViewingDPI = 100

        'User force full permissions
        serverStartEventArgs.ViewerPreferences.Security.ForceFullUserPermissions = False

    End Sub

    Public Overrides Sub BeforeDocumentLoad(documentLoadEventArgs As BeforeDocumentLoadEventArgs)
        'get loaded document identification 
    End Sub

    Public Overrides Sub NeedUsername(usernameEventArgs As NeedUsernameEventArgs)
        'set document viewer user name 
        usernameEventArgs.UserName = "Anonymous"
    End Sub

    Public Overrides Sub AfterDocumentSave(documentSaveEventArgs As AfterDocumentSaveEventArgs)
        'You can uncomment following code to save saved document to server. 

        'Dim fileName As String = HttpContext.Current.Server.MapPath("~\\App_Data\\") + "savedDocument.pdf"
        'Dim fileStream As FileStream = New FileStream(fileName, FileMode.OpenOrCreate)
        'documentSaveEventArgs.DocStream.CopyTo(fileStream)
        'fileStream.Dispose()

    End Sub
End Class
