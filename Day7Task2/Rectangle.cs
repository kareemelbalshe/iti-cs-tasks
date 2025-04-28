using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Task2
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
            Console.WriteLine($"Drawing a Rectangle with color {Color}, width {Dim1}, height {Dim2}");
        }
    }

}
