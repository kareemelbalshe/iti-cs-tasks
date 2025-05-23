﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Task3
{
    internal abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Salary { get; set; }

        public Client []Clients;

        public Employee(int id, string name, double salary, Client[] clients)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Clients = clients;
        }

        public abstract void ShowEmployeeDetails();
        public static bool operator >(Employee e1, Employee e2)
        {
            return e1.Salary > e2.Salary;
        }
        public static bool operator <(Employee e1, Employee e2)
        {
            return !(e1 > e2);
        }

        public static bool operator >=(Employee e1, Employee e2)
        {
            return e1.Salary >= e2.Salary;
        }
        public static bool operator <=(Employee e1, Employee e2)
        {
            return !(e1 >= e2);
        }
    }
}
