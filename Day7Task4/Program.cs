using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student()
            {
                Id = 1,
                Name = "Kareem",
                UserName = "kareem_elbalshy",
                Password = "1234",
                Email = "kareem@gmail.com"
            };

            Authenticate auth = new Authenticate(s);

            Console.WriteLine(auth.LoginMethod("kareem_elbalshy", "kareem@gmail.com", "1234"));
            Console.WriteLine(auth.ForgetPassword("kareem_elbalshy"));
            Console.WriteLine(auth.ResetPassword("kareem@gmail.com", "1234", "123456")); 

        }
    }
}
