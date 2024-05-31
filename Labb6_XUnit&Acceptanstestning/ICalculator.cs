using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_XUnit_Acceptanstestning
{
    internal interface ICalculator
    {
        double Addition(double x, double y);
        double Subtraction(double x, double y);
        double Multiplication(double x, double y);
        double Divide(double x, double y);
       
    }
}
