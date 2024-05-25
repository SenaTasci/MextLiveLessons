using Calculator.Domain.Calculation;
using Calculator.Domain.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CalculateController : ControllerBase
{
    CalculationServices calculationServices = new();

    [HttpGet("[action]")]

    public void Add(int number1, int number2)
    {
        calculationServices.AddCalculation(number1, number2, Operations.Sum);
    }

    [HttpGet("[action]")]

    public void Subtract(int number1, int number2)
    {
        calculationServices.SubscractCalculation(number1, number2, Operations.Subtract);
    }

    [HttpGet("[action]")]

    public void Multiply(int number1, int number2)
    {
        calculationServices.MultiplyCalculation(number1, number2, Operations.Multiply);
    }

    [HttpGet("[action]")]
    public ActionResult<string> Divide(double number1, double number2)
    { 

        if (number2 == 0)
        {
            return BadRequest("Cannot divide by zero");
        }

        calculationServices.DivideCalculation(number1, number2, Operations.Divide);
        return Ok();    
    }


    [HttpGet("[action]")]
    public List<Calculation> GetAllCalculations()
    {
        //calculation.Id = Guid.NewGuid();
        return calculationServices.GetCalculations();
    }
}

