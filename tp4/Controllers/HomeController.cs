using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tp4.Models;

namespace tp4.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.listaPaises=Info.ListarPaises();
        return View("index");
    }

    public IActionResult DetallePais(string pais)
    {
        ViewBag.paisBuscado=Info.DetallePais(pais);
        return View("detallePais");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
