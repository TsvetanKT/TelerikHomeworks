//04.Create a class Person with two fields – name and age. Age can be left unspecified (may contain 
//   null value. Override ToString() to display the information of a person and if age is not 
//   specified – to say so. Write a program to test this functionality.

namespace Person
{
    using System;

        class TestingPerson
    {
        static void Main()
        {
            Console.WriteLine("04.Testing Person\n");

            var joe = new Person();
            joe.Name = "Joe";
            Console.WriteLine("Person without age: \n" + joe.ToString());

            joe.Age = 33;
            Console.WriteLine("\nPerson with age: \n" + joe.ToString());

            Console.WriteLine();
        }
    }
}
