using Microsoft.AspNetCore.Mvc;
using MyFridge.Data.Services.Interfaces;

namespace MyFridge.Controllers
{
    public class RecipeController : Controller
    {
        private readonly IRecipeService _recipeService;

        public RecipeController(IRecipeService recipeService)
        {
            this._recipeService = recipeService;
        }

        public async Task<IActionResult> Index()
        {
            var recipes = await _recipeService.GetAllRecipesAsync();
            return View(recipes);
        }
    }
}
