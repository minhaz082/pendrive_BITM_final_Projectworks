using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UniversityWebAppNew.Models
{
    public class UniversityAddContext:DbContext
    {
        public UniversityAddContext(): base("workshopProject")
        {
        }
        public DbSet<Department> DepartmentDbSet { get; set; }
        public DbSet<Course> CourseDbSet { get; set; }
        public DbSet<Semister> SemisterDbSet { get; set; }
        public DbSet<Teacher> TeacherDbSet { get; set; }
        public DbSet<Designation> DesignationDbSet { get; set; }
        public DbSet<Student> StudentDbSet { get; set; }
        public DbSet<Room> RoomsDbSet { get; set; }
        public DbSet<GradeLetter> GradeLetterDbSet { get; set; }
        public DbSet<WeekDays> WeekDayDbSet { set; get; }
        public DbSet<CourseAssign> CourseAssignDbSet { set; get; }
        public DbSet<EnrollCourse> EnrollCourseDbSet { get; set; }
        public DbSet<ResultEntry> ResultEntrieDbSet { get; set; }        
        public DbSet<AllocateClassroom> AllocateClassRoomDdSet{ get; set; }       
        
    }
}