using Gnostice.Controls.ASP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace FileStore
{
    public class FolderView
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private string appDataFolder;
        public FolderView(HttpServerUtility utility)
        {
            appDataFolder = utility.MapPath("~/App_Data/");
        }

        public string GetFile() 
        {
            log.Info("Log Messages from FileStore Application");
            log.Info("App_Data folder path : " + appDataFolder);
            var filepath = appDataFolder + "datasheet.pdf";
            String sDocID;
            ViewerController vc = new ViewerController();
            
            sDocID = vc.LoadDocument(filepath);
            return sDocID;
        }
    }
}
