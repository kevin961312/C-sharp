using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";

            // Act
            string actual = customer.FullName;
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // Arrange
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };
            string expected = "Baggins";

            // Act
            string actual = customer.FullName;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            Assert.AreEqual(3, Customer.InstanceCount);
        }
        [TestMethod]
        public void ValidateValid()
        {
            //-- Arrange
            var customer = new Customer
            {
                LastName = "Baggins",
                EmailAdress = "fbaggins@hobbilon.me"
            };
            var expected = true;
            // -- Act
            var actual = customer.Validate();
            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateMissingLastName()
        {
            //-- Arrange
            var customer = new Customer
            {
                EmailAdress = "fbaggins@hobbilon.me"
            };
            var expected = false;

            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }
    }
}
