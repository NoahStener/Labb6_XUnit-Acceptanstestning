using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_XUnit_Acceptanstestning
{
    public class CalculatorMenu
    {
        private Calculator _calculator;
        private Calculation _calculation;
        public CalculatorMenu(Calculator calculator, Calculation calculation)
        {
            _calculator = calculator;
            _calculation = calculation;
            _calculation.LoadCalculations();

        }
        public void ShowMenu()
        {
            while (true)
            {
                MenuOptions();
                string choice = Console.ReadLine();

                if (choice == "0")
                {
                    _calculation.SaveCalculations();
                    break;
                }
                if (choice == "5")
                {
                    ShowPreviousCalculations();
                    continue;
                }

                double num1 = GetNumberInput("Ange första siffran");
                double num2 = GetNumberInput("Ange andra siffran");

                string operation;
                double result = _calculator.PerformCalculation(choice, num1, num2, out operation);   

                if(!string.IsNullOrEmpty(operation))
                {
                    DisplayResult(result);
                    _calculation.LogCalculation(operation, num1, num2, result);
                }
            }
        }

        public static void MenuOptions()
        {
            Console.WriteLine("Välj räknesätt och två siffor");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtraktion");
            Console.WriteLine("3: Multiplikation");
            Console.WriteLine("4: Division");
            Console.WriteLine("5: Visa tidigare beräkningar");
            Console.WriteLine("0: Avsluta");
        }

        public static double GetNumberInput(string prompt)
        {
            Console.WriteLine(prompt);
            return double.Parse(Console.ReadLine());
        }

        public static void DisplayResult(double result) 
        {
            Console.WriteLine($"Resultat: {result}");
        }

      
        public void ShowPreviousCalculations()
        {
            foreach (var calc in _calculation.GetCalculations())
            {
                Console.WriteLine($"{calc.TimeSamp}: {calc.Number1} {calc.Operation} {calc.Number2} = {calc.Result}");
            }
        }
    }
}
