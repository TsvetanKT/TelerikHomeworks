using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//02.Define abstract class Human with first name and last name. Define new class Student which is derived from Human 
//  and has new field – grade. Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay 
//  and method MoneyPerHour() that returns money earned by hour by the worker. Define the proper constructors and 
//  properties for this hierarchy. Initialize a list of 10 students and sort them by grade in ascending order 
//  (use LINQ or OrderBy() extension method). Initialize a list of 10 workers and sort them by money per hour 
//  in descending order. Merge the lists and sort them by first name and last name.

namespace Human
{
    class TestingHuman
    {
        static void Main()
        {
            Console.WriteLine("02.Testing");

            // Initialize a list of 10 students and sort them by grade in ascending order 
            
            Student stud1 = new Student("Joe","Moe",3 );
            Student stud2 = new Student("Elvis","Presli",6 );
            Student stud3 = new Student("Joe","Cocker",5 );
            Student stud4 = new Student("Axmet","Dogan", 2);
            Student stud5 = new Student("Petar","Ivanov", 4);
            Student stud6 = new Student("Kozmo","Giorgiev", 6);
            Student stud7 = new Student("Dilqn","Peevski", 2);
            Student stud8 = new Student("Asen","Agov", 5);
            Student stud9 = new Student("Jan","Videnov", 4);
            Student stud0 = new Student("Cvetelina","Borislavova", 6);

            List<Student> students = new List<Student> {stud1,stud2,stud3,stud4,stud5,stud6,stud7,stud8,stud9,stud0};

            var studentsByGrade = students.OrderBy(s => s.Grade);

            Console.WriteLine("\nStudents :\n");
            foreach (var student in studentsByGrade)
            {
                Console.WriteLine(student.FirstName+" "+student.LastName + " " + student.Grade);
            }

            // Initialize a list of 10 workers and sort them by money per hour in descending order. 
            // Merge the lists and sort them by first name and last name.

            Worker w1 = new Worker ("Koko", "Kranista", 200, 8);
            Worker w2 = new Worker ("Pesho", "Programista", 400, 7);
            Worker w3 = new Worker ("Vladimir", "Putin", 5000, 10);
            Worker w4 = new Worker ("Ivailoo", "Bezrabotniq", 0, 24);
            Worker w5 = new Worker ("Bill", "Gates", 1000000, 8);
            Worker w6 = new Worker ("Carlos", "Slim", 2000000, 12);
            Worker w7 = new Worker ("Ivo", "Indjev", 250, 6);
            Worker w8 = new Worker ("Veneta", "Raikova", 1000, 6);
            Worker w9 = new Worker ("Cecka", "Cacheva", 750, 5);
            Worker w0 = new Worker ("Kapka", "Siderova", 180, 8);

            List<Worker> workers = new List<Worker> { w1, w2, w3, w4, w5, w6, w7, w8, w9, w0 };

            var workersByMonewDescending = workers.OrderByDescending(w => w.MoneyPerHour());

            Console.WriteLine("\nWorkers:\n");
            foreach (var worker in workersByMonewDescending)
            {
                Console.WriteLine(worker.FirstName + " " + worker.LastName + " " + worker.MoneyPerHour().ToString("#,#.00#"));
            }
        }
    }
}
