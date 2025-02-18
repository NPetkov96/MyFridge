using Microsoft.AspNetCore.Mvc;
using MyFridge.Data.Services.Interfaces;
using MyFridge.Web.ProductsViewModels;
using System.Security.Claims;

namespace MyFridge.Controllers
{
    public class MarketController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMyFridgeService _myFridgeService;

        public MarketController(IProductService productService, IMyFridgeService myFridgeService)
        {
            this._productService = productService;
            _myFridgeService = myFridgeService;
        }
        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var products = await _productService.GetAllProductsAsync(Guid.Parse(userId!));
            return View(products);
        }

        [HttpGet]
        public async Task<IActionResult> AddProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(AddProductViewModel model)
        {
            await _productService.AddProductAsync(model);
            return RedirectToAction(nameof(Index)); ;
        }

        [HttpGet]
        public async Task<IActionResult> AddProductInFridge(Guid productId)
        {
            await _myFridgeService.AddProductAsync(productId, GetUserId());
            return RedirectToAction(nameof(Index)); ;
        }

        [HttpPost]
        public async Task<IActionResult> DeleteProduct(Guid productId)
        {
            await _productService.DeleteProduct(productId);
            return RedirectToAction(nameof(Index)); ;
        }

        private Guid GetUserId()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            return Guid.Parse(userId!);
        }
    }
}
