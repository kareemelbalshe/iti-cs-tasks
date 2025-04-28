using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
                new Circle("Red", 5),
                new Rectangle("Blue", 4, 6),
                new Square("Green", 3),
                new Triangle("Yellow", 3, 4, 5)
            };

            RunAllDraw(shapes);
        }

        public static void RunAllDraw(Shape[] shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
                Console.WriteLine($"Area: {shape.CalcArea()}");
                Console.WriteLine();
            }
        }


    }
}
