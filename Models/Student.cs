using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Manager.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public DateTime Dob { get; set; }
        public string Nationality { get; set; }
        public string Major { get; set; }
    }
}
