using Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Application.Interfaces;

public interface IAppDbContext
{
    public DbSet<TEntity> Set<TEntity>() where TEntity : class;
}