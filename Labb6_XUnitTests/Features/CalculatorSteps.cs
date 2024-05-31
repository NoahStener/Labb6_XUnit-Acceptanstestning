using Labb6_XUnit_Acceptanstestning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Labb6_XUnitTests.Features
{
    [Binding]
    public class CalculatorSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private Calculator _calculator;
        private double _number1;
        private double _number2;
        private double _result;

        public CalculatorSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"the calculator is turned on")]
        public void GivenTheCalculatorIsTurnedOn()
        {
            _calculator = new Calculator();
        }

        [When(@"I select addition")]
        public void WhenISelectAddition()
        {
            _scenarioContext["Operation"] = "Addition";
        }

        [When(@"I select subtraction")]
        public void WhenISelectSubtraction()
        {
            _scenarioContext["Operation"] = "Subtraction";
        }

        [When(@"I select multiplication")]
        public void WhenISelectMultiplication()
        {
            _scenarioContext["Operation"] = "Multiplication";
        }

        [When(@"I select division")]
        public void WhenISelectDivision()
        {
            _scenarioContext["Operation"] = "Division";
        }

        [When(@"I enter (.*)")]
        public void WhenIEnterNumber(double number)
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

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(double expectedResult)
        {
            string operation = _scenarioContext["Operation"].ToString();

            switch (operation)
            {
                case "Addition":
                    _result = _calculator.Addition(_number1, _number2);
                    break;
                case "Subtraction":
                    _result = _calculator.Subtraction(_number1, _number2);
                    break;
                case "Multiplication":
                    _result = _calculator.Multiplication(_number1, _number2);
                    break;
                case "Division":
                    _result = _calculator.Divide(_number1, _number2);
                    break;
            }

            Assert.Equal(expectedResult, _result);
        }
    }


}

