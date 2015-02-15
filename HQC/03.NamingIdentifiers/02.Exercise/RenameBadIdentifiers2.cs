using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQPC_HW_02
{
    class Program
    {
        static void Main()
        {
        }
    }

    class Hauptklasse
    {
        public enum Sex { Male, Female };

        class Person
        {
            public Sex Sex { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public void MakeHuman(int age)
        {
            Person newPerson = new Person();
            newPerson.Age = age;
            if (age % 2 == 0)
            {
                newPerson.Name = "Батката";
                newPerson.Sex = Sex.Male;
            }
            else
            {
                newPerson.Name = "Мацето";
                newPerson.Sex = Sex.Female;
            }
        }
    }
}
