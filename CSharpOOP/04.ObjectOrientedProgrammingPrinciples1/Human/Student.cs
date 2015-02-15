namespace Human
{
    using System;
    public class Student : Human
    {
        private int grade;

        public Student (string firstName, string secondName, int theGrade)
            :base(firstName,secondName)
        {
            this.Grade = theGrade;
        }
        public int Grade
        {
            get
            {
                return this.grade;
            }
            private set
            {
                if (value>6 ||value < 2)
                {
                    throw new ArgumentOutOfRangeException("Grade must be between 2 and 6.");
                }
                grade = value;
            }
        }
    }
}
