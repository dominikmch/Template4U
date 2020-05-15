using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Template4UClassLib;

namespace Template4UTesting
{
    [TestClass]
    public class tstProductList
    {

        string tstProductId = "1";
        string tstProductName = "GamingTemplate";
        string tstProductDescription = "This is an example description of GamingTemplate";
        string tstPrice = "100";
        string tstDateAdded = DateTime.Now.Date.ToString();
        string tstisAvailable = "True";

        [TestMethod]
        public void InstanceOK()
        {
            clsProductList Product = new clsProductList();
            Assert.IsNotNull(Product);
        }

        [TestMethod]

        public void isAvailablePropertyOK()

        {
            clsProductList Product = new clsProductList();
            Boolean TestData = true;
            Product.isAvailable = TestData;
            Assert.AreEqual(Product.isAvailable, TestData);

        }

        [TestMethod]

        public void DateAddedPropertyOK()

        {
            clsProductList Product = new clsProductList();
            DateTime TestData = DateTime.Now.Date;
            Product.DateAdded = TestData;
            Assert.AreEqual(Product.DateAdded, TestData);
        }

        [TestMethod]

        public void PricePropertyOK()
        {
            clsProductList Product = new clsProductList();
            double TestData = 100.00;
            Product.Price = TestData;
            Assert.AreEqual(Product.Price, TestData);

        }
        [TestMethod]

        public void ProductNamePropertyOK()

        {
            clsProductList Product = new clsProductList();
            String TestData = "GamingTemplate";
            Product.ProductName = TestData;
            Assert.AreEqual(Product.ProductName, TestData);
        }

        [TestMethod]

        public void ProductIdPropertyOK()

        {
            clsProductList Product = new clsProductList();
            int TestData = 1;
            Product.ProductId = TestData;
            Assert.AreEqual(Product.ProductId, TestData);
        }

