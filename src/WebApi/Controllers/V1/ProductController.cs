using Application.UseCases;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.v1;

public class ProductController(IMediator mediator) : ApiController
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