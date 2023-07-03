<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebViewer.aspx.cs" Inherits="ASP.NET_DocumentViewer.WebViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Gnostice ASP.NET document viewer demo application</title>

     <!--demo stylesheet-->
    <link href="Content/Stylesheet/Demo-Stylesheet.css" rel="stylesheet" />

   
    <link href="CSS/jquery-ui.css" rel="stylesheet" />

    <link href="Content/gnostice/all.min.css" rel="stylesheet" />
    <link href="Content/gnostice/solid.min.css" rel="stylesheet" />
    <link href="Content/gnostice/documentviewer.css" rel="stylesheet" />

    <script src="Scripts/jquery-2.0.0.min.js"></script>
    <script src="Scripts/jquery-ui-1.13.2.min.js"></script>
    
    <script src="Scripts/gnostice/documentviewer.min.js"></script>

     <script type="text/javascript">
	 
	    var documentViewer = null;
        $(document).ready(function () {
            documentViewer = new gnostice.DocumentViewer("doc-viewer-id");
            if (document.getElementById('hidden_document_field_id') != null) {
                 documentViewer.loadDocument(
                     document.getElementById('hidden_document_field_id').value);
             }
        });
        
    </script>
    

</head>
<body>
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
                        <h2 class="article-header">ASP.NET Document Viewer Control</h2>
                        <div class="gnostice-doc-viewer-container" id="doc-viewer-id">
                        </div>
                    </div>
                </div>
            </div>
            <hr />
            <div>
                &copy; 2002 - 2021. Gnostice Information Technologies Private Limited. All Rights
            Reserved.
            </div>
        </div>
    </div>
    </form>
</body>
</html>
