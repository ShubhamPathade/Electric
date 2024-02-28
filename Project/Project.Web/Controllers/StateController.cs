using Microsoft.AspNetCore.Mvc;
using Project.Web.Models.States;

namespace Project.Web.Controllers
{
    public class StateController:Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(StateModel stateModel)
        {
            return View();
        }
    }
}
