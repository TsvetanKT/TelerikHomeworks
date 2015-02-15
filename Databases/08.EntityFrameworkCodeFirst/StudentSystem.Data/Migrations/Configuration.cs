namespace StudentSystem.Data.Migrations
{
    using StudentSystem.Models;
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<StudentSystemDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "StudentSystem.Data.StudentSystemDbContext";
        }

        protected override void Seed(StudentSystemDbContext context)
        {
            this.SeedCourses(context);
            this.SeedStudents(context);
        }

        private void SeedStudents(StudentSystemDbContext context)
        {
            if (context.Students.Any())
            {
                return;
            }

            context.Students.Add(new Student
            {
                FirstName = "Joe",
                LastName = "Straxilov",
                Level = 1
            });

            context.Students.Add(new Student
            {
                FirstName = "Kozmo",
                LastName = "Ilief",
                Level = 3,
            });

            context.Students.Add(new Student
            {
                FirstName = "Cecka",
                LastName = "Me4ka",
                Level = 2
            });

            context.Students.Add(new Student
            {
                FirstName = "Kuzman",
                LastName = "Admina",
                Level = 501
            });
        }

        private void SeedCourses(StudentSystemDbContext context)
        {
            if (context.Courses.Any())
            {
                return;
            }

            context.Courses.Add(new Course
            {
                Name = "Seeded course test",
                Description = "Initial course for testing purposes only"
            });
        }
    }
}
