using Microsoft.AspNetCore.Mvc;
using Resume.Models;
using System.Diagnostics;
using System.Reflection;

namespace Resume.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> Logger;

    public HomeController(ILogger<HomeController> logger) => Logger = logger;

    [ResponseCache(Duration = 600)]
    public IActionResult Index()
    {
        ViewBag.AppVersion = Assembly.GetExecutingAssembly().GetName().Version?.ToString();
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() =>
        View(new ErrorViewModel(Activity.Current?.Id ?? HttpContext.TraceIdentifier));
}