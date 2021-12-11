using Microsoft.VisualStudio.TestTools.UnitTesting;
using SE.Common;
using SECM.BL;
using System;
using System.Collections.Generic;

namespace SE.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //----- Arrange
            var changedItems = new List<ILoggable>();

            Customer customer = new Customer(1)
            {
                EmailAddress = "masudranaat@gmail.com",
                FirstName = "Masud",
                LastName = "Rana",
                AddressList = null
            };
            changedItems.Add(customer);

            Product product = new Product
            {
                ProductName = "Kakoli Furniture",
                ProductDescription = "Dame kom mane valo.",
                CurrentPrice = 2.2M
            };
            changedItems.Add(product);

            //----- Act
            LoggingService.WriteToFile(changedItems);

            //-----Assert
        }
    }
}
