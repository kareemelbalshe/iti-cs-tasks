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
