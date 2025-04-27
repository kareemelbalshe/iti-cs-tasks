using System;
using System.Collections.Generic;
using System.Linq;

namespace Day5
{
    internal class Department
    {
        private string deptName;
        private string manager;
        private List<Employee> employees = new List<Employee>();

        public string DeptName { get => deptName; set => deptName = value; }
        public string Manager { get => manager; set => manager = value; }
        public List<Employee> Employees { get => employees; }

        public Department() : this("", "", new List<Employee>()) { }

        public Department(string name, string manager, List<Employee> employees)
        {
            DeptName = name;
            Manager = manager;
            this.employees = employees;
        }

        public void Print()
        {
            Console.WriteLine($"\nDepartment: {DeptName}, Manager: {Manager}, Employees Count: {employees.Count}");
            foreach (var emp in employees)
                emp.Print();
        }

        public Employee GetEmployeeById(int id) =>
            employees.FirstOrDefault(e => e.ID == id);

        public bool DeleteEmployee(int id) =>
            employees.Remove(GetEmployeeById(id));

        public int CountEmployees() => employees.Count;
    }
}
