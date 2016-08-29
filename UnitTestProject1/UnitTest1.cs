using System;
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
            // Arrange


            // Act
            Student.Name = "N";

            // Assert
            Assert.AreNotEqual("N", Student.Name);
        }
        [TestMethod]
        public void TestSetAddressNull()
        {
            // Arrange


            // Act
            Student.Address = null;

            // Assert
            Assert.IsNotNull(Student.Address,Student.Address);
        }
        [TestMethod]
        public void TestSetAddressEmpty()
        {
            // Arrange


            // Act
            Student.Address = "";

            // Assert
            Assert.AreNotEqual("", Student.Address);
        }
        [TestMethod]
        public void TestSetSemester()
        {
            // Arrange


            // Act
            Student.Semester = 9;

            // Assert
            Assert.AreNotEqual(9, Student.Semester);
        }

        [TestMethod]
        public void TestForCheckingNameLength()
        {
            // Arrange
            

            // Act


            // Assert
            Assert.AreNotEqual("N",Student.Name);
        }
        [TestMethod]
        public void TestForCheckingIfAddressIsNotNull()
        {
            // Arrange


            // Act

            // Assert
            Assert.IsNotNull(Student.Address);
        }
        [TestMethod]
        public void TestForCheckingIfAddressIsNotEmpty()
        {
            // Arrange

            // Act

            // Assert
            Assert.AreNotEqual("", Student.Address);
        }
        [TestMethod]
        public void TestForCheckingIfSemesterIsLegal()
        {
            // Arrange

            // Act

            // Assert
            Assert.AreNotEqual(9, Student.Semester);
        }


    }
}
