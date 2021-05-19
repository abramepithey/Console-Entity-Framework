using System;

namespace ConsoleTests.CalculatorTDD
{
    public class Operations
    {
        public decimal Sum(decimal firstNumber, decimal secondNumber)
        {
            var sum = firstNumber + secondNumber;
            return sum;
        }

        public decimal Division(decimal firstNumber, decimal secondNumber)
        {
            var quotient = firstNumber / secondNumber;
            return Math.Round(quotient, 3);
        }
    }
}