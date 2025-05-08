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
                    Description = "Класическа италианска рецепта със спагети, яйца, бекон и пармезан.",
                    RequiredProducts = new List<string> { "Спагети", "Яйца", "Бекон", "Пармезан", "Черен пипер" }
                },
                new Recipe
                {
                    Id = Guid.Parse("a6b62c13-d673-4d6f-92c9-9c0f253f7a4b"),
                    Name = "Шопска салата",
                    Duration = "15 минути",
                    Description = "Свежа салата с домати, краставици, лук и настъргано сирене.",
                    RequiredProducts = new List<string> { "Домати", "Краставици", "Сирене", "Лук", "Зехтин" }
                },
                new Recipe
                {
                    Id = Guid.Parse("b19a6c98-2a4b-4f3d-b7c5-89e8f93a21d7"),
                    Name = "Мусака",
                    Duration = "1 час",
                    Description = "Традиционно българско ястие с картофи и кайма.",
                    RequiredProducts = new List<string> { "Картофи", "Кайма", "Домати", "Лук", "Яйца", "Кисело мляко" }
                },
                new Recipe
                {
                    Id = Guid.Parse("c2f8a1b3-62d5-4d4a-89f6-5a2b3c8d74e9"),
                    Name = "Пиле с ориз",
                    Duration = "45 минути",
                    Description = "Класическо ястие с пиле, ориз и зеленчуци, изпечени във фурна.",
                    RequiredProducts = new List<string> { "Пилешко месо", "Ориз", "Чушки", "Моркови", "Подправки" }
                },
                new Recipe
                {
                    Id = Guid.Parse("e3d7b8c2-49f5-4a6b-98a1-b3c8d62e5f47"),
                    Name = "Риба на скара",
                    Duration = "30 минути",
                    Description = "Прясна сьомга, приготвена на скара с лимон и подправки.",
                    RequiredProducts = new List<string> { "Сьомга", "Лимон", "Зехтин", "Сол", "Чесън" }
                },
                new Recipe
                {
                    Id = Guid.Parse("f4a9c7b2-5d4e-4f3a-89b6-2c8d5a7e93f1"),
                    Name = "Баница",
                    Duration = "50 минути",
                    Description = "Българска баница със сирене и яйца, изпечена със златиста коричка.",
                    RequiredProducts = new List<string> { "Яйца", "Сирене", "Кори за баница", "Масло", "Сода бикарбонат" }
                },
                new Recipe
                {
                    Id = Guid.Parse("a7d4e2b3-69f8-4c3a-b5d7-92c8e1f3a45b"),
                    Name = "Пица Маргарита",
                    Duration = "35 минути",
                    Description = "Класическа италианска пица с домати, моцарела и босилек.",
                    RequiredProducts = new List<string> { "Брашно", "Домати", "Моцарела", "Зехтин", "Босилек" }
                },
                new Recipe
                {
                    Id = Guid.Parse("b9c2e7d5-4f6a-3a8b-95d1-f3c84e7a29b3"),
                    Name = "Лазаня Болонезе",
                    Duration = "1 час 15 минути",
                    Description = "Пълнозърнеста лазаня с кайма, доматен сос и бешамел.",
                    RequiredProducts = new List<string> { "Лазаня кори", "Кайма", "Доматен сос", "Моцарела", "Бешамел" }
                },
                new Recipe
                {
                    Id = Guid.Parse("d8f4b2a6-79e3-4c5a-98d1-b3c7a5e29f48"),
                    Name = "Гуакамоле",
                    Duration = "10 минути",
                    Description = "Мексикански сос с авокадо, лайм и зеленчуци.",
                    RequiredProducts = new List<string> { "Авокадо", "Лайм", "Лук", "Чесън", "Домати" }
                },
                new Recipe
                {
                    Id = Guid.Parse("c3e7d9b5-6a4f-8b2a-91d3-5c7a29f48e62"),
                    Name = "Чийзкейк",
                    Duration = "2 часа",
                    Description = "Кремообразен десерт с бисквитена основа и крем сирене.",
                    RequiredProducts = new List<string> { "Бисквити", "Крем сирене", "Захар", "Яйца", "Ванилия" }
                },
                new Recipe
                {
                    Id = Guid.Parse("f2b3c7e9-4d6a-5a8b-91d4-3c7a5e29f68b"),
                    Name = "Домашна лимонада",
                    Duration = "15 минути",
                    Description = "Освежаваща напитка с лимони, мента и мед.",
                    RequiredProducts = new List<string> { "Лимони", "Вода", "Мед", "Мента", "Лед" }
                });
        }
    }
}
