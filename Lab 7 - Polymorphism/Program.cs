using System.ComponentModel.DataAnnotations;

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
    }
}