using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        // Task 1: Sum of Two Integers (Triple if Equal)
        static void SumOrTriple()
        {
            Console.WriteLine("Enter first integer:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second integer:");
            int num2 = int.Parse(Console.ReadLine());

            int result;

            if (num1 == num2)
            {
                result = (num1 + num2) * 3;
            }
            else
            {
                result = num1 + num2;
            }

            Console.WriteLine($"Result: {result}");
        }

        // Task 2: Absolute Difference from 51
        static void AbsoluteDifference()
        {
            Console.Write("Enter an integer: ");
            int n = int.Parse(Console.ReadLine());

            int diff = Math.Abs(n - 51);
            if (n > 51)
                diff *= 3;

            Console.WriteLine($"Result: {diff}");
        }

        // Task 3: Check if one is 30 or sum is 30
        static void IsThirtyOrSum()
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            bool result = (num1 == 30 || num2 == 30 || (num1 + num2 == 30));
            Console.WriteLine($"Result: {result}");
        }

        // Task 4: Multiple of 3 or 7
        static void MultipleOf3Or7()
        {
            Console.Write("Enter a positive number: ");
            int number = int.Parse(Console.ReadLine());

            bool result = (number % 3 == 0 || number % 7 == 0);
            Console.WriteLine($"Result: {result}");
        }

        // Task 5: Either number in range 100..200
        static void InRange100To200()
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            bool result = (num1 >= 100 && num1 <= 200) || (num2 >= 100 && num2 <= 200);
            Console.WriteLine($"Result: {result}");
        }

        // Task 6: At least one of three numbers is in range 20..50
        static void OneInRange20To50()
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = int.Parse(Console.ReadLine());

            bool result = (a >= 20 && a <= 50) || (b >= 20 && b <= 50) || (c >= 20 && c <= 50);
            Console.WriteLine($"Result: {result}");
        }

        // Task 7: Largest among three numbers
        static void LargestOfThree()
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = int.Parse(Console.ReadLine());

            int max = Math.Max(a, Math.Max(b, c));
            Console.WriteLine($"Largest number is: {max}");
        }

        // Task 8: Closest to 100
        static void ClosestTo100()
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            int result = 0;
            if (a == b)
                result = 0;
            else
            {
                int diffA = Math.Abs(100 - a);
                int diffB = Math.Abs(100 - b);
                result = diffA < diffB ? a : b;
            }

            Console.WriteLine($"Closest to 100 is: {result}");
        }

        // Task 9: Check if both in same range (40..50 or 50..60)
        static void SameRange40To60()
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            bool in40To50 = a >= 40 && a <= 50 && b >= 40 && b <= 50;
            bool in50To60 = a >= 50 && a <= 60 && b >= 50 && b <= 60;

            bool result = in40To50 || in50To60;
            Console.WriteLine($"Result: {result}");
        }

        // Task 10: Larger in range 20..30
        static void LargerInRange20To30()
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            bool aInRange = a >= 20 && a <= 30;
            bool bInRange = b >= 20 && b <= 30;

            int result = 0;
            if (aInRange && bInRange)
                result = Math.Max(a, b);
            else if (aInRange)
                result = a;
            else if (bInRange)
                result = b;

            Console.WriteLine($"Result: {result}");
        }


        // Task 11: Repeat a string n times
        static void RepeatStringNTimes()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            Console.Write("Enter how many times to repeat: ");
            int n = int.Parse(Console.ReadLine());

            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += input;
            }
            Console.WriteLine($"Result: {result}");
        }

        // Task 12: Check if one is 5 or sum/difference is 5
        static void CheckIfFive()
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            bool result = a == 5 || b == 5 || (a + b == 5) || (Math.Abs(a - b) == 5);
            Console.WriteLine($"Result: {result}");
        }

        // Task 13: Multiple of 3 or 7 but not both
        static void Multiple3Or7ButNotBoth()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            bool result = (n % 3 == 0 ^ n % 7 == 0);
            Console.WriteLine($"Result: {result}");
        }

        // Task 14: FizzBuzz
        static void FizzBuzzCheck()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 3 == 0 && n % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if (n % 3 == 0)
                Console.WriteLine("Fizz");
            else if (n % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine("Not divisible by 3 or 5");
        }

        // Task 15: Can two numbers add up to the third?
        static void CanAddToThird()
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = int.Parse(Console.ReadLine());

            bool result = (a + b == c) || (a + c == b) || (b + c == a);
            Console.WriteLine($"Result: {result}");
        }


        // Task 16: Check if y > x and z > y
        static void CheckIncreasingOrder()
        {
            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Enter z: ");
            int z = int.Parse(Console.ReadLine());

            bool result = y > x && z > y;
            Console.WriteLine($"Result: {result}");
        }

        // Task 17: Multiplication Table
        static void MultiplicationTable()
        {
            Console.WriteLine("Multiplication Table (1 to 5):");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write($"{i}*{j}={i * j}\t");
                }
                Console.WriteLine();
            }
        }

        // Task 18: Max and Min of 3 positive numbers
        static void MaxMinOfThree()
        {
            Console.Write("Enter first number: ");
            int fn = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int sn = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int tn = int.Parse(Console.ReadLine());

            int max = Math.Max(fn, Math.Max(sn, tn));
            int min = Math.Min(fn, Math.Min(sn, tn));

            Console.WriteLine($"Max = {max}, Min = {min}");
        }

        // Task 19: Sum numbers until total reaches or exceeds 400
        static void SumUntil400()
        {
            int sum = 0;
            while (sum < 400)
            {
                Console.Write("Enter a positive number: ");
                int num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    sum += num;
                    Console.WriteLine($"Current Sum = {sum}");
                }
                else
                {
                    Console.WriteLine("Please enter a positive number only.");
                }
            }
            Console.WriteLine($"Final Sum = {sum} (Reached or exceeded 400)");
        }

        // Task 20: Calculator with selection menu
        static void CalculatorMenu()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nChoose Operation: + | - | * | / | e (exit)");
                Console.Write("Enter your choice: ");
                string op = Console.ReadLine();

                if (op == "e")
                {
                    running = false;
                    break;
                }

                Console.Write("Enter first number: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                double b = double.Parse(Console.ReadLine());

                switch (op)
                {
                    case "+":
                        Console.WriteLine($"Result: {a + b}");
                        break;
                    case "-":
                        Console.WriteLine($"Result: {a - b}");
                        break;
                    case "*":
                        if (a != 0 && b != 0)
                            Console.WriteLine($"Result: {a * b}");
                        else
                            Console.WriteLine("Both numbers must be non-zero.");
                        break;
                    case "/":
                        if (b != 0)
                            Console.WriteLine($"Result: {a / b}");
                        else
                            Console.WriteLine("Cannot divide by zero.");
                        break;
                    default:
                        Console.WriteLine("Invalid operation.");
                        break;
                }
            }
        }


        // Task 21: Display even, odd numbers and their sums and difference
        static void EvenOddBetween()
        {
            Console.Write("Enter first positive number: ");
            int fn = int.Parse(Console.ReadLine());
            Console.Write("Enter second positive number: ");
            int sn = int.Parse(Console.ReadLine());

            int start = Math.Min(fn, sn);
            int end = Math.Max(fn, sn);

            int[] evenNumbers = new int[end-start];
            int[] oddNumbers = new int[end-start];
            int evenSum = 0, oddSum = 0;

            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbers.SetValue(i, i+fn);
                    evenSum += i;
                }
                else
                {
                    oddNumbers.SetValue(i, i + fn);
                    oddSum += i;
                }
            }

            Console.WriteLine($"Even Numbers: {string.Join(", ", evenNumbers)}");
            Console.WriteLine($"Sum of Even = {evenSum}");

            Console.WriteLine($"Odd Numbers: {string.Join(", ", oddNumbers)}");
            Console.WriteLine($"Sum of Odd = {oddSum}");

            Console.WriteLine($"Absolute Difference = {Math.Abs(evenSum - oddSum)}");
        }
        static void Main(string[] args)
        {

            //Lab2
            bool runProgram = true;

            while (runProgram)
            {
                Console.Clear();
                Console.WriteLine("=== C# OOP Lab Exercises ===");
                Console.WriteLine("1. Sum of Two Integers (Triple if Equal)");
                Console.WriteLine("2. Absolute Difference from 51");
                Console.WriteLine("3. Check if 30 or Sum is 30");
                Console.WriteLine("4. Multiple of 3 or 7");
                Console.WriteLine("5. In Range 100-200");
                Console.WriteLine("6. Any in Range 20-50");
                Console.WriteLine("7. Find Largest of Three");
                Console.WriteLine("8. Nearest to 100");
                Console.WriteLine("9. Check Range 40-50 or 50-60");
                Console.WriteLine("10. Max in Range 20-30");
                Console.WriteLine("11. Repeat String n Times");
                Console.WriteLine("12. Check 5, Sum or Diff is 5");
                Console.WriteLine("13. Multiple of 3 or 7 (Not Both)");
                Console.WriteLine("14. FizzBuzz");
                Console.WriteLine("15. Add Two Equals Third");
                Console.WriteLine("16. y > x, z > y");
                Console.WriteLine("17. Multiplication Table");
                Console.WriteLine("18. Max & Min of 3 Numbers");
                Console.WriteLine("19. Sum Until ≥ 400");
                Console.WriteLine("20. Calculator Menu");
                Console.WriteLine("21. Even & Odd Between Two Numbers");
                Console.WriteLine("0. Exit");
                Console.Write("\nEnter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (choice)
                {
                    case 1:
                        SumOrTriple();
                        break;
                    case 2:
                        AbsoluteDifference();
                        break;
                    case 3:
                        IsThirtyOrSum();
                        break;
                    case 4:
                        MultipleOf3Or7();
                        break;
                    case 5:
                        InRange100To200();
                        break;
                    case 6:
                        OneInRange20To50();
                        break;
                    case 7:
                        LargestOfThree();
                        break;
                    case 8:
                        ClosestTo100();
                        break;
                    case 9:
                        SameRange40To60();
                        break;
                    case 10:
                        LargerInRange20To30();
                        break;
                    case 11:
                        RepeatStringNTimes();
                        break;
                    case 12:
                        CheckIfFive();
                        break;
                    case 13:
                        Multiple3Or7ButNotBoth();
                        break;
                    case 14:
                        FizzBuzzCheck();
                        break;
                    case 15:
                        CanAddToThird();
                        break;
                    case 16:
                        CheckIncreasingOrder();
                        break;
                    case 17:
                        MultiplicationTable();
                        break;
                    case 18:
                        MaxMinOfThree();
                        break;
                    case 19:
                        SumUntil400();
                        break;
                    case 20:
                        CalculatorMenu();
                        break;
                    case 21:
                        EvenOddBetween();
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

                if (choice != 0)
                {
                    Console.Write("\nDo you want to run another task? (y/n): ");
                    string answer = Console.ReadLine().ToLower();
                    runProgram = (answer == "y" || answer == "Y");
                }
            }

            Console.WriteLine("\nProgram Ended. Goodbye!");


           
        }
    }
}

