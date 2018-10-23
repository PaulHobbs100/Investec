using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnyCompany.Tests
{
    [TestClass]
    public class AnyCompanyDBTests
    {
        [TestMethod]
        public void SaveDummyOrderRowToDB()
        {
            var OR = new OrderRepository();
            Order order = new Order()
            {
                Amount = 1.11,
                VAT = 0.2,
                CustomerId = 999
                
            };
            OR.Save(order);
        }
    }
}
