using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
public class TestController : ControllerBase
{
    [HttpGet]
    [Route("hello")]
    public string SayHello()
    {
        return "hello";
    }
}