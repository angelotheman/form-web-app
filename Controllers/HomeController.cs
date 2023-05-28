using Microsoft.AspNetCore.Mvc;
namespace formApp.Controllers;

public class HomeController : Controller

{
    public IActionResult Index()
    {
        return View();
    }
}
