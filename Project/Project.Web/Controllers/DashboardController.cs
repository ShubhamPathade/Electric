using Microsoft.AspNetCore.Mvc;

namespace Project.Web.Controllers
{
    public class DashboardController : Controller
    {
        public async Task<IActionResult> Dashboard()
        {
            return View();
        }
    }
}
