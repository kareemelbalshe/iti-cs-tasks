using System;

namespace Day6Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
       {
            new Circle("Red", 5),
            new Rectangle("Blue", 4, 6),
            new Square("Green", 4),
            new Triangle("Yellow", 3, 4, 5)
       };

            RunAllDraw(shapes);
            CalculateAllAreas(shapes);
        }

        static void RunAllDraw(Shape[] shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }

        static void CalculateAllAreas(Shape[] shapes)
        {
            float totalArea = 0;
            foreach (var shape in shapes)
            {
                totalArea += shape.CalcArea();
            }
            Console.WriteLine($"Total Area of All Shapes: {totalArea}");
        }
    }
}
