using Microsoft.AspNetCore.Mvc;
using MyFridge.Data.Models;
using MyFridge.Data.Services.Interfaces;
using MyFridge.Web.RecipeViewModels;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyFridge.Controllers
{
    public class RecipeController : Controller
    {
        private readonly IRecipeService _recipeService;
        private readonly IMyFridgeService _fridgeService;

        public RecipeController(IRecipeService recipeService, IMyFridgeService fridgeService)
        {
            this._recipeService = recipeService;
            _fridgeService = fridgeService;
        }

        public async Task<IActionResult> Index()
        {
            ViewData["FridgeProducts"] = await _fridgeService.GetAllProductsAsync(GetUserId());
            var recipes = await _recipeService.GetAllRecipesAsync();
            return View(recipes);
        }

        [HttpGet]
        public IActionResult AddRecipe()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRecipe(AddRecipeViewModel model)
        {
            if (!ModelState.IsValid)
            {
               throw new ArgumentException("Not implemented");
            }
            await _recipeService.AddRecipeAsync(model);
            return RedirectToAction(nameof(Index));
        }

        private Guid GetUserId()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            return Guid.Parse(userId!);
        }

    }
}
