using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using MyFridge.Data.Services.Interfaces;
using MyFridge.Web.ProductsViewModels;

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
            var products = await _myFridgeService.GetAllProductsAsync(GetUserId());
            return View(products);
        }

        [HttpGet]
        public async Task<IActionResult> AddProduct()
        {
            return View(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(AddProductViewModel model)
        {
            //var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            //var userGuid = Guid.Parse(userId!);

            await _myFridgeService.AddProductAsync(model, GetUserId());
            return View(nameof(Index));
        }

        private Guid GetUserId()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            return Guid.Parse(userId!);
        }
    }
}
