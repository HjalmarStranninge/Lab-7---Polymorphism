using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7___Polymorphism
{
    //Third subclass 'Circle'
    public class Circle : Geometry
    {
        public double Radius { get; set; }

        public Circle()
        {
            Radius = 18.1;
        }

        //Method for calculating the area of a circle
        public override double Area()
        {
            return (Radius * Radius) * Math.PI;
        }
    }
}
