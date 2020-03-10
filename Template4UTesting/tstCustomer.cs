using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Template4UClassLib;

namespace Template4UTesting
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer Customer = new clsCustomer();
            Assert.IsNotNull(Customer);
        }

        [TestMethod]
        public void TestFindAllMethod_OK()
        {
            clsCustomer Customer = new clsCustomer();
            Console.WriteLine(Customer.FindAll().ToString());
            Assert.IsTrue(Customer.FindAll());
        }
    }
}
