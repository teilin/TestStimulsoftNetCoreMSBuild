using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Stimulsoft.Report.NetCore;

namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment _hostingEnviroment;

        public HomeController(IHostingEnvironment hostingEnviroment)
        {
            _hostingEnviroment = hostingEnviroment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult GetReport()
        {
            var reportPath = _hostingEnviroment.WebRootPath + "\\Reports\\SimpleList.mrt";
            return StiNetCoreViewer.GetReportResult(this, reportPath);
        }
        
        public IActionResult ViewerEvent()
        {
            return StiNetCoreViewer.ViewerEventResult(this);
        }
    }
}
