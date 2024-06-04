using InterfaceExampleBank.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExampleBank.Concrete
{
    public class Vakıfbank : IGetCredit
    {
        public decimal GetCredit(int duration, decimal amount)
         {
            if (amount < 50000)
            {

                decimal result = ((amount) * 0.1m * ((decimal)duration / 12)) + amount;

                return result;


            }


            else if (amount >= 50000)
            {


                decimal calculate = ((amount) * 0.7m * ((decimal)duration / 12)) + amount;

                return calculate;

            }

            else
            {
                return amount;
            }
        }
    }

}


