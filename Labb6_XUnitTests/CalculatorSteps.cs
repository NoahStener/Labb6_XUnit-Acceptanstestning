using Labb6_XUnit_Acceptanstestning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Labb6_XUnitTests
{
    [Binding]
    public class CalculatorSteps
    {
        private Calculator _calculator;
        private double _result;
        private double _number1;
        private double _number2;
        private string _errorMessage;

        [Given(@"the calculator is turned on")]
        public void GivenTheCalculatorIsTurnedOn()
        {
            _calculator = new Calculator();
        }

        [When(@"I enter (.*)")]
        public void WhenIEnter(double number)
        {
            if (_number1 == 0)
            {
                _number1 = number;
            }
            else
            {
                _number2 = number;
            }
        }
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _result = _calculator.Addition(_number1, _number2);
        }

        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            _result = _calculator.Subtraction(_number1, _number2);
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            _result = _calculator.Multiplication(_number1, _number2);
        }

        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            try
            {
                _result = _calculator.Divide(_number1, _number2);
            }
            catch (DivideByZeroException ex)
            {
                _errorMessage = ex.Message;
            }
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(double expected)
        {
            Assert.Equal(expected, _result);
        }

        [Then(@"an error message should be displayed saying ""(.*)""")]
        public void ThenAnErrorMessageShouldBeDisplayedSaying(string expectedMessage)
        {
            Assert.Equal(expectedMessage, _errorMessage);
        }


    }
}
