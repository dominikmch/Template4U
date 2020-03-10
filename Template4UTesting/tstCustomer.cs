using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Template4UClassLib;

namespace Template4UTesting
{
    [TestClass]
    public class tstCustomer
    {
        clsCustomer Customer;

        [TestMethod]
        public void InstanceOK()
        {
            Customer = new clsCustomer();
            Assert.IsNotNull(Customer);
        }

        [TestMethod]
        public void TestFindAllMethod_OK()
        {
            Customer.FindAll();
        }
    }
}
