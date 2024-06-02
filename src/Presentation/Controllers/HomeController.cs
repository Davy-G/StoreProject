using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

public class HomeController : ControllerBase
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return Ok();
    }

    public IActionResult Privacy()
    {
        return Ok();
    }
    
}