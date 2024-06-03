using EducationInterfaces.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationInterfaces.Concretes
{
    public class KocaeliUniversity : IGradeCalculation
    {

        public double Grade1 { get; set; }

        public double Grade2 { get; set; }

        public double CalculateGrade()
        {
            return 0.4 * Grade1 + 0.6 * Grade2;
        }
    }


}
