using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//01.We are given a school. In the school there are classes of students. Each class has a set of teachers. 
//   Each teacher teaches a set of disciplines. Students have name and unique class number. Classes have 
//   unique text identifier. Teachers have name. Disciplines have name, number of lectures and number 
//   of exercises. Both teachers and students are people. Students, classes, teachers and disciplines 
//   could have optional comments (free text block).
//   Your task is to identify the classes (in terms of  OOP) and their attributes and operations, encapsulate 
//   their fields, define the class hierarchy and create a class diagram with Visual Studio.

namespace School
{
    class TestingSchool
    {
        static void Main()
        {
            Console.WriteLine("01.Testing \"School\"");

            // New disciplines
            Discipline oop = new Discipline("OOP", 4, 2);
            Discipline cSharp = new Discipline("C#", 2, 1);

            // New teachers
            Teacher koko = new Teacher("Koko", oop);
            Teacher joko = new Teacher("Joko", cSharp);

            List<Teacher> teacherList = new List<Teacher>{koko, joko};    
          
            // New class
            Class programing = new Class ("Programing",teacherList);


            // New students
            Student petkancho = new Student("Petkancho", "0809014");
            Student paraskeva = new Student("Paraskeva", "0810014");

            // Adding comment to student
            paraskeva.Comments = "Paraskeva is very smart.";

            // Adding comment to discipline
            oop.Comments = "OOP comes after C#2.";

            Console.WriteLine(paraskeva.Comments + "\n" + oop.Comments);

            //People someone = new People("someone");  This doesn't works - Abstract class
        }
    }
}
