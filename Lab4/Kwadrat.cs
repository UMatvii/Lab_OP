using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Kwadrat : Figura
    {
        double a = 4;

        public override double obwod()
        {
            return a * a;
        }

        public override double pole()
        {
            return 4 * a;
        }
    }
}
