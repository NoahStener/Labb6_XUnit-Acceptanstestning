namespace Labb6_XUnit_Acceptanstestning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Calculation calculation = new Calculation();
            CalculatorMenu menu = new CalculatorMenu(calculator, calculation);
            menu.ShowMenu();
            
        }
    }
}
