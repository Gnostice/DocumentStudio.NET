﻿using System.Web.Mvc;

namespace ASP.NET_MVC_Razor_CS_Document_Viewer
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}