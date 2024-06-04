using Application.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using IMediator = MediatR.IMediator;

namespace Application.UseCases;


public sealed record GetProductsOnSale() : IRequest<List<Product>>;

public sealed record GetProductsHandler(IAppDbContext DbContext) : IRequestHandler<GetProductsOnSale, List<Product>>
{
    public async Task<List<Product>> Handle(GetProductsOnSale request, CancellationToken ct)
    {
        var resp = await DbContext.Set<Product>().Where(x => x.Sale == true).ToListAsync(ct);
        return resp;
    }
}