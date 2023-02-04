using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;

using WieldyDotNet.Models;

namespace WieldyDotNet.Controllers;

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

  public IActionResult Profile() => View();

  public IActionResult Mail() => View();

  public IActionResult Chat() => View();

  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
  public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
}