using Microsoft.AspNetCore.Mvc;
using MyFridge.Data.Services.Interfaces;
using System.Security.Claims;

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

        [HttpPost]
        public async Task<IActionResult> AddProductInFridge(Guid productId)
        {
            await _myFridgeService.AddProductAsync(productId, GetUserId());
            return RedirectToAction(nameof(Index),"Market");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteProductInFridge(Guid productId)
        {
            await _myFridgeService.DeleteProductAsync(productId, GetUserId());
            return RedirectToAction(nameof(Index));
        }

        private Guid GetUserId()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            return Guid.Parse(userId!);
        }
    }
}
