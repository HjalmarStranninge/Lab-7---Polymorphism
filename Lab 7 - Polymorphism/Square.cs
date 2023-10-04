using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7___Polymorphism
{
    //Second subclass 'Square'
    public class Square : Geometry
    {
        public double Side { get; set; }

        public Square()
        {
            Side = 14;
        }

        //Essentially the same as the method for rectangle
        public override double Area()
        {
            return Side * Side;
        }
    }
}
