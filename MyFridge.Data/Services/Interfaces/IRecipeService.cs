using MyFridge.Web.RecipeViewModels;

namespace MyFridge.Data.Services.Interfaces
{
    public interface IRecipeService
    {
        Task<IEnumerable<RecipeViewModel>> GetAllRecipesAsync();
        Task<RecipeViewModel> GetRecipeAsync(Guid recipeId);
        Task AddRecipeAsync(RecipeViewModel recipe);
        Task UpdateRecipeAsync(RecipeViewModel recipe);
        Task DeleteRecipeAsync(Guid recipeId);
    }
}
