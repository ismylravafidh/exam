using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Exam.Models
{
    internal class Blog
    {
        static int _id;
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Blog(string title , string description)
        {
            _id++;
            Id = _id;
            Title = title;
            Description = description;
        }

        public override string ToString()
        {
            return $" Title : {Title} \n Description : {Description}";
        }

    }
}
