using System;

namespace Day4
{
    enum Gender { M, F }
    enum SecurityLevel { Guest, Developer, Secretary, DBA }

    struct HiringDate
    {
        public int Day, Month, Year;
        public void SetDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public override string ToString() => $"{Day}/{Month}/{Year}";
    }

    struct Employee
    {
        public int ID;
        public string Name;
        public SecurityLevel Security;
        public double Salary;
        public HiringDate HireDate;
        public Gender Gender;

        public void SetEmployee(int id, string name, SecurityLevel sec, double sal, HiringDate date, Gender gender)
        {
            ID = id;
            Name = name;
            Security = sec;
            Salary = sal;
            HireDate = date;
            Gender = gender;
        }

        public void Print()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Security: {Security}, Salary: {Salary}, HireDate: {HireDate}, Gender: {Gender}");
        }
    }

    class Program
    {
        static Employee[] ConcatEmployees(Employee[] arr1, Employee[] arr2)
        {
            Employee[] result = new Employee[arr1.Length + arr2.Length];
            arr1.CopyTo(result, 0);
            arr2.CopyTo(result, arr1.Length);
            return result;
        }

        static void PrintEmployees(Employee[] employees)
        {
            foreach (var emp in employees)
            {
                if (emp.ID != 0)
                    emp.Print();
            }
        }

        static bool CheckUniqueID(Employee[] employees, int id)
        {
            foreach (var emp in employees)
            {
                if (emp.ID == id) return false;
            }
            return true;
        }

        static int FindIndexById(Employee[] employees, int id)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].ID == id) return i;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            Employee[] employees = new Employee[10];
            int count = 0;

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("a- Insert new employee");
                Console.WriteLine("b- Display inserted employees only");
                Console.WriteLine("c- Search by id");
                Console.WriteLine("d- Search by name");
                Console.WriteLine("e- Count number of inserted employees");
                Console.WriteLine("f- Update employee by id");
                Console.WriteLine("g- Delete employee by id");
                Console.WriteLine("h- Exit");
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "a":
                        if (count < 10)
                        {
                            Console.Write("Enter ID: ");
                            int id = int.Parse(Console.ReadLine());
                            if (!CheckUniqueID(employees, id))
                            {
                                Console.WriteLine("ID already exists.");
                                break;
                            }
                            Console.Write("Enter Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter Security (Guest, Developer, Secretary, DBA): ");
                            SecurityLevel sec = (SecurityLevel)Enum.Parse(typeof(SecurityLevel), Console.ReadLine(), true);
                            Console.Write("Enter Salary: ");
                            double sal = double.Parse(Console.ReadLine());
                            Console.Write("Enter Hire Date (day month year): ");
                            int d = int.Parse(Console.ReadLine());
                            int m = int.Parse(Console.ReadLine());
                            int y = int.Parse(Console.ReadLine());
                            HiringDate date = new HiringDate();
                            date.SetDate(d, m, y);
                            Console.Write("Enter Gender (M or F): ");
                            Gender gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine(), true);
                            employees[count++].SetEmployee(id, name, sec, sal, date, gender);
                        }
                        else
                        {
                            Console.WriteLine("Array full.");
                        }
                        break;
                    case "b":
                        PrintEmployees(employees);
                        break;
                    case "c":
                        Console.Write("Enter ID: ");
                        int searchId = int.Parse(Console.ReadLine());
                        int idx = FindIndexById(employees, searchId);
                        if (idx != -1)
                            employees[idx].Print();
                        else
                            Console.WriteLine("Not found.");
                        break;
                    case "d":
                        Console.Write("Enter Name: ");
                        string searchName = Console.ReadLine();
                        bool found = false;
                        foreach (var emp in employees)
                        {
                            if (emp.Name == searchName && emp.ID != 0)
                            {
                                emp.Print();
                                found = true;
                            }
                        }
                        if (!found) Console.WriteLine("Not found.");
                        break;
                    case "e":
                        Console.WriteLine($"Count: {count}");
                        break;
                    case "f":
                        Console.Write("Enter ID to update: ");
                        int upId = int.Parse(Console.ReadLine());
                        int updateIdx = FindIndexById(employees, upId);
                        if (updateIdx != -1)
                        {
                            Console.Write("Enter New Name: ");
                            employees[updateIdx].Name = Console.ReadLine();
                            Console.WriteLine("Updated.");
                        }
                        else Console.WriteLine("Not found.");
                        break;
                    case "g":
                        Console.Write("Enter ID to delete: ");
                        int delId = int.Parse(Console.ReadLine());
                        int delIdx = FindIndexById(employees, delId);
                        if (delIdx != -1)
                        {
                            employees[delIdx] = new Employee();
                            Console.WriteLine("Deleted.");
                        }
                        else Console.WriteLine("Not found.");
                        break;
                    case "h":
                        return;
                }
            }
        }
    }
}
