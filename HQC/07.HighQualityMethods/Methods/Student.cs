namespace Methods
{
    using System;

    public class Student
    {
        // The date is 10 simbols. I think consts can have underscores.
        public const int MIN_INFO_LENGHT = 10;
        private string firstName;
        private string lastName;
        private string otherInfo;
        private DateTime birthday;

        public Student(string firstNameInput, string lastNameInput, string otherInfoInput)
        {
            this.FirstName = firstNameInput;
            this.LastName = lastNameInput;
            this.OtherInfo = otherInfoInput;
        }

        public string FirstName 
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (value.Trim().Length > 1)
                {
                    this.firstName = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("First name must be with more than one simbol.");
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (value.Trim().Length > 1)
                {
                    this.lastName = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Last name must be with more than one simbol.");
                }
            }
        }

        public string OtherInfo
        {
            get
            {
                return this.otherInfo;
            }

            set
            {
                DateTime birthdayInput;

                // Trim for useless empty spaces.
                if (value.Trim().Length < MIN_INFO_LENGHT)
                {   
                    throw new ArgumentOutOfRangeException("Student info must contain more than " + MIN_INFO_LENGHT + " simbols.");
                }

                // Check if the last 10 simbols are not a valid date.
                if (DateTime.TryParse(value.Substring(value.Length - 10), out birthdayInput) == false)
                {
                    throw new FormatException("Bad data format in Other Info section.");
                }

                this.birthday = DateTime.Parse(value.Substring(value.Length - 10));
                this.otherInfo = value;               
            }
        }

        public bool IsOlderThan(Student other)
        {
            bool isOlder = this.birthday < other.birthday;
            return isOlder;
        }
    }
}
