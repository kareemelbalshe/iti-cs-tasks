using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public enum Gender { M, F }
    public enum SecurityLevel { Guest, Developer, Secretary, DBA }

    internal class Employee
    {
        private int id;
        private string name;
        private SecurityLevel securityLevel;
        private double salary;
        private HireDate hireDate;
        private Gender gender;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public SecurityLevel Security { get => securityLevel; set => securityLevel = value; }
        public double Salary { get => salary; set => salary = value; }
        public HireDate HireDate { get => hireDate; set => hireDate = value; }
        public Gender Gender { get => gender; set => gender = value; }

        public Employee() : this(0, "", SecurityLevel.Guest, 0.0, new HireDate(), Gender.M) { }

        public Employee(int id, string name, SecurityLevel sec, double salary, HireDate hireDate, Gender gender)
        {
            ID = id;
            Name = name;
            Security = sec;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        public void Print()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Security: {Security}, Salary: {Salary}, Gender: {Gender}");
            Console.Write("Hire Date: ");
            HireDate.Print();
        }
    }

}
