using Microsoft.VisualStudio.TestTools.UnitTesting;
using SECM.BL;
using System;

namespace SECM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //----- Arrange
            Customer customer = new Customer
            {
                FirstName = "Masud",
                LastName = "Rana"
            };

            string expected = "Masud, Rana";

            //----- Act
            string actual = customer.FullName;

            //----- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //----- Arrange
            Customer customer = new Customer
            {
                LastName = "Rana"
            };

            string expected = "Rana";
            //----- Act
            string actual = customer.FullName;

            //----- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //----- Arrange
            Customer customer = new Customer
            {
                FirstName = "Masud"
            };

            string expected = "Masud";
            //----- Act
            string actual = customer.FullName;

            //----- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //----- Arrange
            Customer customer = new Customer
            {
                FirstName = "Masud",
                EmailAddress = "masudranaata@gmail.com"
            };
            bool expected = true;
            //----- Act
            bool actual = customer.Validate();

            //----- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingFirstName()
        {
            //----- Arrange
            Customer customer = new Customer
            {
                EmailAddress = "masudranaata@gmail.com"
            };
            bool expected = false;
            //----- Act
            bool actual = customer.Validate();

            //----- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
