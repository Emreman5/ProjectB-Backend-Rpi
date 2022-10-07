using Microsoft.AspNetCore.Mvc;

namespace RpiServerAPI.Controllers;
[ApiController]
[Route("[controller]")]
public class HelloController : Controller
{
    [HttpGet("hello")]
    public IActionResult Hello()
    {
        return Ok("Batuş");
    }
    [HttpGet("GetLocation")]
    public IActionResult GetLocation()
    {
        return Ok("X : 100, Y : 50");
    }
}
