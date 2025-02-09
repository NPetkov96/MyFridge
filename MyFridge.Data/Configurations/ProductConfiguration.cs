using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyFridge.Common.Enums;
using MyFridge.Data.Models;

namespace MyFridge.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
               new Product { Id = Guid.Parse("bd99667c-3aeb-40b9-9590-b53599a5c9f7"), Name = "Apple", Quantity = 5, Categories = ProductsCategories.Fruit, Notes = "Fresh and juicy apples" },
                new Product { Id = Guid.Parse("57286e97-0a7b-4225-a0f3-4499d58fac29"), Name = "Banana", Quantity = 6, Categories = ProductsCategories.Fruit, Notes = "Ripe bananas" },
                new Product { Id = Guid.Parse("f63ecbf3-7089-4e53-9d82-49d0a0efb415"), Name = "Carrot", Quantity = 10, Categories = ProductsCategories.Vegetables, Notes = "Organic carrots" },
                new Product { Id = Guid.Parse("f4eb169a-5894-43b0-8427-acdaa4e0221e"), Name = "Broccoli", Quantity = 2, Categories = ProductsCategories.Vegetables, Notes = "Fresh green broccoli" },
                new Product { Id = Guid.Parse("4f2ee850-f944-454e-8c9f-6dc84a12ee0c"), Name = "Milk", Quantity = 2, Categories = ProductsCategories.Dairy, Notes = "Full-fat milk" },
                new Product { Id = Guid.Parse("655a4401-0234-47cc-8ac2-90946669d963"), Name = "Cheese", Quantity = 1, Categories = ProductsCategories.Dairy, Notes = "Cheddar cheese block" },
                new Product { Id = Guid.Parse("0425a159-c244-4fd1-84dc-a27466892376"), Name = "Chicken Breast", Quantity = 2, Categories = ProductsCategories.Meat, Notes = "Boneless skinless chicken breast" },
                new Product { Id = Guid.Parse("7309db87-eefa-4a95-81ba-ad509f19d7c2"), Name = "Ground Beef", Quantity = 1, Categories = ProductsCategories.Meat, Notes = "Lean ground beef" },
                new Product { Id = Guid.Parse("928d845f-e222-448e-b425-af700ff02d84"), Name = "Salmon", Quantity = 1, Categories = ProductsCategories.Fish, Notes = "Fresh Atlantic salmon fillet" },
                new Product { Id = Guid.Parse("c8049172-15e5-4803-82e1-e924700a55e5"), Name = "Rice", Quantity = 5, Categories = ProductsCategories.Grains, Notes = "Basmati rice" },
                new Product { Id = Guid.Parse("3c6c22e2-9e20-486b-84fb-35febc954f67"), Name = "Pasta", Quantity = 3, Categories = ProductsCategories.Grains, Notes = "Whole wheat pasta" },
                new Product { Id = Guid.Parse("7c8b4d13-e2b4-40a0-a020-0df92bfca497"), Name = "Orange Juice", Quantity = 2, Categories = ProductsCategories.Beverages, Notes = "100% fresh orange juice" },
                new Product { Id = Guid.Parse("99cff922-cfad-4899-b3a8-bdefd6eac76d"), Name = "Chocolate Bar", Quantity = 2, Categories = ProductsCategories.Snacks, Notes = "Dark chocolate 70%" },
                new Product { Id = Guid.Parse("63fc94a1-d8e7-4eca-be83-ba4337d4d2f9"), Name = "Frozen Peas", Quantity = 1, Categories = ProductsCategories.Frozen, Notes = "Organic frozen peas" },
                new Product { Id = Guid.Parse("b2b5408a-30fd-4023-bd09-ab64dc650cce"), Name = "Canned Tuna", Quantity = 3, Categories = ProductsCategories.Canned, Notes = "Tuna in olive oil" },
                new Product { Id = Guid.Parse("50013858-40fe-441c-9933-d2ff24e8992c"), Name = "Salt", Quantity = 1, Categories = ProductsCategories.Spices, Notes = "Sea salt" },
                new Product { Id = Guid.Parse("50a05479-945f-4838-8fac-449b1dd0d71e"), Name = "Ketchup", Quantity = 1, Categories = ProductsCategories.Condiments, Notes = "Organic tomato ketchup" },
                new Product { Id = Guid.Parse("d4c31264-bba5-400c-97f8-559d779b091c"), Name = "Bread", Quantity = 1, Categories = ProductsCategories.Bakery, Notes = "Whole grain bread" },
                new Product { Id = Guid.Parse("eb330b9e-fe2f-4e29-b87c-ee8ad6e86308"), Name = "Eggs", Quantity = 12, Categories = ProductsCategories.Dairy, Notes = "Free-range eggs" },
                new Product { Id = Guid.Parse("b83e5f54-f1c9-4731-a08a-975636eae8ce"), Name = "Butter", Quantity = 1, Categories = ProductsCategories.Dairy, Notes = "Unsalted butter" });
        }
    }
}