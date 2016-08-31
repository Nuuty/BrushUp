using System;
using System.Net.Sockets;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public static Student Student { get; set; }

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            Student = new Student("N", null, 9, Gender.Male);
        }

        [TestMethod]
        public void TestSetName()
        {
            // Act
            Student.Name = "N";

            // Assert
            Assert.AreNotEqual("N", Student.Name);
        }
        [TestMethod]
        public void TestSetAddressNull()
        {
            // Act
            Student.Address = null;

            // Assert
            Assert.IsNotNull(Student.Address,Student.Address);
        }
        [TestMethod]
        public void TestSetAddressEmpty()
        {
            // Act
            Student.Address = "";

            // Assert
            Assert.AreNotEqual("", Student.Address);
        }
        [TestMethod]
        public void TestSetSemester()
        {
            // Act
            Student.Semester = 9;

            // Assert
            Assert.AreNotEqual(9, Student.Semester);
        }

        [TestMethod]
        public void TestForCheckingNameLength()
        {
            Assert.AreNotEqual("N",Student.Name);
        }
        [TestMethod]
        public void TestForCheckingIfAddressIsNotNull()
        {
            Assert.IsNotNull(Student.Address);
        }
        [TestMethod]
        public void TestForCheckingIfAddressIsNotEmpty()
        {
            Assert.AreNotEqual("", Student.Address);
        }
        [TestMethod]
        public void TestForCheckingIfSemesterIsLegal()
        {
            Assert.AreNotEqual(9, Student.Semester);
        }

        [TestMethod]
        public void TestTeacherName()
        {
            Teacher teacher = new Teacher("N","Elisagårdsvej 5",Gender.Male,19000);
            
            Assert.AreNotEqual("N",teacher.Name);
        }

    }
}
