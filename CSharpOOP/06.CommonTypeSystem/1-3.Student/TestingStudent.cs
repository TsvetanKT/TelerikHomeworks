//01.Define a class Student, which contains data about a student – first, middle and last name, SSN, 
//   permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration 
//   for the specialties, universities and faculties. Override the standard methods, inherited by  
//   System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
//
//02.Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's 
//   fields into a new object of type Student.
//
//03.Implement the  IComparable<Student> interface to compare students by names (as first criteria, in 
//   lexicographic order) and by social security number (as second criteria, in increasing order).

namespace Student
{
    using System;

    class TestingStudent
    {
        static void Main()
        {
            Console.WriteLine("01-03.Testing Students\n");
            var joko = new Student("Pernik, ul Golema Mina №5");
            joko.FirstName = "Joko";
            joko.MiddleName = "Ivanov";
            joko.LastName = "Petrov";
            joko.MobilePhone = "08989745612";
            joko.SSN = "3336547";
            joko.University = Universities.TU;
            joko.Speciality = Specialties.Specialty1;
            joko.Faculty = Faculties.Faculty2;

            var ivo = new Student();
            ivo.FirstName = "Ivo";
            ivo.MiddleName = "Dimov";
            ivo.LastName = "Trenchev";
            ivo.MobilePhone = "0881001";
            ivo.SSN = "56465465";

            //joko.Address = "drugade";  // Address cannot be changed - its permanent

            Console.WriteLine("Testing ToString: joko.ToString() = " + joko.ToString());
            Console.WriteLine("Testing ToString: ivo.ToString() = " + ivo.ToString());
            Console.WriteLine("\nTesting Equals(): joko.Equals(ivo) = " + joko.Equals(ivo));
            Console.WriteLine("\nTesting GetHashCode: joko.GetHashCode() = " + joko.GetHashCode());
            Console.WriteLine("                     ivo.GetHashCode() = " + ivo.GetHashCode());

            Console.WriteLine("\nTesting \"==\": joko==ivo = "+(joko==ivo));
            Console.WriteLine("Testing \"!=\": joko!=ivo = " + (joko != ivo));

            var jokoClone =(Student) joko.Clone();
            Console.WriteLine("\nToString Clone: jokoClone.ToString() = " + jokoClone.ToString());
            Console.WriteLine("\nTesting \"==\": joko==jokoClone = " + (joko == jokoClone));

            string newSNN = "999999999";

            Console.WriteLine("\nTesting CompareTo: joko.CompareTo(ivo) = " + joko.CompareTo(ivo));
            Console.WriteLine("             joko.CompareTo(jokoClone) = " + joko.CompareTo(jokoClone));
            Console.WriteLine("\nChanging jokoClone's SSN from {0} to {1}",jokoClone.SSN,newSNN);

            jokoClone.SSN = newSNN;
            Console.WriteLine("\nTesting CompareTo: joko.CompareTo(jokoClone) = " + joko.CompareTo(jokoClone));
            Console.WriteLine();

        }
    }
}
