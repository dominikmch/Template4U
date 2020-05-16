using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Template4UClassLib;

namespace Template4UTesting
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void TestInstanceOk()
        {
            var allCustomers = new clsCustomerCollection();

            Assert.IsNotNull(allCustomers);
        }

        [TestMethod]
        public void CustomerListOk()
        {
            var allCustomers = new clsCustomerCollection();

            var testList = new List<clsCustomer>();

            var testItem = new clsCustomer();

            testItem.CustomerId = 36;
            testItem.IsBusinessCustomer = true;
            testItem.CustomerEmail = "testing@this.com";
            testItem.CustomerName = "Andrzej Testowy";
            testItem.RegistrationDate = DateTime.Now;
            testItem.CustomerPassword = "ilovemypassword";

            testList.Add(testItem);

            allCustomers.CustomersList = testList;
            Assert.AreEqual(testList, allCustomers.CustomersList);
        }

        [TestMethod]
        public void ThisCustomerOK()
        {
            var allCustomers = new clsCustomerCollection();

            var testItem = new clsCustomer();

            testItem.CustomerId = 36;
            testItem.IsBusinessCustomer = true;
            testItem.CustomerEmail = "testing@this.com";
            testItem.CustomerName = "Andrzej Testowy";
            testItem.RegistrationDate = DateTime.Now;
            testItem.CustomerPassword = "ilovemypassword";

            allCustomers.ThisCustomer = testItem;
            Assert.AreEqual(testItem, allCustomers.ThisCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            var allCustomers = new clsCustomerCollection();

            var testList = new List<clsCustomer>();

            var testItem = new clsCustomer();

            testItem.CustomerId = 36;
            testItem.IsBusinessCustomer = true;
            testItem.CustomerEmail = "testing@this.com";
            testItem.CustomerName = "Andrzej Testowy";
            testItem.RegistrationDate = DateTime.Now;
            testItem.CustomerPassword = "ilovemypassword";

            testList.Add(testItem);

            allCustomers.CustomersList = testList;

            Assert.AreEqual(testList.Count, allCustomers.Count);

        }


        [TestMethod]
        public void AddMethodOK()
        {
            var allCustomers = new clsCustomerCollection();

            int primaryKey = 0;

            var testItem = new clsCustomer();

            testItem.CustomerId = 36;
            testItem.IsBusinessCustomer = true;
            testItem.CustomerEmail = "testing@this.com";
            testItem.CustomerName = "Andrzej Testowy";
            testItem.RegistrationDate = DateTime.Now;
            testItem.CustomerPassword = "ilovemypassword";

            allCustomers.ThisCustomer = testItem;

            primaryKey = allCustomers.Add();

            testItem.CustomerId = primaryKey;

            allCustomers.ThisCustomer.Find(primaryKey);

            Assert.AreEqual(allCustomers.ThisCustomer, testItem);

        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            var allCustomers = new clsCustomerCollection();

            var testItem = new clsCustomer();

            var primaryKey = 0;

            testItem.CustomerId = 36;
            testItem.IsBusinessCustomer = true;
            testItem.CustomerEmail = "testing@this.com";
            testItem.CustomerName = "Andrzej Testowy";
            testItem.RegistrationDate = DateTime.Now;
            testItem.CustomerPassword = "ilovemypassword";

            allCustomers.ThisCustomer = testItem;

            primaryKey = allCustomers.Add();

            testItem.CustomerId = primaryKey;

            allCustomers.ThisCustomer.Find(primaryKey);

            allCustomers.Delete();

            bool Found = allCustomers.ThisCustomer.Find(primaryKey);

            Assert.IsFalse(Found);

        }
        
        [TestMethod]
        public void UpdateMethodOK()
        {
            var allCustomers = new clsCustomerCollection();

            var testItem = new clsCustomer();

            int primaryKey = 0;


            testItem.CustomerId = 36;
            testItem.IsBusinessCustomer = true;
            testItem.CustomerEmail = "testing@this.com";
            testItem.CustomerName = "Andrzej Testowy";
            testItem.RegistrationDate = DateTime.Now;
            testItem.CustomerPassword = "ilovemypassword";

            allCustomers.ThisCustomer = testItem;

            primaryKey = allCustomers.Add();

            testItem.CustomerId = primaryKey;

            testItem.CustomerId = 36;
            testItem.IsBusinessCustomer = false;
            testItem.CustomerEmail = "ITISOK@KK.com";
            testItem.CustomerName = "Jessica Simpson";
            testItem.RegistrationDate = DateTime.Now;
            testItem.CustomerPassword = "IHateMyPass1232";

            allCustomers.ThisCustomer.Find(primaryKey);

            allCustomers.Update();

            bool Found = allCustomers.ThisCustomer.Find(primaryKey);

            Assert.IsFalse(Found);

        }


        [TestMethod]
        public void ReportByTypeMethodOK()
        {
            var allCustomers = new clsCustomerCollection();
            var filteredCustomers = new clsCustomerCollection();

            filteredCustomers.ReportByType(true);

            Assert.AreNotEqual(filteredCustomers.Count, allCustomers.Count);

        }
    }
}
