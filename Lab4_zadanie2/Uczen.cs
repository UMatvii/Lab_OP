using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_zadanie2
{
    internal class Uczen : Osoba
    {
        public string szkola
        {
            get; set;

        }

        public bool MozeSamWracacDoDomu
        {
            get; set;
        } = false;

        public void SetSchool(string school)
        {
            szkola = school;
        }

        public void ChangeSchool(string school)
        {
            SetSchool(school);
        }

        public void SetCanGoHomeAlone(bool canGoHomeAlone)
        {
            MozeSamWracacDoDomu = canGoHomeAlone;

        }

        public override bool CanGoHomeAlone()
        {
            int age = GetAge();
            if (age >= 12 || MozeSamWracacDoDomu)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string GetEducationInfo()
        {
            return $"Imię: {GetFullName()}\nSzkoła: {szkola}\nWiek: {GetAge()}";
        }
    }
}
