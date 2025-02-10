using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFridge.Data.Models
{
    public class ShoppingListProducts
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(ShoppingList))]
        public Guid ShoppingListId { get; set; }
        public ShoppingList ShoppingList { get; set; } = null!;

        [ForeignKey(nameof(Product))]
        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
