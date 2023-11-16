using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class SamochodOsobowy : Samochod
    {
        double waga;
        double pojemnosc_silnika;
        int ilosc_osob;

        public SamochodOsobowy(Samochod samochod, double waga, double pojemnosc, int ilosc_Os):
            base(samochod.Marka, samochod.Model, samochod.Nadzwozie, samochod.Kolor, samochod.Rok_Produkcji, samochod.Przebieg)
        {
            this.waga = waga;
            pojemnosc_silnika = pojemnosc;
            ilosc_osob = ilosc_Os;
        }

        public override void View_samochod()
        {
            base.View_samochod();
            Console.WriteLine($"\tWaga samochodu: {waga}\n\tPojemność silnika: {pojemnosc_silnika}\n\tIlośćosób: {ilosc_osob}");
        }
    }
}
