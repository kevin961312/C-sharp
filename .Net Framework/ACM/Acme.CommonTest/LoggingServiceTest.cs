using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            var changedItems = new List<ILoggable>();
            var customer = new Customer(1)
            {
              EmailAdress = "fbaggins@hobbiton.me",
              FirstName = "Frodo",
              LastName = "Baggins",
              AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake With Steel Head",
                CurrentPrice = 6M
            };
            changedItems.Add(product);
            // Act
            LoggingService.WriteToFile(changedItems);
        }
    }
}
