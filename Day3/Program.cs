using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Program
    {
        // 5. Concatenate two one-dimensional arrays
        static int[] ConcatArrays(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            arr1.CopyTo(result, 0);
            arr2.CopyTo(result, arr1.Length);
            return result;
        }

        // 6. Count repeating elements
        static void CountRepeats(int[] arr)
        {
            Dictionary<int, int> count = new Dictionary<int, int>();
            foreach (var num in arr)
            {
                if (count.ContainsKey(num)) count[num]++;
                else count[num] = 1;
            }
            foreach (var pair in count)
                Console.WriteLine($"{pair.Key} occurs {pair.Value} times");
        }

        // 7. Check uniqueness and input unique values
        static int[] InputUniqueArray(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < size;)
            {
                Console.Write($"Enter unique value {i + 1}: ");
                int val = Convert.ToInt32(Console.ReadLine());
                if (!arr.Contains(val))
                {
                    arr[i] = val;
                    i++;
                }
                else Console.WriteLine("Value must be unique. Try again.");
            }
            return arr;
        }

        // 8. Power function
        static int GetPower(int baseVal, int exp)
        {
            int result = 1;
            for (int i = 0; i < exp; i++)
                result *= baseVal;
            return result;
        }

        // 9. Check prime number (1 to 100)
        static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }

        // 11. Factorial function
        static int GetFactorial(int n)
        {
            int result = 1;
            for (int i = 2; i <= n; i++)
                result *= i;
            return result;
        }

        // 12. Longest distance between two equal values
        static int LongestDistance(int[] arr)
        {
            Dictionary<int, int> firstIndex = new Dictionary<int, int>();
            int maxDistance = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (!firstIndex.ContainsKey(arr[i]))
                    firstIndex[arr[i]] = i;
                else
                    maxDistance = Math.Max(maxDistance, i - firstIndex[arr[i]]);
            }
            return maxDistance;
        }

        

        static void Main(string[] args)
        {
            //Console.Write("Enter the size of the array: ");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];

            //FillArray(arr);
            //DisplayArray(arr);
            //Console.WriteLine($"Summation: {SumArray(arr)}");
            //Console.WriteLine("Odd numbers: " + string.Join(", ", GetOdd(arr)));
            //Console.WriteLine("Even numbers: " + string.Join(", ", GetEven(arr)));
            //Console.WriteLine($"Max value: {GetMax(arr)}");
            //Console.WriteLine($"Min value: {GetMin(arr)}");
            //Console.WriteLine($"Average: {GetAvg(arr):F2}");

        int[] arr1 = {1,2, 3, 4 };
            int[] arr2 = { 20, 30, 40, 50 };
            int[] result = ConcatArrays(arr1, arr2);
            //Console.WriteLine(string.Join(", ", result));

            //CountRepeats(new int[]{1,2,1});

            //int[] uniqueArr = InputUniqueArray(10);
            //Console.WriteLine(string.Join(", ", uniqueArr));

            Console.WriteLine(GetPower(2, 3));
            //Console.WriteLine(IsPrime(11));
            //Console.WriteLine(GetFactorial(4));
            //Console.WriteLine(LongestDistance(new int[]{7,0,0,0,5,6,7,5,0,7,5}));
        }

        static void FillArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter value at index {i}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void DisplayArray(int[] arr)
        {
            Console.WriteLine("Array Elements: " + string.Join(", ", arr));
        }

        static int SumArray(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr) sum += num;
            return sum;
        }

        static int[] GetOdd(int[] arr)
        {
            return Array.FindAll(arr, x => x % 2 != 0);
        }

        static int[] GetEven(int[] arr)
        {
            return Array.FindAll(arr, x => x % 2 == 0);
        }

        static int GetMax(int[] arr)
        {
            int max = arr[0];
            foreach (int num in arr) if (num > max) max = num;
            return max;
        }

        static int GetMin(int[] arr)
        {
            int min = arr[0];
            foreach (int num in arr) if (num < min) min = num;
            return min;
        }

        static double GetAvg(int[] arr)
        {
            return (double)SumArray(arr) / arr.Length;
        }
    }
}
