using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Persona
    {
        string firstName;
        string lastName;
        public int wiek;

        public string FirstName
        {
            get { return firstName; }
            set { }
        }
        public string LastName
        {
            get { return lastName; }
            set { }
        }
        public Persona(string firstname, string lastname, int wiek)
        {
            firstName = firstname;
            lastName = lastname;
            this.wiek = wiek;
        }

        public virtual void View()
        {
            Console.WriteLine($"Imię: {firstName}\nNazwisko: {lastName}\nWiek: {wiek}");
        }
    }
}
