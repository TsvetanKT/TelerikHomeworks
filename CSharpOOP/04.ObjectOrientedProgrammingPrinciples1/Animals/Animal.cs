namespace Animals
{
    using System;
    public abstract class Animal : ISound
    {
        private int age;
        private string sex;

        public Animal (string name, int age, string sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public Animal ()
        {

        }

        public string Name { get; private set; }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value > 50 || value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age must be between 0 and 50.");
                }
                age = value;
            }
        }

        public string Sex
        {
            get
            {
                return this.sex;
            }
            private set
            {
                if (value.ToLower() != "male" && value.ToLower() != "female")
                {
                    throw new ArgumentOutOfRangeException("Male or Female only !");
                }
                sex = value;
            }
        }

        public virtual string MakeSound()
        {
            return "?";
        }
    }
}
