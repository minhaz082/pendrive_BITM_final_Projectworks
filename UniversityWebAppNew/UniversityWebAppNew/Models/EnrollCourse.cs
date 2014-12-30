using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityWebAppNew.Models
{
    public class EnrollCourse
    {
        public int EnrollCourseID { get; set; }
        public Student Students { get; set; }
        public virtual Course Courses { get; set; }
        public int CourseID { set; get; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EnrollDate { get; set; }
        
        
    }
}