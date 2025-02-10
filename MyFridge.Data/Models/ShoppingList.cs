using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFridge.Data.Models
{
    public class ShoppingList
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        public ApplicationUser User { get; set; } = null!;

        public ICollection<ShoppingListProducts> ShoppingListProducts { get; set; } = new List<ShoppingListProducts>();
    }
}
