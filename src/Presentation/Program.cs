using Application.Interfaces;
using Infrastructure.Db;
using Microsoft.EntityFrameworkCore;
using Application.UseCases;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services
    .AddDbContext<StoreDbContext>(o => o
        .UseSqlite("Data Source=../../dbo/store.db"));
builder.Services
    .AddScoped<IAppDbContext>(sp => sp.GetRequiredService<StoreDbContext>());
builder.Services.AddMediatR(conf => conf.RegisterServicesFromAssembly(typeof(GetProductsOnSale).Assembly));
 


var app = builder.Build();

Console.WriteLine(Directory.GetCurrentDirectory());

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();