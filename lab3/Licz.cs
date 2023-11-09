using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Licz
    {
        double Value = 0;
        public double Dodaj(double a)
        {
            Value += a;
            return Value;
        }
        public double Odejmij(double a)
        {
            Value -= a;
            return Value;
        }
        public Licz(double a)
        {
            Value = a;
        }
        public void Wypisz()
        {
            Console.WriteLine($"Wartość wynosi: {Value}");
        }
    }
}
