using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DepartmentUnique2.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        [Display(Name = "Teacher Name")]
        public string TeacherName { get; set; }
        [Display(Name = "Teacher Address")]
        [StringLength(150)]
        public string TeacherAddress { get; set; }
        [Required(ErrorMessage = "Teacher Email can not be empty!")]
        [Remote("Check_EmailAddress", "Teacher", ErrorMessage = "This Email Address already exists!")]
        [Display(Name = "Teacher Email")]
        [DataType(DataType.EmailAddress)] 
        public string TeacherEmail { get; set; }
        [StringLength(11)]
        public string ContactNo { get; set; }
        [Range(1, 100)]
        public double TeacherCredit { get; set; }
        public virtual Designation Designations { get; set; }
        public int DesignationId { get; set; }
        public virtual Department Departments { get; set; }
        public int DepartmentId { get; set; }


    }
}