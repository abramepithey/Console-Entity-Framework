using System;
using System.Runtime.InteropServices;
using ConsoleTests.CalculatorTDD;
using Xunit;

namespace ConsoleTests.CalculatorTests
{
    public class CalculatorTesting
    {
        private readonly Operations _operations;

        public CalculatorTesting()
        {
            this._operations = new Operations();
        }
        
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(33, 42, 75)]
        [InlineData(19, 66, 85)]
        [InlineData(58, 31, 89)]
        [InlineData(155, 12, 167)]
        [InlineData(64, 123, 187)]
        public void Sum_ReturnsCorrectSum(decimal firstNumber, decimal secondNumber, decimal sumNumber)
        {
            var assertion = _operations.Sum(firstNumber, secondNumber);
            Assert.Equal(sumNumber, assertion);
        }
        
        [Theory]
        [InlineData(-1, -2, -3)]
        [InlineData(-33, -42, -75)]
        [InlineData(-19, -66, -85)]
        [InlineData(-58, -31, -89)]
        [InlineData(-155, -12, -167)]
        [InlineData(-64, -123, -187)]
        public void Sum_UsingTwoNegatives_ReturnsCorrectSum(decimal firstNumber, decimal secondNumber, decimal sumNumber)
        {
            var assertion = _operations.Sum(firstNumber, secondNumber);
            Assert.Equal(sumNumber, assertion);
        }
        
        [Theory]
        [InlineData(1, 1.3, 2.3)]
        [InlineData(4.2, 45.89, 50.09)]
        [InlineData(-13.8, 34.123, 20.323)]
        [InlineData(0.00001, 0.00009, 0.0001)]
        public void Sum_UsingDecimals_ReturnsCorrectSum(decimal firstNumber, decimal secondNumber, decimal sumNumber)
        {
            var assertion = _operations.Sum(firstNumber, secondNumber);
            Assert.Equal(sumNumber, assertion);
        }

        [Theory]
        [InlineData(8, 2, 4)]
        [InlineData(99, 3, 33)]
        [InlineData(-21, 7, -3)]
        [InlineData(5.2456, 2.54, 2.065)]
        public void Division_ReturnsCorrectQuotient(decimal firstNumber, decimal secondNumber, decimal quotientNumber)
        {
            var assertion = _operations.Division(firstNumber, secondNumber);
            Assert.Equal(quotientNumber, assertion);
        }
    }
}