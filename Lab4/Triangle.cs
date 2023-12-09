using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Triangle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Rysuję trójkąt");
        }
    }
}
