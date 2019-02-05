using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace Ahbc.Class.FiftyTwo.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var claimsPrincipal = User as ClaimsPrincipal;
            var surnameClaim = claimsPrincipal.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Surname);

            ViewBag.Message = $"Hello {surnameClaim.Value}";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}