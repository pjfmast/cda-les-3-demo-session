using DemoLes3Session.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoLes3Session.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // todo 3. add const definitions for Session keys
        const string SessionUser = "_SessionUser";
        const string SessionRole = "_SessionRole";

        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }

        public IActionResult Index() {
            // todo 4. store Session data
            HttpContext.Session.SetString(SessionUser, "Henk");
            HttpContext.Session.SetString(SessionRole, "Balie");

            return View();
        }

        public IActionResult Privacy() {
            // todo 5. Use ViewBag to pass Session data to View
            ViewBag.User = HttpContext.Session.GetString(SessionUser);
            ViewBag.Role = HttpContext.Session.GetString(SessionRole);
            ViewBag.Message = "Dynamic properties!";
            ViewBag.LoginTime = DateTime.Now;
            ViewBag.Keys = HttpContext.Session.Keys;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}