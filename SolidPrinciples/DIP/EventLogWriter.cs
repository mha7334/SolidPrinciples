using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DIP
{
    public class EventLogWriter : INofificationAction
    {
        public void ActOnNotification(string message)
        {
            Console.WriteLine("EventLog:" + message);
        }
    }

    public class EmailSender : INofificationAction
    {
        public void ActOnNotification(string message)
        {
            Console.WriteLine("Email:" + message);
        }
    }

    public class SMSSender : INofificationAction
    {
        public void ActOnNotification(string message)
        {
            Console.WriteLine("SMS:" + message);
        }
    }

}
