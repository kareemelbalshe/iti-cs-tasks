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
            Console.ReadLine();
        }
    }
}
