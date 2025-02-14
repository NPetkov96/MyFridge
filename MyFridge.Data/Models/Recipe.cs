using System.ComponentModel.DataAnnotations;

namespace MyFridge.Data.Models
{
    public class Recipe
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Duration { get; set; }
    }
}
