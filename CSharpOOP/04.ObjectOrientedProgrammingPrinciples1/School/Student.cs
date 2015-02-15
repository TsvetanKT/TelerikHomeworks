namespace School
{
    using System;
    public class Student : People
    {
        public Student (string name, string number)
            :base(name)
        {
            this.ClassNumber = number;
        }

        public string ClassNumber { get; private set; }  // No need to be int
    }
}
