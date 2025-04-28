using System;

namespace Day7Task2
{
    abstract class Shape
    {
        public string Color { get; set; }

        public Shape(string color)
        {
            Color = color;
        }

        public abstract float CalcArea();

        public virtual void Draw()
        {
            Console.WriteLine($"Drawing a shape with color {Color}");
        }
    }

}