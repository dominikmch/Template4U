using System;
using System.Text;
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

        //[TestMethod]
        //public void FindAllMethod_OK()
        //{
        //    clsCustomer customer = new clsCustomer();
        //    Console.WriteLine(customer.FindAll().ToString());
        //    Assert.IsTrue(customer.FindAll());
        //}

        [TestMethod]
        public void RegistrationDateProperyOk()
        {
            clsCustomer customer = new clsCustomer();
            DateTime TestData = DateTime.Now;
            customer.RegistrationDate = TestData;

            Assert.AreEqual(customer.RegistrationDate, TestData);
        }

        [TestMethod]
        public void TestIfClientIsBusinessPropertyOk()
        {
            clsCustomer customer = new clsCustomer();

            bool IsBusiness = true;
            customer.IsBusinessCustomer = IsBusiness;

            Assert.AreEqual(customer.IsBusinessCustomer, IsBusiness);
        }

        [TestMethod]
        public void CustomerNamePropertyOk()
        {
            clsCustomer customer = new clsCustomer();
            string customerName = "Andrew";
            customer.CustomerName = customerName;

            Assert.AreEqual(customerName, customer.CustomerName);
        }

        [TestMethod]
        public void CustomerPasswordPropertyOk()
        {
            clsCustomer customer = new clsCustomer();
            string customerPassword = "secret";
            customer.CustomerPassword = customerPassword;

            Assert.AreEqual(customerPassword, customer.CustomerPassword);
        }

        [TestMethod]
        public void CustomerEmailPropertyOk()
        {
            clsCustomer customer = new clsCustomer();
            string customerEmail = "email@email.com";
            customer.CustomerEmail = customerEmail;

            Assert.AreEqual(customerEmail, customer.CustomerEmail);
        }

        [TestMethod]
        public void CustomerIdPropertyOk()
        {
            clsCustomer customer = new clsCustomer();
            int customerId = 71;
            customer.CustomerId = customerId;

            Assert.AreEqual(customerId, customer.CustomerId);
        }

        [TestMethod]
        public void TestFindMethodOk()
        {
            clsCustomer customer = new clsCustomer();

            var found = false;
            var customerId = 8;
            found = customer.Find(customerId);
            Assert.IsTrue(found);
        }
    }
}
