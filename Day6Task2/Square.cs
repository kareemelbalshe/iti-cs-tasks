using System;

namespace Day6Task2
{
    internal class Square : Rectangle
    {
        public Square(string color, float side) : base(color, side, side)
        {
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {Color} Square");
        }
    }
}
