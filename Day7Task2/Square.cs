using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Task2
{
    internal class Square : Rectangle
    {
        public Square(string color, float side) : base(color, side, side)
        {
        }

        public override float CalcArea()
        {
            return Dim1 * Dim1; 
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a Square with color {Color} and side {Dim1}");
        }
    }

}
