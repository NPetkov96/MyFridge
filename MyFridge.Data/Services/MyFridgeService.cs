using MyFridge.Data.Services.Interfaecs;
using MyFridge.Web.ProductsViewModels;

namespace MyFridge.Data.Services
{
    public class MyFridgeService : IMyFridgeService
    {
        public Task<GetAllProductsViewModel> GetAllProducts()
        {
            throw new NotImplementedException();
        }
    }
}
