using Microsoft.EntityFrameworkCore;
using MyFridge.Common.Enums;
using MyFridge.Data.Models;
using MyFridge.Data.Repository.Interfaces;
using MyFridge.Data.Services.Interfaces;
using MyFridge.Web.ProductsViewModels;

namespace MyFridge.Data.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product, Guid> _productRepository;

        public ProductService(IRepository<Product, Guid> productRepository)
        {
            this._productRepository = productRepository;
        }

        public async Task AddProductAsync(AddProductViewModel model)
        {
            Guid newId = Guid.NewGuid();
            var product = new Product()
            {
                Id = newId,
                Name = model.Name,
                Categories = (ProductsCategories)Enum.Parse(typeof(ProductsCategories), model.Category),
            };

            await _productRepository.AddAsync(product);
        }

        public async Task DeleteProduct(Guid productId)
        {
            var product = await _productRepository.GetByIdAsync(productId);
            await _productRepository.DeleteAsync(product);
        }

        public async Task<IEnumerable<ShowProductsViewModel>> GetAllProductsAsync(Guid userId)
        {
            var products = await _productRepository
                .GetAllAttached()
                .ToListAsync();

            var viewMoldeProducts = products
                .Select(p => new ShowProductsViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Category = p.Categories.ToString(),
                })
                .OrderBy(p => p.Name)
                .ToList();

            return viewMoldeProducts;
        }
    }
}
