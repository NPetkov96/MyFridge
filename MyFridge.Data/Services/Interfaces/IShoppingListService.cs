using MyFridge.Web.ProductsViewModels;

namespace MyFridge.Data.Services.Interfaces
{
    public interface IShoppingListService
    {
        Task<List<ShowProductsViewModel>> GetAllShoppingListProducts(Guid userId);
        Task AddProductInShoppingList(Guid productId, Guid userId);
        Task AddProductInShoppingList(string productName, Guid userId);
        Task DeleteProductInShoppingList(Guid productId, Guid guid);
    }
}
