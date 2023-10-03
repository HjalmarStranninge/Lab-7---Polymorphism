using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Lab_7___Polymorphism
{
    internal class Program
    {
        //Creating an object in each class and using the associated methods. The 'Math.Round' method is used to limit the amount of
        //decimals printed to 2
        static void Main(string[] args)
        {
            Geometry rectangle = new Rectangle();
            Console.WriteLine($"Area rektangel: {Math.Round(rectangle.Area(), 2)}");

            Geometry square = new Square();
            Console.WriteLine($"Area fyrkant: {Math.Round(square.Area(), 2)}");

            Geometry circle = new Circle();
            Console.WriteLine($"Area cirkel: {Math.Round(circle.Area(), 2)}");

            Geometry parallelogram = new Parallelogram();
            Console.WriteLine($"Area parallellogram: {Math.Round(parallelogram.Area(), 2)}");

            Geometry ellipse = new Ellipse();
            Console.WriteLine($"Area ellips: {Math.Round(ellipse.Area(), 2)}");
        }


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
                return (2 * Radius) * Math.PI;
            }
        }


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


        //Fifth subclass 'Ellipse'
        public class Ellipse: Geometry
        {
            //Has similar properties to a circle but since it isn't perfectly round there is a long as well as a short radius
            public double RadiusLong { get; set; }
            public double RadiusShort { get; set; }

            public Ellipse()
            {
                RadiusLong = 32;
                RadiusShort = 20;
            }

            //Method for calculating the area
            public override double Area()
            {
                return (RadiusLong * RadiusShort) * Math.PI;
            }
        }
    }
} 