using Microsoft.AspNetCore.Mvc;
using MyFridge.Data.Services.Interfaces;
using System.Security.Claims;

namespace MyFridge.Controllers
{
    public class MarketController : Controller
    {
        private readonly IProductService _productService;

        public MarketController(IProductService productService)
        {
            this._productService = productService;
        }
        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var products = await _productService.GetAllProductsAsync(Guid.Parse(userId!));
            return View(products);
        }

    }
}
