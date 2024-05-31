using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_XUnit_Acceptanstestning
{
    public class Calculation
    {
        public string Operation {  get; set; }
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public double Result {  get; set; }
        public DateTime TimeSamp { get; set; }

        private List<Calculation> calculations = new List<Calculation>();
        private const string FilePath = "calculations.json";

        public void AddCalculation(Calculation calculation)
        {
            calculations.Add(calculation);
            SaveCalculations();
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
            if (File.Exists(FilePath))
            {
                var json = File.ReadAllText(FilePath);
                calculations = JsonConvert.DeserializeObject<List<Calculation>>(json);
            }
        }

        public void LogCalculation(string operation, double num1, double num2, double result)
        {
            Calculation calculation = new Calculation
            {
                Operation = operation,
                Number1 = num1,
                Number2 = num2,
                Result = result,
                TimeSamp = DateTime.Now
            };

            calculations.Add(calculation);
        }
    }
}
