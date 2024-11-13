using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.v1;

public class LoginController(IMediator mediator) : ApiController
{
    [HttpPost("")]
    public IActionResult Login()
    {
        return Ok();
    }
}