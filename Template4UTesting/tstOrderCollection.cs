using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Template4UClassLib;

namespace Template4UTesting
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            List<clsOrder> TestList = new List<clsOrder>();

            clsOrder TestItem = new clsOrder();

            TestItem.PromoCode = "VALENTINES";
            TestItem.IsCompleted = false;
            TestItem.OrderId= 123;
            TestItem.DatePlaced = DateTime.Now.Date;
            TestItem.OrderlineId = 100;
            TestList.Add(TestItem);

            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }


        [TestMethod]
        public void ThisOrderOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();


            clsOrder TestItem = new clsOrder();

            TestItem.PromoCode = "VALENTINES";
            TestItem.IsCompleted = false;
            TestItem.OrderId = 123;
            TestItem.DatePlaced = DateTime.Now.Date;
            TestItem.OrderlineId = 100;

            AllOrders.ThisOrder = TestItem;
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();


            List<clsOrder> TestList = new List<clsOrder>();

            clsOrder TestItem = new clsOrder();

            TestItem.PromoCode = "VALENTINES";
            TestItem.IsCompleted = false;
            TestItem.OrderId = 123;
            TestItem.DatePlaced = DateTime.Now.Date;
            TestItem.OrderlineId = 100;


            TestList.Add(TestItem);

            AllOrders.OrderList = TestList;

            Assert.AreEqual(AllOrders.Count, TestList.Count);

        }

    }
}
