using helloWorldMvcCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace helloWorldMvcCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        // Returns JSON
        public IActionResult GetData()
        {
            var data = new { Id = 1, Name = "Imran" };
            return Json(data);
        }

        // Redirects to another action
        public IActionResult RedirectToAbout()
        {
            return RedirectToAction("About");
        }

        // Returns plain content
        public IActionResult HelloWorld()
        {
            return Content("Hello, Imran!");
        }

        public IActionResult Contact()
        {
            ViewBag.contact = "imran bhatti";
            return View();
        }

        public IActionResult MessageView()
        {
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