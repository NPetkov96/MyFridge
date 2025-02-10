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

        [HttpPost]
        public async Task<IActionResult> AddProduct(AddProductViewModel model)
        {
            await _productService.AddProductAsync(model, GetUserId());
            return RedirectToAction(nameof(Index)); ;
        }

        [HttpGet]
        public async Task<IActionResult> AddProductInFridge(Guid procutId)
        {
            await _myFridgeService.AddProductAsync(procutId, GetUserId());
            return RedirectToAction(nameof(Index)); ;
        }

        [HttpPost]
        public IActionResult AddProductToShoppingList(string productName)
        {
            var shoppingList = TempData["ShoppingList"] as List<string> ?? new List<string>();
            shoppingList.Add(productName);
            TempData["ShoppingList"] = shoppingList;
            return RedirectToAction("Index");
        }


        private Guid GetUserId()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            return Guid.Parse(userId!);
        }
    }
}
