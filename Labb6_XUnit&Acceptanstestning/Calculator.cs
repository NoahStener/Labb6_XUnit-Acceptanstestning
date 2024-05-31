using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_XUnit_Acceptanstestning
{
    public class Calculator : ICalculator
    {
        
        public double Addition(double x, double y)
        {
            double result = x + y;
            return result;
        }

        public double Subtraction(double x, double y)
        {
            double result = x - y;
            return result;
        }

        public double Multiplication(double x, double y)
        {
            double result = x * y;
            return result;
        }

        public double Divide(double x, double y)
        {
            double result = x / y;
            if(y == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return result;
        }

        public double PerformCalculation(string choice, double num1, double num2, out string operation)
        {
            double result = 0;
            operation = "";

            switch (choice)
            {
                case "1":
                    result = Addition(num1, num2);
                    operation = "Addition";
                    break;
                case "2":
                    result = Subtraction(num1, num2);
                    operation = "Subtraktion";
                    break;
                case "3":
                    result = Multiplication(num1, num2);
                    operation = "Multiplikation";
                    break;
                case "4":
                    try
                    {
                        result = Divide(num1, num2);
                        operation = "Division";
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Ogitligt val");
                    break;
            }
            return result;
        }
    }
}
