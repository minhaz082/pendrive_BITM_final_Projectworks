using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityWebAppNew.Models
{
    public class ResultEntry
    {
        public int ResultEntryID { get; set; }
        public virtual Course Course { get; set; }
        public int CourseID { set; get; }
        public Student Students { get; set; }
        public virtual GradeLetter GradeLetter { get; set; }
        public int GradeLatterID { get; set; }

    }
}