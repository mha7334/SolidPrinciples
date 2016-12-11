using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LSP
{
    public class SilverCustomer:IDatabase, IDiscount
    {
        public virtual void Add()
        {
            //Add to database.
        }

        public double GetDiscount(double TotalSales)
        {
            return TotalSales - 5;
        }
    }
}
