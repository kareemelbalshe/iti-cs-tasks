using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Task4
{
    internal class Authenticate
    {
        public Student student { get; set; }

        public Authenticate(Student student)
        {
            this.student = student;
        }

        public bool LoginMethod(string username, string useremail, string userpass)
        {
            return student.UserName == username && student.Password == userpass && student.Email == useremail;
        }

        public bool LoginMethod(string useremail, string userpass)
        {
            return student.Email == useremail && student.Password == userpass;
        }

        public bool LoginMethod(int id, string userpass)
        {
            return student.Id == id && student.Password == userpass;
        }

        public bool LoginMethod(int id, string email, bool isEmail)
        {
            return student.Id == id && student.Email == email;
        }

        // Forget password methods
        public string ForgetPassword(string username)
        {
            return student.UserName == username ? student.Password : "user not found !";
        }

        public string ForgetPassword(string useremail, int id)
        {
            return student.Email == useremail && student.Id == id ? student.Password : "user not found !";
        }

        public string ForgetPassword(int userid)
        {
            return student.Id == userid ? student.Password : "user not found !";
        }

        // Reset password methods
        public bool ResetPassword(int id, string oldpassword, string newpassword)
        {
            if (student.Id == id && student.Password == oldpassword)
            {
                student.Password = newpassword;
                return true;
            }
            return false;
        }

        public bool ResetPassword(string useremail, string oldpassword, string newpassword)
        {
            if (student.Email == useremail && student.Password == oldpassword)
            {
                student.Password = newpassword;
                return true;
            }
            return false;
        }

        public bool ResetPassword(int userid, string username, string oldpassword, string newpassword)
        {
            if (student.Id == userid && student.UserName == username && student.Password == oldpassword)
            {
                student.Password = newpassword;
                return true;
            }
            return false;
        }

    }
}
