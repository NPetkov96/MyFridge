using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyFridge.Data.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Categories = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequiredProducts = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingListsProducts",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingListsProducts", x => new { x.UserId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ShoppingListsProducts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingListsProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsersProducts",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersProducts", x => new { x.UserId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_UsersProducts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Categories", "IsDeleted", "Name", "Notes", "Quantity" },
                values: new object[,]
                {
                    { new Guid("0425a159-c244-4fd1-84dc-a27466892376"), 3, false, "Пилешко филе", "Пилешко филе без кожа и кости", 2.0 },
                    { new Guid("3c6c22e2-9e20-486b-84fb-35febc954f67"), 5, false, "Паста", "Пълнозърнеста паста", 3.0 },
                    { new Guid("4f2ee850-f944-454e-8c9f-6dc84a12ee0c"), 2, false, "Мляко", "Пълномаслено мляко", 2.0 },
                    { new Guid("50013858-40fe-441c-9933-d2ff24e8992c"), 10, false, "Сол", "Морска сол", 1.0 },
                    { new Guid("50a05479-945f-4838-8fac-449b1dd0d71e"), 10, false, "Кетчуп", "Био доматен кетчуп", 1.0 },
                    { new Guid("57286e97-0a7b-4225-a0f3-4499d58fac29"), 0, false, "Банан", "Узрели банани", 6.0 },
                    { new Guid("63fc94a1-d8e7-4eca-be83-ba4337d4d2f9"), 8, false, "Замразен грах", "Био замразен грах", 1.0 },
                    { new Guid("655a4401-0234-47cc-8ac2-90946669d963"), 2, false, "Сирене", "Блок чедър сирене", 1.0 },
                    { new Guid("7309db87-eefa-4a95-81ba-ad509f19d7c2"), 3, false, "Говежда кайма", "Кайма от нетлъсто говеждо", 1.0 },
                    { new Guid("7c8b4d13-e2b4-40a0-a020-0df92bfca497"), 6, false, "Портокалов сок", "100% пресен портокалов сок", 2.0 },
                    { new Guid("928d845f-e222-448e-b425-af700ff02d84"), 4, false, "Сьомга", "Свежо филе от атлантическа сьомга", 1.0 },
                    { new Guid("99cff922-cfad-4899-b3a8-bdefd6eac76d"), 7, false, "Шоколадов десерт", "Тъмен шоколад 70%", 2.0 },
                    { new Guid("b2b5408a-30fd-4023-bd09-ab64dc650cce"), 9, false, "Консервирана риба тон", "Риба тон в зехтин", 3.0 },
                    { new Guid("b83e5f54-f1c9-4731-a08a-975636eae8ce"), 2, false, "Масло", "Немаслено масло", 1.0 },
                    { new Guid("bd99667c-3aeb-40b9-9590-b53599a5c9f7"), 0, false, "Ябълка", "Свежи и сочни ябълки", 5.0 },
                    { new Guid("c8049172-15e5-4803-82e1-e924700a55e5"), 5, false, "Ориз", "Басмати ориз", 5.0 },
                    { new Guid("d4c31264-bba5-400c-97f8-559d779b091c"), 11, false, "Хляб", "Пълнозърнест хляб", 1.0 },
                    { new Guid("eb330b9e-fe2f-4e29-b87c-ee8ad6e86308"), 2, false, "Яйца", "Яйца от свободно отглеждани кокошки", 12.0 },
                    { new Guid("f4eb169a-5894-43b0-8427-acdaa4e0221e"), 1, false, "Броколи", "Свежи зелени броколи", 2.0 },
                    { new Guid("f63ecbf3-7089-4e53-9d82-49d0a0efb415"), 1, false, "Морков", "Био моркови", 10.0 }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Description", "Duration", "Name", "RequiredProducts" },
                values: new object[,]
                {
                    { new Guid("a6b62c13-d673-4d6f-92c9-9c0f253f7a4b"), "Свежа салата с домати, краставици, лук и настъргано сирене.", "15 минути", "Шопска салата", "[\"\\u0414\\u043E\\u043C\\u0430\\u0442\\u0438\",\"\\u041A\\u0440\\u0430\\u0441\\u0442\\u0430\\u0432\\u0438\\u0446\\u0438\",\"\\u0421\\u0438\\u0440\\u0435\\u043D\\u0435\",\"\\u041B\\u0443\\u043A\",\"\\u0417\\u0435\\u0445\\u0442\\u0438\\u043D\"]" },
                    { new Guid("a7d4e2b3-69f8-4c3a-b5d7-92c8e1f3a45b"), "Класическа италианска пица с домати, моцарела и босилек.", "35 минути", "Пица Маргарита", "[\"\\u0411\\u0440\\u0430\\u0448\\u043D\\u043E\",\"\\u0414\\u043E\\u043C\\u0430\\u0442\\u0438\",\"\\u041C\\u043E\\u0446\\u0430\\u0440\\u0435\\u043B\\u0430\",\"\\u0417\\u0435\\u0445\\u0442\\u0438\\u043D\",\"\\u0411\\u043E\\u0441\\u0438\\u043B\\u0435\\u043A\"]" },
                    { new Guid("b19a6c98-2a4b-4f3d-b7c5-89e8f93a21d7"), "Традиционно българско ястие с картофи и кайма.", "1 час", "Мусака", "[\"\\u041A\\u0430\\u0440\\u0442\\u043E\\u0444\\u0438\",\"\\u041A\\u0430\\u0439\\u043C\\u0430\",\"\\u0414\\u043E\\u043C\\u0430\\u0442\\u0438\",\"\\u041B\\u0443\\u043A\",\"\\u042F\\u0439\\u0446\\u0430\",\"\\u041A\\u0438\\u0441\\u0435\\u043B\\u043E \\u043C\\u043B\\u044F\\u043A\\u043E\"]" },
                    { new Guid("b9c2e7d5-4f6a-3a8b-95d1-f3c84e7a29b3"), "Пълнозърнеста лазаня с кайма, доматен сос и бешамел.", "1 час 15 минути", "Лазаня Болонезе", "[\"\\u041B\\u0430\\u0437\\u0430\\u043D\\u044F \\u043A\\u043E\\u0440\\u0438\",\"\\u041A\\u0430\\u0439\\u043C\\u0430\",\"\\u0414\\u043E\\u043C\\u0430\\u0442\\u0435\\u043D \\u0441\\u043E\\u0441\",\"\\u041C\\u043E\\u0446\\u0430\\u0440\\u0435\\u043B\\u0430\",\"\\u0411\\u0435\\u0448\\u0430\\u043C\\u0435\\u043B\"]" },
                    { new Guid("c2f8a1b3-62d5-4d4a-89f6-5a2b3c8d74e9"), "Класическо ястие с пиле, ориз и зеленчуци, изпечени във фурна.", "45 минути", "Пиле с ориз", "[\"\\u041F\\u0438\\u043B\\u0435\\u0448\\u043A\\u043E \\u043C\\u0435\\u0441\\u043E\",\"\\u041E\\u0440\\u0438\\u0437\",\"\\u0427\\u0443\\u0448\\u043A\\u0438\",\"\\u041C\\u043E\\u0440\\u043A\\u043E\\u0432\\u0438\",\"\\u041F\\u043E\\u0434\\u043F\\u0440\\u0430\\u0432\\u043A\\u0438\"]" },
                    { new Guid("c3e7d9b5-6a4f-8b2a-91d3-5c7a29f48e62"), "Кремообразен десерт с бисквитена основа и крем сирене.", "2 часа", "Чийзкейк", "[\"\\u0411\\u0438\\u0441\\u043A\\u0432\\u0438\\u0442\\u0438\",\"\\u041A\\u0440\\u0435\\u043C \\u0441\\u0438\\u0440\\u0435\\u043D\\u0435\",\"\\u0417\\u0430\\u0445\\u0430\\u0440\",\"\\u042F\\u0439\\u0446\\u0430\",\"\\u0412\\u0430\\u043D\\u0438\\u043B\\u0438\\u044F\"]" },
                    { new Guid("d2b5d3c1-5f5b-4a0b-9c3b-1b27c8a441f8"), "Класическа италианска рецепта със спагети, яйца, бекон и пармезан.", "30 минути", "Спагети Карбонара", "[\"\\u0421\\u043F\\u0430\\u0433\\u0435\\u0442\\u0438\",\"\\u042F\\u0439\\u0446\\u0430\",\"\\u0411\\u0435\\u043A\\u043E\\u043D\",\"\\u041F\\u0430\\u0440\\u043C\\u0435\\u0437\\u0430\\u043D\",\"\\u0427\\u0435\\u0440\\u0435\\u043D \\u043F\\u0438\\u043F\\u0435\\u0440\"]" },
                    { new Guid("d8f4b2a6-79e3-4c5a-98d1-b3c7a5e29f48"), "Мексикански сос с авокадо, лайм и зеленчуци.", "10 минути", "Гуакамоле", "[\"\\u0410\\u0432\\u043E\\u043A\\u0430\\u0434\\u043E\",\"\\u041B\\u0430\\u0439\\u043C\",\"\\u041B\\u0443\\u043A\",\"\\u0427\\u0435\\u0441\\u044A\\u043D\",\"\\u0414\\u043E\\u043C\\u0430\\u0442\\u0438\"]" },
                    { new Guid("e3d7b8c2-49f5-4a6b-98a1-b3c8d62e5f47"), "Прясна сьомга, приготвена на скара с лимон и подправки.", "30 минути", "Риба на скара", "[\"\\u0421\\u044C\\u043E\\u043C\\u0433\\u0430\",\"\\u041B\\u0438\\u043C\\u043E\\u043D\",\"\\u0417\\u0435\\u0445\\u0442\\u0438\\u043D\",\"\\u0421\\u043E\\u043B\",\"\\u0427\\u0435\\u0441\\u044A\\u043D\"]" },
                    { new Guid("f2b3c7e9-4d6a-5a8b-91d4-3c7a5e29f68b"), "Освежаваща напитка с лимони, мента и мед.", "15 минути", "Домашна лимонада", "[\"\\u041B\\u0438\\u043C\\u043E\\u043D\\u0438\",\"\\u0412\\u043E\\u0434\\u0430\",\"\\u041C\\u0435\\u0434\",\"\\u041C\\u0435\\u043D\\u0442\\u0430\",\"\\u041B\\u0435\\u0434\"]" },
                    { new Guid("f4a9c7b2-5d4e-4f3a-89b6-2c8d5a7e93f1"), "Българска баница със сирене и яйца, изпечена със златиста коричка.", "50 минути", "Баница", "[\"\\u042F\\u0439\\u0446\\u0430\",\"\\u0421\\u0438\\u0440\\u0435\\u043D\\u0435\",\"\\u041A\\u043E\\u0440\\u0438 \\u0437\\u0430 \\u0431\\u0430\\u043D\\u0438\\u0446\\u0430\",\"\\u041C\\u0430\\u0441\\u043B\\u043E\",\"\\u0421\\u043E\\u0434\\u0430 \\u0431\\u0438\\u043A\\u0430\\u0440\\u0431\\u043E\\u043D\\u0430\\u0442\"]" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingListsProducts_ProductId",
                table: "ShoppingListsProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersProducts_ProductId",
                table: "UsersProducts",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "ShoppingListsProducts");

            migrationBuilder.DropTable(
                name: "UsersProducts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
