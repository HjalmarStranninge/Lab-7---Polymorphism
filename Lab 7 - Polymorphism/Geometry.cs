using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7___Polymorphism
{
    //Defining parent class 'Geometry'
    public class Geometry
    {
        //The default Area() method returns 0 since there are no variables to calculate. It is set as virtual so I can override it
        //down the line
        public virtual double Area()
        {
            return 0.0;
        }
    }
}
