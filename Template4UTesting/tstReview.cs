using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Template4UBackend;
using Template4UClassLib;

namespace Template4UTesting
{
    [TestClass]
    public class tstReview
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsReview Review = new clsReview();
            Assert.IsNotNull(Review);
        }

    [TestMethod]
    public void EditedPropertyOK()
        {
            clsReview Review = new clsReview();
            Boolean TestData = true;
            Review.Edited = TestData;
            Assert.AreEqual(Review.Edited, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsReview Review = new clsReview();

            DateTime TestData = DateTime.Now.Date;
            Review.DateAdded = TestData;
            Assert.AreEqual(Review.DateAdded, TestData);
        }

        [TestMethod]
        public void GradePropertyOK()
        {
            clsReview Review = new clsReview();

            int TestData = 4;
            Review.Grade = TestData;
            Assert.AreEqual(Review.Grade, TestData);
        }

        [TestMethod]
        public void DescriptionPropertyOK()
        {
            clsReview Review = new clsReview();

            String TestData = "Perfect Widget, good customer service";
            Review.Description = TestData;
            Assert.AreEqual(Review.Description, TestData);
        }

        [TestMethod]
        public void ReviewIdPropertyOK()
        {
            clsReview Review = new clsReview();

            int TestData = 1;
            Review.ReviewId = TestData;
            Assert.AreEqual(Review.ReviewId, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsReview Review = new clsReview();

            Boolean Found = false;
            int ReviewId = 1;
            Found = Review.find(ReviewId);
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestReviewFound()
        {
            clsReview Review = new clsReview();

            Boolean Found = false;
            Boolean OK = true;
            int ReviewId = 21;
            Found = Review.find(ReviewId);
            if(Review.ReviewId != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsReview Review = new clsReview();

            Boolean Found = false;
            Boolean OK = true;
            int ReviewId = 21;
            Found = Review.find(ReviewId);
            if (Review.DateAdded != Convert.ToDateTime("04/03/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestGradeFound()
        {
            clsReview Review = new clsReview();

            Boolean Found = false;
            Boolean OK = true;
            int ReviewId = 21;
            Found = Review.find(ReviewId);
            if (Review.Grade != 4)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDescriptionFound()
        {
            clsReview Review = new clsReview();

            Boolean Found = false;
            Boolean OK = true;
            int ReviewId = 21;
            Found = Review.find(ReviewId);
            if (Review.Description != "Very goood template")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        public void TestEditedFound()
        {
            clsReview Review = new clsReview();

            Boolean Found = false;
            Boolean OK = true;
            int ReviewId = 21;
            Found = Review.find(ReviewId);
            if (!Review.Edited)
            {
                OK = false;
            }
            Assert.IsTrue(OK);






        }


    }
