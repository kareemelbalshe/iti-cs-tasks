using System;

namespace Day6Task2
{
    internal class Shape
    {
        public string Color { get; set; }

        public Shape(string color)
        {
            Color = color;
        }

        public virtual float CalcArea()
        {
            return 0;
        }

        public virtual void Draw()
        {
            Console.WriteLine("Drawing a Shape");
        }
    }
}
