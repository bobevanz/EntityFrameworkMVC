using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EducationEFMVC.Models
{
    public class Student    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SAT { get; set; }
        public double GPA { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public int? MajorId { get; set; }
        public virtual Major Major { get; set; }
    }
}