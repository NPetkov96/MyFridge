using Microsoft.AspNetCore.Mvc;
using MyFridge.Data.Services.Interfaces;
using System.Security.Claims;

namespace MyFridge.Controllers
{
    public class MarketController : Controller
    {
        private readonly IMyFridgeService _myFridgeService;

        public MarketController(IMyFridgeService myFridgeService)
        {
            this._myFridgeService = myFridgeService;
        }
        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var products = await _myFridgeService.GetAllProductsAsync(Guid.Parse(userId!));
            return View(products);
        }

    }
}