        [TestMethod]
        public void ProductDescriptionPropertyOK()
        {
            clsProductList Product = new clsProductList();
            String TestData = "This template is dedicated for websites related with various Gaming field. Enjoy it";
            Product.ProductDescription = TestData;
            Assert.AreEqual(Product.ProductDescription, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsProductList Product = new clsProductList();
            Boolean Found = false;
            int ProductId = 1;
            Found = Product.Find(ProductId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestProductIdFound()
        {
            clsProductList Product = new clsProductList();
            Boolean Found = false;
            Boolean OK = true;
            int ProductId = 6;
            Found = Product.Find(ProductId);

            if (Product.ProductId != 6)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsProductList Product = new clsProductList();

            Boolean Found = false;
            Boolean OK = true;
            int ProductId = 6;
            Found = Product.Find(ProductId);
            if (Product.DateAdded != Convert.ToDateTime("26/04/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductNameFound()
        {
            clsProductList Review = new clsProductList();

            Boolean Found = false;
            Boolean OK = true;
            int ProductId = 6;
            Found = Review.Find(ProductId);
            if (Review.ProductName != "GamingTemplate")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductDescriptionFound()
        {
            clsProductList Review = new clsProductList();

            Boolean Found = false;
            Boolean OK = true;
            int ProductId = 6;
            Found = Review.Find(ProductId);
            if (Review.ProductDescription != "This is a example of template which could be used to various Gaming websistes...")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestisAvailableFound()
        {
            clsProductList Product = new clsProductList();

            Boolean Found = false;
            Boolean OK = true;
            int ProductId = 6;
            Found = Product.Find(ProductId);
            if (Product.isAvailable)
            {
                OK = true;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            clsProductList Product = new clsProductList();

            Boolean Found = false;
            Boolean OK = true;
            int ProductId = 6;
            Found = Product.Find(ProductId);
            if (Product.Price != 100)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsProductList Product = new clsProductList();

            String Error = "";
            Error = Product.Valid(tstProductId, tstProductName, tstProductDescription, tstPrice, tstDateAdded, tstisAvailable);
            Assert.IsTrue(Error == "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            clsProductList Product = new clsProductList();
            String Error = "";
            string tstPrice = "";
            Error = Product.Valid(tstProductId, tstProductName, tstProductDescription, tstPrice, tstDateAdded, tstisAvailable);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinLessZero()
        {
            clsProductList Product = new clsProductList();

            String Error = "";
            string tstPrice = "-1";
            Error = Product.Valid(tstProductId, tstProductName, tstProductDescription, tstPrice, tstDateAdded, tstisAvailable);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            clsProductList Product = new clsProductList();

            String Error = "";
            string tstPrice = "0";
            Error = Product.Valid(tstProductId, tstProductName, tstProductDescription, tstPrice, tstDateAdded, tstisAvailable);
            Assert.IsTrue(Error == "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            clsProductList Product = new clsProductList();

            String Error = "";
            string tstPrice = "1";
            Error = Product.Valid(tstProductId, tstProductName, tstProductDescription, tstPrice, tstDateAdded, tstisAvailable);
            Assert.IsTrue(Error == "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            clsProductList Product = new clsProductList();

            String Error = "";
            string tstPrice = "499";
            Error = Product.Valid(tstProductId, tstProductName, tstProductDescription, tstPrice, tstDateAdded, tstisAvailable);
            Assert.IsTrue(Error == "");
        }

        [TestMethod]
        public void PriceMedium()
        {
            clsProductList Product = new clsProductList();

            String Error = "";
            string tstPrice = "250";
            Error = Product.Valid(tstProductId, tstProductName, tstProductDescription, tstPrice, tstDateAdded, tstisAvailable);
            Assert.IsTrue(Error == "");
        }


        [TestMethod]
        public void PriceMax()
        {
            clsProductList Product = new clsProductList();

            String Error = "";
            string tstPrice = "500";
            Error = Product.Valid(tstProductId, tstProductName, tstProductDescription, tstPrice, tstDateAdded, tstisAvailable);
            Assert.IsTrue(Error == "");
        }
        [TestMethod]
        public void PriceMaxPlusOne()
        {
            clsProductList Product = new clsProductList();

            String Error = "";
            string tstPrice = "501";
            Error = Product.Valid(tstProductId, tstProductName, tstProductDescription, tstPrice, tstDateAdded, tstisAvailable);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceNotInt()
        {
            clsProductList Product = new clsProductList();

            String Error = "";
            string tstPrice = "20b";
            Error = Product.Valid(tstProductId, tstProductName, tstProductDescription, tstPrice, tstDateAdded, tstisAvailable);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsProductList Product = new clsProductList();

            String Error = "";
            DateTime Date = DateTime.Now.Date;
            Date = Date.AddYears(-100);
            tstDateAdded = Date.ToString();
            Error = Product.Valid(tstProductId, tstProductName, tstProductDescription, tstPrice, tstDateAdded, tstisAvailable);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsProductList Product = new clsProductList();

            String Error = "";
            DateTime Date = DateTime.Now.Date;
            Date = Date.AddYears(-1);
            tstDateAdded = Date.ToString();
            Error = Product.Valid(tstProductId, tstProductName, tstProductDescription, tstPrice, tstDateAdded, tstisAvailable);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedCorrect()
        {
            clsProductList Product = new clsProductList();

            String Error = "";
            DateTime Date = DateTime.Now.Date;
            tstDateAdded = Date.ToString();
            Error = Product.Valid(tstProductId, tstProductName, tstProductDescription, tstPrice, tstDateAdded, tstisAvailable);
            Assert.IsTrue(Error == "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsProductList Product = new clsProductList();

            String Error = "";
            DateTime Date = DateTime.Now.Date;
            Date = Date.AddYears(1);
            tstDateAdded = Date.ToString();
            Error = Product.Valid(tstProductId, tstProductName, tstProductDescription, tstPrice, tstDateAdded, tstisAvailable);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinExtreme()
        {
            clsProductList Product = new clsProductList();

            String Error = "";
            DateTime Date = DateTime.Now.Date;
            Date = Date.AddYears(100);
            tstDateAdded = Date.ToString();
            Error = Product.Valid(tstProductId, tstProductName, tstProductDescription, tstPrice, tstDateAdded, tstisAvailable);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedWrongFormat()
        {
            clsProductList Product = new clsProductList();

            String Error = "";
            tstDateAdded = "Definitely not a date";
            Error = Product.Valid(tstProductId, tstProductName, tstProductDescription, tstPrice, tstDateAdded, tstisAvailable);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductDescriptionEmpty()
        {
            clsProductList Product = new clsProductList();

            String Error = "";
            tstProductDescription = "";
            Error = Product.Valid(tstProductId, tstProductName, tstProductDescription, tstPrice, tstDateAdded, tstisAvailable);
            Assert.IsTrue(Error == "");
        }
        [TestMethod]
        public void ProductDescriptionMax()
        {
            clsProductList Product = new clsProductList();

            String Error = "";
            tstProductDescription = "";

            tstProductDescription += "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test " +
                "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test" +
                "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test" +
                "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test" +
                "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test" +
                "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test" +
                "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test" +
                "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test" +
                "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test" +
                "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test";


            Error = Product.Valid(tstProductId, tstProductName, tstProductDescription, tstPrice, tstDateAdded, tstisAvailable);
            Assert.IsTrue(Error == "");
        }

        [TestMethod]
        public void ProductDescriptionMaxMinusOne()
        {
            clsProductList Product = new clsProductList();

            String Error = "";
            tstProductDescription = "";
            tstProductDescription += "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test " +
                      "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test" +
                      "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test" +
                      "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test" +
                      "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test" +
                      "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test" +
                      "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test" +
                      "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test" +
                      "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test" +
                      "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test";


            Error = Product.Valid(tstProductId, tstProductName, tstProductDescription, tstPrice, tstDateAdded, tstisAvailable);
            Assert.IsTrue(Error == "");
        }
        [TestMethod]
        public void ProductDescriptionMaxPlusOne()
        {
            clsProductList Product = new clsProductList();

            String Error = "";
            tstProductDescription = "";
            for (int i = 0; i < 202; i++)
            {
                tstProductDescription += "Test ";
            }

            Error = Product.Valid(tstProductId, tstProductName, tstProductDescription, tstPrice, tstDateAdded, tstisAvailable);
            Assert.AreNotEqual(Error, "");

        }
    }
}
