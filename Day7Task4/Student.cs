using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Task4
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; } 
        public string Email { get; set; }

        public void Print()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Username: {UserName}, Email: {Email}");
        }

    }
}
