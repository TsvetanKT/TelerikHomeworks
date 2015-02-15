namespace TestingSchool
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using UnitTestingHW;
    using System.Text;

    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void TestNewSchoolConstructorName()
        {
            string name = "40 SOU";
            School school = new School(name);
            Assert.AreEqual(school.Name, name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNewSchoolConstructorNullName()
        {
            string name = null;
            School school = new School(name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNewSchoolConstructorEmptyName()
        {
            string name = string.Empty;
            School school = new School(name);
        }

        [TestMethod]
        public void TestAddStudentName()
        {
            string name = "40 SOU";
            Student student = new Student("Ivan Ivanov", 12233);
            School school = new School(name);
            school.AddStudent(student);
            Assert.AreEqual(student.Name, school.StudentsList[0].Name);
        }

        [TestMethod]
        public void TestAddStudentId()
        {
            string name = "40 SOU";
            Student student = new Student("Ivan Ivanov", 12233);
            School school = new School(name);
            school.AddStudent(student);
            Assert.AreEqual(student.StudentId, school.StudentsList[0].StudentId);
        }

        [TestMethod]
        public void TestRemoveStudent()
        {
            string name = "40 SOU";
            Student student = new Student("Ivan Ivanov", 12233);
            School school = new School(name);
            school.AddStudent(student);
            school.RemoveStudent(student);
            Assert.IsTrue(school.StudentsList.Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRemoveNotAddedStudent()
        {
            string name = "40 SOU";
            Student student = new Student("Ivan Ivanov", 12233);
            School school = new School(name);
            school.RemoveStudent(student);
        }

        [TestMethod]
        public void TestToStringValidName()
        {
            string name = "40 SOU";

            var sb = new StringBuilder();
            sb.Append("School: 40 SOU");
            sb.AppendLine();
            sb.Append("Student ID Name");
            sb.AppendLine();
            sb.AppendLine(12233 + " Ivan Ivanov");
            string answer = sb.ToString();

            School school = new School(name);
            Student student = new Student("Ivan Ivanov", 12233);
            school.AddStudent(student);
            Assert.AreEqual(school.ToString(), answer);
        }
    }
}
