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

        public MyFridgeService(IRepository<Product, Guid> productRepository)
        {
            this._productRepository = productRepository;
        }

        public async Task<IEnumerable<AllProductsViewModel>> GetAllProductsAsync()
        {
            var products = await _productRepository
                .GetAllAttached()
                .ToListAsync();

            var viewMoldeProducts = products
                .Select(p => new AllProductsViewModel
                {
                    Name = p.Name,
                    Category = p.Categories.ToString(),
                })
                .ToList();

            return viewMoldeProducts;
        }

    }
}
