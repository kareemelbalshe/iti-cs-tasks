using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day7Task3
{
    internal class HREmployee : Employee
    {

        public HREmployee(int id, string name, double salary, Client[] clients)
            : base(id, name, salary, clients)
        {
        }
        public override void ShowEmployeeDetails()
        {
            Console.WriteLine("HR Employee Details");
            Console.WriteLine($"Employee Id: {Id}");
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Employee Salary: {Salary}");
            Console.WriteLine();
            for (int i = 0; i < Clients.Length; i++)
            {
                Console.WriteLine($"Client {i + 1}:");
                Clients[i].ShowClientDetails();
            }
        }
    }
}
