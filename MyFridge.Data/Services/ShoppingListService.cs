using Microsoft.EntityFrameworkCore;
using MyFridge.Data.Models;
using MyFridge.Data.Repository.Interfaces;
using MyFridge.Data.Services.Interfaces;
using MyFridge.Web.ProductsViewModels;

namespace MyFridge.Data.Services
{
    public class ShoppingListService : IShoppingListService
    {
        private readonly IRepository<ShoppingListProducts, Guid> _productsListRepository;

        public ShoppingListService(IRepository<ShoppingListProducts, Guid> productsListRepository)
        {
            this._productsListRepository = productsListRepository;
        }

        public async Task AddProductInShoppingList(Guid productId, Guid userId)
        {

            //var userShoppingList = _shoppingListRepository.FirstOrDefaultAsync(sl => sl.UserId == userId);
            //if (userShoppingList == null)
            //{
            //    userShoppingList = new ShoppingList()
            //    {
            //        Id = Guid.NewGuid(),
            //        ShoppingListProducts = new ShoppingListProducts()
            //        {
            //            Id = Guid.NewGuid()
            //        }
            //    };
            //}




            //var userList = new ShoppingListProducts()
            //{
            //    ProductId = productId,
            //    ShoppingList = new ShoppingList()
            //    {
            //        UserId = userId,
            //    }
            //};

            //await _shoppingListRepository.AddAsync(userList);
        }

        public Task<List<ShowProductsViewModel>> GetAllShoppingListProducts(Guid userId)
        {
            var shoppinList = _productsListRepository.GetAllAttached().Where(l => l.UserId == userId);

            var productList = shoppinList
                .Select(l=> new ShowProductsViewModel()
                {
                    //Name = l.Product.Name,
                    //Category = l.Product.Categories.ToString(),
                })
                .ToListAsync();

            return productList;
        }
    }
}
