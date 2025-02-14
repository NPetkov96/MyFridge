using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyFridge.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedRecipes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Duration", "Name", "RequiredProducts" },
                values: new object[,]
                {
                    { new Guid("a7d4e2b3-69f8-4c3a-b5d7-92c8e1f3a45b"), "35 минути", "Пица Маргарита", "[\"\\u0411\\u0440\\u0430\\u0448\\u043D\\u043E\",\"\\u0414\\u043E\\u043C\\u0430\\u0442\\u0438\",\"\\u041C\\u043E\\u0446\\u0430\\u0440\\u0435\\u043B\\u0430\",\"\\u0417\\u0435\\u0445\\u0442\\u0438\\u043D\",\"\\u0411\\u043E\\u0441\\u0438\\u043B\\u0435\\u043A\"]" },
                    { new Guid("b19a6c98-2a4b-4f3d-b7c5-89e8f93a21d7"), "1 час", "Мусака", "[\"\\u041A\\u0430\\u0440\\u0442\\u043E\\u0444\\u0438\",\"\\u041A\\u0430\\u0439\\u043C\\u0430\",\"\\u0414\\u043E\\u043C\\u0430\\u0442\\u0438\",\"\\u041B\\u0443\\u043A\",\"\\u042F\\u0439\\u0446\\u0430\",\"\\u041A\\u0438\\u0441\\u0435\\u043B\\u043E \\u043C\\u043B\\u044F\\u043A\\u043E\"]" },
                    { new Guid("b9c2e7d5-4f6a-3a8b-95d1-f3c84e7a29b3"), "1 час 15 минути", "Лазаня Болонезе", "[\"\\u041B\\u0430\\u0437\\u0430\\u043D\\u044F \\u043A\\u043E\\u0440\\u0438\",\"\\u041A\\u0430\\u0439\\u043C\\u0430\",\"\\u0414\\u043E\\u043C\\u0430\\u0442\\u0435\\u043D \\u0441\\u043E\\u0441\",\"\\u041C\\u043E\\u0446\\u0430\\u0440\\u0435\\u043B\\u0430\",\"\\u0411\\u0435\\u0448\\u0430\\u043C\\u0435\\u043B\"]" },
                    { new Guid("c2f8a1b3-62d5-4d4a-89f6-5a2b3c8d74e9"), "45 минути", "Пиле с ориз", "[\"\\u041F\\u0438\\u043B\\u0435\\u0448\\u043A\\u043E \\u043C\\u0435\\u0441\\u043E\",\"\\u041E\\u0440\\u0438\\u0437\",\"\\u0427\\u0443\\u0448\\u043A\\u0438\",\"\\u041C\\u043E\\u0440\\u043A\\u043E\\u0432\\u0438\",\"\\u041F\\u043E\\u0434\\u043F\\u0440\\u0430\\u0432\\u043A\\u0438\"]" },
                    { new Guid("c3e7d9b5-6a4f-8b2a-91d3-5c7a29f48e62"), "2 часа", "Чийзкейк", "[\"\\u0411\\u0438\\u0441\\u043A\\u0432\\u0438\\u0442\\u0438\",\"\\u041A\\u0440\\u0435\\u043C \\u0441\\u0438\\u0440\\u0435\\u043D\\u0435\",\"\\u0417\\u0430\\u0445\\u0430\\u0440\",\"\\u042F\\u0439\\u0446\\u0430\",\"\\u0412\\u0430\\u043D\\u0438\\u043B\\u0438\\u044F\"]" },
                    { new Guid("d8f4b2a6-79e3-4c5a-98d1-b3c7a5e29f48"), "10 минути", "Гуакамоле", "[\"\\u0410\\u0432\\u043E\\u043A\\u0430\\u0434\\u043E\",\"\\u041B\\u0430\\u0439\\u043C\",\"\\u041B\\u0443\\u043A\",\"\\u0427\\u0435\\u0441\\u044A\\u043D\",\"\\u0414\\u043E\\u043C\\u0430\\u0442\\u0438\"]" },
                    { new Guid("e3d7b8c2-49f5-4a6b-98a1-b3c8d62e5f47"), "30 минути", "Риба на скара", "[\"\\u0421\\u044C\\u043E\\u043C\\u0433\\u0430\",\"\\u041B\\u0438\\u043C\\u043E\\u043D\",\"\\u0417\\u0435\\u0445\\u0442\\u0438\\u043D\",\"\\u0421\\u043E\\u043B\",\"\\u0427\\u0435\\u0441\\u044A\\u043D\"]" },
                    { new Guid("f2b3c7e9-4d6a-5a8b-91d4-3c7a5e29f68b"), "15 минути", "Домашна лимонада", "[\"\\u041B\\u0438\\u043C\\u043E\\u043D\\u0438\",\"\\u0412\\u043E\\u0434\\u0430\",\"\\u041C\\u0435\\u0434\",\"\\u041C\\u0435\\u043D\\u0442\\u0430\",\"\\u041B\\u0435\\u0434\"]" },
                    { new Guid("f4a9c7b2-5d4e-4f3a-89b6-2c8d5a7e93f1"), "50 минути", "Баница", "[\"\\u042F\\u0439\\u0446\\u0430\",\"\\u0421\\u0438\\u0440\\u0435\\u043D\\u0435\",\"\\u041A\\u043E\\u0440\\u0438 \\u0437\\u0430 \\u0431\\u0430\\u043D\\u0438\\u0446\\u0430\",\"\\u041C\\u0430\\u0441\\u043B\\u043E\",\"\\u0421\\u043E\\u0434\\u0430 \\u0431\\u0438\\u043A\\u0430\\u0440\\u0431\\u043E\\u043D\\u0430\\u0442\"]" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("a7d4e2b3-69f8-4c3a-b5d7-92c8e1f3a45b"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("b19a6c98-2a4b-4f3d-b7c5-89e8f93a21d7"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("b9c2e7d5-4f6a-3a8b-95d1-f3c84e7a29b3"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c2f8a1b3-62d5-4d4a-89f6-5a2b3c8d74e9"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c3e7d9b5-6a4f-8b2a-91d3-5c7a29f48e62"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("d8f4b2a6-79e3-4c5a-98d1-b3c7a5e29f48"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("e3d7b8c2-49f5-4a6b-98a1-b3c8d62e5f47"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("f2b3c7e9-4d6a-5a8b-91d4-3c7a5e29f68b"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("f4a9c7b2-5d4e-4f3a-89b6-2c8d5a7e93f1"));
        }
    }
}
