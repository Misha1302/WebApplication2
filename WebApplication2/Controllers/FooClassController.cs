using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers;

[ApiController]
[Route("[controller]")]
public class FooClassController : ControllerBase
{
    private readonly List<int> _ints = new();

    [HttpGet(Name = "GetWeatherForecast")]
    public List<int> Get()
    {
        return _ints;
    }

    [HttpPost(Name = "SetWeatherForecast")]
    public bool Post(int i)
    {
        _ints.Add(i);

        return true;
    }
}