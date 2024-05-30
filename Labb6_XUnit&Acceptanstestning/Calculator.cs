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
        private List<Calculation> calculations = new List<Calculation>();
        private const string FilePath = "calculations.json";

        public void AddCalculation(Calculation calculation)
        {
            calculations.Add(calculation);
        }

        public List<Calculation> GetCalculations()
        {
            return calculations;
        }

        public void SaveCalculations()
        {
            var json = JsonConvert.SerializeObject(calculations, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }

        public void LoadCalculations()
        {
            if(File.Exists(FilePath))
            {
                var json = File.ReadAllText(FilePath);
                calculations = JsonConvert.DeserializeObject<List<Calculation>>(json);
            }
        }

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

        
    }
}
