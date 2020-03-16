using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Template4UClassLib;

namespace Template4UTesting
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrder Order = new clsOrder();
            Assert.IsNotNull(Order);
        }
        [TestMethod]
        public void DatePlacedPropertyOK()
        {
            clsOrder Order = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            Order.DatePlaced =  TestData;
            Assert.AreEqual(Order.DatePlaced, TestData);
        }
        [TestMethod]
        public void OrderIdPropertyOK()
        {
            clsOrder Order = new clsOrder();

            int TestData = 1;
            Order.OrderId = TestData;
            Assert.AreEqual(Order.OrderId, TestData);
        }
        [TestMethod]
        public void PromoCodePropertyOK()
        {
            clsOrder Order = new clsOrder();
            String TestData = "VALENTINES";
            Order.PromoCode = TestData;
            Assert.AreEqual(Order.PromoCode, TestData);
        }
        public void IsCompletedPropertyOK()
        {
            clsOrder Order = new clsOrder();
            Boolean TestData = true;
            Order.IsCompleted = TestData;
            Assert.AreEqual(Order.IsCompleted, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder Order = new clsOrder();

            Boolean Found = false;
            Found = Order.findAll();
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder Order = new clsOrder();

            Boolean Found = false;
            int OrderId = 2;
            Found = Order.find(OrderId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestReviewFound()
        {
            clsOrder Order = new clsOrder();

            Boolean Found = false;
            Boolean OK = true;
            int OrderId = 2;
            Found = Order.find(OrderId);
            if (Order.OrderId != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPromoCodeFound()
        {
            clsOrder Order = new clsOrder();

            Boolean Found = false;
            Boolean OK = true;
            int OrderId = 2;
            Found = Order.find(OrderId);
            if (Order.PromoCode != "VALENTINES")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderlineIdFound()
        {
            clsOrder Order = new clsOrder();

            Boolean Found = false;
            Boolean OK = true;
            int OrderId = 2;
            Found = Order.find(OrderId);
            if (Order.OrderlineId != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestIsCompletedFound()
        {
            clsOrder Order = new clsOrder();

            Boolean Found = false;
            Boolean OK = true;
            int OrderId = 2;
            Found = Order.find(OrderId);
            if (!Order.IsCompleted)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDatePlacedFound()
        {

            clsOrder Order = new clsOrder();

            Boolean Found = false;
            Boolean OK = true;
            int OrderId = 2;
            Found = Order.find(OrderId);
            if (Order.DatePlaced != Convert.ToDateTime("10/03/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void PromoCodeTooShort()
        {
            clsOrder Order = new clsOrder();

            String Error = "";
            String tstPromoCode = "VALENTINES";
            Error = Order.validate(tstPromoCode);
            Assert.IsTrue(Error == "");
        }


    }

}
