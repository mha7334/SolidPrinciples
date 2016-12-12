using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DIP
{
    public interface INofificationAction
    {
        void ActOnNotification(string message);
    }
}
