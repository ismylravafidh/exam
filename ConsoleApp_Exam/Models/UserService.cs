using ConsoleApp_Exam.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp_Exam.Models
{
    internal static class UserService
    {
        public static void Register(User user)
        {

            if (user.Name == null || !Regex.IsMatch(user.Name, "^[a-zA-Z]+$"))
            {
                throw new InvalidNameException("Invalid Name Exception");
            }
            if(user.Surname == null || !Regex.IsMatch(user.Surname, "^[a-zA-Z]+$"))
            {
                throw new InvalidSurNameException("Invalid Surname Exception");
            }
            if(user.Password == null || !Regex.IsMatch(user.Password, @"^(?=[A-Z])(?=.*\d).{8,}$"))
            {
                throw new InvalidPasswordException("Invalid Password Exception");
            }
            BlogDatabase.Users.Add(user);
        }
        public static bool Login(string username, string password)
        {
            foreach (User user in BlogDatabase.Users)
            {
                if(user.Username == username && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
