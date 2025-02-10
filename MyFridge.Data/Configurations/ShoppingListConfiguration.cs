using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyFridge.Data.Models;

namespace MyFridge.Data.Configurations
{
    public class ShoppingListConfiguration : IEntityTypeConfiguration<ShoppingListProducts>
    {
        public void Configure(EntityTypeBuilder<ShoppingListProducts> builder)
        {
            builder.HasKey(sl => new { sl.UserId, sl.ProductId });

            builder.HasOne(sl => sl.User)
                .WithMany(u => u.ShoppingListProducts)
                .HasForeignKey(sl => sl.UserId);

            builder.HasOne(sl => sl.Product)
                .WithMany(p => p.ShoppingListProducts)
                .HasForeignKey(sl => sl.ProductId);
        }
    }
}
