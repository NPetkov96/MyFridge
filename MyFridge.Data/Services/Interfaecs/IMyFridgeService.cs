using MyFridge.Web.ProductsViewModels;

namespace MyFridge.Data.Services.Interfaecs
{
    public interface IMyFridgeService
    {
        Task<GetAllProductsViewModel> GetAllProducts();
    }
}
