using System;
using System.ComponentModel.DataAnnotations;

namespace DepartmentUnique2.Models
{
    public class Student
    {
        public int StudentId { set; get; }
        public string RegNo { set; get; }

        [Required(ErrorMessage = "Error : Student Name can not be empty")]
        [Display(Name = "Student Name  ")]
        public string StudentName { set; get; }
        [DataType(DataType.EmailAddress)] 
        public string Email { set; get; }
        [Display(Name = "Contact No.  ")]
        [StringLength(11)]
        public string ContactNo { set; get; }
        [Display(Name = "Admission Date  ")]
        public DateTime AdmissionDate { set; get; }
        [StringLength(150)]
        public string Address { set; get; }
        public virtual Department Departments { set; get; }
        public int DepartmentId { set; get; }
    }
}