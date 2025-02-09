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

        public async Task AddProductAsync(AddProductViewModel model, Guid userId)
        {
            Guid newId = Guid.NewGuid();
            var product = new Product()
            {
                Id = newId,
                Name = model.Name,
                Categories = (ProductsCategories)Enum.Parse(typeof(ProductsCategories), model.Category),
                UserProducts = new List<UserProduct>
                {
                    new UserProduct()
                    {
                        ProductId = newId,
                        UserId = userId
                    }
                }
            };

            await _productRepository.AddAsync(product);
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
                    Name = p.Name,
                    Category = p.Categories.ToString(),
                })
                .ToList();

            return viewMoldeProducts;
        }
    }
}
