namespace ExtensionETCHomework
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    public class Student
    {
        public string FirstName { get; set; }

        public string LasttName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int FN { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        public int Age ()
        {
            return ((DateTime.Now - this.DateOfBirth).Days ) / 365;
        }

        public string PrintingMarks ()
        {
            var printedMarks = new StringBuilder();
            foreach (var mark in this.Marks)
            {
               printedMarks.Append(mark+" ");
            }
            return printedMarks.ToString();
        }

        public override string ToString()
        {
            return "FN: " + this.FN + " " + this.FirstName + " " + this.LasttName + "   Age: " + this.Age()
                + "\nTel: " + this.Tel + "  Email: " + this.Email + "  Group Number: " + this.GroupNumber
                + "\nMarks: " + this.PrintingMarks() + "\n****************\n";
        }
    }
}
