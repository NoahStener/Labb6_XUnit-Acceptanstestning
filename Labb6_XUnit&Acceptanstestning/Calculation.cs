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
        public double Operand1 { get; set; }
        public double Operand2 { get; set; }
        public double Result {  get; set; }
        public DateTime TimeSamp { get; set; }
    }
}
