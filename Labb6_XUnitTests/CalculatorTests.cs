using Labb6_XUnit_Acceptanstestning;

namespace Labb6_XUnitTests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnCorrectResult()
        {
            //Arrange
            var calc = new Calculator();
            double a = 5;
            double b = 3;
            double expected = 8;

            //Act
            double result = calc.Addition(a, b);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectResult()
        {
            var calc = new Calculator();
            double a = 5;
            double b = 3;
            double expected = 2;

            //Act
            double result = calc.Subtraction(a, b);

            //Assert
            Assert.Equal(expected,result);
        }
    }
}