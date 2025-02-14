using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyFridge.Data.Migrations
{
    /// <inheritdoc />
    public partial class Inittial : Migration
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
                columns: new[] { "Id", "Duration", "Name", "RequiredProducts" },
                values: new object[,]
                {
                    { new Guid("a6b62c13-d673-4d6f-92c9-9c0f253f7a4b"), "15 минути", "Шопска салата", "[\"\\u0414\\u043E\\u043C\\u0430\\u0442\\u0438\",\"\\u041A\\u0440\\u0430\\u0441\\u0442\\u0430\\u0432\\u0438\\u0446\\u0438\",\"\\u0421\\u0438\\u0440\\u0435\\u043D\\u0435\",\"\\u041B\\u0443\\u043A\",\"\\u0417\\u0435\\u0445\\u0442\\u0438\\u043D\"]" },
                    { new Guid("d2b5d3c1-5f5b-4a0b-9c3b-1b27c8a441f8"), "30 минути", "Спагети Карбонара", "[\"\\u0421\\u043F\\u0430\\u0433\\u0435\\u0442\\u0438\",\"\\u042F\\u0439\\u0446\\u0430\",\"\\u0411\\u0435\\u043A\\u043E\\u043D\",\"\\u041F\\u0430\\u0440\\u043C\\u0435\\u0437\\u0430\\u043D\",\"\\u0427\\u0435\\u0440\\u0435\\u043D \\u043F\\u0438\\u043F\\u0435\\u0440\"]" }
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
