using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Data
    {
        DateTime data;

        public Data()
        {
            data = DateTime.Now;
        }

        public DateTime Teraz()
        {
            return data;
        }

        public void przezPrzodSied()
        {
            data = data.AddDays(7);
        }

        public void przezWtylSied()
        {
            data = data.AddDays(-14);
        }

    }
}
