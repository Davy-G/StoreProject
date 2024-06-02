using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Db;

public class StoreDbContext(DbContextOptions<StoreDbContext> options) : DbContext(options), IAppDbContext
{
    public DbSet<Product> Product { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Order> Orders { get; set; }

}