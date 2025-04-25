using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Company
    {
        private string companyName;
        private List<Department> departments = new List<Department>();

        public string CompanyName { get => companyName; set => companyName = value; }
        public List<Department> Departments { get => departments; }

        public Company() : this("") { }

        public Company(string name)
        {
            CompanyName = name;
        }

        public void AddDepartment(Department dept)
        {
            departments.Add(dept);
        }

        public void PrintDepartments()
        {
            foreach (var d in departments)
                Console.WriteLine($"- {d.DeptName}");
        }

        public void PrintEmployeesCountPerDept()
        {
            foreach (var d in departments)
                Console.WriteLine($"{d.DeptName}: {d.CountEmployees()} employee(s)");
        }

        public int TotalEmployees()
        {
            return departments.Sum(d => d.CountEmployees());
        }

        public Department GetDepartmentByName(string name)
        {
            return departments.FirstOrDefault(d => d.DeptName == name);
        }
    }
}
