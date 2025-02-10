using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyFridge.Data.Configurations;
using MyFridge.Data.Models;

namespace MyFridge.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<UserProduct> UsersProducts { get; set; } = null!;
        public DbSet<ShoppingListProducts> ShoppingListsProducts { get; set; } = null!;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .ApplyConfiguration(new ShoppingListConfiguration())
                .ApplyConfiguration(new ProductConfiguration())
                .ApplyConfiguration(new UserProductConfiguration());
        }

    }
}
