using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Template4UClassLib;

namespace Template4UTesting
{
    [TestClass]
    public class tstProductListCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsProductListCollection Products = new clsProductListCollection();

            Assert.IsNotNull(Products);
        }

        [TestMethod]
        public void ProductListsOK()
        {
            clsProductListCollection Products = new clsProductListCollection();

            List<clsProductList> TestList = new List<clsProductList>();

            clsProductList TestItem = new clsProductList();

            TestItem.ProductId = 2;
            TestItem.ProductName = "GamingTemplate";
            TestItem.ProductDescription = "This is best template for gaming websistes.";
            TestItem.Price = 129;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.isAvailable = true;

            TestList.Add(TestItem);

            Products.ProductLists = TestList;
            Assert.AreEqual(Products.ProductLists, TestList);
        }


        [TestMethod]
        public void ThisProductListOK()
        {
            clsProductListCollection Products = new clsProductListCollection();


            clsProductList TestItem = new clsProductList();

            TestItem.ProductId = 2;
            TestItem.ProductName = "GamingTemplate";
            TestItem.ProductDescription = "This is best template for gaming websistes.";
            TestItem.Price = 129;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.isAvailable = true;

            Products.ThisProductList = TestItem;
            Assert.AreEqual(Products.ThisProductList, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsProductListCollection Products = new clsProductListCollection();

            List<clsProductList> TestList = new List<clsProductList>();

            clsProductList TestItem = new clsProductList();

            TestItem.ProductId = 2;
            TestItem.ProductName = "GamingTemplate";
            TestItem.ProductDescription = "This is best template for gaming websistes.";
            TestItem.Price = 129;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.isAvailable = true;

            TestList.Add(TestItem);

            Products.ProductLists = TestList;

            Assert.AreEqual(Products.Count, TestList.Count);

        }


        [TestMethod]
        public void AddMethodOK()
        {
            clsProductListCollection Products = new clsProductListCollection();

            Int32 PrimaryKey = 0;

            clsProductList TestItem = new clsProductList();

            TestItem.ProductId = 2;
            TestItem.ProductName = "GamingTemplate";
            TestItem.ProductDescription = "This is best template for gaming websistes.";
            TestItem.Price = 129;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.isAvailable = true;

            Products.ThisProductList = TestItem;

            PrimaryKey = Products.Add();

            TestItem.ProductId = PrimaryKey;

            Products.ThisProductList.Find(PrimaryKey);

            Assert.AreEqual(Products.ThisProductList, TestItem);

        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            clsProductListCollection Products = new clsProductListCollection();

            clsProductList TestItem = new clsProductList();

            Int32 PrimaryKey = 0;



            TestItem.ProductId = 2;
            TestItem.ProductName = "GamingTemplate";
            TestItem.ProductDescription = "This is best template for gaming websistes.";
            TestItem.Price = 129;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.isAvailable = true;

            Products.ThisProductList = TestItem;

            PrimaryKey = Products.Add();

            TestItem.ProductId = PrimaryKey;

            Products.ThisProductList.Find(PrimaryKey);

            Products.Delete();

            Boolean Found = Products.ThisProductList.Find(PrimaryKey);

            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsProductListCollection Products = new clsProductListCollection();

            clsProductList TestItem = new clsProductList();

            Int32 PrimaryKey = 0;

            TestItem.ProductId = 6;
            TestItem.ProductName = "GamingTemplate";
            TestItem.ProductDescription = "This is best template for gaming websistes.";
            TestItem.Price = 129;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.isAvailable = false;

            Products.ThisProductList = TestItem;

            PrimaryKey = Products.Add();

            TestItem.ProductId = PrimaryKey;
            TestItem.ProductId = 6;
            TestItem.ProductName = "GamingTemplate2";
            TestItem.ProductDescription = "This is another best template for gaming websistes.";
            TestItem.Price = 130;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.isAvailable = true;

            Products.ThisProductList.Find(PrimaryKey);

            Products.Update();

            Boolean Found = Products.ThisProductList.Find(PrimaryKey);

            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void FilterByPriceMethodOK()
        {
            clsProductListCollection Products = new clsProductListCollection();
            clsProductListCollection FilteredPrice = new clsProductListCollection();
            
            FilteredPrice.FilterByPrice(0);

            Assert.AreEqual(Products.Count, FilteredPrice.Count);

        }

        [TestMethod]
        public void FilterByPriceNotFound()
        {

            clsProductListCollection FilteredPrice = new clsProductListCollection();

            FilteredPrice.FilterByPrice(9999999);

            Assert.AreEqual(0, FilteredPrice.Count);

        }

        [TestMethod]
        public void FilterByPriceDataFound()
        {

            clsProductListCollection FilteredPrice = new clsProductListCollection();

            FilteredPrice.FilterByPrice(11);

            Assert.AreEqual(0, FilteredPrice.Count);

        }
    }
}
