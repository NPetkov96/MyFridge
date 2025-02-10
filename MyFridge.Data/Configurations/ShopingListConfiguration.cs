using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyFridge.Data.Models;

namespace MyFridge.Data.Configurations
{
    public class ShoppingListConfiguration : IEntityTypeConfiguration<ShoppingList>
    {
        public void Configure(EntityTypeBuilder<ShoppingList> builder)
        {
            builder
                .HasIndex(sl => sl.UserId)
                .IsUnique();
        }
    }
}
