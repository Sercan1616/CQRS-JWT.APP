using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWT.APP.WebUI.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles ="Admin")]
        public string AdminPage()
        {
            return "Admin Page";
        }

        [Authorize(Roles = "Member")]
        public string MemberPagfe()
        {
            return "Member Page"; 
        }
    }
}
