using Microsoft.AspNetCore.Mvc;

namespace TaskManagementSystem.Controllers
{
    public class AgileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
