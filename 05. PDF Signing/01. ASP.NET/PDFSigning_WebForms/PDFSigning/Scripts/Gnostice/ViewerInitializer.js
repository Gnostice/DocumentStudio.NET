/*
* Gnostice Document Studio .NET
* Copyright © Gnostice Information Technologies Private Limited, Bangalore, India
* http://www.gnostice.com
*/
var documentViewer;
$(document).ready(function () {

    var preferences = new gnostice.Preferences();
    
    //Specifies whether the toolbar of the viewer should be displayed.
    preferences.toolbarVisible = true;

    //Specifies whether all the pages of the document should be rendered.
    preferences.lazyLoading = true;

    //Specifies whether the status notification should be shown.
    preferences.showStatusNotifications = true;

    //Specifies whether file operation controls needs to be displayed.
    preferences.visibleFileOperationControls.download = true;
    preferences.visibleFileOperationControls.downloadAs = true;
    preferences.visibleFileOperationControls.open = true;
    preferences.visibleFileOperationControls.print = true;
    preferences.visibleFileOperationControls.save = true;

    //Specifies whether page navigation controls needs to be displayed.
    preferences.visibleNavigationControls.firstPage = true;
    preferences.visibleNavigationControls.gotoPage = true;
    preferences.visibleNavigationControls.lastPage = true;
    preferences.visibleNavigationControls.nextPage = true;
    preferences.visibleNavigationControls.pageIndicator = true;
    preferences.visibleNavigationControls.prevPage = true;

    //Specifies whether page magnification controls needs to be displayed.
    preferences.visibleZoomControls.fixedSteps = true;
    preferences.visibleZoomControls.zoomIn = true;
    preferences.visibleZoomControls.zoomOut = true;

    //Specifies whether page rotation operation controls needs to be displayed.
    preferences.visibleRotationControls.clockwise = true;
    preferences.visibleRotationControls.counterClockwise = true;

    //Specifies whether color inversion controls needs to be displayed.
    preferences.visibleColorInversionControls.allPages = true;

    //Specifies whether signature controls needs to be displayed.
    preferences.visibleSignatureControls.sign = true;

    //Specifies whether full screen control needs to be displayed.
    preferences.visibleFullScreen = true;

    
    // Specifies navigation pane settings for navigation controls.
    preferences.navigationPane.enableBookmarks = true;
    preferences.navigationPane.enableThumbnails = true;
    preferences.navigationPane.visible = true;
    preferences.navigationPane.position = gnostice.NavigationPanePosition.fixed;
    preferences.navigationPane.width = 210;

    //Specifies search operation controls settings.
    preferences.search.enableQuickSearch = true;
    preferences.search.visibleQuickSearchControls = true;
    preferences.search.highlightColor = "yellow";

    // Specifies settings for form fields.
    preferences.interactiveElements.form.highlightColor = "rgba(204, 215, 255, 0.5)";
    preferences.interactiveElements.form.readonlyColor = "rgba(128, 128, 128, 0.5)";
    preferences.interactiveElements.form.focusColor = "rgba(255, 255, 255, 0.8)";
    preferences.interactiveElements.form.listContainerBackgroundColor = "rgba(255, 255, 255, 1)";
    preferences.interactiveElements.form.listItemHoverBackgroundColor = "";
    preferences.interactiveElements.form.allowJavaScriptExecution = true;

    // Specifies settings for annotations.
    preferences.interactiveElements.annotations.commentsPanelDisplayColor = "rgb(255, 245, 245)";
    preferences.interactiveElements.annotations.userFieldDisplayColor = "blue";

    // Specifies settings for signature fields.
    preferences.interactiveElements.signatures.strokeColor = "black";
    preferences.interactiveElements.signatures.strokeWidth = gnostice.StrokeWidth.Default;
    preferences.interactiveElements.signatures.allowSavingUserSignatures = true;
    preferences.interactiveElements.signatures.allowSavingSignatures = true;
    preferences.interactiveElements.signatures.maxNumberOfSavedUserSignatures = 2;
    preferences.interactiveElements.signatures.allowCreatingNewUserSignatures = true;
    preferences.interactiveElements.signatures.allowUploadingNewUserSignatures = true;
    preferences.interactiveElements.signatures.allowDeletingUserSignatures = true;
    preferences.interactiveElements.signatures.maxNumberOfSignaturesAllowedPerPage = -1;
    preferences.interactiveElements.signatures.maxNumberOfSignaturesAllowedPerDocument = -1;
    preferences.interactiveElements.signatures.showSavePrompt = true;


    // Specifies initial view settings with which document when loaded needs to be displayed.
    preferences.initialView.zoomValue = gnostice.ZoomMode.actualSize;
    preferences.initialView.rotationAngle = gnostice.RotationAngle.zero;
    preferences.initialView.colorInversionApplied = false;
    preferences.initialView.navigationPaneOpened = true;

    // Specifies hyperlink access settings.
    preferences.security.hyperlinkNavigation.access = gnostice.HyperlinkAccess.alwaysAsk;
    preferences.security.password.enablePasswordDialog = true;
    preferences.security.password.maxNumberOfPasswordRetries = 3;

    // Specifies UI language selection settings.
    preferences.localization.language = "en_US";
    preferences.localization.resourcePath = "Scripts/localization/";

    documentViewer = new gnostice.DocumentViewer('doc-viewer-id', preferences);
});
