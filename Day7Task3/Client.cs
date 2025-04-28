using System;

namespace Day7Task3
{
    internal class Client
    {
        int Id { get; set; }
        string Name { get; set; }
        string City { get; set; }

        public Client(int id, string name, string city)
        {
            Id = id;
            Name = name;
            City = city;
        }
        public void ShowClientDetails()
        {
            Console.WriteLine($"Client Id: {Id}");
            Console.WriteLine($"Client Name: {Name}");
            Console.WriteLine($"Client City: {City}");
            Console.WriteLine();
        }
    }
}
