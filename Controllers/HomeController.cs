using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCAT.Models;

namespace MVCAT.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult ListCats()
    {
        return View();
    }
    public IActionResult CreateCat()
    {
        return View();
    }
    [HttpPost]
    public IActionResult CreateCat(string name, int age)
    {
        System.Console.WriteLine("Nome: " + name);
        System.Console.WriteLine("Idade: " + age);
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
