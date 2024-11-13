using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("/api/v1/[controller]")]
[Produces("application/json")]
public abstract class ApiController : ControllerBase;