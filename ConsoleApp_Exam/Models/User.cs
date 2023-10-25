using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Exam.Models
{
    internal class User
    {
        static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public User(string name , string surname , string password)
        {
            _id++;
            Id = _id;
            Name = name;
            Surname = surname;
            Password = password;
            Username = name.ToLower() + "." + surname.ToLower();
        }
        
    }
}
