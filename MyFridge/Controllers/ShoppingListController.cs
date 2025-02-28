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
            await _shoppingListService.AddProductInShoppingList(productId, GetUserId());
            return RedirectToAction(nameof(Index), "Market");
        }

        [HttpGet]
        public async Task<IActionResult> AddProductInShoppingList(string productName)
        {
            try
            {
                await _shoppingListService.AddProductInShoppingList(productName, GetUserId());
                //return Ok(); // Връща 200 OK за AJAX
                return RedirectToAction(nameof(Index), "Recipe");
            }
            catch (KeyNotFoundException)
            {
                return RedirectToAction("AddProduct", "Market", new { productName = productName });
            }
            //return RedirectToAction(nameof(Index), "Market");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteProductInShoppingList(Guid productId)
        {
            await _shoppingListService.DeleteProductInShoppingList(productId, GetUserId());
            return Ok();
        }

        private Guid GetUserId()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            return Guid.Parse(userId!);
        }
    }
}
