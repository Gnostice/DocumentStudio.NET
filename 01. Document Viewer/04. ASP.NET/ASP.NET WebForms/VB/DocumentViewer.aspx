<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="DocumentViewer.aspx.vb" Inherits="ASP.NETWebFormsVBHTML5DocumentViewer.csproj.DocumentViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="Content/Stylesheet/Demo-Stylesheet.css" rel="stylesheet" />

    <link href="CSS/default.theme.css" rel="stylesheet" />
    <link href="CSS/documentviewer.css" rel="stylesheet" />
    <link href="CSS/jquery-ui.css" rel="stylesheet" />


    <script src="Script/jquery-1.11.0.min.js"></script>
    <script src="Script/jquery-ui.min.js"></script>
    <script src="Script/documentviewer.min.js"></script>
    <script src="Script/ViewerInitializer.js"></script>

    <script type="text/javascript">
        var documentViewer = null;
        function displayServerDocumentInViewer() {
            if (document.getElementById('hidden_document_field_id') != null) {
                if (documentViewer != null) {
                    documentViewer.loadDocument(
                        document.getElementById('hidden_document_field_id').value);
                }
            }
        }
    </script>

</head>
<body onload="displayServerDocumentInViewer();">
    <form id="form1" runat="server">
     <div class="centerBodyContent">
        <div>
            <div class="gnostice-header">
                        <img src="Content/Images/gnostice.png" />
                        <span style="float:right;font-size:35px;color:#428bca;">ASP.NET Document Viewer Demo
                        </span>
            </div>
            <div>
                <br />

                <div class="body">
                    <div class="article-container">
                        <div class="gnostice-doc-viewer-container" id="doc-viewer-id">
                        </div>
                    </div>
                </div>
            </div>
            <hr />
            <div>
                &copy; 2002 - 2019. Gnostice Information Technologies Private Limited. All Rights
            Reserved.
            </div>
        </div>
    </div>
    </form>
</body>
</html>
