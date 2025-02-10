using Microsoft.AspNetCore.Identity;

namespace MyFridge.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ICollection<UserProduct> UserProducts { get; set; } = new List<UserProduct>();
        public ICollection<ShoppingListProducts> ShoppingListProducts { get; set; } = new List<ShoppingListProducts>();

    }
}
