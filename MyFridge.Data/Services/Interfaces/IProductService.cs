using MyFridge.Web.ProductsViewModels;

namespace MyFridge.Data.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ShowProductsViewModel>> GetAllProductsAsync(Guid userId);
        Task AddProductAsync(AddProductViewModel model, Guid userId);
        Task DeleteProduct(Guid productId);
    }
}
