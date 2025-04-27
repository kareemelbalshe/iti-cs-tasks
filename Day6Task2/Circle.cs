using System;

namespace Day6Task2
{
    internal class Circle : Shape
    {
        public float Radius { get; set; }

        public Circle(string color, float radius) : base(color)
        {
            Radius = radius;
        }

        public override float CalcArea()
        {
            return (float)(Math.PI * Radius * Radius);
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {Color} Circle");
        }
    }
}
