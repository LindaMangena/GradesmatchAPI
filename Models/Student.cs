using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradesmatchAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public string? Course { get; set; }

    }
}