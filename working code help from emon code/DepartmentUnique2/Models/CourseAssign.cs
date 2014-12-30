using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DepartmentUnique2.Models
{
    public class CourseAssign
    {
        public int CourseAssignId { get; set; }
        public int DepartmentId { get; set; }
        public Department Departments { get; set; }
        public int CourseId { get; set; }
        public Course Courses { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teachers { get; set; }
    }
}