using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Student : ICloneable, IComparable<Student>
    {
        public Student ()
        {

        }

        public Student (string adsress)
        {
            this.Address = adsress;
        }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string SSN { get; set; }  // Using string for SSN cuz it's not going to be any calculations with it.

        public string Address { get; private set; } 

        public string MobilePhone { get; set; }

        public string Email { get; set; }

        public string Course { get; set; }

        public Specialties Speciality { get; set; }

        public Universities University { get; set; }

        public Faculties Faculty { get; set; }



        public override bool Equals(object param)
        {
            // If the cast is invalid, the result will be null
            Student student = param as Student;
            // Check if we have valid not null Student object
            if (student == null)
                return false;
            // Compare the reference type member fields
            if (!Object.Equals(this.FirstName, student.FirstName))
                return false;
            // Compare the value type member fields
            if (!Object.Equals(this.LastName, student.LastName))
                return false;
            return true;
        }

        public static bool operator ==(Student student1,
                                  Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1,
                           Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ LastName.GetHashCode();
        }

        public override string ToString()
        {
            return this.FirstName + " " 
                + this.MiddleName + " "
                + this.LastName 
                + " Phone: " 
                + this.MobilePhone;
        }

        public object Clone()
        {
            // No real need for deep copy algorithms cuz all the fields are strings
            return this.MemberwiseClone();
        }

        public int CompareTo(Student other)
        {
            if (this.FirstName.CompareTo(other.FirstName)>0)
            {
                return 1;
            }

            if (this.FirstName.CompareTo(other.FirstName) < 0)
            {
                return -1;
            }

            // If names are equal, we are trying the second criteria
            else // When : (this.FirstName.CompareTo(other.FirstName) == 0)
            {
                if (this.SSN.CompareTo(other.SSN)>0)
                {
                    return 1;
                }

                if (this.SSN.CompareTo(other.SSN)< 0)
                {
                    return -1;
                }

                else // when  (this.SSN.CompareTo(other.SSN) == 0)
                {
                    return 0;
                }
            }
        }
    }
}
