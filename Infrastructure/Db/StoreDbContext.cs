using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Db;

public class StoreDbContext : DbContext, IAppDbContext
{
    public DbSet<Products> Product { get; set; }
    public DbSet<Users> Users { get; set; }
}