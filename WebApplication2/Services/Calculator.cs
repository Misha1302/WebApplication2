namespace WebApplication2.Services;

/// <remarks>
/// Simple Calculator
/// <seealso cref="https://habr.com/ru/company/piter/blog/508508/"/>
/// </remarks>
public class Calculator : ICalculator
{
    public float Divide(float number1, float number2)
    {
        return number1 / number2;
    }

    public float Multiply(float number1, float number2)
    {
        return number1 * number2;
    }

    public float Add(float number1, float number2)
    {
        return number1 + number2;
    }

    public float Subtract(float number1, float number2)
    {
        return number1 - number2;
    }
}
