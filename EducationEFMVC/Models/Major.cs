using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EducationEFMVC.Models
{
    public class Major
    {
        public int Id { get; set; }
        public string Description { get; set; }
            //keeps student from loading the same time as major. *Lazy Loading*//
        [JsonIgnore]
        public ICollection<Student> Students { get; set; }
    }
}