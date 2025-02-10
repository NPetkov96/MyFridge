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

        [HttpPost]
        public async Task<IActionResult> AddProductInFridge(Guid procutId)
        {
            await _myFridgeService.AddProductAsync(procutId, GetUserId());
            return RedirectToAction(nameof(Index),"Market");
        }

        private Guid GetUserId()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            return Guid.Parse(userId!);
        }
    }
}
