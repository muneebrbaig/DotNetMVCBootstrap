using Microsoft.AspNetCore.Mvc;

using WieldyDotNet.Models;

namespace WieldyDotNet.Controllers;

public class UserController : Controller
{
  private readonly List<User> _users = new()
    {
      new("1", "Chris", "Crowder", "@c.crowder", "Graphic Designer/ UI & UX", "35", "170k+"),
      new("2", "Domnic","Brown","@dom.brown","JavaScript Dev", "30","189k+"),
      new("3", "Jonathan","Madano","@john.madano", "React Dev", "50", "269k+"),
      new("4", "Stella","Johnson","@stella.johnson", "C# Dev", "69", "106k+")
    };

  public IActionResult Index() => View(_users);

  public IActionResult UserList() => View(_users);
}