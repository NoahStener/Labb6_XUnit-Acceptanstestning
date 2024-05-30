using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_XUnit_Acceptanstestning
{
    internal interface ICalculator
    {
        void AddCalculation(Calculation calculation);
        void GetCalculations();
        void SaveCalculations();
        void LoadCalculations();


    }
}
