using Microsoft.VisualStudio.TestTools.UnitTesting;
using SECM.BL;
using System;
using System.Collections.Generic;

namespace SECM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //----- Arrange
            CustomerRepository customerRepository = new CustomerRepository();
            Customer expected = new Customer(1)
            {
                EmailAddress = "masudranaata@gmail.com",
                FirstName = "Masud",
                LastName = "Rana"
            };

            //----- Act
            Customer actual = customerRepository.Retrieve(1);

            //----- Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {

            //----- Arrange
            CustomerRepository customerRepository = new CustomerRepository();
            Customer expected = new Customer(1)
            {
                EmailAddress = "masudranaata@gmail.com",
                FirstName = "Masud",
                LastName = "Rana",
                AddressList = 
                {
                    new Address(1)
                    {
                        AddressType = 1,
                        streetLine1 = "Central Road",
                        streetLine2 = "Vuter golli",
                        City = "Dhaka",
                        State = "Dhaka",
                        Country = "Bangladesh",
                        PostalCode = "1205"
                    },

                    new Address(2)
                    {
                        AddressType = 2,
                        streetLine1 = "Central Road",
                        streetLine2 = "Vuter golli",
                        City = "Dhaka",
                        State = "Dhaka",
                        Country = "Bangladesh",
                        PostalCode = "1205"
                    },

                     new Address(3)
                    {
                        AddressType = 3,
                        streetLine1 = "Central Road",
                        streetLine2 = "Vuter golli",
                        City = "Dhaka",
                        State = "Dhaka",
                        Country = "Bangladesh",
                        PostalCode = "1205"
                    }
                }
            };

            //----- Act
            Customer actual = customerRepository.Retrieve(1);

            //----- Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            Assert.AreEqual(expected.AddressList[0].AddressType, actual.AddressList[0].AddressType);
            Assert.AreEqual(expected.AddressList[0].streetLine1, actual.AddressList[0].streetLine1);
            Assert.AreEqual(expected.AddressList[0].streetLine2, actual.AddressList[0].streetLine2);
            Assert.AreEqual(expected.AddressList[0].City, actual.AddressList[0].City);
            Assert.AreEqual(expected.AddressList[0].State, actual.AddressList[0].State);
            Assert.AreEqual(expected.AddressList[0].Country, actual.AddressList[0].Country);
            Assert.AreEqual(expected.AddressList[0].PostalCode, actual.AddressList[0].PostalCode);

            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].streetLine1, actual.AddressList[i].streetLine1);
                Assert.AreEqual(expected.AddressList[i].streetLine2, actual.AddressList[i].streetLine2);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }
    }
}
