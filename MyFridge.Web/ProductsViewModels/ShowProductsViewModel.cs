namespace MyFridge.Web.ProductsViewModels
{
    public class ShowProductsViewModel
    {
        public string Name { get; set; } = null!;

        public string Category { get; set; }

        public Guid UserId { get; set; }
    }
}
