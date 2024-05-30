using Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Application.Interfaces;

public interface IAppDbContext
{
    public DbSet<Products> Product { get; set; }

    public DbSet<Users> Users { get; set; }



}