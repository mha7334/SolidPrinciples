using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SRP
{
    class PrintSalary
    {       
        public void PrintSal(double amount)
        {
            Console.WriteLine("Salary: " + amount);
        }
    }
}
