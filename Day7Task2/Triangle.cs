using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Task2
{
    internal class Triangle : Shape
    {
        public float Dim1 { get; set; }
        public float Dim2 { get; set; }
        public float Dim3 { get; set; }

        public Triangle(string color, float dim1, float dim2, float dim3) : base(color)
        {
            Dim1 = dim1;
            Dim2 = dim2;
            Dim3 = dim3;
        }

        public override float CalcArea()
        {
            float s = (Dim1 + Dim2 + Dim3) / 2;
            return (float)Math.Sqrt(s * (s - Dim1) * (s - Dim2) * (s - Dim3));
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a Triangle with color {Color} and sides {Dim1}, {Dim2}, {Dim3}");
        }
    }

}
