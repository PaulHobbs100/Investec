using System;
using AnyCompany;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnyCompant.Tests
{
    [TestClass]
    public class AnyCompanyLogicTests
    {
        [TestMethod]
        public void PlaceOrderUKCustomerUsingSeedData()
        {
            Order order = new Order()
            {
                Amount = 1.11,
                CustomerId = 1

            };
            var OS = new OrderService();
            OS.PlaceOrder(order, 1);
        }
        [TestMethod]
        public void PlaceOrdernonUKCustomerUsingSeedData()
        {
            Order order = new Order()
            {
                Amount = 2.22,
                CustomerId = 2

            };
            var OS = new OrderService();
            OS.PlaceOrder(order, 2);
        }
        [TestMethod]
        public void LoadAll_viewOutputWindowforresults()
        {
            var OR =new OrderRepository();
            OR.LoadAll();
            //view results in test output window
            
        }
    }
}
