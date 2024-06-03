using LearningInterfaces.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaces.Concrete
{
    public class Rectangle : IShape
    {

        public decimal SideA {  get; set; }
        
        public decimal SideB { get; set; }

        public decimal CalculateArea()
        {
            return SideA * SideB;
        }

        public decimal CalculatePerimeter()
        {
            return 2 * (SideA + SideB);   
        }
    }
}
