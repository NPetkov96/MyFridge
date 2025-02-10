using MyFridge.Web.ProductsViewModels;

namespace MyFridge.Data.Services.Interfaces
{
    public interface IShoppingListService
    {
        public Task<List<ShowProductsViewModel>> GetAllShoppingListProducts(Guid userId);
        public Task AddProductInShoppingList(Guid productId, Guid userId);

    }
}
