using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Szescina : IFigura3D
    {
        double a = 6;

        public void objetnosc()
        {
            Console.WriteLine($"Objętność: {a * a * a}");
        }

        public void pole()
        {
            Console.WriteLine($"Pole: {6 * a}");
        }
    }
}
