using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Samochod
    {
        string marka;
        string model;
        string nadzwozie;
        string kolor;
        int rok_produkcji;
        int przebieg;

        public Samochod(string marka, string model, string nadzwozie, string kolor, int rok, int przebieg)
        {
            this.marka = marka; 
            this.model = model;
            this.nadzwozie = nadzwozie;
            this.kolor = kolor;
            rok_produkcji = rok;
            this.przebieg = przebieg;
        }

        public string Marka
        {
            get { return marka; }
            set {}
        }

        public string Model
        {
            get { return model; }
            set { }
        }

        public string Nadzwozie
        {
            get { return nadzwozie; }
            set { }
        }

        public string Kolor
        {
            get { return kolor; }
            set { }
        }

        public int Rok_Produkcji
        {
            get { return rok_produkcji;}
            set { }
        }

        public int Przebieg
        {
            get { return przebieg;}
            set { }
        }

        public virtual void View_samochod()
        {
            Console.WriteLine($"\tMarka: {marka}\n\tModel: {model}\n\tNadwozie: {nadzwozie}\n\tKolor: {kolor}\n\tRok produkcji: {rok_produkcji}\n\tPrzebieg: {przebieg}");
        }
    }
}
