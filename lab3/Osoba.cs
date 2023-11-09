using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Osoba
    {
        // pola clasy
        private string firstname;
        private string lastname;
        private int age;
        private string city;

        public Osoba() { }

        public Osoba(string firstname, string lastname, int age, string city)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            this.city = city;
        }

        public void View()
        {
            Console.WriteLine($"Imię:\t{firstname}\tNazwisko:\t{lastname}\tWiek:\t{age}\tMiasto:\t{city}");
        }
    }
}
