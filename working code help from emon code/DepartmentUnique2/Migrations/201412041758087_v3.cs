namespace DepartmentUnique2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "Description", c => c.String(maxLength: 150));
            AlterColumn("dbo.Students", "ContactNo", c => c.String(maxLength: 11));
            AlterColumn("dbo.Students", "Address", c => c.String(maxLength: 150));
            AlterColumn("dbo.Teachers", "TeacherAddress", c => c.String(maxLength: 150));
            AlterColumn("dbo.Teachers", "ContactNo", c => c.String(maxLength: 11));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Teachers", "ContactNo", c => c.String());
            AlterColumn("dbo.Teachers", "TeacherAddress", c => c.String());
            AlterColumn("dbo.Students", "Address", c => c.String());
            AlterColumn("dbo.Students", "ContactNo", c => c.String());
            AlterColumn("dbo.Courses", "Description", c => c.String());
        }
    }
}
