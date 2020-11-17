using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            // Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescription = "Assorted size set of 4 bright yellow mini sunflowers",
                CurrentPrice = 15.96M
            };
            // Act
            var actual = productRepository.Retrieve(2);
            // Assert 
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }
            [TestMethod]
            public void SaveTestValid()
            {
                // Arrange
            var productRepository = new ProductRepository();
            var updatedProduct= new Product(2)
            {
                    ProductName = "Sunflowers",
                    ProductDescription = "Assorted size set of 4 bright yellow mini sunflowers",
                    CurrentPrice = 18M,
                    HasChanges = true
                };
            // Act
            var actual = productRepository.Save(updatedProduct);
            // Assert 
            Assert.AreEqual(true, actual);
            }
        [TestMethod]
        public void SaveTestMissingPrice()
        {
            // Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescription = "Assorted size set of 4 bright yellow mini sunflowers",
                CurrentPrice = null,
                HasChanges = true
            };
            var actual = productRepository.Save(updatedProduct);
            // Assert 
            Assert.AreEqual(false, actual);
        }
    }
}
