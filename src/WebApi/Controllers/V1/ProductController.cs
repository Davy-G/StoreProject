using Application.Products.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.v1;

public class ProductController(IMediator mediator) : ApiController
{
    [HttpGet("sale")]
    public async Task<IActionResult> Sale()
    {
        var request = await mediator.Send(new GetProductsOnSale());
        return Ok(request);
    }

    [HttpGet("/name/{name}")]
    public async Task<IActionResult> Sale(string name)
    {
        var request = await mediator.Send(new GetProductsByName(name));
        return Ok(request);
    }
}