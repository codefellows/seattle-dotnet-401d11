using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using Microsoft.EntityFrameworkCore;
using StudentEnrollmentAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollmentAPI.Data
{
    // Your DBContext will be "AsyncInnDbContext.cs"
    public class SchoolEnrollmentDbContext : DbContext
    {
        public SchoolEnrollmentDbContext(DbContextOptions<SchoolEnrollmentDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // this tells the db that the enrollments table has a combination composite key of the courseid and studentid
            modelBuilder.Entity<Enrollments>().HasKey(x => new { x.CourseId, x.StudentId });

            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    FirstName = "Jack",
                    LastName = "Shepard",
                    Birthdate = new DateTime(1970, 3, 5)
                },
                new Student
                {
                    Id = 2,
                    FirstName = "Kate",
                    LastName = "Austin",
                    Birthdate = new DateTime(1980, 11, 11)

                }
                );

            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    Id = 1,
                    CourseCode = "seattle-dotnet-401d11",
                    Price = 100m,
                    Technology = Technology.dotNet
                },
                new Course
                {
                    Id = 2,
                    CourseCode = "seattle-201d100",
                    Price = 50m,
                    Technology = Technology.javascript
                }
                );
        }

        // to create an intial migration
        // Install-Package Microsoft.EntityFrameworkCore.Tools
        // add-migration {migrationName}
        // add-migration intial
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollments> Enrollments { get; set; }
        public DbSet<StudentEnrollmentAPI.Models.Transcript> Transcript { get; set; }
    }
}
