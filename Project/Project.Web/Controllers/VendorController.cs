using Microsoft.AspNetCore.Mvc;

namespace Project.Web.Controllers
{
    public class VendorController : Controller
    {
        public async Task<IActionResult> Ledger()
        {
            return View();
        }

        public async Task<IActionResult> Shop()
        {
            return View();
        }
    }
}
