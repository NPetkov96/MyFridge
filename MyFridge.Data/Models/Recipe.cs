using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace MyFridge.Data.Models
{
    public class Recipe
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Duration { get; set; }

        [NotMapped] // Казваме на EF Core да не създава директно List<string> в базата
        public List<string> RequiredProducts
        {
            get => _requiredProducts == null ? new List<string>() : JsonSerializer.Deserialize<List<string>>(_requiredProducts)!;
            set => _requiredProducts = JsonSerializer.Serialize(value);
        }

        private string? _requiredProducts;
    }
}
