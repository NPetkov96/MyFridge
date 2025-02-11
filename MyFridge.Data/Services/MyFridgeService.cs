using Microsoft.EntityFrameworkCore;
using MyFridge.Data.Models;
using MyFridge.Data.Repository.Interfaces;
using MyFridge.Data.Services.Interfaces;
using MyFridge.Web.ProductsViewModels;

namespace MyFridge.Data.Services
{
    public class MyFridgeService : IMyFridgeService
    {
        private readonly IRepository<Product, Guid> _productRepository;
        private readonly IRepository<UserProduct, Guid> _userProductRepository;

        public MyFridgeService(IRepository<Product, Guid> productRepository, IRepository<UserProduct, Guid> userProductRepository)
        {
            this._productRepository = productRepository;
            this._userProductRepository = userProductRepository;
        }

        public async Task AddProductAsync(Guid productId, Guid userId)
        {
            var userProdcut = new UserProduct()
            {
                ProductId = productId,
                UserId = userId
            };

            await _userProductRepository.AddAsync(userProdcut);
        }

        public async Task DeleteProductAsync(Guid procutId, Guid userId)
        {
            var userProduct = await _userProductRepository.FirstOrDefaultAsync(p => p.ProductId == procutId && p.UserId == userId);

            await _userProductRepository.DeleteAsync(userProduct);
        }

        public async Task<IEnumerable<ShowProductsViewModel>> GetAllProductsAsync(Guid userId)
        {
            var products = await _productRepository
                .GetAllAttached()
                .Include(p => p.UserProducts)
                .Where(p => p.UserProducts.Any(u => u.UserId == userId))
                .ToListAsync();

            var viewModelProducts = products
                .Select(p => new ShowProductsViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Category = p.Categories.ToString(),
                })
                .ToList();

            return viewModelProducts;
        }
    }
}
