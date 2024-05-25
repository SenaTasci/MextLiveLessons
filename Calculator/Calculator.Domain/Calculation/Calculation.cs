using Calculator.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Domain.Calculation
{
    public class CalculationBase
    {
        public string Id { get; set; }
        public Operations Operation { get; set; }
        public double Result { get; set; }

    }
    public class Calculation : CalculationBase
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }

    }

}
