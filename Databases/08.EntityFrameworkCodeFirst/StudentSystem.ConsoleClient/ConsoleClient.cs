namespace StudentSystem.ConsoleClient
{
    using System;
    using System.Linq;
    using StudentSystem.Data;
    using StudentSystem.Models;
    using System.Collections.Generic;

    public class ConsoleClient
    {
        public static void PrintStudents(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.FirstName);
            }
        }

        public static void Main()
        {
            //01. Using c0de first approach, create database for student system with the following tables:
            //Students (with Id, Name, Number, etc.)
            //Courses (Name, Description, Materials, etc.)
            //StudentsInCourses (many-to-many relationship)
            //Homework (one-to-many relationship with students and courses), fields: Content, TimeSent
            //Annotate the data models with the appropriate attributes and enable code first migrations

            // 02. Write a console application that uses the data

            // 03. Seed the data with random values

            var data = new StudentsSystemData();
            var courses = data.Courses.All();

            foreach (var course in courses)
            {
                Console.WriteLine(course.Name);
            }

            data.Courses.Add(new Course
            {
                Name = "Test",
                Description = "Testing"
            });

            data.SaveChanges();

            var students = data.Students.All();
            Console.WriteLine(students.Count());
        }
    }
}
