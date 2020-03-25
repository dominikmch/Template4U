using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Template4UBackend;
using Template4UClassLib;

namespace Template4UTesting
{
    [TestClass]
    public class TstReview
    {

        String tstReviewId = "10";
        String tstGrade = "4";
        String tstReviewComment = "Very good";
        String tstDateAdded = DateTime.Now.Date.ToString();
        String tstUserId = "78";

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
        public void ReviewCommentPropertyOK()
        {
            clsReview Review = new clsReview();

            String TestData = "Perfect Widget, good customer service";
            Review.ReviewComment = TestData;
            Assert.AreEqual(Review.ReviewComment, TestData);
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
        public void UserIdPropertyOK()
        {
            clsReview Review = new clsReview();

            int TestData = 1;
            Review.UserId = TestData;
            Assert.AreEqual(Review.UserId, TestData);
        }
        [TestMethod]
        public void ProductIdPropertyOK()
        {
            clsReview Review = new clsReview();

            int TestData = 1;
            Review.ProductId = TestData;
            Assert.AreEqual(Review.ProductId, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsReview Review = new clsReview();

            Boolean Found = false;
            int ReviewId = 6;
            Found = Review.find(ReviewId);
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestReviewFound()
        {
            clsReview Review = new clsReview();

            Boolean Found = false;
            Boolean OK = true;
            int ReviewId = 6;
            Found = Review.find(ReviewId);
            if (Review.ReviewId != 6)
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
            int ReviewId = 6;
            Found = Review.find(ReviewId);
            if (Review.DateAdded != Convert.ToDateTime("03/04/2020"))
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
            int ReviewId = 6;
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
            int ReviewId = 6;
            Found = Review.find(ReviewId);
            if (Review.ReviewComment != "Very good template")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEditedFound()
        {
            clsReview Review = new clsReview();

            Boolean Found = false;
            Boolean OK = true;
            int ReviewId = 6;
            Found = Review.find(ReviewId);
            if (Review.Edited)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestProductIdFound()
        {
            clsReview Review = new clsReview();

            Boolean Found = false;
            Boolean OK = true;
            int ReviewId = 6;
            Found = Review.find(ReviewId);
            if (Review.ProductId==69)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestUserIdFound()
        {
            clsReview Review = new clsReview();

            Boolean Found = false;
            Boolean OK = true;
            int ReviewId = 6;
            Found = Review.find(ReviewId);
            if (Review.UserId != 10)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsReview AnReview = new clsReview();

            String Error = "";
            Error = AnReview.valid(tstReviewId, tstGrade, tstReviewComment,tstDateAdded, tstUserId);
            Assert.IsTrue(Error == "");
        }
        [TestMethod]
        public void GradeEmpty()
        {
            clsReview AnReview = new clsReview();

            String Error = "";
            string Grade = "";
            Error = AnReview.valid(tstReviewId, Grade, tstReviewComment, tstDateAdded, tstUserId);
            Assert.IsTrue(Error == "");
        }
        [TestMethod]
        public void GradeMinLessZero()
        {
            clsReview AnReview = new clsReview();

            String Error = "";
            string Grade = "-1";
            Error = AnReview.valid(tstReviewId, Grade, tstReviewComment, tstDateAdded, tstUserId);
            Assert.IsTrue(Error == "");
        }

        [TestMethod]
        public void GradeMin()
        {
            clsReview AnReview = new clsReview();

            String Error = "";
            string Grade = "0";
            Error = AnReview.valid(tstReviewId, Grade, tstReviewComment, tstDateAdded, tstUserId);
            Assert.IsTrue(Error == "");
        }

        [TestMethod]
        public void GradeMinPlusOne()
        {
            clsReview AnReview = new clsReview();

            String Error = "";
            string Grade = "1";
            Error = AnReview.valid(tstReviewId, Grade, tstReviewComment, tstDateAdded, tstUserId);
            Assert.IsTrue(Error == "");
        }

        [TestMethod]
        public void GradeMaxLessOne()
        {
            clsReview AnReview = new clsReview();

            String Error = "";
            string Grade = "4";
            Error = AnReview.valid(tstReviewId, Grade, tstReviewComment, tstDateAdded, tstUserId);
            Assert.IsTrue(Error == "");
        }

        [TestMethod]
        public void GradeMedium()
        {
            clsReview AnReview = new clsReview();

            String Error = "";
            string Grade = "3";
            Error = AnReview.valid(tstReviewId, Grade, tstReviewComment, tstDateAdded, tstUserId);
            Assert.IsTrue(Error == "");
        }


        [TestMethod]
        public void GradeMax()
        {
            clsReview AnReview = new clsReview();

            String Error = "";
            string Grade = "5";
            Error = AnReview.valid(tstReviewId, Grade, tstReviewComment, tstDateAdded, tstUserId);
            Assert.IsTrue(Error == "");
        }
        [TestMethod]
        public void GradeMaxPlusOne()
        {
            clsReview AnReview = new clsReview();

            String Error = "";
            string Grade = "6";
            Error = AnReview.valid(tstReviewId, Grade, tstReviewComment, tstDateAdded, tstUserId);
            Assert.IsTrue(Error == "");
        }
        [TestMethod]
        public void GradeNotInt()
        {
            clsReview AnReview = new clsReview();

            String Error = "";
            string Grade = "1b";
            Error = AnReview.valid(tstReviewId, Grade, tstReviewComment, tstDateAdded, tstUserId);
            Assert.IsTrue(Error == "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsReview AnReview = new clsReview();

            String Error = "";
            DateTime Date=DateTime.Now.Date;
            Date = Date.AddYears(-100);
            tstDateAdded = Date.ToString();
            Error = AnReview.valid(tstReviewId, tstGrade, tstReviewComment, tstDateAdded, tstUserId);
            Assert.IsTrue(Error == "");
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsReview AnReview = new clsReview();

            String Error = "";
            DateTime Date = DateTime.Now.Date;
            Date = Date.AddYears(-1);
            tstDateAdded = Date.ToString();
            Error = AnReview.valid(tstReviewId, tstGrade, tstReviewComment, tstDateAdded, tstUserId);
            Assert.IsTrue(Error == "");
        }
        [TestMethod]
        public void DateAddedMin()
        {
            clsReview AnReview = new clsReview();

            String Error = "";
            DateTime Date = DateTime.Now.Date;
            tstDateAdded = Date.ToString();
            Error = AnReview.valid(tstReviewId, tstGrade, tstReviewComment, tstDateAdded, tstUserId);
            Assert.IsTrue(Error == "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsReview AnReview = new clsReview();

            String Error = "";
            DateTime Date = DateTime.Now.Date;
            Date = Date.AddYears(1);
            tstDateAdded = Date.ToString();
            Error = AnReview.valid(tstReviewId, tstGrade, tstReviewComment, tstDateAdded, tstUserId);
            Assert.IsTrue(Error == "");
        }
        [TestMethod]
        public void DateAddedMinExtreme()
        {
            clsReview AnReview = new clsReview();

            String Error = "";
            DateTime Date = DateTime.Now.Date;
            Date = Date.AddYears(100);
            tstDateAdded = Date.ToString();
            Error = AnReview.valid(tstReviewId, tstGrade, tstReviewComment, tstDateAdded, tstUserId);
            Assert.IsTrue(Error == "");
        }
        [TestMethod]
        public void DateAddedWrongFormat()
        {
            clsReview AnReview = new clsReview();

            String Error = "";
            tstDateAdded = "Definately not a date";
            Error = AnReview.valid(tstReviewId, tstGrade, tstReviewComment, tstDateAdded, tstUserId);
            Assert.IsTrue(Error == "");
        }
        [TestMethod]
        public void ReviewCommentEmpty()
        {
            clsReview AnReview = new clsReview();

            String Error = "";
            tstReviewComment = "";
            Error = AnReview.valid(tstReviewId, tstGrade, tstReviewComment, tstDateAdded, tstUserId);
            Assert.IsTrue(Error == "");
        }
        [TestMethod]
        public void ReviewCommentMax()
        {
            clsReview AnReview = new clsReview();

            String Error = "";
            tstReviewComment = "";
            for (int i=0; i < 201; i++)
            {
                tstReviewComment += "Test ";
            }
            
            Error = AnReview.valid(tstReviewId, tstGrade, tstReviewComment, tstDateAdded, tstUserId);
            Assert.IsTrue(Error == "");
        }
        [TestMethod]
        public void ReviewCommentMaxMinusOne()
        {
            clsReview AnReview = new clsReview();

            String Error = "";
            tstReviewComment = "";
            for (int i = 0; i < 200; i++)
            {
                tstReviewComment += "Test ";
            }

            Error = AnReview.valid(tstReviewId, tstGrade, tstReviewComment, tstDateAdded, tstUserId);
            Assert.IsTrue(Error == "");
        }
        [TestMethod]
        public void ReviewCommentMaxPlusOne()
        {
            clsReview AnReview = new clsReview();

            String Error = "";
            tstReviewComment = "";
            for (int i = 0; i < 202; i++)
            {
                tstReviewComment += "Test ";
            }

            Error = AnReview.valid(tstReviewId, tstGrade, tstReviewComment, tstDateAdded, tstUserId);
            Assert.IsTrue(Error == "");
        }



    }
}
