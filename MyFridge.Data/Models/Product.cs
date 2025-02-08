using System.ComponentModel.DataAnnotations;
using MyFridge.Common.Enums;

namespace MyFridge.Data.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public double Quantity { get; set; }

        public string? Notes { get; set; }

        [Required]
        public ProductsCategories Categories { get; set; }

        public bool IsDeleted { get; set; } = false;

        public List<UserProduct> UserProducts { get; set; } = new List<UserProduct>();

    }
}
