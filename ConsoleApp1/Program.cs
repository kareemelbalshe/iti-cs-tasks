using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lab1
            #region lab1
            Console.WriteLine("Hello World");

            Console.Write("Enter a character: ");
            string input = Console.ReadLine();

            char ch = input[0];
            Console.WriteLine("ASCII code of '{0}' is: {1}", ch, (int)ch);

            Console.Write("Enter an ASCII code (0-127): ");
            int code = int.Parse(Console.ReadLine());
            char ch2 = (char)code;
            Console.WriteLine("Character for ASCII code {0} is: '{1}'", code, ch2);

            Console.Write("Enter a decimal number: ");
            int num = int.Parse(Console.ReadLine());
            string hex = num.ToString("X");
            Console.WriteLine("Hexadecimal of {0} is: {1}", num, hex);

            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum: {0}", num1 + num2);
            Console.WriteLine("Subtraction: {0}", num1 - num2);
            Console.WriteLine("Multiplication: {0}", num1 * num2);
            #endregion
        }
    }
}
