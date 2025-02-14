using MyFridge.Data.Models;
using MyFridge.Data.Repository.Interfaces;
using MyFridge.Data.Services.Interfaces;
using MyFridge.Web.RecipeViewModels;

namespace MyFridge.Data.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRepository<Recipe, Guid> _recipeRepository;

        public RecipeService(IRepository<Recipe, Guid> recipeRepository)
        {
            this._recipeRepository = recipeRepository;
        }

        public Task AddRecipeAsync(RecipeViewModel recipe)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRecipeAsync(Guid recipeId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RecipeViewModel>> GetAllRecipesAsync()
        {
            var recipes = await _recipeRepository.GetAllAsync();

            return recipes
                .Select(r => new RecipeViewModel()
                {
                    Id = r.Id,
                    Name = r.Name,
                    Duration = r.Duration,
                    RequiredProducts = r.RequiredProducts
                })
                .ToList();
        }

        public Task<RecipeViewModel> GetRecipeAsync(Guid recipeId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRecipeAsync(RecipeViewModel recipe)
        {
            throw new NotImplementedException();
        }
    }
}
