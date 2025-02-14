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

            // Уникалност на името на рецептата
            builder.HasIndex(r => r.Name).IsUnique();

            // Определяне на максимална дължина на Name
            builder.Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(r => r.Duration)
                .IsRequired();

        }
    }
}
