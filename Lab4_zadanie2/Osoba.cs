using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_zadanie2
{
    public abstract class Osoba
    {

        string imie;
        string nazwisko;
        string pesel;

        public string SetFirstName
        {
            set { imie = value; }
        }

        public string SetLastName
        {
            set { nazwisko = value; }
        }

        public string Pesel
        {
            get { return pesel; }
            set { pesel = value; }
        }

        public virtual int GetAge()
        {
            DateTime now = DateTime.Now;
            int year = int.Parse(pesel.Substring(0, 2)) + 1900;
            int month = int.Parse(pesel.Substring(2, 2));
            int day = int.Parse(pesel.Substring(4, 2));
            DateTime birthdate = new DateTime(year, month, day);
            int age = now.Year - birthdate.Year;
            return age;
        }

        public virtual void GetGender()
        {
            string gender;
            int num = int.Parse(pesel.Substring(9, 1));
            if (num % 2 == 0)
            {
                gender = "Kobieta";

            }
            else
            {
                gender = "Mężczyzna";
            }
        }

        public abstract string GetEducationInfo();

        public string GetFullName()
        {
            return $"{imie} {nazwisko}";
        }

        public abstract bool CanGoHomeAlone();
    }
}
