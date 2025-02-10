using Microsoft.EntityFrameworkCore;
using MyFridge.Common.Enums;
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
            //var product = await _productRepository.FirstOrDefaultAsync(p => p.Id == productId);
            //product.UserProducts = new List<UserProduct>
            //{
            //   new UserProduct()
            //   {
            //       ProductId = product.Id,
            //       UserId = userId
            //   }
            //};

            var userProdcut = new UserProduct()
            {
                ProductId = productId,
                UserId = userId
            };

            await _userProductRepository.AddAsync(userProdcut);
        }

        public async Task<IEnumerable<ShowProductsViewModel>> GetAllProductsAsync(Guid userId)
        {
            var products = await _productRepository
                .GetAllAttached()
                .Include(p => p.UserProducts)
                .Where(p => p.UserProducts.Any(u => u.UserId == userId))
                .ToListAsync();

            var viewMoldeProducts = products
                .Select(p => new ShowProductsViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Category = p.Categories.ToString(),
                })
                .ToList();

            return viewMoldeProducts;
        }
    }
}
