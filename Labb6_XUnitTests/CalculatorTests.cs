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

        [Fact]
        public void Multiplication_ShouldReturnCorrectResult()
        {
            //Arrange
            var calc = new Calculator();
            double a = 5;
            double b = 3;
            double expected = 15;

            //Act
            double result = calc.Multiplication(a, b);

            //Assert
            Assert.Equal(expected ,result);

        }

        [Fact]
        public void Divide_ShouldReturnCorrectResult()
        {
            //Arrange
            var calc = new Calculator();
            var a = 8;
            var b = 2;
            double expected = 4;

            //Act
            double result = calc.Divide(a, b);

            //Assert
            Assert.Equal(expected,result);
        }

        [Fact]
        public void AddCalculation_ShouldAddCalculationToList()
        {
            //Arrange
            var calculation = new Calculation
            {
                Operation = "Add",
                Number1 = 5,
                Number2 = 3,
                Result = 8,
                TimeSamp = DateTime.Now,
            };

            //Act
            calculation.AddCalculation(calculation);
            var calculations = calculation.GetCalculations();

            //Assert
            Assert.Single(calculations);
            Assert.Equal("Add", calculations[0].Operation);
            Assert.Equal(5, calculations[0].Number1);
            Assert.Equal(3, calculations[0].Number2);
            Assert.Equal(8, calculations[0].Result);
        }

        [Fact]
        public void GetCalculations_ShouldReturnAllCalculations()
        {
            //Arrange
            var calculation = new Calculation();
            var calculation1 = new Calculation
            {
                Operation = "Add",
                Number1 = 5,
                Number2 = 3,
                Result = 8,
                TimeSamp = DateTime.Now,
            };
            var calculation2 = new Calculation
            {
                Operation= "Multiply",
                Number1 = 2,
                Number2 = 4,
                Result = 8,
                TimeSamp = DateTime.Now,
            };

            calculation.AddCalculation(calculation1);
            calculation.AddCalculation(calculation2);

            //Act
            var calculations = calculation.GetCalculations();

            //Assert
            Assert.Equal(2, calculations.Count);
            Assert.Equal("Add", calculations[0].Operation);
            Assert.Equal("Multiply", calculations[1].Operation);
        }

        [Theory]
        [InlineData(4,2,6)] 
        [InlineData(10, 2, 12)] 
        [InlineData(-3,-3,-6)] 
        [InlineData(5,5,10)] 
        [InlineData(40, 32, 72)] 
        public void Addition_ShouldReturnCorrectResult_Theory(double a, double b, double expected)
        {
            //Arrange
            var calc = new Calculator();

            //Act
            double result = calc.Addition(a, b);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(20, 10, 10)]
        [InlineData(8,5,3)]
        [InlineData(75,35,40)]
        [InlineData(80,42,38)]
        [InlineData(130,50,80)]
        public void Subtraction_ShouldReturnCorrectResult_Theory(double a, double b, double expected)
        {
            //Arrange
            var calc = new Calculator();

            //Act
            double result = calc.Subtraction(a, b);

            //Assert
            Assert.Equal(expected, result);
           
        }

        [Theory]
        [InlineData(5,5,25)]
        [InlineData(10,10, 100)]
        [InlineData(4,8,32)]
        [InlineData(5,20, 100)]
        [InlineData(7, 3, 21)]
        public void Multiplication_ShouldReturnCorrectResult_Theory(double a, double b, double expected)
        {
            //Arrange
            var calc = new Calculator();

            //Act
            double result = calc.Multiplication(a, b);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(100,5,20)]
        [InlineData(40,4,10)]
        [InlineData(8,4,2)]
        [InlineData(50,10,5)]
        [InlineData(30,10,3)]
        public void Divide_ShouldReturnCorrectResult_Theory(double a, double b, double expected)
        {
            //Arrange
            var calc = new Calculator();

            //Act
            double result = calc.Divide(a, b);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}