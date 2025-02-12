using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFridge.Data.Services.Interfaces;
using System.Security.Claims;

namespace MyFridge.Data.ViewComponents
{
    public class ShoppingListViewComponent : ViewComponent
    {
        private readonly IShoppingListService _shoppingListService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ShoppingListViewComponent(IShoppingListService shoppingListService, IHttpContextAccessor httpContextAccessor)
        {
            _shoppingListService = shoppingListService;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userId = GetUserId();
            var shoppingList = await _shoppingListService.GetAllShoppingListProducts(userId);
            return View(shoppingList);
        }

        private Guid GetUserId()
        {
            var userIdClaim = _httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier);

            if (userIdClaim != null)
            {
                return Guid.Parse(userIdClaim.Value);
            }

            throw new InvalidOperationException("User ID not found.");
        }
    }
}
