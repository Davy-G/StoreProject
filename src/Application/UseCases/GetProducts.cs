using Application.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.UseCases;

public sealed record GetProductsOnSale : IRequest<List<Product>>;

public sealed record GetProductsHandler(IAppDbContext DbContext) : IRequestHandler<GetProductsOnSale, List<Product>>
{
    public async Task<List<Product>> Handle(GetProductsOnSale request, CancellationToken ct)
    {
        var resp = await DbContext.Set<Product>().Where(x => x.Sale == true).ToListAsync(ct);
        return resp;
    }
}

public sealed record GetProductsByName(string Name) : IRequest<List<Product>>;

public sealed record GetProductsByNameHandler(IAppDbContext DbContext)
    : IRequestHandler<GetProductsByName, List<Product>>
{
    public async Task<List<Product>> Handle(GetProductsByName request, CancellationToken ct)
    {
        var resp = await DbContext.Set<Product>().Where(o => o.ProductName == request.Name).OrderBy(o => o.Price)
            .ToListAsync(ct);
        return resp;
    }
}