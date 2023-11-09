using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Sumator
    {
        double[] liczby = new double[5];
        int ilosc_elem;

        public double[] Tablica(double[] liczby_konstr)
        {
            liczby = liczby_konstr;
            return liczby;
        }

        public int IleElementów(double[] i_licz)
        {
            ilosc_elem = 0;
            for (int i = 1; i <= i_licz.Length; i++)
            {
                ilosc_elem = i;
            }
            return ilosc_elem;
        }

        public double Suma_tabl(double[] liczby)
        {
            double sum_elem = 0;
            for (int i = 0; i < liczby.Length; i++)
            {
                sum_elem += liczby[i];
            }
            return sum_elem;
        }
        public double SumaPodziel2(double[] liczby)
        {
            double sum_elempodziel2 = 0;
            for (int i = 0; i < liczby.Length; i++)
            {
                if (liczby[i] % 2 == 0)
                {
                    sum_elempodziel2 += liczby[i];
                }
            }
            return sum_elempodziel2;
        }
        public void Wyswietl()
        {
            Console.Write("Elementy tablicy: ");
            for (int i = 0; i < liczby.Length; i++)
            {
                Console.Write(liczby[i] + " ");
            }
        }
        public void Zakres(int lowindex, int highindex)
        {
            if (lowindex > highindex)
            {
                Console.WriteLine("Indeksy wpisane niepoprawnie!!");
                return;
            }
            for (int i = lowindex; i <= highindex; i++)
            {
                if (i <= liczby.Length - 1)
                {
                    Console.Write(liczby[i] + " ");
                }
            }
        }
    }
}
