using DemoLes3Session.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoLes3Session.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // todo 3. add const definitions for Session keys

        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }

        public IActionResult Index() {
            // todo 4. store Session data

            return View();
        }

        public IActionResult Privacy() {
            // todo 5. Use ViewBag to pass Session data to View

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}