using Microsoft.AspNetCore.Mvc;
using Resume.Models;
using System.Diagnostics;

namespace Resume.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> Logger;

    public HomeController(ILogger<HomeController> logger) => Logger = logger;

    [ResponseCache(Duration = 600)]
    public IActionResult Index() =>
        View();

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() =>
        View(new ErrorViewModel(Activity.Current?.Id ?? HttpContext.TraceIdentifier));
}