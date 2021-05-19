using System;
using ConsoleTests.CalculatorTDD;
using Xunit;

namespace ConsoleTests.CalculatorTests
{
    public class CalculatorTesting
    {
        private readonly Operations _operations;

        public CalculatorTesting(Operations operations)
        {
            this._operations = operations;
        }
        
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(33, 42, 75)]
        [InlineData(19, 66, 85)]
        [InlineData(58, 31, 89)]
        [InlineData(155, 12, 167)]
        [InlineData(64, 123, 187)]
        public void AddNumbers_ReturnsCorrectSum(decimal firstNumber, decimal secondNumber, decimal sumNumber)
        {
            var assertion = _operations.Sum(firstNumber, secondNumber);
            Assert.Equal(sumNumber, assertion);
        }
    }
}