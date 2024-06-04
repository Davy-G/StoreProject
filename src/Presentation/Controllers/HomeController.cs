using System.Diagnostics;
using Application.UseCases;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

public class HomeController(IMediator mediator) : ControllerBase
{

    public IActionResult Index()
    {
        //TODO register mediator services
        var request = mediator.Send(new GetProductsOnSale());
        
        
        return Ok(request);
    }

    public IActionResult Privacy()
    {
        return Ok();
    }
    
}