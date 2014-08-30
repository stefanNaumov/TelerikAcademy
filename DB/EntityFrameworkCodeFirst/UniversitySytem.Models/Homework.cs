using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySytem.Models
{
    public class Homework
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime Deadline { get; set; }

        public int CourseID { get; set; }
    }
}
