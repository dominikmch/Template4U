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
    }

}
