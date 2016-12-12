using SolidPrinciples.DIP;
using SolidPrinciples.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    //SOLID Principles
    class Program
    {
        static void Main(string[] args)
        {
            //SRP - Single Responsibility Principle
            CalculateSalary calSal = new CalculateSalary();
            calSal.NumberOfDays = 5;
            calSal.PerDayRate = 250;
            
            PrintSalary printSal = new PrintSalary();
            printSal.PrintSal(calSal.CalcualteSalary());

            //DIP
            AppPoolWatcher watcher = new AppPoolWatcher(new EventLogWriter());
            watcher.Notify("Sample message to log");
            watcher = new AppPoolWatcher(new SMSSender());
            watcher.Notify("Sendt!");

        }
    }
}
