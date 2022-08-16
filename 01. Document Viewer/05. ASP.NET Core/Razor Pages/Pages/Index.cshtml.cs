using Gnostice.Controls.ASP;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication12.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private IMemoryCache _memoryCache;
        private IWebHostEnvironment _environment;
        public string documentUri { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IMemoryCache memoryCache, IWebHostEnvironment environment)
        {
            _logger = logger;
            _memoryCache = memoryCache;
            _environment = environment;
        }

        public void OnGet()
        {
            var file = Path.Combine(_environment.WebRootPath, "files", "DifferentAlignments.docx");
            ViewerController controller = new ViewerController(_memoryCache);
            documentUri = controller.LoadDocument(file);
        }
    }
}
