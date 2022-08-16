using ASPNETCore_MVC_Document_Viewer.Models;
using Gnostice.Controls.ASP;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCore_MVC_Document_Viewer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IMemoryCache _memoryCache;
        private IWebHostEnvironment _environment;

        public HomeController(ILogger<HomeController> logger, IMemoryCache memoryCache, IWebHostEnvironment environment)
        {
            _logger = logger;
            _memoryCache = memoryCache;
            _environment = environment;
        }

        public IActionResult Index()
        {
            var file = Path.Combine(_environment.WebRootPath, "files", "DifferentAlignments.docx");
            ViewerController controller = new ViewerController(_memoryCache);
            string documentUri = controller.LoadDocument(file);
            ViewBag.docUri = documentUri;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
