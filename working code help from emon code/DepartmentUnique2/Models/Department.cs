using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.Web.Mvc;

namespace DepartmentUnique2.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "Department Code can not be empty!")]
        [Remote("Check_DeptName", "Department", ErrorMessage = "Department name already exists!")]
        [Display(Name = "Department Name")]
        public string Name { get; set; }
        [Required]
        [Remote("Check_DeptCode", "Department", ErrorMessage = "Department code already exists!")]
        [Display(Name = "Department Code")]
        public string  Code { get; set; }

        public virtual List<Course> CourseList { get; set; }
        public virtual List<Teacher> TeacherList { get; set; }
        public virtual List<Student> StudentList { set; get; }
        public virtual List<CourseAssign> CourseAssigns { set; get; } 
    }
}