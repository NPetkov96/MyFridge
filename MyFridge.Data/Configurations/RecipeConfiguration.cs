using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyFridge.Data.Models;

namespace MyFridge.Data.Configurations
{
    public class RecipeConfiguration : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Name).IsRequired().HasMaxLength(100);
            builder.Property(r => r.Duration).IsRequired().HasMaxLength(50);

            builder.Property<string>("_requiredProducts")
                   .HasColumnName("RequiredProducts")
                   .HasColumnType("nvarchar(max)");

            builder.HasData(
                new Recipe
                {
                    Id = Guid.Parse("d2b5d3c1-5f5b-4a0b-9c3b-1b27c8a441f8"),
                    Name = "Спагети Карбонара",
                    Duration = "30 минути",
                    RequiredProducts = new List<string> { "Спагети", "Яйца", "Бекон", "Пармезан", "Черен пипер" }
                },
                new Recipe
                {
                    Id = Guid.Parse("a6b62c13-d673-4d6f-92c9-9c0f253f7a4b"),
                    Name = "Шопска салата",
                    Duration = "15 минути",
                    RequiredProducts = new List<string> { "Домати", "Краставици", "Сирене", "Лук", "Зехтин" }
                });
        }
    }
}
