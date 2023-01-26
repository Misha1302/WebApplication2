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

    [HttpGet(Name = "Sum")]
    public int GetSum(int a, int b)
    {
        return a + b;
    }

    [HttpGet(Name = "Sub")]
    public int GetSub(int a, int b)
    {
        return a - b;
    }
}