using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OCP
{
    public class SummerDiscountCalculator:IDiscountCalculate
    {
        public bool Rule(string ruleName)
        {
            return "summer".Equals(ruleName);
        }
        public double Calculate(int amount)
        {
            return amount * 0.15;
        }
    }
}
