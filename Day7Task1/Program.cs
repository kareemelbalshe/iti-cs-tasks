using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duration duration1 = new Duration(1, 30, 45);
            duration1.Print();
            Console.WriteLine();
            Duration duration2 = new Duration(3600);
            duration2.Print();
            Console.WriteLine();
            Duration duration3 = new Duration(666);
            duration3.Print();
            Console.WriteLine();

            Duration duration4 = duration1 + duration3;
            Console.WriteLine(duration4);

            Duration duration5 = duration1 + 3600;
            Console.WriteLine(duration5);

            if (duration1 > duration2)
            {
                Console.WriteLine("duration1 is greater than duration2");
            }
            else
            {
                Console.WriteLine("duration1 is less than duration2");
            }
            if (duration1 >= duration2)
            {
                Console.WriteLine("duration1 is greater than or equal to duration2");
            }
            else
            {
                Console.WriteLine("duration1 is less than duration2");
            }
        }
    }
}
