using System;
using System.Globalization;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Template4UClassLib;

namespace Template4UTesting
{
    [TestClass]
    public class tstCustomer
    {
        //Test Data
        private string _customerId = "555";
        private string _customerEmail = "aaa@bbb.com";
        private string _customerPassword = "Password";
        private string _customerName = "SuperUser";
        private string _customerRegistrationDate = DateTime.Now.ToString(CultureInfo.CurrentCulture);
        private string _customerIsBusinessClient = "true";

        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer Customer = new clsCustomer();
            Assert.IsNotNull(Customer);
        }

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

        [TestMethod]
        public void TestFindMethodNotFound()
        {
            clsCustomer customer = new clsCustomer();

            var found = false;
            var customerId = 999;
            found = customer.Find(customerId);
            Assert.IsFalse(found);
        }

        [TestMethod]
        public void TestFindMethodFound()
        {
            clsCustomer customer = new clsCustomer
            {
                CustomerId = int.Parse(_customerId)
            };

            var customerId = 555;

            Assert.IsFalse(customer.Find(customerId));
        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            clsCustomer customer = new clsCustomer();

            customer.Find(1);

            Assert.IsTrue(customer.CustomerId == 1);
        }

        [TestMethod]
        public void TestCustomerEmailFound()
        {
            clsCustomer customer = new clsCustomer();

            customer.Find(1);

            Assert.AreEqual("test@test.co.uk", customer.CustomerEmail);
        }

        [TestMethod]
        public void TestCustomerPasswordFound()
        {
            clsCustomer customer = new clsCustomer();

            customer.Find(1);

            Assert.AreEqual("TestPassword", customer.CustomerPassword );
        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            clsCustomer customer = new clsCustomer();

            customer.Find(1);

            Assert.AreEqual("TestUser", customer.CustomerName );
        }

        [TestMethod]
        public void TestCustomerRegistrationDateFound()
        {
            clsCustomer customer = new clsCustomer();

            customer.Find(1);

            Assert.AreNotEqual(DateTime.Now, customer.RegistrationDate);
        }

        [TestMethod]
        public void TestCustomerIsBusinessFound()
        {
            clsCustomer customer = new clsCustomer();

            customer.Find(1);

            Assert.AreEqual(true,customer.IsBusinessCustomer);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            var customer = new clsCustomer();

            var Error = customer.ValidateFields(_customerId, _customerEmail, _customerName, _customerPassword,
                _customerIsBusinessClient);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StandardValuesAreValid() 
        {
            var customer = new clsCustomer();

            var Error = customer.ValidateFields(_customerId, _customerEmail, _customerName, _customerPassword,
                _customerIsBusinessClient);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void ValuesBelowMinimumAreNotValid()
        {
            var customer = new clsCustomer();

            var Error = customer.ValidateFields("", "", "", "", "");

            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void ValuesAboveMaximumAreNotValid()
        {
            var customer = new clsCustomer();

            var maxValue = "".PadRight(500, 'x');

            var Error = customer.ValidateFields(maxValue, maxValue, maxValue, maxValue, maxValue);

            Assert.AreNotEqual("", Error);
        }
    }
}
