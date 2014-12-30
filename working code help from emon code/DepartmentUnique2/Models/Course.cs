using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DepartmentUnique2.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        [Required(ErrorMessage = "Course Code can not be empty!")]
        [Remote("Check_CourseCode", "Course", ErrorMessage = "Course code already exists!")]
        [Display(Name = "Course Code")]
        public string CourseCode { get; set; }
        [Display(Name = "Course Credit")]
        public double CourseCredit { get; set; }
        [Required(ErrorMessage = "Course Name can not be empty!")]
        [Remote("Check_CourseName", "Course", ErrorMessage = "Course Name already exists!")]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }
        [StringLength(150)]
        public string Description { get; set; }
        public virtual Department Departments { get; set; }
        public int DepartmentId { get; set; }
        public virtual Semister Semisters { get; set; }
        public int SemisterId { get; set; }
        public string AssignedTo { set; get; }

        public virtual List<CourseAssign> CourseAssigns { set; get; }
    }
}