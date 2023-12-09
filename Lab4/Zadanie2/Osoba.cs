using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    public virtual class Osoba
    {
        string imie;
        string nazwisko;
        string pesel;
        
        public void SetFirstName(string imie)
        {
            this.imie = imie;
        }

        public void SetLastName(string nazwisko)
        {
            this.nazwisko = nazwisko;
        }

        public void SetPesel(string pesel)
        {
            this.pesel = pesel;
        }

        public void GetAge(string pesel)
        {
            int year = int.Parse(pesel.Substring(0, 2));
            int month = int.Parse(pesel.Substring(2,2));
            int day = int.Parse(pesel.Substring(4,2));
        }

        public void GetGender(string pesel)
        {
            string gender;
            int pozycja = int.Parse(pesel.Substring(9,1));
            
            if (pozycja % 2  == 0)
            {
                gender = "Kobieta";
            }
            else
            {
                gender = "Mężczyzna";
            }
        }
        public void GetEducationInfo()
        {

        }
        public void GetFullName(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
        public void CanGoAloneToHome()
        {
            
        }
    } 
}


