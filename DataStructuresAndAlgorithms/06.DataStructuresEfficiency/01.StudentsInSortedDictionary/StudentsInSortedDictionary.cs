namespace StudentsInSortedDictionary
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Wintellect.PowerCollections;

    class StudentsInSortedDictionary
    {
        static void Main()
        {
            SortedDictionary<string, OrderedBag<Student>> dict = new SortedDictionary<string, OrderedBag<Student>>();

            int counter = 0;
            string line;

            var myDictionary = new SortedDictionary<string, SortedDictionary<string, string>>();

            StreamReader sr = new StreamReader("..\\..\\text.txt");
            using (sr)
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    var entry = line.Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);

                    Student stud = new Student(entry[0], entry[1]);
                    string key = entry[2];

                    if (dict.ContainsKey(key))
                    {
                        dict[key].Add(stud);
                    }
                    else
                    {
                        dict[key] = new OrderedBag<Student> { new Student(entry[0], entry[1]) };
                    }

                    counter++;
                }
            }

            Console.WriteLine("\nCourses:");
            foreach (var course in dict)
            {
                Console.WriteLine("{0} Students: ", course.Key);
                Console.WriteLine(String.Join(", ", course.Value) + "\n");
            }
        }
    }
}

