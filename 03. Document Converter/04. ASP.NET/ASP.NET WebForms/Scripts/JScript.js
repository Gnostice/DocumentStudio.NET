function EnableOrDisable() {
    var ddlInputFiles = document.getElementById("MainContent_ddlInputFiles");
    var btnRemove = document.getElementById("MainContent_btnRemove");
    var btnUp = document.getElementById("MainContent_btnUp");
    var btnDown = document.getElementById("MainContent_btnDown");
    //var btnConvert = document.getElementById("MainContent_btnConvert");
    if (ddlInputFiles.length == 0) {
        btnRemove.disabled = true;
        btnUp.disabled = true;
        btnDown.disabled = true;
        //btnConvert.disabled = true;
        return;
    }
    else {
        btnRemove.disabled = false;
        btnUp.disabled = false;
        btnDown.disabled = false;
        //btnConvert.disabled = false;
    }
    if (ddlInputFiles.selectedIndex == 0)
        btnUp.disabled = true;
    else if (ddlInputFiles.selectedIndex == ddlInputFiles.length - 1)
        btnDown.disabled = true;
    else {
        btnUp.disabled = false;
        btnDown.disabled = false;
    }
}