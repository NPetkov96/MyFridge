using MyFridge.Web.ProductsViewModels;

namespace MyFridge.Data.Services.Interfaces
{
    public interface IMyFridgeService
    {
        Task<IEnumerable<ShowProductsViewModel>> GetAllProductsAsync(Guid userId);
        Task AddProductAsync(Guid productId, Guid userId);
        Task DeleteProductAsync(Guid procutId, Guid userId);
    }
}
