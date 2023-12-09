using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Shape
    {
        double x;
        double y;
        double height;
        double width;
        public double X
        {
            get { return x; }
            set { }
        }
        public double Y
        {
            get { return y; }
            set { }
        }

        public double Height
        {
            get { return height; }
            set { }
        }

        public double Width
        {
            get { return width; }
            set { }
        }

        public virtual void Draw()
        {

        }
    }
}
