using Microsoft.EntityFrameworkCore;
using MyFridge.Data.Models;
using MyFridge.Data.Repository.Interfaces;
using MyFridge.Data.Services.Interfaces;
using MyFridge.Web.ProductsViewModels;

namespace MyFridge.Data.Services
{
    public class ShoppingListService : IShoppingListService
    {
        private readonly IRepository<ShoppingListProducts, Guid> _listProductRepository;
        private readonly IProductService _productSercice;

        public ShoppingListService(IRepository<ShoppingListProducts, Guid> listProductRepository, IProductService productSercice)
        {
            this._listProductRepository = listProductRepository;
            this._productSercice = productSercice;
        }

        public async Task AddProductInShoppingList(Guid productId, Guid userId)
        {
            var listProduct = new ShoppingListProducts()
            {
                ProductId = productId,
                UserId = userId
            };

           await _listProductRepository.AddAsync(listProduct);
        }

        public async Task AddProductInShoppingList(string productName, Guid userId)
        {
            var product = await _productSercice.GetProductByName(productName);
            if (product == null)
            {
                return;
            }

            var listProduct = new ShoppingListProducts()
            {
                ProductId = product.Id,
                UserId = userId
            };

            await _listProductRepository.AddAsync(listProduct);
        }

        public async Task DeleteProductInShoppingList(Guid productId, Guid userId)
        {
            var userProduct = await _listProductRepository.FirstOrDefaultAsync(p => p.ProductId == productId && p.UserId == userId);

            await _listProductRepository.DeleteAsync(userProduct);
        }

        public async Task<List<ShowProductsViewModel>> GetAllShoppingListProducts(Guid userId)
        {
            var shoppinList = await _listProductRepository
                .GetAllAttached()
                .Include(p => p.Product)
                .Where(l => l.UserId == userId)
                .ToListAsync();

            var productListViewModel = shoppinList
                .Select(l=> new ShowProductsViewModel()
                {
                    Id = l.ProductId,
                    Name = l.Product.Name,
                    Category = l.Product.Categories.ToString(),
                })
                .ToList();

            return productListViewModel;
        }
    }
}
