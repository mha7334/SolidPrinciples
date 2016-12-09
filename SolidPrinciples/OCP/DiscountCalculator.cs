using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OCP
{
    public class DiscountCalculator
    {
     
        List<IDiscountCalculate> _discountService;
        public DiscountCalculator()
        {   _discountService = new List<IDiscountCalculate>();
            _discountService.Add(new SummerDiscountCalculator());
            _discountService.Add(new WinterDiscountCalculator());
        }

        public double CalculateDiscount(int amount, string rule)
        {
            return _discountService.Find(i => i.Rule(rule)).Calculate(amount);
        }
    }
}
