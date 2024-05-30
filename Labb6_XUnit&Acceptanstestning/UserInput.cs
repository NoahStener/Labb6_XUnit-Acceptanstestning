using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_XUnit_Acceptanstestning
{
    public class UserInput
    {
        public static void CalcMenu()
        {
            Calculator calculator = new Calculator();
            calculator.LoadCalculations();

            while (true)
            {
                Console.WriteLine("Välj räknesätt och två siffor");
                Console.WriteLine("1: Addition");
                Console.WriteLine("2: Subtraktion");
                Console.WriteLine("3: Multiplikation");
                Console.WriteLine("4: Division");
                Console.WriteLine("5: Visa tidigare beräkningar");
                Console.WriteLine("0: Avsluta");
                string choice = Console.ReadLine();

                if (choice == "0")
                {
                    calculator.SaveCalculations();
                    break;
                }
                if (choice == "5")
                {
                    ShowPreviousCalculations(calculator);
                    continue;
                }

                Console.WriteLine("Ange första siffran");
                double number1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ange andra siffran");
                double number2 = double.Parse(Console.ReadLine());

                double result = 0;
                string operation = "";

                switch (choice)
                {
                    case "1":
                        result = calculator.Addition(number1, number2);
                        operation = "Addition";
                        break;
                    case "2":
                        result = calculator.Subtraction(number1, number2);
                        operation = "Subtraktion";
                        break;
                    case "3":
                        result = calculator.Multiplication(number1, number2);
                        operation = "Multiplikation";
                        break;
                    case "4":
                        try
                        {
                            result = calculator.Divide(number1, number2);
                            operation = "Division";
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    default:
                        Console.WriteLine("Ogitligt val");
                        continue;
                }

                Console.WriteLine($"Resultat: {result}");

                Calculation calculation = new Calculation
                {
                    Operation = operation,
                    Operand1 = number1,
                    Operand2 = number2,
                    Result = result,
                    TimeSamp = DateTime.Now
                };

                calculator.AddCalculation(calculation);
            }
        }

        public static void ShowPreviousCalculations(Calculator calculator)
        {
            var calculations = calculator.GetCalculations();
            if(calculations.Count == 0)
            {
                Console.WriteLine("Inga tidigare beräkningar");
                return;
            }

            Console.WriteLine("Tidigare beräkningar:");
            foreach(var calc in  calculations)
            {
                Console.WriteLine($"{calc.TimeSamp}: {calc.Operand1} {calc.Operation} {calc.Operand2} = {calc.Result}");
            }
        }
    }
}
