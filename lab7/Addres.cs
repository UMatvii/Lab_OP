using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Addres
    {
        string streetName;
        string city;
        string streetNum;
        string apartNum;

        public string StreetName
        {
            get { return streetName; }
            set { streetName = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string StreetNum
        {
            get { return streetNum; }
            set { streetNum = value; }
        }

        public string ApartNum
        {
            get { return apartNum; }
            set { apartNum = value; }
        }
    }
}
