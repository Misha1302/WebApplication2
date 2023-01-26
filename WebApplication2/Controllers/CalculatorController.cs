using Microsoft.AspNetCore.Mvc;
using WebApplication2.Services;

namespace WebApplication2.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly IPersistanceDataService _dataService;

    public CalculatorController(IPersistanceDataService dataService)
    {
        _dataService = dataService;
    }

    [HttpGet("Summ")]
    public int GetSum(int a, int b)
    {
        return a + b;
    }

    [HttpGet("Sub")]
    public int GetSub(int a, int b)
    {
        return a - b;
    }
}
