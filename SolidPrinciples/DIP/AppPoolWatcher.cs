using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DIP
{
    public class AppPoolWatcher
    {
        // Handle to EventLog writer to write to the logs
        INofificationAction action = null;

        public AppPoolWatcher(INofificationAction concreteImplementation)
        {
            this.action = concreteImplementation;
        }

        // This function will be called when the app pool has problem
        public void Notify(string message)
        {
            action.ActOnNotification(message);
        }
    }
}
