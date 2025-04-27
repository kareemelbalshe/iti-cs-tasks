using System;

namespace Day6Task2
{
    internal class Rectangle : Shape
    {
        public float Dim1 { get; set; }
        public float Dim2 { get; set; }

        public Rectangle(string color, float dim1, float dim2) : base(color)
        {
            Dim1 = dim1;
            Dim2 = dim2;
        }

        public override float CalcArea()
        {
            return Dim1 * Dim2;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {Color} Rectangle");
        }
    }
}
