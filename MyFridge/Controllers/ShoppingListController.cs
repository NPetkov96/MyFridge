using Microsoft.AspNetCore.Mvc;
using MyFridge.Data.Services.Interfaces;
using System.Security.Claims;

namespace MyFridge.Controllers
{
    public class ShoppingListController : Controller
    {
        private readonly IShoppingListService _shoppingListService;

        public ShoppingListController(IShoppingListService shoppingListService)
        {
            this._shoppingListService = shoppingListService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _shoppingListService.GetAllShoppingListProducts(GetUserId());
            return View(products);
        }

        [HttpPost]
        public async Task<IActionResult> AddProductInShoppingList(Guid productId)
        {
            await _shoppingListService.AddProductInShoppingList(productId,GetUserId());
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> DeleteProductInShoppingList(Guid productId)
        {
            await _shoppingListService.DeleteProductInShoppingList(productId, GetUserId());
            return RedirectToAction(nameof(Index));
        }

        private Guid GetUserId()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            return Guid.Parse(userId!);
        }
    }
}
