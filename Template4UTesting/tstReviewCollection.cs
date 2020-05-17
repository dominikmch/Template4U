using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Template4UClassLib;

namespace Template4UTesting
{
    [TestClass]
    public class tstReviewCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsReviewCollection AllReviews = new clsReviewCollection();

            Assert.IsNotNull(AllReviews);
        }

        [TestMethod]
        public void ReviewListOK()
        {
            clsReviewCollection AllReviews = new clsReviewCollection();

            List<clsReview> TestList = new List<clsReview>();

            clsReview TestItem = new clsReview();

            TestItem.Grade = 4;
            TestItem.Edited = false;
            TestItem.ReviewId = 245;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.UserId = 10;
            TestItem.ReviewComment = "very good";

            TestList.Add(TestItem);

            AllReviews.ReviewList = TestList;
            Assert.AreEqual(AllReviews.ReviewList, TestList);
    }


        [TestMethod]
        public void ThisReviewOK()
        {
            clsReviewCollection AllReviews = new clsReviewCollection();


            clsReview TestItem = new clsReview();

            TestItem.Grade = 4;
            TestItem.Edited = false;
            TestItem.ReviewId = 245;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.UserId = 10;
            TestItem.ReviewComment = "very good";

            AllReviews.ThisReview = TestItem;
            Assert.AreEqual(AllReviews.ThisReview, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsReviewCollection AllReviews = new clsReviewCollection();

            List<clsReview> TestList = new List<clsReview>();

            clsReview TestItem = new clsReview();

            TestItem.Grade = 4;
            TestItem.Edited = false;
            TestItem.ReviewId = 245;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.UserId = 10;
            TestItem.ReviewComment = "very good";

            TestList.Add(TestItem);

            AllReviews.ReviewList = TestList;

            Assert.AreEqual(AllReviews.Count, TestList.Count);

        }


        [TestMethod]
        public void AddMethodOK()
        {
            clsReviewCollection AllReviews = new clsReviewCollection();

            Int32 PrimaryKey=0;

            clsReview TestItem = new clsReview();

            TestItem.Grade = 4;
            TestItem.Edited = false;
            TestItem.ReviewId = 7;
            TestItem.UserId = 10;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ReviewComment = "very good";
            TestItem.ProductId = 69;

            AllReviews.ThisReview = TestItem;

            PrimaryKey = AllReviews.Add();

            TestItem.ReviewId = PrimaryKey;

            AllReviews.ThisReview.find(PrimaryKey);

            Assert.AreEqual(AllReviews.ThisReview, TestItem);

        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            clsReviewCollection AllReviews = new clsReviewCollection();

            clsReview TestItem = new clsReview();

            Int32 PrimaryKey = 0;

            

            TestItem.Grade = 4;
            TestItem.Edited = false;
            TestItem.ReviewId = 7;
            TestItem.UserId = 10;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ReviewComment = "very good";
            TestItem.ProductId = 69;

            AllReviews.ThisReview = TestItem;

            PrimaryKey = AllReviews.Add();

            TestItem.ReviewId = PrimaryKey;

            AllReviews.ThisReview.find(PrimaryKey);

            AllReviews.delete();

            Boolean Found = AllReviews.ThisReview.find(PrimaryKey);

            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsReviewCollection AllReviews = new clsReviewCollection();

            clsReview TestItem = new clsReview();

            Int32 PrimaryKey = 0;



            TestItem.Grade = 4;
            TestItem.Edited = false;
            TestItem.ReviewId = 7;
            TestItem.UserId = 10;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ReviewComment = "very good";
            TestItem.ProductId = 69;

            AllReviews.ThisReview = TestItem;

            PrimaryKey = AllReviews.Add();

            TestItem.ReviewId = PrimaryKey;
            TestItem.Grade = 5;
            TestItem.Edited = true;
            TestItem.ReviewId = 7;
            TestItem.UserId = 101;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ReviewComment = "very nice";
            TestItem.ProductId =9;

            AllReviews.ThisReview.find(PrimaryKey);

            AllReviews.update();

            Boolean Found = AllReviews.ThisReview.find(PrimaryKey);

            Assert.IsFalse(Found);

        }


        [TestMethod]
        public void ReportByProductIdMethodOK()
        {
            clsReviewCollection AllReviews = new clsReviewCollection();
            clsReviewCollection FilteredReviews = new clsReviewCollection();

            FilteredReviews.ReportByProductId(0);

            Assert.AreEqual(AllReviews.Count, FilteredReviews.Count);

        }


        [TestMethod]
        public void ReportByProductIdNotFound()
        {
 
            clsReviewCollection FilteredReviews = new clsReviewCollection();

            FilteredReviews.ReportByProductId(999999999);

            Assert.AreEqual(0, FilteredReviews.Count);

        }

        [TestMethod]
        public void ReportByProductIdDataFound()
        {

            clsReviewCollection FilteredReviews = new clsReviewCollection();


            FilteredReviews.ReportByProductId(11);

            Assert.AreEqual(3, FilteredReviews.Count);

        }




    }
}
