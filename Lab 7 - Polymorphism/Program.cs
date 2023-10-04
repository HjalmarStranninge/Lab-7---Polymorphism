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
    }
} 