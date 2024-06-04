using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExampleBank.Abstractions
{
    public interface IGetCredit
    {

        decimal GetCredit(int duration, decimal amount);

    }
}
