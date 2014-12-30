using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityWebAppNew.Models
{
    public class CourseAssign
    {
        public int CourseAssignID { get; set; }
        public int DepartmentID { get; set; }
        public Department Departments { get; set; }
        public int TeacherID { get; set; }
        public Teacher Teachers { get; set; }
        public int CourseID { get; set; }
        public Course Courses { get; set; }
    }
}