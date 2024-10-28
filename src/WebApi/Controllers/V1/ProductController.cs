using Application.UseCases;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.v1;

public class ProductController(IMediator mediator) : ApiController
{
    [HttpGet("sale")]
    public async Task<IActionResult> Index()
    {
        var request = await mediator.Send(new GetProductsOnSale());
        return Ok(request);
    }

    public IActionResult Privacy()
    {
        return Ok();
    }
}