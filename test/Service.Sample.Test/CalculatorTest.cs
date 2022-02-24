using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TDD.Domain;
using ExpectedObjects;

namespace TDD.Domain.Test
{
    public class CalculatorTest
    {

        [Theory(DisplayName = "addition test scenario")]
        [InlineData(2,3,5)]
        [InlineData(50, 30, 80)]
        public void AdditionTest(int n1, int n2, int result)
        {
            var calculator = new Calculator();

            Assert.Equal(result, calculator.Addition(n1, n2) );
        }

        [Theory(DisplayName = "Subtraction test scenario")]
        [InlineData(10, 3, 7)]
        [InlineData(5, 8, -3)]
        public void SubtractionTest(int n1, int n2, int result)
        {
            var calculator = new Calculator();

            Assert.Equal(result, calculator.Subtraction(n1, n2));
        }
        
        [Theory(DisplayName = "Multiplication test scenario")]
        [InlineData(3, 5, 15)]
        [InlineData(10, 10, 100)]
        public void MultiplicationTest(int n1, int n2, int result)
        {
            var calculator = new Calculator();

            Assert.Equal(result, calculator.Multiplication(n1, n2));
        }

        [Theory(DisplayName = "Division test scenario")]
        [InlineData(50, 5, 10)]
        [InlineData(16, 2, 8)]
        public void DivisionTest(int n1, int n2, int result)
        {
            var calculator = new Calculator();

            Assert.Equal(result, calculator.Division(n1, n2));
        }

        [Fact(DisplayName = "Division test scenario - WhenDivisionByZeroThenThrowException")]
        public void WhenDivisionByZeroThenThrowException()
        {
            var calculator = new Calculator();

            Assert.Throws<ArgumentException>(() => calculator.Division(10,0) );
        }
    }
}
