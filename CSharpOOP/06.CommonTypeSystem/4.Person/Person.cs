namespace Person
{
    using System;

    public class Person
    {
        public string Name { get; set; }

        public int? Age { get; set; }

        public override string ToString()
        {
            string theAge;

            if (this.Age == null)
            {
                theAge = "not specified";
            }
            else
            {
                theAge = this.Age.ToString();
            }

            return "Name: " + this.Name + " Age: " + theAge;

        }
    }
}
