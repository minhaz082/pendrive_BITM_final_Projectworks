namespace DepartmentUnique2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GradeLetters",
                c => new
                    {
                        GradeLetterId = c.Int(nullable: false, identity: true),
                        GradeLetterName = c.String(),
                    })
                .PrimaryKey(t => t.GradeLetterId);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomsId = c.Int(nullable: false, identity: true),
                        RoomsName = c.String(),
                    })
                .PrimaryKey(t => t.RoomsId);
            
            CreateTable(
                "dbo.WeekDays",
                c => new
                    {
                        WeekDayId = c.Int(nullable: false, identity: true),
                        WeekDayName = c.String(),
                    })
                .PrimaryKey(t => t.WeekDayId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WeekDays");
            DropTable("dbo.Rooms");
            DropTable("dbo.GradeLetters");
        }
    }
}
