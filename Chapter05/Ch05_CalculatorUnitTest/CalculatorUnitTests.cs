using System;
using Xunit;
using Ch05_Calculator;

namespace Ch05_CalculatorUnitTest
{
    public class CalculatorUnitTests
    {
        [Fact]
        public void TestAdding2And2()
        {
            // arrange
            double a = 2, b = 2;
            double expected = 4;
            var calc = new Calculator();
            // act
            double actual = calc.Add(a, b);
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAdding2And3()
        {
            // arrange
            double a = 2, b = 3;
            double expected = 5;
            var calc = new Calculator();
            // act
            double actual = calc.Add(a, b);
            // assert
            Assert.Equal(expected, actual);
        }
    }
}
