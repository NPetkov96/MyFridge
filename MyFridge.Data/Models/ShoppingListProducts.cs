using System.ComponentModel.DataAnnotations;

namespace MyFridge.Data.Models
{
    public class ShoppingListProducts
    {
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;

        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
