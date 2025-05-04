using System;

namespace Day7Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client[] hrClients = new Client[]
            {
                new Client(1, "Client A", "City A"),
                new Client(2, "Client B", "City B")
            };

            Client[] prClients = new Client[]
            {
                new Client(3, "Client C", "City C"),
                new Client(4, "Client D", "City D"),
                new Client(5, "Client E", "City E")
            };

            Employee[] employees = new Employee[]
            {
                new HREmployee(1, "kareem", 50000, hrClients),
                new PREmployee(2, "ahmed", 40000, prClients)
            };
            

            foreach (var employee in employees)
            {
                employee.ShowEmployeeDetails();
                Console.WriteLine();
            }

            Employee mostClientsEmployee = GetEmployeeWithLongestClientsArray(employees);
            Console.WriteLine($"Employee with most clients: {mostClientsEmployee.Name}");
            Console.WriteLine();

            if (employees[0] > employees[1])
            {
                Console.WriteLine("Employee 1 has more salary than Employee 2");
            }
            else
            {
                Console.WriteLine("Employee 1 has more salary than Employee 2");
            }


        }

        static Employee GetEmployeeWithLongestClientsArray(Employee[] employees)
        {
            Employee max = employees[0];
            foreach (var emp in employees)
            {
                if (emp.Clients.Length > max.Clients.Length)
                {
                    max = emp;
                }
            }
            return max;
        }


    }
}
