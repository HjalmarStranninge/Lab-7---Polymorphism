using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7___Polymorphism
{
    //Fifth subclass 'Ellipse'
    public class Ellipse : Geometry
    {
        //Has similar properties to a circle but since it isn't perfectly round there is a long as well as a short radius
        public double RadiusLong { get; set; }
        public double RadiusShort { get; set; }

        public Ellipse()
        {
            RadiusLong = 22;
            RadiusShort = 10;
        }

        //Method for calculating the area
        public override double Area()
        {
            return RadiusLong * RadiusShort * Math.PI;
        }
    }
}
