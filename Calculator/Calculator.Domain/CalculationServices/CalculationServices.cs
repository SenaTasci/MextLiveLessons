using Calculator.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Domain.Calculation
{
    public class CalculationServices
    {

        public static List<Calculation> calculations = new List<Calculation>();

        public void AddCalculation(int number1, int number2, Operations operation)
        {
            int sum = number1 + number2;

            Calculation calculation = new Calculation
            {
                Id = Guid.NewGuid().ToString(),
                Number1 = number1,
                Number2 = number2,
                Operation = operation,
                Result = sum
            };

            calculations.Add(calculation);
        }

        public void SubscractCalculation(int number1, int number2, Operations operation)
        {
            int subscract = number1 - number2;

            Calculation calculation = new Calculation
            {
                Id = Guid.NewGuid().ToString(),
                Number1 = number1,
                Number2 = number2,
                Operation = operation,
                Result = subscract
            };

            calculations.Add(calculation);
        }

        public void MultiplyCalculation(int number1, int number2, Operations operation)
        {
            int multiply = number1 * number2;

            Calculation calculation = new Calculation
            {
                Id = Guid.NewGuid().ToString(),
                Number1 = number1,
                Number2 = number2,
                Operation = operation,
                Result = multiply
            };

            calculations.Add(calculation);
        }

        public void DivideCalculation(double number1, double number2, Operations operation)
        {
            double divide = number1 / number2;

            Calculation calculation = new Calculation
            {
                Id = Guid.NewGuid().ToString(),
                Number1 = number1,
                Number2 = number2,
                Operation = operation,
                Result = divide,
            };

            calculations.Add(calculation);
        }

        public List<Calculation> GetCalculations() 
        {
            return calculations; 
        }

    }
}
