using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class Users : Controller
{
    public IActionResult SignIn()
    {

        return Ok();
    }

    [Authorize]
    public string Profile()
    {
        var name = HttpContext.User.FindFirst("username").ToString();
        return name;
    }
}
