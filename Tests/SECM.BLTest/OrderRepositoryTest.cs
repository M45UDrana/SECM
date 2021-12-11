using Microsoft.VisualStudio.TestTools.UnitTesting;
using SECM.BL;
using System;

namespace SECM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveOrderDisplayTest()
        {
            //----- Arrange
            OrderRepository orderRepository = new OrderRepository();
            Order expected = new Order(5)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 5, 21, 20, 03, 02, new TimeSpan(7, 0, 0))
            };

            //-----Act
            Order actual = orderRepository.Retrieve(5);

            //-----Assert
            Assert.AreEqual(expected.OrderId, actual.OrderId);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}
