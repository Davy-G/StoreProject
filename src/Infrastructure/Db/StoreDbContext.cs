using Application.Interfaces;
using Domain.Common;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Db;

public class StoreDbContext(DbContextOptions<StoreDbContext> options) : DbContext(options), IAppDbContext
{
    public DbSet<Product> Products => Set<Product>();
    public DbSet<User> Users => Set<User>();
    public DbSet<Order> Orders => Set<Order>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
        foreach (var Entity in modelBuilder.Model.GetEntityTypes())
            Entity.SetTableName(Entity.GetTableName()?.ToSnakeCaseRename());


        base.OnModelCreating(modelBuilder);
    }
}