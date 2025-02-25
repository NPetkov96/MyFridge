﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyFridge.Data;

#nullable disable

namespace MyFridge.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250214130330_Inittial")]
    partial class Inittial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MyFridge.Data.Models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("MyFridge.Data.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Categories")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bd99667c-3aeb-40b9-9590-b53599a5c9f7"),
                            Categories = 0,
                            IsDeleted = false,
                            Name = "Ябълка",
                            Notes = "Свежи и сочни ябълки",
                            Quantity = 5.0
                        },
                        new
                        {
                            Id = new Guid("57286e97-0a7b-4225-a0f3-4499d58fac29"),
                            Categories = 0,
                            IsDeleted = false,
                            Name = "Банан",
                            Notes = "Узрели банани",
                            Quantity = 6.0
                        },
                        new
                        {
                            Id = new Guid("f63ecbf3-7089-4e53-9d82-49d0a0efb415"),
                            Categories = 1,
                            IsDeleted = false,
                            Name = "Морков",
                            Notes = "Био моркови",
                            Quantity = 10.0
                        },
                        new
                        {
                            Id = new Guid("f4eb169a-5894-43b0-8427-acdaa4e0221e"),
                            Categories = 1,
                            IsDeleted = false,
                            Name = "Броколи",
                            Notes = "Свежи зелени броколи",
                            Quantity = 2.0
                        },
                        new
                        {
                            Id = new Guid("4f2ee850-f944-454e-8c9f-6dc84a12ee0c"),
                            Categories = 2,
                            IsDeleted = false,
                            Name = "Мляко",
                            Notes = "Пълномаслено мляко",
                            Quantity = 2.0
                        },
                        new
                        {
                            Id = new Guid("655a4401-0234-47cc-8ac2-90946669d963"),
                            Categories = 2,
                            IsDeleted = false,
                            Name = "Сирене",
                            Notes = "Блок чедър сирене",
                            Quantity = 1.0
                        },
                        new
                        {
                            Id = new Guid("0425a159-c244-4fd1-84dc-a27466892376"),
                            Categories = 3,
                            IsDeleted = false,
                            Name = "Пилешко филе",
                            Notes = "Пилешко филе без кожа и кости",
                            Quantity = 2.0
                        },
                        new
                        {
                            Id = new Guid("7309db87-eefa-4a95-81ba-ad509f19d7c2"),
                            Categories = 3,
                            IsDeleted = false,
                            Name = "Говежда кайма",
                            Notes = "Кайма от нетлъсто говеждо",
                            Quantity = 1.0
                        },
                        new
                        {
                            Id = new Guid("928d845f-e222-448e-b425-af700ff02d84"),
                            Categories = 4,
                            IsDeleted = false,
                            Name = "Сьомга",
                            Notes = "Свежо филе от атлантическа сьомга",
                            Quantity = 1.0
                        },
                        new
                        {
                            Id = new Guid("c8049172-15e5-4803-82e1-e924700a55e5"),
                            Categories = 5,
                            IsDeleted = false,
                            Name = "Ориз",
                            Notes = "Басмати ориз",
                            Quantity = 5.0
                        },
                        new
                        {
                            Id = new Guid("3c6c22e2-9e20-486b-84fb-35febc954f67"),
                            Categories = 5,
                            IsDeleted = false,
                            Name = "Паста",
                            Notes = "Пълнозърнеста паста",
                            Quantity = 3.0
                        },
                        new
                        {
                            Id = new Guid("7c8b4d13-e2b4-40a0-a020-0df92bfca497"),
                            Categories = 6,
                            IsDeleted = false,
                            Name = "Портокалов сок",
                            Notes = "100% пресен портокалов сок",
                            Quantity = 2.0
                        },
                        new
                        {
                            Id = new Guid("99cff922-cfad-4899-b3a8-bdefd6eac76d"),
                            Categories = 7,
                            IsDeleted = false,
                            Name = "Шоколадов десерт",
                            Notes = "Тъмен шоколад 70%",
                            Quantity = 2.0
                        },
                        new
                        {
                            Id = new Guid("63fc94a1-d8e7-4eca-be83-ba4337d4d2f9"),
                            Categories = 8,
                            IsDeleted = false,
                            Name = "Замразен грах",
                            Notes = "Био замразен грах",
                            Quantity = 1.0
                        },
                        new
                        {
                            Id = new Guid("b2b5408a-30fd-4023-bd09-ab64dc650cce"),
                            Categories = 9,
                            IsDeleted = false,
                            Name = "Консервирана риба тон",
                            Notes = "Риба тон в зехтин",
                            Quantity = 3.0
                        },
                        new
                        {
                            Id = new Guid("50013858-40fe-441c-9933-d2ff24e8992c"),
                            Categories = 10,
                            IsDeleted = false,
                            Name = "Сол",
                            Notes = "Морска сол",
                            Quantity = 1.0
                        },
                        new
                        {
                            Id = new Guid("50a05479-945f-4838-8fac-449b1dd0d71e"),
                            Categories = 10,
                            IsDeleted = false,
                            Name = "Кетчуп",
                            Notes = "Био доматен кетчуп",
                            Quantity = 1.0
                        },
                        new
                        {
                            Id = new Guid("d4c31264-bba5-400c-97f8-559d779b091c"),
                            Categories = 11,
                            IsDeleted = false,
                            Name = "Хляб",
                            Notes = "Пълнозърнест хляб",
                            Quantity = 1.0
                        },
                        new
                        {
                            Id = new Guid("eb330b9e-fe2f-4e29-b87c-ee8ad6e86308"),
                            Categories = 2,
                            IsDeleted = false,
                            Name = "Яйца",
                            Notes = "Яйца от свободно отглеждани кокошки",
                            Quantity = 12.0
                        },
                        new
                        {
                            Id = new Guid("b83e5f54-f1c9-4731-a08a-975636eae8ce"),
                            Categories = 2,
                            IsDeleted = false,
                            Name = "Масло",
                            Notes = "Немаслено масло",
                            Quantity = 1.0
                        });
                });

            modelBuilder.Entity("MyFridge.Data.Models.Recipe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("_requiredProducts")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("RequiredProducts");

                    b.HasKey("Id");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d2b5d3c1-5f5b-4a0b-9c3b-1b27c8a441f8"),
                            Duration = "30 минути",
                            Name = "Спагети Карбонара",
                            _requiredProducts = "[\"\\u0421\\u043F\\u0430\\u0433\\u0435\\u0442\\u0438\",\"\\u042F\\u0439\\u0446\\u0430\",\"\\u0411\\u0435\\u043A\\u043E\\u043D\",\"\\u041F\\u0430\\u0440\\u043C\\u0435\\u0437\\u0430\\u043D\",\"\\u0427\\u0435\\u0440\\u0435\\u043D \\u043F\\u0438\\u043F\\u0435\\u0440\"]"
                        },
                        new
                        {
                            Id = new Guid("a6b62c13-d673-4d6f-92c9-9c0f253f7a4b"),
                            Duration = "15 минути",
                            Name = "Шопска салата",
                            _requiredProducts = "[\"\\u0414\\u043E\\u043C\\u0430\\u0442\\u0438\",\"\\u041A\\u0440\\u0430\\u0441\\u0442\\u0430\\u0432\\u0438\\u0446\\u0438\",\"\\u0421\\u0438\\u0440\\u0435\\u043D\\u0435\",\"\\u041B\\u0443\\u043A\",\"\\u0417\\u0435\\u0445\\u0442\\u0438\\u043D\"]"
                        });
                });

            modelBuilder.Entity("MyFridge.Data.Models.ShoppingListProducts", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingListsProducts");
                });

            modelBuilder.Entity("MyFridge.Data.Models.UserProduct", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("UsersProducts");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("MyFridge.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("MyFridge.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyFridge.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("MyFridge.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyFridge.Data.Models.ShoppingListProducts", b =>
                {
                    b.HasOne("MyFridge.Data.Models.Product", "Product")
                        .WithMany("ShoppingListProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyFridge.Data.Models.ApplicationUser", "User")
                        .WithMany("ShoppingListProducts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MyFridge.Data.Models.UserProduct", b =>
                {
                    b.HasOne("MyFridge.Data.Models.Product", "Product")
                        .WithMany("UserProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyFridge.Data.Models.ApplicationUser", "User")
                        .WithMany("UserProducts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MyFridge.Data.Models.ApplicationUser", b =>
                {
                    b.Navigation("ShoppingListProducts");

                    b.Navigation("UserProducts");
                });

            modelBuilder.Entity("MyFridge.Data.Models.Product", b =>
                {
                    b.Navigation("ShoppingListProducts");

                    b.Navigation("UserProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
