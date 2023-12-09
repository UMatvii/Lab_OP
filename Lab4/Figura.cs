using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
     abstract internal class Figura
    {
        public abstract double pole();
        public abstract double obwod();

        public void View()
        {
            Console.WriteLine($"Klasa abstrakcyjna metoda zwykła");
        }
    }
}
