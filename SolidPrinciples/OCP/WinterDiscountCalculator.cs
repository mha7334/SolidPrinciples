using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OCP
{
    public class WinterDiscountCalculator : IDiscountCalculate
    {
        public bool Rule(string ruleName)
        {
            return "winter".Equals(ruleName);
        }
        public double Calculate(int amount)
        {
            return amount * 0.10;
        }
    }
}
