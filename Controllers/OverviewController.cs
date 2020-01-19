using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebSiteFrame.Controllers
{
    [Authorize]
    public class OverviewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}