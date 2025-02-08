using MyFridge.Web.ProductsViewModels;

namespace MyFridge.Data.Services.Interfaces
{
    public interface IMyFridgeService
    {
        Task<IEnumerable<AllProductsViewModel>> GetAllProductsAsync();
    }
}
