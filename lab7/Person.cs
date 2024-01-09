using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace lab7
{
    internal class Person
    {
        public string firstName;
        public string lastName;
        public string pesel;
        public Addres addres;
        public string email;

        public Person(string firstName, string lastName, string pesel, Addres addres, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.pesel = pesel;
            this.addres = addres;
            this.email = email;
        }
    }
}
