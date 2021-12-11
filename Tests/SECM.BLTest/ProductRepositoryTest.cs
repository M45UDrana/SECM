using Microsoft.VisualStudio.TestTools.UnitTesting;
using SECM.BL;
using System;

namespace SECM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            //----- Arrange
            ProductRepository productRepository = new ProductRepository();
            Product expected = new Product(4)
            {
                ProductName = "Mobile",
                ProductDescription = "Legendary Nokia 1200 model",
                CurrentPrice = 25.5M
            };

            //----- Act
            Product actual = productRepository.Retrieve(4);

            //----- Assert
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }


        [TestMethod]
        public void SaveValidTest()
        {
            //----- Arrange
            ProductRepository productRepository = new ProductRepository();
            Product updatedProduct = new Product(4)
            {
                ProductName = "Mobile",
                ProductDescription = "Legendary Nokia 1200 model",
                CurrentPrice = 13.5M,
                HasChanges = true
            };

            //----- Act
            bool actual = productRepository.Saves(updatedProduct);

            //----- Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SaveTestMissingPrice()
        {
            //----- Arrange
            ProductRepository productRepository = new ProductRepository();
            Product updatedProduct = new Product(4)
            {
                ProductName = "Mobile",
                ProductDescription = "Legendary Nokia 1200 model",
                CurrentPrice = null,
                HasChanges = true
            };

            //----- Act
            bool actual = productRepository.Saves(updatedProduct);

            //----- Assert
            Assert.AreEqual(false, actual);
        }
    }
}
