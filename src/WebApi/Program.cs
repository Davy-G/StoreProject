using Infrastructure.Db;
using Microsoft.EntityFrameworkCore;
using dotenv.net;
using MediatR;


DotEnv.Load();
var env = DotEnv.Read();

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IMediator>(o => o.GetRequiredService<IMediator>());
builder.Services
    .AddDbContext<StoreDbContext>(o => o
        .UseSqlite(env["DB__PATH"]));


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
    pattern: "{controller=Product}/{action=Index}/{id?}");

app.Run();