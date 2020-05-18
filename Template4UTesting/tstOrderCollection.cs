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
        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            Int32 PrimaryKey = 0;

            clsOrder TestItem = new clsOrder();

            TestItem.OrderId = 222;
            TestItem.OrderlineId = 20;
            TestItem.PromoCode = "MONDAY";
            TestItem.DatePlaced = DateTime.Now.Date;
            TestItem.IsCompleted = false;
            AllOrders.ThisOrder = TestItem;

            PrimaryKey = AllOrders.Add();

            TestItem.OrderId = PrimaryKey;

            AllOrders.ThisOrder.find(PrimaryKey);

            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

        }

        [TestMethod]
        public void DeletMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            Int32 PrimaryKey = 0;

            clsOrder TestItem = new clsOrder();

            TestItem.OrderId = 222;
            TestItem.OrderlineId = 20;
            TestItem.PromoCode = "MONDAY";
            TestItem.DatePlaced = DateTime.Now.Date;
            TestItem.IsCompleted = false;
            AllOrders.ThisOrder = TestItem;

            PrimaryKey = AllOrders.Add();

            TestItem.OrderId = PrimaryKey;

            AllOrders.ThisOrder.find(PrimaryKey);
            AllOrders.Delete();

            Boolean Found = AllOrders.ThisOrder.find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Int32 PrimaryKey = 0;

            clsOrder TestItem = new clsOrder();

            TestItem.OrderId = 222;
            TestItem.OrderlineId = 20;
            TestItem.PromoCode = "MONDAY";
            TestItem.DatePlaced = DateTime.Now.Date;
            TestItem.IsCompleted = false;
            AllOrders.ThisOrder = TestItem;

            PrimaryKey = AllOrders.Add();

            TestItem.OrderId = PrimaryKey;

            TestItem.OrderId = 222;
            TestItem.OrderlineId = 96;
            TestItem.PromoCode = "WEDNESDAY";
            TestItem.DatePlaced = DateTime.Now.Date;
            TestItem.IsCompleted = true;

            AllOrders.ThisOrder.find(PrimaryKey);
            AllOrders.Update();

            Boolean Found = AllOrders.ThisOrder.find(PrimaryKey);

            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByIsCompletedMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();

            FilteredOrders.ReportByIsCompleted(true);

            Assert.AreNotEqual(FilteredOrders.Count, AllOrders.Count);
        }

    }
}
