using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ISP
{
    public interface IUtils
    {
        void Add();

    }
    public interface IUtilsSpecial :IUtils
    {
        void Read();
    }
}
