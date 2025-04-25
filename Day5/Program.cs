using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Company Name: ");
            string cname = Console.ReadLine();
            Company comp = new Company(cname);

            Console.Write("Number of Departments: ");
            int deptCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < deptCount; i++)
            {
                Console.Write($"\nEnter Dept Name #{i + 1}: ");
                string dname = Console.ReadLine();

                Console.Write("Manager Name: ");
                string manager = Console.ReadLine();

                Console.Write("Number of Employees: ");
                int empCount = int.Parse(Console.ReadLine());

                var emps = new List<Employee>();

                for (int j = 0; j < empCount; j++)
                {
                    Console.WriteLine($"\nEnter data for Employee #{j + 1}:");
                    Console.Write("ID: "); int id = int.Parse(Console.ReadLine());
                    Console.Write("Name: "); string ename = Console.ReadLine();
                    Console.Write("Security (0:Guest, 1:Developer, 2:Secretary, 3:DBA): ");
                    SecurityLevel sec = (SecurityLevel)int.Parse(Console.ReadLine());
                    Console.Write("Salary: "); double sal = double.Parse(Console.ReadLine());
                    Console.Write("Gender (M/F): "); Gender g = Console.ReadLine() == "M" ? Gender.M : Gender.F;

                    Console.Write("Hire Date (dd mm yyyy): ");
                    var parts = Console.ReadLine().Split();
                    HireDate hd = new HireDate(int.Parse(parts[0]), int.Parse(parts[1]), int.Parse(parts[2]));

                    emps.Add(new Employee(id, ename, sec, sal, hd, g));
                }

                comp.AddDepartment(new Department(dname, manager, emps));
            }

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("a- Display All Departments Names");
                Console.WriteLine("b- Display Employees Count Per Department");
                Console.WriteLine("c- Display Total number of employees in company");
                Console.WriteLine("d- Search for Employee ID in Dept");
                Console.WriteLine("e- Update Employee Name in Dept");
                Console.WriteLine("f- Delete employee by ID");
                Console.WriteLine("g- Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "a":
                        comp.PrintDepartments();
                        break;

                    case "b":
                        comp.PrintEmployeesCountPerDept();
                        break;

                    case "c":
                        Console.WriteLine($"Total Employees: {comp.TotalEmployees()}");
                        break;

                    case "d":
                        Console.Write("Enter Dept Name: ");
                        var dn = Console.ReadLine();
                        var dept = comp.GetDepartmentByName(dn);
                        if (dept == null) break;
                        Console.Write("Enter Employee ID: ");
                        int eid = int.Parse(Console.ReadLine());
                        var emp = dept.GetEmployeeById(eid);
                        if (emp != null) emp.Print();
                        else Console.WriteLine("Employee not found.");
                        break;

                    case "e":
                        Console.Write("Enter Dept Name: ");
                        dept = comp.GetDepartmentByName(Console.ReadLine());
                        if (dept == null) break;
                        Console.Write("Enter Employee ID: ");
                        eid = int.Parse(Console.ReadLine());
                        emp = dept.GetEmployeeById(eid);
                        if (emp != null)
                        {
                            Console.Write("Enter New Name: ");
                            emp.Name = Console.ReadLine();
                            Console.WriteLine("Updated.");
                        }
                        else Console.WriteLine("Employee not found.");
                        break;

                    case "f":
                        Console.Write("Enter Dept Name: ");
                        dept = comp.GetDepartmentByName(Console.ReadLine());
                        if (dept == null) break;
                        Console.Write("Enter Employee ID: ");
                        eid = int.Parse(Console.ReadLine());
                        if (dept.DeleteEmployee(eid)) Console.WriteLine("Deleted.");
                        else Console.WriteLine("Not found.");
                        break;

                    case "g":
                        return;
                }
            }
        }
    }
}
