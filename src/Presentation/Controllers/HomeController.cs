using System.Diagnostics;
using Application.UseCases;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

public class HomeController(IMediator mediator) : ControllerBase
{

    public async Task<IActionResult>Index()
    {
        var request = await mediator.Send(new GetProductsOnSale());
        return Ok(request);
    }
    
}