using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_zadanie2
{
    internal class Nauczyciel : Uczen
    {
        List<Uczen> podwladniUczniowie;
        string tytulNaukowy;

        public List<Uczen> PodwladniUczniowie
        {
            get
            {
                return podwladniUczniowie;
            }
            set
            {
                podwladniUczniowie = value;

            }
        }

        public string TytulNaukowy
        {
            get
            {
                return tytulNaukowy;
            }
            set
            {
                tytulNaukowy = value;
            }
        }

        public void WhichStudentCanGoHomeAlone()
        {
            foreach (Uczen uczen in podwladniUczniowie)
            {
                if (uczen.CanGoHomeAlone())
                {
                    Console.WriteLine(uczen.GetFullName());
                }
            }
        }
    }
}
