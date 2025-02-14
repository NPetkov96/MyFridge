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
                new Product { Id = Guid.Parse("bd99667c-3aeb-40b9-9590-b53599a5c9f7"), Name = "Ябълка", Quantity = 5, Categories = ProductsCategories.Плодове, Notes = "Свежи и сочни ябълки" },
                new Product { Id = Guid.Parse("57286e97-0a7b-4225-a0f3-4499d58fac29"), Name = "Банан", Quantity = 6, Categories = ProductsCategories.Плодове, Notes = "Узрели банани" },
                new Product { Id = Guid.Parse("f63ecbf3-7089-4e53-9d82-49d0a0efb415"), Name = "Морков", Quantity = 10, Categories = ProductsCategories.Зеленчуци, Notes = "Био моркови" },
                new Product { Id = Guid.Parse("f4eb169a-5894-43b0-8427-acdaa4e0221e"), Name = "Броколи", Quantity = 2, Categories = ProductsCategories.Зеленчуци, Notes = "Свежи зелени броколи" },
                new Product { Id = Guid.Parse("4f2ee850-f944-454e-8c9f-6dc84a12ee0c"), Name = "Мляко", Quantity = 2, Categories = ProductsCategories.Млечни, Notes = "Пълномаслено мляко" },
                new Product { Id = Guid.Parse("655a4401-0234-47cc-8ac2-90946669d963"), Name = "Сирене", Quantity = 1, Categories = ProductsCategories.Млечни, Notes = "Блок чедър сирене" },
                new Product { Id = Guid.Parse("0425a159-c244-4fd1-84dc-a27466892376"), Name = "Пилешко филе", Quantity = 2, Categories = ProductsCategories.Месо, Notes = "Пилешко филе без кожа и кости" },
                new Product { Id = Guid.Parse("7309db87-eefa-4a95-81ba-ad509f19d7c2"), Name = "Говежда кайма", Quantity = 1, Categories = ProductsCategories.Месо, Notes = "Кайма от нетлъсто говеждо" },
                new Product { Id = Guid.Parse("928d845f-e222-448e-b425-af700ff02d84"), Name = "Сьомга", Quantity = 1, Categories = ProductsCategories.Риба, Notes = "Свежо филе от атлантическа сьомга" },
                new Product { Id = Guid.Parse("c8049172-15e5-4803-82e1-e924700a55e5"), Name = "Ориз", Quantity = 5, Categories = ProductsCategories.Зърна, Notes = "Басмати ориз" },
                new Product { Id = Guid.Parse("3c6c22e2-9e20-486b-84fb-35febc954f67"), Name = "Паста", Quantity = 3, Categories = ProductsCategories.Зърна, Notes = "Пълнозърнеста паста" },
                new Product { Id = Guid.Parse("7c8b4d13-e2b4-40a0-a020-0df92bfca497"), Name = "Портокалов сок", Quantity = 2, Categories = ProductsCategories.Напитки, Notes = "100% пресен портокалов сок" },
                new Product { Id = Guid.Parse("99cff922-cfad-4899-b3a8-bdefd6eac76d"), Name = "Шоколадов десерт", Quantity = 2, Categories = ProductsCategories.Закуски, Notes = "Тъмен шоколад 70%" },
                new Product { Id = Guid.Parse("63fc94a1-d8e7-4eca-be83-ba4337d4d2f9"), Name = "Замразен грах", Quantity = 1, Categories = ProductsCategories.Замразени, Notes = "Био замразен грах" },
                new Product { Id = Guid.Parse("b2b5408a-30fd-4023-bd09-ab64dc650cce"), Name = "Консервирана риба тон", Quantity = 3, Categories = ProductsCategories.Консерви, Notes = "Риба тон в зехтин" },
                new Product { Id = Guid.Parse("50013858-40fe-441c-9933-d2ff24e8992c"), Name = "Сол", Quantity = 1, Categories = ProductsCategories.Подправки, Notes = "Морска сол" },
                new Product { Id = Guid.Parse("50a05479-945f-4838-8fac-449b1dd0d71e"), Name = "Кетчуп", Quantity = 1, Categories = ProductsCategories.Подправки, Notes = "Био доматен кетчуп" },
                new Product { Id = Guid.Parse("d4c31264-bba5-400c-97f8-559d779b091c"), Name = "Хляб", Quantity = 1, Categories = ProductsCategories.Пекарна, Notes = "Пълнозърнест хляб" },
                new Product { Id = Guid.Parse("eb330b9e-fe2f-4e29-b87c-ee8ad6e86308"), Name = "Яйца", Quantity = 12, Categories = ProductsCategories.Млечни, Notes = "Яйца от свободно отглеждани кокошки" },
                new Product { Id = Guid.Parse("b83e5f54-f1c9-4731-a08a-975636eae8ce"), Name = "Масло", Quantity = 1, Categories = ProductsCategories.Млечни, Notes = "Немаслено масло" });
        }
    }
}