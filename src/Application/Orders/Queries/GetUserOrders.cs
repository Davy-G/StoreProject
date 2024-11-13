using Application.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Orders.Queries;

public sealed record GetUserOrdersCommand(User User) : IRequest<List<Order>>;

public sealed record GetUserOrdersHandler(IAppDbContext DbContext) : IRequestHandler<GetUserOrdersCommand, List<Order>>
{
    public async Task<List<Order>> Handle(GetUserOrdersCommand request, CancellationToken ct)
    {
        var resp = await DbContext.Set<Order>().Where(x => x.User == request.User).ToListAsync(ct);
        return resp;
    }
}