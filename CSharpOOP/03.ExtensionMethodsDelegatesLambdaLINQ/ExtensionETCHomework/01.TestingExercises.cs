namespace ExtensionETCHomework
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Threading;
    using System.Globalization;
    using System.Linq;
    class Program
    {
        public static int  longest = 0;
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            string dashes = new string('-', 75);

            //01.Implement an extension method Substring(int index, int length) for the class StringBuilder 
            //   that returns new StringBuilder and has the same functionality as Substring in the class String.

            Console.WriteLine("\t Exercise 01\n");
            string testString = "This is the test string!";
            StringBuilder testSB = new StringBuilder();

            testSB.Append(testString);

            Console.WriteLine("String in the StringBuilder: "+testSB.ToString());

            Console.WriteLine("The StringBuilder with extension method \"SubString(12, 11)\": " 
                + testSB.SubString(12, 11).ToString());

            Console.WriteLine();
            Console.WriteLine(dashes);

            //02.Implement a set of extension methods for IEnumerable<T> that implement the following group 
            //   functions: sum, product, min, max, average.

            Console.WriteLine("\t Exercise 02\n");

            int[] inumTestInts = {3,4,5};

            Console.WriteLine("For  int[] = 3, 4, 5");
            Console.WriteLine(".Sum() = "+inumTestInts.Sum());
            Console.WriteLine(".Product() ="+inumTestInts.Product());
            Console.WriteLine(".Min() = "+inumTestInts.Min());
            Console.WriteLine(".Max() = "+inumTestInts.Max());
            Console.WriteLine();

            double[] inumTestDecimals = { 10 , 20 , 1.1 };

            Console.WriteLine("For double[] = 10 , 20 , 1.1 ");
            Console.WriteLine(".Sum() = "+inumTestDecimals.Sum());
            Console.WriteLine(".Product() ="+inumTestDecimals.Product());
            Console.WriteLine(".Min() = "+inumTestDecimals.Min());
            Console.WriteLine(".Max() = "+inumTestDecimals.Max());

            Console.WriteLine();
            Console.WriteLine(dashes);

            //03.Write a method that from a given array of students finds all students whose first name is before 
            //   its last name alphabetically. Use LINQ query operators.

            Console.WriteLine("\t Exercise 03\n");
            Console.WriteLine("Students whose first name is before its last name alphabetically:\n");

            // The big list of students
            var students = new List<Student>
            {
                new Student
                {
                    FirstName="Petar",
                    LasttName="Stoyanov",
                    DateOfBirth=new DateTime (1962,5,23),
                    FN=500102,
                    Tel="088 1243566",
                    Email="pesho_prezidenta@abv.bg",
                    Marks=new List<int> {6,5,4,2},
                    GroupNumber=1
                },
                new Student
                {
                    FirstName="Axmed",
                    LasttName="Dogan",
                    DateOfBirth=new DateTime (1954,3,29),
                    FN=500209,
                    Tel="089 24444326",
                    Email="baklava@yahoo.com",
                    Marks=new List<int> {2,2},
                    GroupNumber=2
                },
                new Student
                {
                    FirstName="Joseph",
                    LasttName="Stalin",
                    DateOfBirth=new DateTime (1999,12,18),
                    FN=500301,
                    Tel="+359 123 888 999",
                    Email="SuperStalin@gmail.com",
                    Marks=new List<int> {6,6,6,6,5},
                    GroupNumber=1
                },
                new Student
                {
                    FirstName="Boiko",
                    LasttName="Borisov",
                    DateOfBirth=new DateTime (2001,6,13),
                    FN=500502,
                    Tel="+359 444 778 33",
                    Email="pareNema@yahoo.uk",
                    Marks=new List<int> {5,4,2,2},
                    GroupNumber=1
                },
                new Student
                {
                    FirstName="Simeon",
                    LasttName="Saxe-Coburg-Gotha",
                    DateOfBirth=new DateTime (1993,6,16),
                    FN=500606,
                    Tel="088 400 400",
                    Email="carq@abv.bg",
                    Marks=new List<int> {4,5,3,2,2},
                    GroupNumber=2
                },
                new Student
                {
                    FirstName="Vladimir",
                    LasttName="Lenin",
                    DateOfBirth=new DateTime (1991,1,21),
                    FN=500707,
                    Tel="089 697 333",
                    Email="communism@fishki.net",
                    Marks=new List<int> {6,3,4},
                    GroupNumber=1
                },
                new Student
                {
                    FirstName="Joe",
                    LasttName="Cocker",
                    DateOfBirth=new DateTime (1994,5,20),
                    FN=500806,
                    Tel="+359 02 6846 773",
                    Email="joe_cocker@abv.bg",
                    Marks=new List<int> {5,5,6,4},
                    GroupNumber=2
                },
                new Student
                {
                    FirstName="Vladimir",
                    LasttName="Putin",
                    DateOfBirth=new DateTime (1952,10,7),
                    FN=500908,
                    Tel="+7 496 321 333 223",
                    Email="presidente@fishki.net",
                    Marks=new List<int> {6,6,6,6,6},
                    GroupNumber=1
                }              
            };

            var studentsWithAlphabeticalNames = students.Where(s => s.LasttName.CompareTo(s.FirstName)==1);
            Extensions.Print(studentsWithAlphabeticalNames);
            Console.WriteLine(dashes);


            //04.Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

            Console.WriteLine("\t Exercise 04\n");
            Console.WriteLine("First name and last name of all students with age between 18 and 24:\n");

            var studentNamesBetween18and24 =
                from s in students
                where s.Age() < 25 && s.Age() > 17
                select (s.FirstName + " " + s.LasttName + " - " + s.Age().ToString());

            foreach (var student in studentNamesBetween18and24)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine();
            Console.WriteLine(dashes);


            //05.Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first 
            //   name and last name in descending order. Rewrite the same with LINQ.

            Console.WriteLine("\t Exercise 05\n");
            Console.WriteLine("Sorting the students by first name and last name in descending order:\n");
            var studentsOrderedByName = students.OrderByDescending(s => s.FirstName).ThenByDescending(s => s.LasttName);               
            Extensions.Print(studentsOrderedByName);

            Console.WriteLine(dashes);

            //06.Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
            //   Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

            Console.WriteLine("\t Exercise 06\n");

            int[] intArray = {1 , 3 , 7 , 12 , 42 , 4 , 5 , 14 , 333 , 700, 21};
            var divisibleBy7And3 = intArray.Where(a => ((a%3==0 ) && (a%7==0)));
            Console.Write("Int array : "); 
            Extensions.Printing(intArray);
            Console.WriteLine();
            Console.Write("Divisible by 7 and 3 : ");
            Extensions.Printing(divisibleBy7And3);
            Console.WriteLine();

            Console.WriteLine(dashes);

            //09.Create a class student with properties FirstName, LastName, FN, Tel, Email, Marks (a List<int>), GroupNumber. 
            //   Create a List<Student> with sample students. Select only the students that are from group number 2. 
            //   Use LINQ query. Order the students by FirstName.

            Console.WriteLine("\t Exercise 09\n");
            Console.WriteLine("Students from group 2 ordered by First name:\n");
            var studentsFromGroup2 = students.Where(s => s.GroupNumber == 2).OrderBy(s => s.FirstName);
            Extensions.Print(studentsFromGroup2);

            Console.WriteLine(dashes);

            //10.Implement the previous using the same query expressed with extension methods.

            Console.WriteLine("\t Exercise 10\n");
            Console.WriteLine("Students from group 2 ordered by First name (with extension methods):\n");
            Extensions.Print(students.FromGroup(2));

            Console.WriteLine(dashes);

            //11.Extract all students that have email in abv.bg. Use string methods and LINQ.

            Console.WriteLine("\t Exercise 11\n");
            Console.WriteLine("All students that have email in abv.bg:\n");
            var studentsWithAbvEmails = students.Where(s => s.Email.Contains("@abv.bg"));
            Extensions.Print(studentsWithAbvEmails);

            Console.WriteLine(dashes);

            //12.Extract all students with phones in Sofia. Use LINQ.

            Console.WriteLine("\t Exercise 12\n");
            Console.WriteLine("All students with phones in Sofia (code 02)");
            var studentsWithPhonesInSofia = students.Where(s => s.Tel.Contains("359 02"));
            Extensions.Print(studentsWithPhonesInSofia);

            Console.WriteLine(dashes);

            //13.Select all students that have at least one mark Excellent (6) into a new anonymous class that 
            //   has properties – FullName and Marks. Use LINQ.

            Console.WriteLine("\t Exercise 13\n");
            Console.WriteLine("All students that have at least one mark Excellent (6):\n");
            var stBuilder = new StringBuilder();
            foreach (var student in students)
            {
                
                if (student.Marks.Contains(6))
                {
                    // Anonymous class 
                    var temp = new
                    {
                        fullname = (student.FirstName + " " + student.LasttName),
                        marks = student.Marks
                    };

                    Console.Write(temp.fullname+" ");
                    foreach (var mark in temp.marks)
                    {
                        Console.Write(mark+" ");
                    }
                    Console.WriteLine();
                }
                stBuilder.Clear();
            }
            Console.WriteLine();
            Console.WriteLine(dashes);

            //14.Write down a similar program that extracts the students with exactly  two marks "2". Use extension methods.

            Console.WriteLine("\t Exercise 14\n");
            Console.WriteLine("All students that have exactly  two marks \"2\"\n");
            var studentswithTwo2s = students.ExtractWithTwo2s();
            Extensions.Print(studentswithTwo2s);

            Console.WriteLine(dashes);

            //15.Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

            Console.WriteLine("\t Exercise 15\n");
            Console.WriteLine("All Marks of the students that enrolled in 2006. (FN ends with 06):\n");
            var allMarksFrom2006 = new List<int>();
            foreach (var student in students)
            {
                if (student.FN.ToString()[4]=='0' && student.FN.ToString()[5]=='6')
                {
                    allMarksFrom2006.InsertRange(allMarksFrom2006.Count, student.Marks);
                }
            }
            Extensions.Printing(allMarksFrom2006);
            Console.WriteLine();


            Console.WriteLine(dashes);

            //17.Write a program to return the string with maximum length from an array of strings. Use LINQ.
            Console.WriteLine("\t Exercise 17\n");
            Console.WriteLine("The string with maximum length from an array of strings:\n");
            string[] stringArray = { "aa", "aaaaaa", "aaa", "aaaaaaaaaaaaaaa", "a" };
            Console.Write("The Array: ");
            Extensions.Printing(stringArray);
            Console.WriteLine();
            var longestString = from st in stringArray
                                where Extensions.GetLongeestString(st)
                                select st;
            Console.Write("The maximal string: ");
            Console.WriteLine(longestString.Last());
            Console.WriteLine();
        }
    }
}