﻿using Application.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Orders.Commands;

public sealed record PlaceOrderCommand(User User, List<Order> Orders) : IRequest<bool>;

public sealed record PlaceOrderCommandHandler(IAppDbContext DbContext) : IRequestHandler<PlaceOrderCommand, bool>
{
    public async Task<bool> Handle(PlaceOrderCommand request, CancellationToken ct)
    {
        var user = await DbContext.Set<User>().Where(x => x.Id == request.User.Id).FirstOrDefaultAsync(ct);
        if (user is null) return false;
        user.Orders?.AddRange(request.Orders);
        DbContext.Set<User>().Update(user);
        await DbContext.SaveChangesAsync(ct);
        return true;
    }
}