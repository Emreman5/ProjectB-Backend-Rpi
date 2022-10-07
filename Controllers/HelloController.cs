using Microsoft.AspNetCore.Mvc;

namespace RpiServerAPI.Controllers;
[ApiController]
[Route("[controller]")]
public class HelloController : Controller
{
    [HttpGet("hello")]
    public IActionResult Hello()
    {
        return Ok("Erme");
    }
    [HttpGet("GetLocation")]
    public IActionResult GetLocation()
    {
        return Ok("X : 200, Y : 100");
    }
}
