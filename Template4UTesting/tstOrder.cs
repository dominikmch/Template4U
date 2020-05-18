using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Template4UClassLib;

namespace Template4UTesting
{
    [TestClass]
    public class tstOrder
    {
        String tstOrderId = "1";
        String tstOrderlineId = "1";
        String tstPromoCode = "HOLIDAYS";
        String tstDatePlaced = DateTime.Now.Date.ToString();
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
            Order.DatePlaced = TestData;
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
            int OrderId = 1;
            Found = Order.find(OrderId);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";

            Error = AnOrder.validate(tstOrderId, tstOrderlineId, tstPromoCode, tstDatePlaced);
            Assert.IsTrue(Error == "");
        }

        [TestMethod]
        public void TestReviewFound()
        {
            clsOrder Order = new clsOrder();

            Boolean Found = false;
            Boolean OK = true;
            int OrderId = 1;
            Found = Order.find(OrderId);
            if (Order.OrderId != 1)
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
            int OrderId = 1;
            Found = Order.find(OrderId);
            if (Order.PromoCode != "HOLIDAYS")
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
            int OrderId = 5;
            Found = Order.find(OrderId);
            if (Order.OrderlineId != 123)
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
            int OrderId = 1;
            Found = Order.find(OrderId);
            if (Order.IsCompleted)
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
            int OrderId = 5;
            Found = Order.find(OrderId);
            if (Order.DatePlaced != Convert.ToDateTime("16/05/2020"))
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
            String PromoCode = "VE";
            Error = Order.validate(tstOrderId, tstOrderlineId, PromoCode, tstDatePlaced);
            Assert.IsFalse(Error == "");
        }

        [TestMethod]
        public void PromoCodeEmpty()
        {
            clsOrder Order = new clsOrder();
            String Error = "";
            String PromoCode = "";
            Error = Order.validate(tstOrderId, tstOrderlineId, PromoCode, tstDatePlaced);
            Assert.IsFalse(Error == "");
        }

        [TestMethod]
        public void PromoCodeMaxPlusOneLength()
        {
            clsOrder Order = new clsOrder();
            String Error = "";
            String PromoCode = "This is a very long p";
            Error = Order.validate(tstOrderId, tstOrderlineId, PromoCode, tstDatePlaced);
            Assert.IsFalse(Error == "");
        }

        [TestMethod]
        public void PromoCodeMinLength()
        {
            clsOrder Order = new clsOrder();
            String Error = "";
            String PromoCode = "This";
            Error = Order.validate(tstOrderId, tstOrderlineId, PromoCode, tstDatePlaced);
            Assert.IsTrue(Error == "");
        }

        public void PromoCodeMediumLength()
        {
            clsOrder Order = new clsOrder();
            String Error = "";
            String PromoCode = "This is a ";
            Error = Order.validate(tstOrderId, tstOrderlineId, PromoCode, tstDatePlaced);
            Assert.IsTrue(Error == "");
        }

        [TestMethod]
        public void OrderIdIsNotANumber()
        {
            clsOrder Order = new clsOrder();
            String Error = "";
            String OrderId = "Not a number";
            Error = Order.validate(OrderId, tstOrderlineId, tstPromoCode, tstDatePlaced);
            Assert.IsFalse(Error == "");
        }

        [TestMethod]
        public void OrderIdIsEmpty()
        {
            clsOrder Order = new clsOrder();
            String Error = "";
            String OrderId = "";
            Error = Order.validate(OrderId, tstOrderlineId, tstPromoCode, tstDatePlaced);
            Assert.IsFalse(Error == "");
        }

        [TestMethod]
        public void OrderlineIdIsEmpty()
        {
            clsOrder Order = new clsOrder();
            String Error = "";
            String OrderlineId = "";
            Error = Order.validate(tstOrderId, OrderlineId, tstPromoCode, tstDatePlaced);
            Assert.IsFalse(Error == "");
        }

        [TestMethod]
        public void OrderlineIdIsNotANumber()
        {
            clsOrder Order = new clsOrder();
            String Error = "";
            String OrderlineId = "not a number";
            Error = Order.validate(tstOrderId, OrderlineId, tstPromoCode, tstDatePlaced);
            Assert.IsFalse(Error == "");
        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsOrder Order = new clsOrder();

            String Error = "";
            DateTime Date = DateTime.Now.Date;
            Date = Date.AddYears(-100);
            Error = Order.validate(tstOrderId, tstOrderlineId, tstPromoCode, Date.ToString());
            Assert.IsFalse(Error == "");

        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsOrder Order = new clsOrder();

            String Error = "";
            DateTime Date = DateTime.Now.Date;
            Date = Date.AddYears(-1);
            Error = Order.validate(tstOrderId, tstOrderlineId, tstPromoCode, Date.ToString());
            Assert.IsFalse(Error == "");
        }
        [TestMethod]
        public void DateAddedCorrect()
        {
            clsOrder Order = new clsOrder();

            String Error = "";
            DateTime Date = DateTime.Now.Date;
            Error = Order.validate(tstOrderId, tstOrderlineId, tstPromoCode, Date.ToString());
            Assert.IsTrue(Error == "");
        }
        [TestMethod]
        public void DateAddedCorrectPlusOne()
        {
            clsOrder Order = new clsOrder();

            String Error = "";
            DateTime Date = DateTime.Now.Date;
            Date = Date.AddYears(1);
            Error = Order.validate(tstOrderId, tstOrderlineId, tstPromoCode, Date.ToString());
            Assert.IsFalse(Error == "");
        }
        [TestMethod]
        public void DateAddedCorrectMax()
        {
            clsOrder Order = new clsOrder();

            String Error = "";
            DateTime Date = DateTime.Now.Date;
            Date = Date.AddYears(100);
            Error = Order.validate(tstOrderId, tstOrderlineId, tstPromoCode, Date.ToString());
            Assert.IsFalse(Error == "");
        }
        public void DateAddedWrongFormat()
        {
            clsOrder Order = new clsOrder();

            String Error = "";
            String Date = "not a date";
            Error = Order.validate(tstOrderId, tstOrderlineId, tstPromoCode, Date.ToString());
            Assert.IsFalse(Error == "");
        }

    }

}
