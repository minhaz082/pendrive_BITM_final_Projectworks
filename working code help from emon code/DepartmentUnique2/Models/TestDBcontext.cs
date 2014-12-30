using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace DepartmentUnique2.Models
{
    public class TestDBcontext:DbContext
    {
        public TestDBcontext()
            : base("workshopProject")
        {
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> CourseDbSet { get; set; }
        public DbSet<Semister> SemisterDbSet { get; set; }
        public DbSet<Teacher> TeacherDbSet { get; set; }
        public DbSet<Designation> DesignationDbSet { get; set; }

        public System.Data.Entity.DbSet<DepartmentUnique2.Models.Student> Students { get; set; }
        public DbSet<Rooms> RoomsDbSet { get; set; }
        public DbSet<GradeLetter> GradeLetterDbSet { get; set; }
        public DbSet<WeekDay> WeekDayDbSet { set; get; }
        public DbSet<CourseAssign> CourseAssignDbSet { set; get; } 
        
    }
}