using Microsoft.AspNetCore.Mvc;
using WebApplication2.Services;

namespace WebApplication2.Controllers;

[ApiController]
[Route("[controller]")]
public class FooClassController : ControllerBase
{
    private readonly IPersistanceDataService _dataService;

    public FooClassController(IPersistanceDataService dataService)
    {
        _dataService = dataService;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public List<int> Get()
    {
        return _dataService.Ints;
    }

    [HttpPost(Name = "SetWeatherForecast")]
    public bool Post(int i)
    {
        _dataService.Ints.Add(i);

        return true;
    }
}
