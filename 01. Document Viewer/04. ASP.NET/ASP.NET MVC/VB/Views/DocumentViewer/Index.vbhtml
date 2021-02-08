
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <title>Gnostice ASP.NET Document Viewer demo application</title>
    <meta name="viewport" content="width=device-width" />

    <link href="~/Content/Stylesheet/Demo-Stylesheet.css" rel="stylesheet" />

    <link href="~/CSS/default.theme.css" rel="stylesheet" />
    <link href="~/CSS/documentviewer.css" rel="stylesheet" />
    <link href="~/CSS/jquery-ui.css" rel="stylesheet" />

    
    <script src="~/Scripts/jquery-1.11.0.min.js"></script>
    <script src="~/Scripts/jquery-ui.min.js"></script>

    <script src="~/Scripts/documentviewer.min.js"></script>
    <script src="~/Scripts/ViewerInitializer.js"></script>
    <script type="text/javascript">
        var documentViewer = null;
        function displayServerDocumentInViewer() {
            documentViewer.loadDocument('@ViewBag.documentURI');
        }
    </script>
</head>
<body onload="displayServerDocumentInViewer()">
    <div class="centerBodyContent">
        <div>
            <div class="gnostice-header">
                <img src="Content/Images/gnostice.png" />
                <span style="float:right;font-size:35px;color:#428bca;">
                    ASP.NET Document Viewer Demo
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
            <hr/>
            <div>
                &copy; 2002 - 2019. Gnostice Information Technologies Private Limited. All Rights
                Reserved.
            </div>
        </div>
    </div>
</body>
</html>
