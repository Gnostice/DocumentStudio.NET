/*
* Gnostice Document Studio .NET
* Copyright © Gnostice Information Technologies Private Limited, Bangalore, India
* http://www.gnostice.com
*/
/// <reference path="../typings/jquery/jquery.d.ts"/>
var gnostice;
(function (gnostice) {
    var UIEvents = (function () {
        function UIEvents() {
        }
        UIEvents.click = function (domObj, callback, viewerManager) {
            if (domObj != null) {
                $(domObj).on("click", viewerManager, callback);
            }
        };
        UIEvents.change = function (domObj, callback, viewerManager) {
            if (domObj != null) {
                $(domObj).on("change", viewerManager, callback);
            }
        };
        UIEvents.scroll = function (domObj, callback, viewerManager) {
            if (domObj != null) {
                $(domObj).on("scroll", viewerManager, callback);
            }
        };
        return UIEvents;
    })();
    gnostice.UIEvents = UIEvents;
})(gnostice || (gnostice = {}));
var gnostice;
(function (gnostice) {
    var ViewerDOM = (function () {
        function ViewerDOM(viewer, viewableArea, openDoc, printBtn, downloadBtn, firstPage, prevPage, nextPage, lastPage, uploader, pageIndicator, zoomIn, zoomOut, zoomDropdown, rotatePagesClockwise, rotatePagesCounterClockwise, invertBtn) {
            this.viewer = viewer;
            this.viewableArea = viewableArea;
            this.openDoc = openDoc;
            this.printBtn = printBtn;
            this.downloadBtn = downloadBtn;
            this.firstPage = firstPage;
            this.prevPage = prevPage;
            this.nextPage = nextPage;
            this.lastPage = lastPage;
            this.uploader = uploader;
            this.pageIndicator = pageIndicator;
            this.zoomIn = zoomIn;
            this.zoomOut = zoomOut;
            this.zoomDropdown = zoomDropdown;
            this.rotatePagesClockwise = rotatePagesClockwise;
            this.rotatePagesCounterClockwise = rotatePagesCounterClockwise;
            this.invertBtn = invertBtn;
        }
        return ViewerDOM;
    })();
    gnostice.ViewerDOM = ViewerDOM;
})(gnostice || (gnostice = {}));
/// <reference path="../typings/jquery/jquery.d.ts"/>
var gnostice;
(function (gnostice) {
    var ServerCom = (function () {
        function ServerCom() {
        }
        ServerCom.uploadDocument = function (file, documentUri, successCallback, errorCallback) {
            var data = new FormData();
            var files = file;
            // Add the uploaded image content to the form data collection
            if (files.length > 0) {
                data.append("uploadDocument", files[0]);
            }
            $.ajax({
                url: documentUri + "/docs",
                type: 'POST',
                data: data,
                cache: false,
                dataType: 'json',
                processData: false,
                contentType: false,
                success: successCallback,
                error: errorCallback
            });
        };
        ServerCom.getDocInfo = function (documentUri, successCallback, errorCallback) {
            console.log(documentUri);
            $.ajax({
                type: "GET",
                url: documentUri + "/info",
                contentType: "json",
                success: successCallback,
                error: errorCallback
            });
        };
        ServerCom.getPage = function (documentUri, pageNumber, successCallback, errorCallback) {
            $.ajax({
                type: "GET",
                url: documentUri + "/pages/" + pageNumber,
                contentType: "json",
                success: successCallback,
                error: errorCallback
            });
        };
        return ServerCom;
    })();
    gnostice.ServerCom = ServerCom;
})(gnostice || (gnostice = {}));
/// <reference path="../typings/jquery/jquery.d.ts"/>
/// <reference path="../typings/jquery.scrollto/jquery.scrollto.d.ts" />
var gnostice;
(function (gnostice) {
    var Page = (function () {
        function Page(image, width, height) {
            this.image = image;
            this.width = width;
            this.height = height;
        }
        return Page;
    })();
    var log = (function () {
        function log() {
        }
        log.enable = false;
        return log;
    })();
    gnostice.log = log;
    (function (RENDERINGSTATE) {
        RENDERINGSTATE[RENDERINGSTATE["BLANK"] = 0] = "BLANK";
        RENDERINGSTATE[RENDERINGSTATE["RUNNING"] = 1] = "RUNNING";
        RENDERINGSTATE[RENDERINGSTATE["FINISHED"] = 2] = "FINISHED";
    })(gnostice.RENDERINGSTATE || (gnostice.RENDERINGSTATE = {}));
    var RENDERINGSTATE = gnostice.RENDERINGSTATE;
    ;
    var ZOOMVALUE = (function () {
        function ZOOMVALUE() {
        }
        ZOOMVALUE.ZOOM25 = 25;
        ZOOMVALUE.ZOOM50 = 50;
        ZOOMVALUE.ZOOM100 = 100;
        ZOOMVALUE.ZOOM150 = 150;
        ZOOMVALUE.ZOOM200 = 200;
        ZOOMVALUE.ZOOMACTUALSIZE = 100;
        ZOOMVALUE.ZOOMPAGESIZE = 100;
        ZOOMVALUE.ZOOMPAGEWIDTH = 1001;
        return ZOOMVALUE;
    })();
    ;
    var ViewerManager = (function () {
        function ViewerManager(viewerDOM, handlerUri) {
            this.pageCount = 0;
            this.currentPage = 0;
            this.pageRenderingState = new Array();
            this.zoomSteps = new Array();
            this.zoomText = "25%";
            this.zoomfactor = 1;
            this.pages = new Array();
            this.rotationAngle = 0;
            this.viewingInverted = false;
            this.initialPageHeight = 842;
            this.initialPageWidth = 595;
            this.maxPageWidth = 0;
            this.maxPageHeight = 0;
            this.documentLoaded = false;
            this.applyRotationTransform = function (_this, ctx, h, w) {
                switch (_this.rotationAngle) {
                    case 0:
                        ctx.translate(0, 0);
                        break;
                    case 90:
                        ctx.translate(w, 0);
                        break;
                    case 180:
                        ctx.translate(w, h);
                        break;
                    case 270:
                        ctx.translate(0, h);
                        break;
                    case 360:
                        ctx.translate(0, 0);
                        break;
                }
                return ctx;
            };
            this.getZoomText = function (_this, zoomvalue) {
                var zoomText = null;
                switch (zoomvalue) {
                    case ZOOMVALUE.ZOOM25:
                        zoomText = "25%";
                        break;
                    case ZOOMVALUE.ZOOM50:
                        zoomText = "50%";
                        break;
                    case ZOOMVALUE.ZOOM100:
                        zoomText = "100%";
                        break;
                    case ZOOMVALUE.ZOOM150:
                        zoomText = "150%";
                        break;
                    case ZOOMVALUE.ZOOM200:
                        zoomText = "200%";
                        break;
                    case ZOOMVALUE.ZOOMPAGEWIDTH:
                        zoomText = "Fit Width";
                        break;
                    case ZOOMVALUE.ZOOMACTUALSIZE:
                        zoomText = "Actual Size";
                        break;
                    case ZOOMVALUE.ZOOMPAGESIZE:
                        zoomText = "Fit Height";
                        break;
                }
                return zoomText;
            };
            var _this = this;
            this.handlerUri = handlerUri;
            this.viewerDOM = viewerDOM;
            this.zoomValue = ZOOMVALUE.ZOOM100;
            if (viewerDOM != null) {
                gnostice.UIEvents.click(viewerDOM.openDoc, function () {
                    $(viewerDOM.uploader).click();
                });
                gnostice.UIEvents.click(viewerDOM.printBtn, this.onPrintBtnClick, _this);
                gnostice.UIEvents.click(viewerDOM.downloadBtn, this.onDownloadBtnClick, _this);
                $(window).resize(function () {
                    if (_this.documentLoaded) {
                        _this.updateZoomSteps(_this);
                        _this.reFlowDocument(_this);
                    }
                });
                gnostice.UIEvents.click(viewerDOM.firstPage, this.onFirstPageClick, _this);
                gnostice.UIEvents.click(viewerDOM.lastPage, this.onLastPageClick, _this);
                gnostice.UIEvents.click(viewerDOM.prevPage, this.onPrevPageClick, _this);
                gnostice.UIEvents.click(viewerDOM.nextPage, this.onNextPageClick, _this);
                gnostice.UIEvents.click(viewerDOM.zoomIn, this.onZoomInClick, _this);
                gnostice.UIEvents.click(viewerDOM.zoomOut, this.onZoomOutClick, _this);
                gnostice.UIEvents.scroll(viewerDOM.viewableArea, this.onScrollCallback, _this);
                gnostice.UIEvents.change(viewerDOM.uploader, function () {
                    console.log("Onchange File Upload event fired");
                    var files = viewerDOM.uploader.files;
                    var f = files[0];
                    if (f == undefined) {
                    }
                    else {
                        _this.uploadDocument(files, viewerDOM, _this);
                        $(viewerDOM.uploader).val('');
                    }
                });
                gnostice.UIEvents.change(viewerDOM.zoomDropdown, this.onZoomDropdownChange, _this);
                gnostice.UIEvents.click(viewerDOM.rotatePagesClockwise, this.onRotateClockwiseClick, _this);
                gnostice.UIEvents.click(viewerDOM.rotatePagesCounterClockwise, this.onRotateCounterClockwiseClick, _this);
                gnostice.UIEvents.click(viewerDOM.invertBtn, this.onInvertPagesBtnClick, _this);
                _this.setCurrentPage(0, _this);
            }
        }
        ;
        ViewerManager.prototype.uploadDocument = function (file, viewerDOM, _this) {
            gnostice.ServerCom.uploadDocument(file, this.handlerUri, function (responseData) {
                console.log("Success!!!");
                if (responseData.oprStatusCode == 0) {
                    _this.documentid = responseData.id;
                    _this.documentUri = _this.handlerUri + "/docs/" + responseData.id;
                    _this.loadDocument(_this);
                }
            }, null);
        };
        ViewerManager.prototype.resetViewerSettings = function (_this) {
            $(_this.viewerDOM.viewableArea).html("");
            _this.pageCount = 0;
            _this.currentPage = 0;
            _this.pages.length = 0;
            _this.nextPageNumber = 0;
            _this.prevPageNumber = 0;
            _this.flipBoudaryPageOrder = false;
            _this.boundaryPagesReady = false;
            _this.documentRenderingCompleted = false;
            _this.maxPageWidth = 0;
            _this.maxPageHeight = 0;
            _this.documentLoaded = false;
        };
        ViewerManager.prototype.generateGuid = function () {
            function s4() {
                return Math.floor((1 + Math.random()) * 0x10000)
                    .toString(16)
                    .substring(1);
            }
            return function () {
                return s4() + s4() + '-' + s4() + '-' + s4() + '-' +
                    s4() + '-' + s4() + s4() + s4();
            };
        };
        ViewerManager.prototype.loadDocument = function (_this) {
            _this.resetViewerSettings(_this);
            gnostice.ServerCom.getDocInfo(this.documentUri, function (data) {
                console.log("Success!!!");
                _this.pageCount = parseInt(data.pageCount);
                var mimetype = data.pageCount;
                _this.setCurrentPage(1, _this);
                for (var i = 1; i <= _this.pageCount; i += 1) {
                    _this.createPage(i, _this);
                }
                _this.requestServerAndRenderPage(1, _this);
                _this.documentLoaded = true;
            }, null);
        };
        ViewerManager.prototype.loadDoc = function (documenturi, successCallback, errorCallback) {
        };
        ViewerManager.prototype.openDocument = function () {
        };
        ViewerManager.prototype.closeDocument = function (documentUri) {
        };
        ViewerManager.prototype.uploadDocumentFromBuffer = function (base64string) {
        };
        ViewerManager.prototype.download = function () {
        };
        ViewerManager.prototype.downloadAs = function (mimetype) {
        };
        ViewerManager.prototype.print = function () {
        };
        ViewerManager.prototype.firstPage = function () {
            this.scrolToPage(this, 1);
        };
        ViewerManager.prototype.prevPage = function () {
            this.scrolToPage(this, this.getPrevPageNumber(this));
        };
        ViewerManager.prototype.nextPage = function () {
            this.scrolToPage(this, this.getNextPageNumber(this));
        };
        ViewerManager.prototype.lastPage = function () {
            this.scrolToPage(this, this.pageCount);
        };
        ViewerManager.prototype.zoomIn = function () {
        };
        ViewerManager.prototype.zoomOut = function () {
        };
        //zoom(value: Number) {
        //}
        ViewerManager.prototype.rotatePagesClockwise = function () {
        };
        ViewerManager.prototype.rotatePagesCounterClockwise = function () {
        };
        ViewerManager.prototype.invertColors = function (applyInversion) {
        };
        ViewerManager.prototype.gotoPage = function (pageNumber) {
        };
        // scales the canvas by (float) scale < 1
        // returns a new canvas containing the scaled image.
        ViewerManager.prototype.downScaleCanvas = function (cv, scale, pagenumber, _this) {
            if (!(scale < 1) || !(scale > 0))
                throw ('scale must be a positive number <1 ');
            var sqScale = scale * scale; // square scale = area of source pixel within target
            var sw = cv.width; // source image width
            var sh = cv.height; // source image height
            var tw = Math.floor(sw * scale); // target image width
            var th = Math.floor(sh * scale); // target image height
            var sx = 0, sy = 0, sIndex = 0; // source x,y, index within source array
            var tx = 0, ty = 0, yIndex = 0, tIndex = 0; // target x,y, x,y index within target array
            var tX = 0, tY = 0; // rounded tx, ty
            var w = 0, nw = 0, wx = 0, nwx = 0, wy = 0, nwy = 0; // weight / next weight x / y
            // weight is weight of current source point within target.
            // next weight is weight of current source point within next target's point.
            var crossX = false; // does scaled px cross its current px right border ?
            var crossY = false; // does scaled px cross its current px bottom border ?
            var sBuffer = cv.getContext('2d').
                getImageData(0, 0, sw, sh).data; // source buffer 8 bit rgba
            var tBuffer = new Float32Array(3 * tw * th); // target buffer Float32 rgb
            var sR = 0, sG = 0, sB = 0; // source's current point r,g,b
            /* untested !
            var sA = 0;  //source alpha  */
            for (sy = 0; sy < sh; sy++) {
                ty = sy * scale; // y src position within target
                tY = 0 | ty; // rounded : target pixel's y
                yIndex = 3 * tY * tw; // line index within target array
                crossY = (tY != (0 | ty + scale));
                if (crossY) {
                    wy = (tY + 1 - ty); // weight of point within target pixel
                    nwy = (ty + scale - tY - 1); // ... within y+1 target pixel
                }
                for (sx = 0; sx < sw; sx++, sIndex += 4) {
                    tx = sx * scale; // x src position within target
                    tX = 0 | tx; // rounded : target pixel's x
                    tIndex = yIndex + tX * 3; // target pixel index within target array
                    crossX = (tX != (0 | tx + scale));
                    if (crossX) {
                        wx = (tX + 1 - tx); // weight of point within target pixel
                        nwx = (tx + scale - tX - 1); // ... within x+1 target pixel
                    }
                    sR = sBuffer[sIndex]; // retrieving r,g,b for curr src px.
                    sG = sBuffer[sIndex + 1];
                    sB = sBuffer[sIndex + 2];
                    /* !! untested : handling alpha !!
                       sA = sBuffer[sIndex + 3];
                       if (!sA) continue;
                       if (sA != 0xFF) {
                           sR = (sR * sA) >> 8;  // or use /256 instead ??
                           sG = (sG * sA) >> 8;
                           sB = (sB * sA) >> 8;
                       }
                    */
                    if (!crossX && !crossY) {
                        // just add components weighted by squared scale.
                        tBuffer[tIndex] += sR * sqScale;
                        tBuffer[tIndex + 1] += sG * sqScale;
                        tBuffer[tIndex + 2] += sB * sqScale;
                    }
                    else if (crossX && !crossY) {
                        w = wx * scale;
                        // add weighted component for current px
                        tBuffer[tIndex] += sR * w;
                        tBuffer[tIndex + 1] += sG * w;
                        tBuffer[tIndex + 2] += sB * w;
                        // add weighted component for next (tX+1) px                
                        nw = nwx * scale;
                        tBuffer[tIndex + 3] += sR * nw;
                        tBuffer[tIndex + 4] += sG * nw;
                        tBuffer[tIndex + 5] += sB * nw;
                    }
                    else if (crossY && !crossX) {
                        w = wy * scale;
                        // add weighted component for current px
                        tBuffer[tIndex] += sR * w;
                        tBuffer[tIndex + 1] += sG * w;
                        tBuffer[tIndex + 2] += sB * w;
                        // add weighted component for next (tY+1) px                
                        nw = nwy * scale;
                        tBuffer[tIndex + 3 * tw] += sR * nw;
                        tBuffer[tIndex + 3 * tw + 1] += sG * nw;
                        tBuffer[tIndex + 3 * tw + 2] += sB * nw;
                    }
                    else {
                        // add weighted component for current px
                        w = wx * wy;
                        tBuffer[tIndex] += sR * w;
                        tBuffer[tIndex + 1] += sG * w;
                        tBuffer[tIndex + 2] += sB * w;
                        // for tX + 1; tY px
                        nw = nwx * wy;
                        tBuffer[tIndex + 3] += sR * nw;
                        tBuffer[tIndex + 4] += sG * nw;
                        tBuffer[tIndex + 5] += sB * nw;
                        // for tX ; tY + 1 px
                        nw = wx * nwy;
                        tBuffer[tIndex + 3 * tw] += sR * nw;
                        tBuffer[tIndex + 3 * tw + 1] += sG * nw;
                        tBuffer[tIndex + 3 * tw + 2] += sB * nw;
                        // for tX + 1 ; tY +1 px
                        nw = nwx * nwy;
                        tBuffer[tIndex + 3 * tw + 3] += sR * nw;
                        tBuffer[tIndex + 3 * tw + 4] += sG * nw;
                        tBuffer[tIndex + 3 * tw + 5] += sB * nw;
                    }
                } // end for sx 
            } // end for sy
            // create result canvas
            var resCV = document.getElementById("#" + _this.documentid + "_canvas_" + pagenumber);
            resCV.width = tw;
            resCV.height = th;
            var resCtx = resCV.getContext('2d');
            var imgRes = resCtx.getImageData(0, 0, tw, th);
            var tByteBuffer = imgRes.data;
            // convert float32 array into a UInt8Clamped Array
            var pxIndex = 0; //  
            for (sIndex = 0, tIndex = 0; pxIndex < tw * th; sIndex += 3, tIndex += 4, pxIndex++) {
                tByteBuffer[tIndex] = Math.ceil(tBuffer[sIndex]);
                tByteBuffer[tIndex + 1] = Math.ceil(tBuffer[sIndex + 1]);
                tByteBuffer[tIndex + 2] = Math.ceil(tBuffer[sIndex + 2]);
                tByteBuffer[tIndex + 3] = 255;
            }
            // writing result to canvas.
            resCtx.putImageData(imgRes, 0, 0);
            return resCV;
        };
        ViewerManager.prototype.createPage = function (pagenumber, _this) {
            var canvas;
            var domPage;
            var uniqueId;
            var styles = "style";
            var styleval = "";
            if (this.documentid == null) {
                uniqueId = _this.generateGuid();
                this.documentid = (uniqueId);
            }
            else {
                uniqueId = this.documentid;
            }
            domPage = document.createElement('div');
            domPage.id = uniqueId + pagenumber;
            domPage.className = 'git-docviewer-page';
            $(domPage).addClass("git-docviewer-page-drag");
            $(domPage).css({ "background-color": "#FFF", "border-color": "transparent", "position": "relative", "display": "block", "margin-bottom": "10px", "padding": "0px", "width": "700px", "height": "800px" });
            if (_this.rotationAngle == 0 || _this.rotationAngle == 180) {
                $(domPage).height((_this.initialPageHeight * _this.zoomfactor).toFixed());
                $(domPage).width((_this.initialPageWidth * _this.zoomfactor).toFixed());
            }
            else {
                $(domPage).width((_this.initialPageHeight * _this.zoomfactor).toFixed());
                $(domPage).height((_this.initialPageWidth * _this.zoomfactor).toFixed());
            }
            $(_this.viewerDOM.viewableArea).append(domPage);
            _this.pageRenderingState[pagenumber] = RENDERINGSTATE.BLANK;
        };
        ViewerManager.prototype.requestServerAndRenderPage = function (pagenumber, _this) {
            _this.pageRenderingState[pagenumber] = RENDERINGSTATE.RUNNING;
            var prevPageCount = _this.pageCount;
            gnostice.ServerCom.getPage(this.documentUri, pagenumber, function (data) {
                if (data.oprStatusCode == 0) {
                    var updatezoom = false;
                    if (_this.maxPageWidth < data.width) {
                        _this.maxPageWidth = data.width;
                        updatezoom = true;
                    }
                    if (_this.maxPageHeight < data.height) {
                        _this.maxPageHeight = data.height;
                        updatezoom = true;
                    }
                    if (updatezoom) {
                        _this.updateZoomSteps(_this);
                    }
                    _this.documentRenderingCompleted = data.renderingComplete;
                    if (data.renderingComplete == false) {
                        for (var i = prevPageCount + 1; i <= data.loadedPageCount; i += 1) {
                            _this.createPage(i, _this);
                        }
                        _this.pageCount = data.loadedPageCount;
                        _this.updatePageNavButtonState(_this);
                    }
                    var docuId = _this.documentid;
                    var container = $("#" + docuId + pagenumber);
                    var c = document.getElementById(docuId + '_canvas_' + pagenumber);
                    if (c == null) {
                        c = document.createElement('canvas');
                        c.height = data.height;
                        c.width = data.width;
                        c.id = docuId + '_canvas_' + pagenumber;
                        $(container).append(c);
                    }
                    else {
                        c.width = data.width;
                        c.height = data.height;
                    }
                    var w = c.width, h = c.height;
                    if (_this.rotationAngle == 0 || _this.rotationAngle == 180) {
                        var prevHt = $(container).height();
                        $(container).height((data.height * _this.zoomfactor).toFixed());
                        $(container).width((data.width * _this.zoomfactor).toFixed());
                        var curHt = $(container).height();
                        if (parseInt(container[0].offsetTop, 10) < parseInt($(_this.viewerDOM.viewableArea).scrollTop().toString(), 10)) {
                            if (((curHt - prevHt) != 0) && ($(_this.viewerDOM.viewableArea).scrollTop() > 0)) {
                                $(_this.viewerDOM.viewableArea).scrollTop($(_this.viewerDOM.viewableArea).scrollTop() + curHt - prevHt);
                            }
                        }
                    }
                    else {
                        var prevHt = $(container).height();
                        $(container).width((data.height * _this.zoomfactor).toFixed());
                        $(container).height((data.width * _this.zoomfactor).toFixed());
                        var temp = c.height;
                        c.height = c.width;
                        c.width = temp;
                        var curHt = $(container).height();
                        if (parseInt(container[0].offsetTop, 10) < parseInt($(_this.viewerDOM.viewableArea).scrollTop().toString(), 10)) {
                            if (((curHt - prevHt) != 0) && ($(_this.viewerDOM.viewableArea).scrollTop() > 0)) {
                                $(_this.viewerDOM.viewableArea).scrollTop($(_this.viewerDOM.viewableArea).scrollTop() + curHt - prevHt);
                            }
                        }
                    }
                    var w = c.width, h = c.height;
                    var ctx = c.getContext("2d");
                    //  ctx.save();
                    //ctx.scale(_this.zoomfactor, _this.zoomfactor);
                    var img = new Image();
                    img.onload = function (pageObj) {
                        ctx.drawImage(img, 0, 0, w, h);
                        // ctx.scale(_this.zoomfactor, _this.zoomfactor);
                        _this.downScaleCanvas(c, _this.zoomfactor, pagenumber, _this);
                    };
                    img.src = "data:image/png;base64," + data.image;
                    if (_this.pages[pagenumber] == null) {
                        var page = new Page(img, data.width, data.height);
                        _this.pages[pagenumber] = page;
                        _this.pageRenderingState[pagenumber] = RENDERINGSTATE.FINISHED;
                        _this.PrioritizeAndRenderPages(_this);
                    }
                }
            }, null);
        };
        ViewerManager.prototype.isPageRendered = function (pagenumber, _this) {
            var isrendered = false;
            if (_this.pageRenderingState[pagenumber] != RENDERINGSTATE.BLANK) {
                isrendered = true;
            }
            return isrendered;
        };
        ViewerManager.prototype.PrioritizeAndRenderPages = function (_this) {
            var pagenumber = null;
            if (!_this.isPageRendered(_this.currentPage, _this)) {
                pagenumber = _this.currentPage;
            }
            else if (!_this.isPageRendered(_this.nextPageNumber, _this)) {
                pagenumber = _this.nextPageNumber;
            }
            else if (!_this.isPageRendered(_this.prevPageNumber, _this)) {
                pagenumber = _this.prevPageNumber;
            }
            else if (!_this.isPageRendered(_this.pageCount, _this)) {
                pagenumber = _this.pageCount;
            }
            else {
                if (!_this.boundaryPagesReady) {
                    if (_this.flipBoudaryPageOrder) {
                        for (var i = 1; i <= 5; i += 1) {
                            if (!_this.isPageRendered(i, _this)) {
                                pagenumber = i;
                                break;
                            }
                        }
                    }
                    else {
                        for (var j = _this.pageCount - 1; j >= (_this.pageCount - 5); j -= 1) {
                            if (!_this.isPageRendered(j, _this)) {
                                pagenumber = j;
                                break;
                            }
                        }
                    }
                    _this.flipBoudaryPageOrder = _this.flipBoudaryPageOrder == true ? false : true;
                }
                if (pagenumber == null) {
                    _this.boundaryPagesReady = true;
                }
            }
            if (pagenumber != null) {
                _this.requestServerAndRenderPage(pagenumber, _this);
            }
        };
        ViewerManager.prototype.zoomTo = function (value, _this) {
            if (value >= 1 && value <= 300) {
                _this.zoom("custom", value, _this);
            }
        };
        ViewerManager.prototype.rotateClockwise = function (_this) {
            _this.rotate(true, _this);
        };
        ViewerManager.prototype.rotateCounterClockwise = function (_this) {
            _this.rotate(false, _this);
        };
        ViewerManager.prototype.rotate = function (isClockwise, _this) {
            var angle = _this.rotationAngle;
            var ang = 0;
            if (!isClockwise) {
                ang = angle - 90;
                if (ang < 0) {
                    ang = ang + 360;
                }
            }
            else {
                ang = angle + 90;
                if (ang >= 360) {
                    ang = ang - 360;
                }
            }
            _this.rotationAngle = ang;
            _this.reFlowDocument(_this);
        };
        ViewerManager.prototype.zoom = function (action, zoomvalue, _this) {
            var cp = _this.currentPage;
            var prevzoom = _this.zoomValue;
            _this.zoomText = _this.getZoomText(_this, prevzoom);
            switch (action) {
                case "out":
                    if (_this.zoomValue != _this.zoomSteps[0]) {
                        for (var i = _this.zoomSteps.length - 1; i >= 0; i--) {
                            if (_this.zoomValue > _this.zoomSteps[i]) {
                                _this.zoomValue = _this.zoomSteps[i];
                                break;
                            }
                        }
                    }
                    break;
                case "in":
                    if (_this.zoomValue != _this.zoomSteps[_this.zoomSteps.length - 1]) {
                        for (var i = 0; i <= _this.zoomSteps.length - 1; i++) {
                            if (_this.zoomValue < _this.zoomSteps[i]) {
                                _this.zoomValue = _this.zoomSteps[i];
                                break;
                            }
                        }
                    }
                    break;
                case "predefined":
                    _this.zoomValue = zoomvalue;
                    break;
                case "custom":
                    _this.zoomValue = zoomvalue;
                    break;
            }
            /*$(_this.viewerDOM.zoominSelect).val(_this.zoomType);*/
            _this.zoomfactor = _this.getZoomfactor(_this);
            _this.zoomPages(_this);
            _this.zoomText = _this.getZoomText(_this, _this.zoomValue);
            /*_this.scrollTo(obj, cp, 0, 0);*/
            /*obj._events.afterZoomChange(_this.zoomType);*/
        };
        ViewerManager.prototype.updateZoomSteps = function (_this) {
            var viewableAreaWidth = $(_this.viewerDOM.viewableArea).width() - _this.getDivScrollBarWidth();
            var viewableAreaHeight = $(_this.viewerDOM.viewableArea).height();
            ZOOMVALUE.ZOOMPAGESIZE = parseFloat(((viewableAreaHeight / _this.maxPageHeight) * 100).toFixed(2));
            ZOOMVALUE.ZOOMPAGEWIDTH = parseFloat(((viewableAreaWidth / _this.maxPageWidth) * 100).toFixed(2));
            _this.prepareZoomSteps(_this);
            _this.zoomValue = _this.getZoomValue(_this.zoomText, _this);
            _this.zoomfactor = _this.getZoomfactor(_this);
        };
        ViewerManager.prototype.getDivScrollBarWidth = function () {
            var scrollDiv = document.createElement("div");
            $(scrollDiv).css({ "width": "100px", "height": "100px", "overflow": "scroll", "position": "absolute", "top": "-9999px" });
            document.body.appendChild(scrollDiv);
            // Get the scrollbar width
            var scrollbarWidth = scrollDiv.offsetWidth - scrollDiv.clientWidth + 6;
            // Delete the DIV 
            document.body.removeChild(scrollDiv);
            return scrollbarWidth;
        };
        ViewerManager.prototype.getZoomfactor = function (_this) {
            return _this.zoomValue / 100;
        };
        ViewerManager.prototype.prepareZoomSteps = function (_this) {
            _this.zoomSteps[0] = ZOOMVALUE.ZOOM25;
            _this.zoomSteps[1] = ZOOMVALUE.ZOOM50;
            _this.zoomSteps[2] = ZOOMVALUE.ZOOM100;
            _this.zoomSteps[3] = ZOOMVALUE.ZOOM150;
            _this.zoomSteps[4] = ZOOMVALUE.ZOOM200;
            _this.zoomSteps[5] = ZOOMVALUE.ZOOMPAGESIZE;
            _this.zoomSteps[6] = ZOOMVALUE.ZOOMPAGEWIDTH;
            _this.zoomSteps.sort();
            var list = [];
            _this.zoomSteps = _this.zoomSteps.sort(function (a, b) {
                return a - b;
            });
        };
        ViewerManager.prototype.zoomPages = function (_this) {
            var zoomfactor = _this.zoomfactor;
            var uniqueId = _this.documentid;
            _this.reFlowDocument(_this);
        };
        ViewerManager.prototype.invertPages = function (_this) {
            _this.viewingInverted = !_this.viewingInverted;
            _this.reFlowDocument(_this);
        };
        ViewerManager.prototype.reFlowDocument = function (_this) {
            //var progressValue = _this.getProgressValueFromPageCount(_this.pageCount);
            //console.log(progressValue);
            var zoomfactor = _this.zoomfactor;
            var uniqueId = _this.documentid;
            for (var i = 1; i <= _this.pageCount; i += 1) {
                var container = $("#" + uniqueId + i);
                var c = document.getElementById(uniqueId + '_canvas_' + i);
                if (c != null) {
                    var ctx = c.getContext("2d");
                    ctx.restore();
                    ctx.scale(_this.zoomfactor, _this.zoomfactor);
                    if (_this.pageRenderingState[i] == RENDERINGSTATE.FINISHED) {
                        var imges = _this.pages[i].image;
                        if (imges != null) {
                            zoomfactor = _this.zoomfactor;
                            c.height = _this.pages[i].height * zoomfactor;
                            c.width = _this.pages[i].width * zoomfactor;
                            var w = c.width, h = c.height;
                            if (_this.rotationAngle == 90 || _this.rotationAngle == 270) {
                                var temp = c.height;
                                c.height = c.width;
                                c.width = temp;
                            }
                            ctx = _this.applyRotationTransform(_this, ctx, c.height, c.width);
                            ctx.rotate(_this.getRadianAngle(_this.rotationAngle));
                            if (imges != null) {
                                ctx.drawImage(imges, 0, 0);
                                if (_this.viewingInverted) {
                                    _this.convertCanvasImageToInvertedImage(imges, ctx, c.width, c.height);
                                }
                            }
                        }
                    }
                    else {
                        if (i == 1) {
                            var img = _this.pages[i].image;
                            if (img != null) {
                                zoomfactor = _this.zoomfactor;
                                c.height = _this.pages[i].height * zoomfactor;
                                c.width = _this.pages[i].width * zoomfactor;
                                var w = c.width, h = c.height;
                                if (_this.rotationAngle == 90 || _this.rotationAngle == 270) {
                                    var temp = c.height;
                                    c.height = c.width;
                                    c.width = temp;
                                }
                                ctx = _this.applyRotationTransform(_this, ctx, c.height, c.width);
                                ctx.rotate(_this.getRadianAngle(_this.rotationAngle));
                                if (img != null) {
                                    ctx.drawImage(img, 0, 0);
                                    ctx.closePath();
                                    if (_this.viewingInverted) {
                                        _this.convertCanvasImageToInvertedImage(img, ctx, c.width, c.height);
                                    }
                                }
                            }
                        }
                    }
                }
                if (_this.pages[i] != null) {
                    if (_this.rotationAngle == 0 || _this.rotationAngle == 180) {
                        $(container).height(_this.pages[i].height * zoomfactor);
                    }
                    else {
                        $(container).width(_this.pages[i].height * zoomfactor);
                    }
                }
                else {
                    if (_this.rotationAngle == 0 || _this.rotationAngle == 180) {
                        $(container).height(_this.initialPageHeight * zoomfactor);
                    }
                    else {
                        $(container).width(_this.initialPageHeight * zoomfactor);
                    }
                }
                if (_this.pages[i] != null) {
                    if (_this.rotationAngle == 0 || _this.rotationAngle == 180) {
                        $(container).width(_this.pages[i].width * zoomfactor);
                    }
                    else {
                        $(container).height(_this.pages[i].width * zoomfactor);
                    }
                }
                else {
                    if (_this.rotationAngle == 0 || _this.rotationAngle == 180) {
                        $(container).width(_this.initialPageWidth * zoomfactor);
                    }
                    else {
                        $(container).height(_this.initialPageWidth * zoomfactor);
                    }
                }
            }
        };
        ViewerManager.prototype.convertCanvasImageToInvertedImage = function (imageObj, context, w, h) {
            var x = 0;
            var y = 0;
            var imageData = context.getImageData(x, y, w, h);
            var data = imageData.data;
            for (var i = 0; i < data.length; i += 4) {
                // red
                data[i] = 255 - data[i];
                // green
                data[i + 1] = 255 - data[i + 1];
                // blue
                data[i + 2] = 255 - data[i + 2];
            }
            // overwrite original image
            context.putImageData(imageData, x, y);
        };
        ViewerManager.prototype.getRadianAngle = function (degreeValue) {
            return degreeValue * Math.PI / 180;
        };
        ViewerManager.prototype.getZoomValue = function (selectedText, _this) {
            var newzoomvalue = null;
            switch (selectedText) {
                case "25%":
                    newzoomvalue = ZOOMVALUE.ZOOM25;
                    break;
                case "50%":
                    newzoomvalue = ZOOMVALUE.ZOOM50;
                    break;
                case "100%":
                    newzoomvalue = ZOOMVALUE.ZOOM100;
                    break;
                case "150%":
                    newzoomvalue = ZOOMVALUE.ZOOM150;
                    break;
                case "200%":
                    newzoomvalue = ZOOMVALUE.ZOOM200;
                    break;
                case "Actual Size":
                    newzoomvalue = ZOOMVALUE.ZOOMACTUALSIZE;
                    break;
                case "Fit Height":
                    newzoomvalue = ZOOMVALUE.ZOOMPAGESIZE;
                    break;
                case "Fit Width":
                    newzoomvalue = ZOOMVALUE.ZOOMPAGEWIDTH;
                    break;
            }
            return newzoomvalue;
        };
        ViewerManager.prototype.getCurrentPage = function (_this) {
            var bodyheight;
            var viewableArea = _this.viewerDOM.viewableArea;
            var uniqueId = _this.documentid;
            bodyheight = $(viewableArea).outerHeight(true);
            var scrollPosition = Number(viewableArea.scrollTop);
            scrollPosition += Number(bodyheight) / 2;
            var i = 1, height = 0;
            for (i = 1; i <= Number(this.pageCount); i++) {
                height = Number(height) + $("#" + uniqueId + i).outerHeight(true);
                if (Number(height) >= Number(scrollPosition)) {
                    break;
                }
            }
            return i;
        };
        ViewerManager.prototype.getPrevPageNumber = function (_this) {
            if (_this.currentPage > 1) {
                return _this.currentPage - 1;
            }
            return 1;
        };
        ViewerManager.prototype.getNextPageNumber = function (_this) {
            if (_this.currentPage < _this.pageCount) {
                return _this.currentPage + 1;
            }
            return _this.pageCount;
        };
        ViewerManager.prototype.setCurrentPage = function (pageNumber, _this) {
            if (_this.currentPage != pageNumber) {
                _this.currentPage = pageNumber;
                _this.updatePageNavButtonState(_this);
            }
        };
        ViewerManager.prototype.updatePageNavButtonState = function (_this) {
            $(_this.viewerDOM.pageIndicator).width(_this.textWidth(_this.currentPage + " / " + _this.pageCount, '18px arial'));
            $(_this.viewerDOM.pageIndicator).val(_this.currentPage + " / " + _this.pageCount);
        };
        ViewerManager.prototype.textWidth = function (text, font) {
            return 25;
        };
        ViewerManager.prototype.onScrollCallback = function (event) {
            if (log.enable) {
                console.log("Logging algorithm is working fine");
            }
            console.log("onScrollCallBack: Entering");
            if (event.data != null) {
                console.log("onScrollCallBack: event.data " + event.data);
                var _this = event.data;
                var newpagenumber = _this.getCurrentPage(_this);
                console.log("onScrollCallBack: newpagenumber = " + newpagenumber);
                if (Number(_this.currentPage) != Number(newpagenumber)) {
                    _this.setCurrentPage(newpagenumber, _this);
                }
            }
        };
        ViewerManager.prototype.onPrintBtnClick = function (event) {
            if (event.data != null) {
                var _this = event.data;
            }
        };
        ViewerManager.prototype.onDownloadBtnClick = function (event) {
            if (event.data != null) {
                var _this = event.data;
                var url = _this.documentUri + "/download";
                var iframe = document.getElementById("hiddenDownloader");
                if (iframe === null) {
                    iframe = document.createElement('iframe');
                    iframe.id = "hiddenDownloader";
                    iframe.style.display = 'none';
                    document.body.appendChild(iframe);
                }
                iframe.src = url;
                iframe.onload = function () {
                    this.parentNode.removeChild(this);
                };
            }
        };
        ViewerManager.prototype.onInvertPagesBtnClick = function (event) {
            if (event.data != null) {
                var _this = event.data;
                _this.invertPages(_this);
            }
        };
        ViewerManager.prototype.onRotateClockwiseClick = function (event) {
            if (event.data != null) {
                var _this = event.data;
                _this.rotate(true, _this);
            }
        };
        ViewerManager.prototype.onRotateCounterClockwiseClick = function (event) {
            if (event.data != null) {
                var _this = event.data;
                _this.rotate(false, _this);
            }
        };
        ViewerManager.prototype.onZoomDropdownChange = function (event) {
            if (event.data != null) {
                var _this = event.data;
                var newzoomVal = null;
                var selectedText = $(_this.viewerDOM.zoomDropdown).children("option").filter(":selected").text();
                newzoomVal = _this.getZoomValue(selectedText, _this);
                _this.zoom("predefined", newzoomVal, _this);
            }
        };
        ViewerManager.prototype.onFirstPageClick = function (event) {
            if (event.data != null) {
                var _this = event.data;
                _this.scrolToPage(_this, 1);
            }
        };
        ViewerManager.prototype.onPrevPageClick = function (event) {
            if (event.data != null) {
                var _this = event.data;
                _this.scrolToPage(_this, _this.getPrevPageNumber(_this));
            }
        };
        ViewerManager.prototype.onNextPageClick = function (event) {
            if (event.data != null) {
                var _this = event.data;
                _this.scrolToPage(_this, _this.getNextPageNumber(_this));
            }
        };
        ViewerManager.prototype.onZoomInClick = function (event) {
            if (event.data != null) {
                var _this = event.data;
                _this.zoom("in", null, _this);
            }
        };
        ViewerManager.prototype.onZoomOutClick = function (event) {
            if (event.data != null) {
                var _this = event.data;
                _this.zoom("out", null, _this);
            }
        };
        ViewerManager.prototype.onLastPageClick = function (event) {
            if (event.data != null) {
                var _this = event.data;
                if (_this.currentPage < _this.pageCount) {
                    _this.scrolToPage(_this, _this.pageCount);
                }
            }
        };
        ViewerManager.prototype.gotoCallback = function (pageNumber) {
        };
        ViewerManager.prototype.scrolToPage = function (_this, targetPageNumber) {
            var afterCallback = function () {
                _this.setCurrentPage(targetPageNumber, _this);
            };
            var settings = { easing: "swing", onAfter: afterCallback };
            var target = '#' + _this.documentid + targetPageNumber;
            $(_this.viewerDOM.viewableArea).scrollTo(target, settings);
        };
        return ViewerManager;
    })();
    gnostice.ViewerManager = ViewerManager;
})(gnostice || (gnostice = {}));
var gnostice;
(function (gnostice) {
    var Events = (function () {
        function Events() {
        }
        return Events;
    })();
    gnostice.Events = Events;
})(gnostice || (gnostice = {}));
var gnostice;
(function (gnostice) {
    var VisibleNavigationControls = (function () {
        function VisibleNavigationControls() {
            this.firstPage = true;
            this.prevPage = true;
            this.nextPage = true;
            this.lastPage = true;
            this.pageIndicator = true;
            this.gotoPage = true;
        }
        return VisibleNavigationControls;
    })();
    gnostice.VisibleNavigationControls = VisibleNavigationControls;
    var VisibleZoomControls = (function () {
        function VisibleZoomControls() {
            this.fixedSteps = true;
            this.zoomIn = true;
            this.zoomOut = true;
        }
        return VisibleZoomControls;
    })();
    gnostice.VisibleZoomControls = VisibleZoomControls;
    ;
    var VisibleRotationControls = (function () {
        function VisibleRotationControls() {
            this.clockwise = true;
            this.counterClockwise = true;
        }
        return VisibleRotationControls;
    })();
    gnostice.VisibleRotationControls = VisibleRotationControls;
    ;
    var VisibleFileOperationControls = (function () {
        function VisibleFileOperationControls() {
            this.open = true;
            this.download = true;
            this.print = true;
            this.downloadAs = true;
        }
        return VisibleFileOperationControls;
    })();
    gnostice.VisibleFileOperationControls = VisibleFileOperationControls;
    ;
    var VisibleColorInversionControls = (function () {
        function VisibleColorInversionControls() {
            this.allPages = true;
        }
        return VisibleColorInversionControls;
    })();
    gnostice.VisibleColorInversionControls = VisibleColorInversionControls;
    ;
    var Preferences = (function () {
        function Preferences() {
            this.toolbarVisible = true;
            this.disableOpen = false;
            this.disableDownload = false;
            this.disablePrint = false;
            this.visibleFullScreen = true;
            this.visibleNavigationControls = new VisibleNavigationControls();
            this.visibleRotationControls = new VisibleRotationControls();
            this.visibleFileOperationControls = new VisibleFileOperationControls();
            this.visibleColorInversionControls = new VisibleColorInversionControls();
            this.visibleZoomControls = new VisibleZoomControls();
        }
        return Preferences;
    })();
    gnostice.Preferences = Preferences;
})(gnostice || (gnostice = {}));
var gnostice;
(function (gnostice) {
    var ViewerOptions = (function () {
        function ViewerOptions() {
            this.preferences = new gnostice.Preferences();
            this.events = new gnostice.Events();
        }
        return ViewerOptions;
    })();
    gnostice.ViewerOptions = ViewerOptions;
})(gnostice || (gnostice = {}));
/// <reference path="../../typings/jquery/jquery.d.ts"/>
var gnostice;
(function (gnostice) {
    var DocumentViewer = (function () {
        function DocumentViewer(parentID, options) {
            this.handlerUri = "DocumentHandler.axd";
            this.id = null;
            this.renderingDpi = 96;
            this.renderingFormat = "PNG";
            this.id = parentID;
            this.docviewercontrol = $("#" + this.id) || null;
            var _preferences = {
                toolbarVisible: true,
                disableOpen: false,
                disableDownload: false,
                disablePrint: false,
                searchControls: {
                    enableQuickSearch: true,
                    highlightColor: "yellow"
                },
                visibleNavigationControls: {
                    firstPage: true,
                    prevPage: true,
                    nextPage: true,
                    lastPage: true,
                    pageIndicator: true,
                    gotoPage: true
                },
                visibleZoomControls: {
                    fixedSteps: true,
                    zoomIn: true,
                    zoomOut: true
                },
                visibleRotationControls: {
                    clockwise: true,
                    counterClockwise: true
                },
                visibleFileOperationControls: {
                    open: true,
                    download: true,
                    print: true,
                    downloadAs: true
                },
                visibleColorInversionControls: {
                    allPages: false
                },
                visibleFullScreen: true
            };
            var _events = {
                beforePageChange: function () {
                },
                afterPageChange: function () {
                },
                beforeZoomChange: function () {
                },
                afterZoomChange: function () {
                },
                onDocumentClose: function () {
                },
                beforeDocumentLoad: function () {
                },
                afterDocumentLoad: function () {
                },
                afterDocumentUpload: function () {
                },
                beforeDocumentPrint: function () {
                },
                afterDocumentPrint: function () {
                },
                beforeDocumentClose: function () {
                },
                afterDocumentClose: function () {
                },
                beforePageRotate: function () {
                },
                afterPageRotate: function () {
                },
                beforeDocumentDownload: function () {
                },
                afterDocumentDownload: function () {
                }
            };
            if (options != null) {
                this.events = $.extend(_events, options.events);
                this.preferences = $.extend(_preferences, options.preferences);
                this.handlerUri = options.handlerUri == null ? "DocumentHandler.axd" : options.handlerUri;
                this.renderingDpi = options.renderingDpi == null ? 96 : options.renderingDpi;
                this.renderingFormat = options.renderFormat == null ? 'png' : options.renderFormat;
                this.renderingFormat = this.renderingFormat.toUpperCase();
            }
            else {
                this.events = _events;
                this.preferences = new gnostice.Preferences();
            }
        }
        DocumentViewer.prototype.render = function (id) {
            if (id != null) {
                this.id = id;
                this.docviewercontrol = $("#" + this.id) || null;
            }
            var self = this;
            var viewer = document.createElement("DIV");
            $(viewer).height("100%");
            $(viewer).width("100%");
            $(viewer).css("position", "relative");
            var viewercontrainer = document.createElement("DIV");
            $(viewercontrainer).height("100%");
            $(viewercontrainer).width("100%");
            $(viewercontrainer).css("position", "relative");
            $(viewercontrainer).addClass("git-docviewer-container");
            if (self.preferences.toolbarVisible) {
                this.toolbar = document.createElement("DIV");
                $(this.toolbar).css({ "position": "absolute", "z-index": "2", "width": "100%", "min-height": "37px", "text-align": "center", "left": "0px", "right": "0px", "cursor": "default" });
                this.container = document.createElement("DIV");
                $(this.container).css({ "position": "relative", "left": "0", "right": "0", "width": "100%", "text-align": "center" });
                $(this.container).addClass("git-docviewer-toolbar");
                $(this.container).addClass("git_viewer_box_shadow");
                this.placeholder = document.createElement("DIV");
                $(this.placeholder).css({ "position": "relative", "z-index": "2", "width": "100%", "min-height": "37px", "text-align": "center" });
                this.centerplaceholder = document.createElement("span");
                $(this.centerplaceholder).attr("class", "git_xdoc_docviewer_toolbar_container_class_center");
                $(this.centerplaceholder).css({ "position": "relative", "top": "5px;", "min-width": "16px" });
                this.leftplaceholder = document.createElement("span");
                $(this.leftplaceholder).css({ "position": "relative", "float": "left", "margin": "2px 2px 3px 0px", "left": "6px" });
                this.rightplaceholder = document.createElement("span");
                $(this.rightplaceholder).attr("id", "git_xdoc_docviewer_toolbar_id_right");
                $(this.rightplaceholder).attr("class", "git_xdoc_docviewer_toolbar_class_right");
                $(this.rightplaceholder).css({ "position": "relative", "float": "right", "margin": "2px 2px 3px 0px", "right": "6px" });
                this.toggleplaceholder = document.createElement("span");
                $(this.toggleplaceholder).css({ "position": "relative", "float": "right", "margin": "0px 0px 0px 0px", "right": "3px" });
                $(this.placeholder).append(this.leftplaceholder);
                $(this.placeholder).append(this.centerplaceholder);
                $(this.placeholder).append(this.toggleplaceholder);
                $(this.placeholder).append(this.rightplaceholder);
                $(this.container).append(this.placeholder);
                $(this.toolbar).append(this.container);
                //Begin region: first button
                if (self.preferences.visibleNavigationControls.firstPage) {
                    this.firstPageBtn = document.createElement("div");
                    $(this.firstPageBtn).addClass("git-docviewer-controlcontainer");
                    $(this.firstPageBtn).addClass("git-docviewer-first");
                    $(this.firstPageBtn).addClass("git-docviewer-mob-first");
                    $(this.centerplaceholder).append(this.firstPageBtn);
                }
                //Begin region: prev button
                if (self.preferences.visibleNavigationControls.prevPage) {
                    this.prevPageBtn = document.createElement("div");
                    $(this.prevPageBtn).addClass("git-docviewer-controlcontainer");
                    $(this.prevPageBtn).addClass("git-docviewer-prev");
                    $(this.prevPageBtn).addClass("git-docviewer-mob-prev");
                    $(this.centerplaceholder).append(this.prevPageBtn);
                }
                //Begion Region:Page Number and page Count
                if (self.preferences.visibleNavigationControls.pageIndicator) {
                    self.pagenumberInput = document.createElement("input");
                    $(self.pagenumberInput).attr({ "title": "Goto Page", "type": "text", "class": "git-docviewer-goto git-docviewer-mob-goto", "id": "git_xdoc_docviewer_toolbar_id_goto", "value": "0 / 0" });
                    $(self.pagenumberInput).css({ "text-align": "center", "min-height": "24px" });
                    $(this.centerplaceholder).append(self.pagenumberInput);
                }
                //Begin region: Next button
                if (self.preferences.visibleNavigationControls.nextPage) {
                    this.nextPageBtn = document.createElement("div");
                    $(this.nextPageBtn).addClass("git-docviewer-controlcontainer");
                    $(this.nextPageBtn).addClass("git-docviewer-next");
                    $(this.nextPageBtn).addClass("git-docviewer-mob-next");
                    $(this.centerplaceholder).append(this.nextPageBtn);
                }
                //Begin region: last button
                if (self.preferences.visibleNavigationControls.lastPage) {
                    this.lastPageBtn = document.createElement("div");
                    $(this.lastPageBtn).addClass("git-docviewer-controlcontainer");
                    $(this.lastPageBtn).addClass("git-docviewer-last");
                    $(this.lastPageBtn).addClass("git-docviewer-mob-last");
                    $(this.centerplaceholder).append(this.lastPageBtn);
                }
                //Begin region: open
                if (self.preferences.visibleFileOperationControls.open) {
                    this.openDoc = document.createElement("div");
                    $(this.openDoc).addClass("git-docviewer-controlcontainer");
                    $(this.openDoc).addClass("git-docviewer-open");
                    $(this.openDoc).addClass("git-docviewer-mob-open");
                    $(this.leftplaceholder).append(this.openDoc);
                }
                //Begin region: print button
                if (self.preferences.visibleFileOperationControls.print) {
                    this.printBtn = document.createElement("div");
                    $(this.printBtn).addClass("git-docviewer-controlcontainer");
                    $(this.printBtn).addClass("git-docviewer-print");
                    $(this.printBtn).addClass("git-docviewer-mob-print");
                    $(this.leftplaceholder).append(this.printBtn);
                }
                //Begin region: download button
                if (self.preferences.visibleFileOperationControls.download) {
                    this.downloadBtn = document.createElement("div");
                    $(this.downloadBtn).addClass("git-docviewer-controlcontainer");
                    $(this.downloadBtn).addClass("git-docviewer-download");
                    $(this.downloadBtn).addClass("git-docviewer-mob-print");
                    $(this.leftplaceholder).append(this.downloadBtn);
                }
                if (self.preferences.visibleColorInversionControls.allPages) {
                    this.invertAllPagesBtn = document.createElement("div");
                    $(this.invertAllPagesBtn).addClass("git-docviewer-controlcontainer");
                    $(this.invertAllPagesBtn).addClass("git-docviewer-invert");
                    $(this.invertAllPagesBtn).addClass("git-docviewer-mob-invert");
                    $(self.rightplaceholder).append(this.invertAllPagesBtn);
                }
                if (self.preferences.visibleRotationControls.counterClockwise) {
                    this.counterClockwiseBtn = document.createElement("div");
                    $(this.counterClockwiseBtn).addClass("git-docviewer-controlcontainer");
                    $(this.counterClockwiseBtn).addClass("git-docviewer-rotateleft");
                    $(this.counterClockwiseBtn).addClass("git-docviewer-mob-rotateleft");
                    $(self.rightplaceholder).append(this.counterClockwiseBtn);
                }
                if (self.preferences.visibleRotationControls.clockwise) {
                    this.clockwiseBtn = document.createElement("div");
                    $(this.clockwiseBtn).addClass("git-docviewer-controlcontainer");
                    $(this.clockwiseBtn).addClass("git-docviewer-rotateright");
                    $(this.clockwiseBtn).addClass("git-docviewer-mob-rotateright");
                    $(self.rightplaceholder).append(this.clockwiseBtn);
                }
                //Begin region: zoom button
                if (self.preferences.visibleZoomControls.zoomOut) {
                    this.zoomOutBtn = document.createElement("div");
                    $(this.zoomOutBtn).addClass("git-docviewer-controlcontainer");
                    $(this.zoomOutBtn).addClass("git-docviewer-zoomout");
                    $(this.zoomOutBtn).addClass("git-docviewer-mob-zoomout");
                    $(this.rightplaceholder).append(this.zoomOutBtn);
                }
                //Begin region: zoom button
                if (self.preferences.visibleZoomControls.zoomIn) {
                    this.zoomInBtn = document.createElement("div");
                    $(this.zoomInBtn).addClass("git-docviewer-controlcontainer");
                    $(this.zoomInBtn).addClass("git-docviewer-zoomin");
                    $(this.zoomInBtn).addClass("git-docviewer-mob-zoomin");
                    $(this.rightplaceholder).append(this.zoomInBtn);
                }
                //Begin region: predefined zoom button
                if (self.preferences.visibleZoomControls.fixedSteps) {
                    var dropdownToolbarButton = document.createElement("span");
                    $(dropdownToolbarButton).attr("class", "git_viewer_button_container git_xdoc_viewer_toolbar_drpdwn_class_zoom git-viewer-mob-fixedzoom");
                    $(dropdownToolbarButton).css({ "min-width": "120px" });
                    this.zoominSelect = document.createElement("select");
                    $(this.zoominSelect).css({ "height": "100%", "min-width": "142px", "cursor": "pointer" });
                    if (self.preferences.visibleZoomControls.fixedSteps) {
                        var page25PercentageOption = document.createElement("option");
                        $(page25PercentageOption).val("25");
                        $(page25PercentageOption).append("25%");
                        $(self.zoominSelect).append(page25PercentageOption);
                    }
                    if (self.preferences.visibleZoomControls.fixedSteps) {
                        var page50PercentageOption = document.createElement("option");
                        $(page50PercentageOption).val("50");
                        $(page50PercentageOption).append("50%");
                        $(self.zoominSelect).append(page50PercentageOption);
                    }
                    if (self.preferences.visibleZoomControls.fixedSteps) {
                        var page100PercentageOption = document.createElement("option");
                        $(page100PercentageOption).val("100");
                        $(page100PercentageOption).append("100%");
                        $(self.zoominSelect).append(page100PercentageOption);
                    }
                    if (self.preferences.visibleZoomControls.fixedSteps) {
                        var page150PercentageOption = document.createElement("option");
                        $(page150PercentageOption).val("150");
                        $(page150PercentageOption).append("150%");
                        $(self.zoominSelect).append(page150PercentageOption);
                    }
                    if (self.preferences.visibleZoomControls.fixedSteps) {
                        var page200PercentageOption = document.createElement("option");
                        $(page200PercentageOption).val("200");
                        $(page200PercentageOption).append("200%");
                        $(self.zoominSelect).append(page200PercentageOption);
                    }
                    if (self.preferences.visibleZoomControls.fixedSteps) {
                        var pageActualSelectOptions = document.createElement("option");
                        $(pageActualSelectOptions).val("100");
                        $(pageActualSelectOptions).attr("selected", "selected");
                        $(pageActualSelectOptions).append("Actual Size");
                        $(self.zoominSelect).append(pageActualSelectOptions);
                    }
                    if (self.preferences.visibleZoomControls.fixedSteps) {
                        self.pageFitSelectOptions = document.createElement("option");
                        $(self.pageFitSelectOptions).append("Fit Height");
                        $(self.zoominSelect).append(self.pageFitSelectOptions);
                    }
                    if (self.preferences.visibleZoomControls.fixedSteps) {
                        self.pageWidthSelectOptions = document.createElement("option");
                        $(self.pageWidthSelectOptions).append("Fit Width");
                        $(self.zoominSelect).append(self.pageWidthSelectOptions);
                    }
                    $(dropdownToolbarButton).append(self.zoominSelect);
                    $(self.rightplaceholder).append(dropdownToolbarButton);
                }
                if (self.preferences.visibleFullScreen) {
                    var toolbarfullscreenControl = document.createElement("div");
                    $(toolbarfullscreenControl).addClass("git-docviewer-controlcontainer");
                    $(toolbarfullscreenControl).addClass("git-docviewer-fullScreen");
                    $(toolbarfullscreenControl).addClass("git-docviewer-mob-fullScreen");
                    $(self.rightplaceholder).append(toolbarfullscreenControl);
                }
            }
            var self = this;
            $(viewercontrainer).html("");
            if (self.preferences.toolbarVisible) {
                $(viewercontrainer).append(this.toolbar);
            }
            var renderCanvas = document.createElement("div");
            $(renderCanvas).attr("class", "git-docviewer-scrollablecanvas");
            $(renderCanvas).attr("align", "center");
            $(renderCanvas).css({ "padding-top": "38px", "box-sizing": "border-box", "width": "100%", "height": "100%", "position": "relative", "box-shadow": "inset 1px 0 0 hsla(0,0%,100%,.05)" });
            self.scrollableviewer = document.createElement("div");
            $(self.scrollableviewer).attr("align", "center");
            $(self.scrollableviewer).css({ "width": "100%", "height": "100%", "position": "relative", "overflow": "auto", "-webkit-overflow-scrolling": "touch" });
            $(renderCanvas).append(self.scrollableviewer);
            $(viewercontrainer).append(renderCanvas);
            $(viewer).append(viewercontrainer);
            $(self.docviewercontrol).append(viewer);
            this.uploaderBtn = document.createElement("input");
            $(this.uploaderBtn).css({ "display": "none", "left": "-9999px", "top": "-9999px", "width": "1px", "height": "1px" });
            $(this.uploaderBtn).attr("type", "file");
            $(viewer).append(this.uploaderBtn);
            this.viewerDOM = new gnostice.ViewerDOM(viewer, self.scrollableviewer, this.openDoc, this.printBtn, this.downloadBtn, this.firstPageBtn, this.prevPageBtn, this.nextPageBtn, this.lastPageBtn, this.uploaderBtn, this.pagenumberInput, this.zoomInBtn, this.zoomOutBtn, this.zoominSelect, this.clockwiseBtn, this.counterClockwiseBtn, this.invertAllPagesBtn);
            this.viewerManager = new gnostice.ViewerManager(this.viewerDOM, this.handlerUri);
        };
        DocumentViewer.prototype.loadDocument = function (documenturi, successCallback, errorCallback) {
            if (this.viewerManager != null)
                this.viewerManager.loadDoc(documenturi, successCallback, errorCallback);
        };
        DocumentViewer.prototype.openDocument = function () {
            if (this.viewerManager != null)
                this.viewerManager.openDocument();
        };
        DocumentViewer.prototype.closeDocument = function (documentUri) {
            if (this.viewerManager != null)
                this.viewerManager.closeDocument(documentUri);
        };
        DocumentViewer.prototype.uploadDocumentFromBuffer = function (base64string) {
            if (this.viewerManager != null)
                this.viewerManager.uploadDocumentFromBuffer(base64string);
        };
        DocumentViewer.prototype.download = function () {
            if (this.viewerManager != null)
                this.viewerManager.download();
        };
        DocumentViewer.prototype.downloadAs = function (mimetype) {
            if (this.viewerManager != null)
                this.viewerManager.downloadAs(mimetype);
        };
        DocumentViewer.prototype.print = function () {
            if (this.viewerManager != null)
                this.viewerManager.print();
        };
        DocumentViewer.prototype.firstPage = function () {
            if (this.viewerManager != null)
                this.viewerManager.firstPage();
        };
        DocumentViewer.prototype.prevPage = function () {
            if (this.viewerManager != null)
                this.viewerManager.prevPage();
        };
        DocumentViewer.prototype.nextPage = function () {
            if (this.viewerManager != null)
                this.viewerManager.nextPage();
        };
        DocumentViewer.prototype.lastPage = function () {
            if (this.viewerManager != null)
                this.viewerManager.lastPage();
        };
        DocumentViewer.prototype.zoomIn = function () {
            if (this.viewerManager != null)
                this.viewerManager.zoomIn();
        };
        DocumentViewer.prototype.zoomOut = function () {
            if (this.viewerManager != null)
                this.viewerManager.zoomOut();
        };
        DocumentViewer.prototype.zoom = function (value) {
            if (this.viewerManager != null)
                this.viewerManager.zoomTo(value, this.viewerManager);
        };
        DocumentViewer.prototype.rotatePagesClockwise = function () {
            if (this.viewerManager != null)
                this.viewerManager.rotatePagesClockwise();
        };
        DocumentViewer.prototype.rotatePagesCounterClockwise = function () {
            if (this.viewerManager != null)
                this.viewerManager.rotatePagesCounterClockwise();
        };
        DocumentViewer.prototype.invertColors = function (applyInversion) {
            if (this.viewerManager != null)
                this.viewerManager.invertColors(applyInversion);
        };
        DocumentViewer.prototype.gotoPage = function (pageNumber) {
            if (this.viewerManager != null)
                this.viewerManager.gotoPage(pageNumber);
        };
        return DocumentViewer;
    })();
    gnostice.DocumentViewer = DocumentViewer;
})(gnostice || (gnostice = {}));
