using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    internal class Uczen : Osoba
    {
        string szkola;

        public string Szkola
        {
            get { return szkola; }
            set { szkola = value; }
        }

       /* public string MozeSamWracacDoDomu
        {
            get { return moze_sam_wracac_do_domu; }
            set { moze_sam_wracac_do_domu = value; }
        }*/

        public void SetSchool(string szkola)
        {
            this.szkola = szkola;
        }
        
        public void ChangeSchool(string szkola)
        {
            this.szkola = szkola;
        }

        public void SetCanGoHomeAlone()
        {

        }
    }
}
