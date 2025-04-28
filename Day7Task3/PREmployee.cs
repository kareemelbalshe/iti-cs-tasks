using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Task3
{
    internal class PREmployee : Employee
    {

        public PREmployee(int id, string name, double salary, Client[] clients)
            : base(id, name, salary, clients)
        {
        }

        public override void ShowEmployeeDetails()
        {
            Console.WriteLine("PR Employee Details");
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
