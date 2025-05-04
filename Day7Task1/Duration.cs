using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Task1
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public static Duration operator +(Duration d1, Duration d2)
        {
            int totalSeconds = (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) + (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
            return new Duration(totalSeconds);
        }
        public static Duration operator +(Duration d1, int seconds)
        {
            int totalSeconds = (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) + seconds;
            return new Duration(totalSeconds);
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            int totalSeconds1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int totalSeconds2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            return totalSeconds1 > totalSeconds2;
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            return !(d1 > d2);
        }
        public static bool operator >=(Duration d1, Duration d2)
        {
            int totalSeconds1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int totalSeconds2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            return totalSeconds1 >= totalSeconds2;
        }
        public static bool operator <=(Duration d1, Duration d2)
        {
            return !(d1 >= d2);
        }

        public override string ToString()
        {
            return $"{Hours}:{Minutes}:{Seconds}";
        }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
        }
        public void Print()
        {
            if (Hours==0)
            {
                Console.WriteLine($"Minutes: {Minutes} Seconds: {Seconds}");
            }
            else
            {
                Console.WriteLine($"Hours: {Hours} Minutes: {Minutes} Seconds: {Seconds}");
            }
        }
    }
}
