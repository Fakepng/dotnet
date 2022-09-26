using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    [HttpGet]
    public String Get()
    {
        return "Hello World";
    }

    [HttpGet("{id}")]
    public String Get(int id)
    {
        return "Hello " + id;
    }
}
