using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Lab_7___Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle();
            Console.WriteLine($"Area rektangel: {rectangle.Area()}");

            var square = new Square();
            Console.WriteLine($"Area fyrkant: {square.Area()}");

            var circle = new Circle();
            Console.WriteLine($"Area cirkel: {circle.Area()}");
        }

        //Defining parent class 'Geometry'
        public class Geometry
        {
            //The default Area() method returns 0 since there are no variables to calculate. Is virtual so I can override it down the line
            public virtual double Area()
            {
                return 0.0;
            }
        }

        //First subclass 'Rectangle'
        public class Rectangle: Geometry
        {
            public double Length { get;set; } 
            public double Width { get;set; }

            //Constructor setting the parameters 'Length' and 'Width' which are needed to calculate the area
            public Rectangle()
            {
                Length = 12.5;
                Width = 27;
            }

            //Overrides the base Area() method to calculate the area of a rectangle
            public override double Area()
            {              
                return Length*Width;
            }
        }

        //Second subclass 'Square'
        public class Square: Geometry
        {
            public double Side { get;set; }

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

        //Third subclass 'Circle'
        public class Circle: Geometry
        {
            public double Radius { get;set; }

            public Circle()
            {
                Radius = 18.1;
            }

            //Method for calculating the area of a circle
            public override double Area()
            {
                return (2*Radius) * Math.PI;
            }
        }

    }
}