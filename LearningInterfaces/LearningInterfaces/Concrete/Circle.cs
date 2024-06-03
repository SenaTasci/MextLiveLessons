using LearningInterfaces.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaces.Concrete
{
    public class Circle : IShape
    {
        public decimal Radius { get; set; }
        public decimal CalculateArea()
        {

            var result = (decimal)Math.PI * (Radius * Radius);

            return Math.Floor(result * 100) / 100;
        }

        public decimal CalculatePerimeter()
        {

            var calculate = (decimal)Math.PI * 2 * Radius;

            return Math.Floor(calculate * 100) / 100;


        }
    }
}
