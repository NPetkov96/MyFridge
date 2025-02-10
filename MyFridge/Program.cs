using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyFridge.Data;
using MyFridge.Data.Models;
using MyFridge.Data.Repository;
using MyFridge.Data.Repository.Interfaces;
using MyFridge.Data.Services.Interfaces;
using MyFridge.Data.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration
    .GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services
    .AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

builder.Services
    .AddDatabaseDeveloperPageExceptionFilter();

builder.Services
    .AddIdentity<ApplicationUser, IdentityRole<Guid>>(options =>
    {
        options.SignIn.RequireConfirmedAccount = false; 
        options.SignIn.RequireConfirmedEmail = false;   
    })
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

builder.Services
    .AddControllersWithViews();

builder.Services
    .AddRazorPages();

builder.Services.AddScoped(typeof(IRepository<,>), typeof(BaseRepo<,>));

builder.Services.AddScoped<IMyFridgeService, MyFridgeService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IShoppingListService, ShoppingListService>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<ApplicationDbContext>();
        context.Database.Migrate();
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred while applying migrations.");
    }
}

if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    //https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.MapRazorPages();

app.UseAuthorization();

app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
