using Microsoft.AspNetCore.Mvc;

namespace MyFridge.Controllers
{
    public class Recipes : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
