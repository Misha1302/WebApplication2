using Microsoft.AspNetCore.Mvc;
using WebApplication2.Services;

namespace WebApplication2.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly ICalculator _calculator;

    public CalculatorController(ICalculator calculator)
    {
        _calculator = calculator;
    }

    [HttpGet("Summ")]
    public float GetSum(float a, float b) =>
        _calculator.Add(a, b);

    [HttpGet("Sub")]
    public float GetSub(float a, float b) =>
        _calculator.Subtract(a, b);
}
