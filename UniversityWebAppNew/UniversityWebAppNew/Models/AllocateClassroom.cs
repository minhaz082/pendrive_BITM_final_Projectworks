using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityWebAppNew.Models
{
    public class AllocateClassroom
    {
        public int AllocateClassRoomID { get; set; }
        public int DepartmentID { get; set; }
        public virtual Department Departments { get; set; }
        public int CourseID { set; get; }
        public virtual Course Courses { get; set; }
        public int RoomID { get; set; }
        public virtual Room Rooms { get; set; }
        public int WeekDaysID { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public virtual WeekDays WeekDays { get; set; }
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime FromTime { get; set; }
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime ToTime { get; set; }
        

    }
}