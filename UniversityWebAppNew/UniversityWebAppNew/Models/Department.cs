using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniversityWebAppNew.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        [Required(ErrorMessage = "Department Code can not be empty!")]
        //[Remote("Check_DeptName", "Department", ErrorMessage = "Department name already exists!")]
        [Display(Name = "Department Name")]
        public string DepartmentName { get; set; }
        [Required]
        //[Remote("Check_DeptCode", "Department", ErrorMessage = "Department code already exists!")]
        [Display(Name = "Department Code")]
        public string DepartmentCode { get; set; }

        public virtual List<Course> CourseList { get; set; }
        public virtual List<Teacher> TeacherList { get; set; }
        public virtual List<Student> StudentList { set; get; }
        
    }
}