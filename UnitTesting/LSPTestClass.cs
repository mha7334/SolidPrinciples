using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidPrinciples.LSP;


namespace UnitTesting
{
   
    [TestClass]
    public class LSPTestClass
    {
        private List<IDatabase> customers;
      
        [TestInitialize]
        public void TestSetup()
        {
            customers =  new List<IDatabase>();
            customers.Add(new GoldCustomer());
            customers.Add(new SilverCustomer());

            // customers.Add(new EnquiryCustomer()); can't add             
        }

        [TestMethod]
        public void GoldCustomerDiscount()
        {
            var result = new GoldCustomer().GetDiscount(100);
            Assert.AreEqual(94.0, result);
        }

        [TestMethod]
        public void SilverCustomerDiscount()
        {
            var result = new SilverCustomer().GetDiscount(100);
            Assert.AreEqual(95.0, result);
        }


    }
}
