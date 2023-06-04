using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ItDeveloper.Mvc.Models;

namespace ItDeveloper.Mvc.Controllers;

[Route("")]
[Route("gestao-de-pacientes")]
[Route("api/[controller]")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // public IActionResult Index(Guid id, string paciente)
    [Route("")]
    [Route("pagina-inicial")]
    public IActionResult Index()
    {
        return View();
    }

    [Route("sobre/{id}/{paciente}/{categoria}")]
    [Route("quem-somos")]
    [Route("sobre-nos")]
    public IActionResult Sobre(Guid id, string paciente, string categoria)
    {
        return View();
    }

    // public IActionResult Dashboard()
    // {
    //     return View();
    // }


    [Route("politica-de-privacidade")]
    [Route("privacidade")]
    public IActionResult Privacy()
    {
        return View();
    }

    [Route("icones")]
    public IActionResult Icones()
    {
        return View();
    }

    [Route("erro")]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
