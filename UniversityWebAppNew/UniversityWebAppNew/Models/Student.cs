using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityWebAppNew.Models
{
    public class Student
    {

        public int StudentID { set; get; }
        public string RegNo { set; get; }

        [Required(ErrorMessage = "Error : Student Name can not be empty")]
        [Display(Name = "Student Name  ")]
        public string StudentName { set; get; }
        [DataType(DataType.EmailAddress)]
        public string StudentEmail { set; get; }
        [Display(Name = "Contact No.  ")]
        [StringLength(11)]
        public string ContactNo { set; get; }
        [Display(Name = "Admission Date  ")]

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime AdmissionDate { set; get; }
        [StringLength(150)]
        public string Address { set; get; }
        public virtual Department Departments { set; get; }
        public int DepartmentID { set; get; }
    }
}