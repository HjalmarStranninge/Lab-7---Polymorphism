using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7___Polymorphism
{
    //Fourth subclass 'Parallelogram'
    public class Parallelogram : Geometry
    {
        public double Base { get; set; }
        public double Height { get; set; }


        public Parallelogram()
        {
            Base = 11;
            Height = 20;
        }

        //Basically the same method as the one used for rectangles
        public override double Area()
        {
            return Base * Height;
        }
    }
}
