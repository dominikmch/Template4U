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
            customer.mRegistrationDate = TestData;

            Assert.AreEqual(customer.mRegistrationDate, TestData);
        }

        [TestMethod]
        public void TestIfClientIsBusinessPropertyOk()
        {
            clsCustomer customer = new clsCustomer();

            bool IsBusiness = true;
            customer.mIsBusinessCustomer = IsBusiness;

            Assert.AreEqual(customer.mIsBusinessCustomer, IsBusiness);
        }

        [TestMethod]
        public void CustomerNamePropertyOk()
        {
            clsCustomer customer = new clsCustomer();
            string customerName = "Andrew";
            customer.mCustomerName = customerName;

            Assert.AreEqual(customerName, customer.mCustomerName);
        }

        [TestMethod]
        public void CustomerPasswordPropertyOk()
        {
            clsCustomer customer = new clsCustomer();
            string customerPassword = "secret";
            customer.mCustomerPassword = customerPassword;

            Assert.AreEqual(customerPassword, customer.mCustomerPassword);
        }

        [TestMethod]
        public void CustomerEmailPropertyOk()
        {
            clsCustomer customer = new clsCustomer();
            string customerEmail = "email@email.com";
            customer.mCustomerEmail = customerEmail;

            Assert.AreEqual(customerEmail, customer.mCustomerEmail);
        }

        [TestMethod]
        public void CustomerIdPropertyOk()
        {
            clsCustomer customer = new clsCustomer();
            int customerId = 71;
            customer.mCustomerId = customerId;

            Assert.AreEqual(customerId, customer.mCustomerId);
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
