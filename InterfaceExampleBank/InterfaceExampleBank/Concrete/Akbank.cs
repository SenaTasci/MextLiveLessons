using InterfaceExampleBank.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExampleBank.Concrete
{
    public class Akbank : IGetCredit

    {
       

       public decimal GetCredit(int duration, decimal amount)
        {
            if (amount < 50000)
            {

                decimal result = ((amount) * 0.2m * ((decimal)duration / 12)) + amount;

                return result;
            
            
            }


            else if (amount >= 50000)
            {


                decimal calculate = ((amount) * 0.4m * ((decimal)duration / 12)) + amount;

                return calculate;

            }

            else
            {
                return amount;
            }
        }
    }
}
