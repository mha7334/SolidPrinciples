using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SRP
{
    public class CalculateSalary
    {
        public double PerDayRate { get; set; }

        public int NumberOfDays { get; set; }

        public double CalcualteSalary()
        {
            return this.PerDayRate * this.NumberOfDays;
        }
    }
}
