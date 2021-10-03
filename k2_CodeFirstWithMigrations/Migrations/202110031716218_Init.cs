namespace k2_CodeFirstWithMigrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DepartmentLectures",
                c => new
                    {
                        DepartmentID = c.Int(nullable: false),
                        LectureID = c.Int(nullable: false),
                        Department_DepartmenID = c.Int(),
                    })
                .PrimaryKey(t => new { t.DepartmentID, t.LectureID })
                .ForeignKey("dbo.Departments", t => t.Department_DepartmenID)
                .ForeignKey("dbo.Lectures", t => t.LectureID, cascadeDelete: true)
                .Index(t => t.LectureID)
                .Index(t => t.Department_DepartmenID);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmenID = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(),
                        FacultyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DepartmenID)
                .ForeignKey("dbo.Faculties", t => t.FacultyId, cascadeDelete: true)
                .Index(t => t.FacultyId);
            
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        FacultyID = c.Int(nullable: false, identity: true),
                        FacultyName = c.String(),
                    })
                .PrimaryKey(t => t.FacultyID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        StudentNumber = c.String(),
                        ConsultantInstructorId = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        Name = c.String(),
                        Surname = c.String(),
                        Telephone = c.String(),
                        Address = c.String(),
                        ConsultantInstuctor_InstructorID = c.Int(),
                        Department_DepartmenID = c.Int(),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Instructors", t => t.ConsultantInstuctor_InstructorID)
                .ForeignKey("dbo.Departments", t => t.Department_DepartmenID)
                .Index(t => t.ConsultantInstuctor_InstructorID)
                .Index(t => t.Department_DepartmenID);
            
            CreateTable(
                "dbo.Instructors",
                c => new
                    {
                        InstructorID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Telephone = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.InstructorID);
            
            CreateTable(
                "dbo.Lectures",
                c => new
                    {
                        LectureID = c.Int(nullable: false, identity: true),
                        LectureCode = c.String(),
                        LectureName = c.String(),
                        InstructorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LectureID)
                .ForeignKey("dbo.Instructors", t => t.InstructorId, cascadeDelete: true)
                .Index(t => t.InstructorId);
            
            CreateTable(
                "dbo.StudentLectures",
                c => new
                    {
                        StudentID = c.Int(nullable: false),
                        LectureID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.StudentID, t.LectureID })
                .ForeignKey("dbo.Lectures", t => t.LectureID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.LectureID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Department_DepartmenID", "dbo.Departments");
            DropForeignKey("dbo.Students", "ConsultantInstuctor_InstructorID", "dbo.Instructors");
            DropForeignKey("dbo.StudentLectures", "StudentID", "dbo.Students");
            DropForeignKey("dbo.StudentLectures", "LectureID", "dbo.Lectures");
            DropForeignKey("dbo.Lectures", "InstructorId", "dbo.Instructors");
            DropForeignKey("dbo.DepartmentLectures", "LectureID", "dbo.Lectures");
            DropForeignKey("dbo.Departments", "FacultyId", "dbo.Faculties");
            DropForeignKey("dbo.DepartmentLectures", "Department_DepartmenID", "dbo.Departments");
            DropIndex("dbo.StudentLectures", new[] { "LectureID" });
            DropIndex("dbo.StudentLectures", new[] { "StudentID" });
            DropIndex("dbo.Lectures", new[] { "InstructorId" });
            DropIndex("dbo.Students", new[] { "Department_DepartmenID" });
            DropIndex("dbo.Students", new[] { "ConsultantInstuctor_InstructorID" });
            DropIndex("dbo.Departments", new[] { "FacultyId" });
            DropIndex("dbo.DepartmentLectures", new[] { "Department_DepartmenID" });
            DropIndex("dbo.DepartmentLectures", new[] { "LectureID" });
            DropTable("dbo.StudentLectures");
            DropTable("dbo.Lectures");
            DropTable("dbo.Instructors");
            DropTable("dbo.Students");
            DropTable("dbo.Faculties");
            DropTable("dbo.Departments");
            DropTable("dbo.DepartmentLectures");
        }
    }
}
