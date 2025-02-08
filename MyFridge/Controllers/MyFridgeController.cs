using Microsoft.AspNetCore.Mvc;
using MyFridge.Data.Services.Interfaces;

namespace MyFridge.Controllers
{
    public class MyFridgeController : Controller
    {
        private readonly IMyFridgeService _myFridgeService;

        public MyFridgeController(IMyFridgeService myFridgeService)
        {
            this._myFridgeService = myFridgeService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _myFridgeService.GetAllProductsAsync();
            return View(products);
        }

        [HttpGet]
        public async Task<IActionResult> AddProduct()
        {
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> AddProduct()
        //{
        //    return View();
        //}
    }
}
