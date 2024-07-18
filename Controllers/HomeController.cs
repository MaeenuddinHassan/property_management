using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Properties() => View();
    public IActionResult Services() => View();
    public IActionResult Contact() => View();
}

public class AccountController : Controller
{
    public IActionResult Login() => View();
    public IActionResult Register() => View();
}
