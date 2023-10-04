using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7___Polymorphism
{
    //First subclass 'Rectangle'
    public class Rectangle : Geometry
    {
        public double Length { get; set; }
        public double Width { get; set; }

        //Constructor setting the parameters 'Length' and 'Width' which are needed to calculate the area
        public Rectangle()
        {
            Length = 12.5;
            Width = 27;
        }

        //Overrides the base Area() method to calculate the area of a rectangle
        public override double Area()
        {
            return Length * Width;
        }
    }
}
