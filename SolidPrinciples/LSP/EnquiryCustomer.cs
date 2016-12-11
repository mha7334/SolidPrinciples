using SolidPrinciples.LSP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LSP
{
    public class EnquiryCustomer : IDiscount
    {
        public double GetDiscount(double TotalSales)
        {
            return TotalSales - 5;
        }
    }
}
