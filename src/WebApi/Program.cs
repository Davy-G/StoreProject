using dotenv.net;
using Infrastructure.Db;
using MediatR;
using Microsoft.EntityFrameworkCore;

var solutionDir = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent;
DotEnv.Fluent()
    .WithTrimValues()
    .WithEnvFiles($"{solutionDir}/.env")
    .WithOverwriteExistingVars()
    .Load();

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IMediator>(o => o.GetRequiredService<IMediator>());
builder.Services
    .AddDbContext<StoreDbContext>(o => o
        .UseSqlite(Environment.GetEnvironmentVariable("DB__PATH")));


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
    "default",
    "{controller=Product}/{action=Index}/{id?}");

app.Run();