using System.Collections.Generic;
using DepartmentUnique2.Models;

namespace DepartmentUnique2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DepartmentUnique2.Models.TestDBcontext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "DepartmentUnique2.Models.TestDBcontext";
        }

        protected override void Seed(DepartmentUnique2.Models.TestDBcontext context)
        {
            //context.Departments.AddOrUpdate(x => x.DepartmentId,
            //    new Department() { DepartmentId = 1, Code = "CSE", Name = "Computer" },
            //    new Department() { DepartmentId = 2, Code = "EEE", Name = "Electrical" },
            //    new Department() { DepartmentId = 3, Code = "PHY", Name = "Physics" },
            //    new Department() { DepartmentId = 4, Code = "CHE", Name = "Chemistry" },
            //    new Department() { DepartmentId = 5, Code = "MAT", Name = "Mathematics" }
            //    );

            //context.SemisterDbSet.AddOrUpdate(x=>x.SemisterId,
            //    new Semister(){SemisterId  =1,SemisterName = "1st Semister"},
            //     new Semister(){SemisterId =1,SemisterName = "2nd Semister"},
            //      new Semister(){SemisterId =1,SemisterName = "3rd Semister"},
            //       new Semister(){SemisterId =1,SemisterName = "4th Semister"}
            //    );

            //context.CourseDbSet.AddOrUpdate(x => x.CourseId,
            //    new Course() { CourseId = 1, CourseName = "algorithm", CourseCode = "CSE-001", CourseCredit = 3, Description = "test Description", DepartmentId = 1, SemisterId = 2 },
            //    new Course() { CourseId = 2, CourseName = "c+ ", CourseCode = "CSE-002", CourseCredit = 4, Description = "test Description", DepartmentId = 2, SemisterId = 1 },
            //    new Course() { CourseId = 3, CourseName = "java", CourseCode = "CSE-002", CourseCredit = 5, Description = "test Description", DepartmentId = 3, SemisterId = 3 }
            //);

            //context.DesignationDbSet.AddOrUpdate(x => x.DesignationId,
            //    new Designation() { DesignationId = 1, DesignationName = "Lecturer" },
            //    new Designation() { DesignationId = 2, DesignationName = "Ast. Lecturer" },
            //    new Designation() { DesignationId = 3, DesignationName = "TA" },
            //    new Designation() { DesignationId = 4, DesignationName = "Professor" }
            //    );

            //context.TeacherDbSet.AddOrUpdate(x => x.TeacherId,
            //    new Teacher() { TeacherId = 1, TeacherName = "Kamal", TeacherAddress = "Dhaka", TeacherEmail = "k@mail.com", ContactNo = "123456", DesignationId = 1, TeacherCredit = 15, DepartmentId = 1 },
            //    new Teacher() { TeacherId = 2, TeacherName = "Jamal", TeacherAddress = "Chittagong", TeacherEmail = "j@mail.com", ContactNo = "444456", DesignationId = 2, TeacherCredit = 25, DepartmentId = 2 },
            //    new Teacher() { TeacherId = 2, TeacherName = "Kobir", TeacherAddress = "Sylhet", TeacherEmail = "ka@mail.com", ContactNo = "4443356", DesignationId = 4, TeacherCredit = 35, DepartmentId = 2 },
            //    new Teacher() { TeacherId = 2, TeacherName = "Nahar", TeacherAddress = "Vola", TeacherEmail = "n@mail.com", ContactNo = "544456", DesignationId = 1, TeacherCredit = 45, DepartmentId = 3 },
            //    new Teacher() { TeacherId = 2, TeacherName = "ronok", TeacherAddress = "Khulna", TeacherEmail = "r@mail.com", ContactNo = "774456", DesignationId = 4, TeacherCredit = 35, DepartmentId = 1 },
            //    new Teacher() { TeacherId = 2, TeacherName = "saddam", TeacherAddress = "Dhaka", TeacherEmail = "s@mail.com", ContactNo = "433456", DesignationId = 2, TeacherCredit = 55, DepartmentId = 1 }
            //    );

            

        }
    }
}
