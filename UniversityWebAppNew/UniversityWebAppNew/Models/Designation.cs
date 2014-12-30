using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityWebAppNew.Models
{
    public class Designation
    {
        public int DesignationID { get; set; }
        public string DesignationName { get; set; }
        public virtual List<Teacher> TeacherList { get; set; }
    }
}