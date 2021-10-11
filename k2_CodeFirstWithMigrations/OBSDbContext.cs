using k2_CodeFirstWithMigrations.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2_CodeFirstWithMigrations
{
    public class OBSDbContext : DbContext
    {
        public OBSDbContext()
        {
            this.Database.Connection.ConnectionString = "Server=.;Database= OBSDb;User Id=sa;Password=Password1;";

            //this.Database.Connection.ConnectionString = "Server=.;Database= OBSDb;User Id=sa;Password=123";
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<StudentLecture> StudentsLectures { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentLecture> DepartmentLectures { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
    }
}
