<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Viewer.aspx.cs" Inherits="del_PDFSignDemo.Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <script src="Scripts/Gnostice/jquery-1.11.0.min.js"></script>
    <script src="Scripts/Gnostice/jquery-ui.min.js"></script>
    <script src="Scripts/Gnostice/documentviewer.min.js"></script>
    <script src="Scripts/Gnostice/ViewerInitializer.js"></script>

    <link href="Content/Gnostice/jquery-ui.css" rel="stylesheet" />
    <link href="Content/Gnostice/documentviewer.css" rel="stylesheet" />
    <link href="Content/Gnostice/all.min.css" rel="stylesheet" />
    <link href="Content/Gnostice/solid.min.css" rel="stylesheet" />

    <script type="text/javascript">
    function displayServerDocumentInViewer() {
        var uriField = document.getElementById("hidden_document_field_uri");
        if (uriField != null) {
            // Load the server-side document through its URI using the client-side "documentViewer" object
            documentViewer.loadDocument(uriField.value);

            var signPlaceholder = {
                id: "my_sign1",
                required: true,
                pageNumber: 1,
                position: {
                    mode: gnostice.SignaturePositionMode.pageAbsolute,
                    absolutePosition: { x: 150, y: 400 }
                },
                size: { width: 150, height: 60 },
                allowUserResizing: false,
                style: { color: "blue", width: gnostice.StrokeWidth.Medium },
                includeSignerName: true,
                includeDateTime: true,
                dateTimeFormat: "0:MM/dd/yy H:mm:ss zzz"
            };
            documentViewer.Signatures.addPlaceholder(signPlaceholder);
        }
    }
    </script>
</head>
<body onload="displayServerDocumentInViewer()">
    <form id="form1" runat="server">
        <div id="doc-viewer-id" style="width: 100%; height: 800px;"></div>
    </form>
</body>
</html>
