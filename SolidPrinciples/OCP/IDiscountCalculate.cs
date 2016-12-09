using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OCP
{
    public interface IDiscountCalculate
    {
        bool Rule(string ruleName);
        double Calculate(int amount);
    }
}
