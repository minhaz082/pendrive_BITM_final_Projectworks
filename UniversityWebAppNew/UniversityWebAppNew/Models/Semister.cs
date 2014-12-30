using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityWebAppNew.Models
{
    public class Semister
    {
        public int SemisterID { get; set; }
        public string SemisterName { get; set; }
        public virtual List<Course> CourseList { get; set; }

    }
}