using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Template4UClassLib;

namespace Template4UFrontEnd
{
    public partial class Review : System.Web.UI.Page
    { Int32 ReviewId;
        protected void Page_Load(object sender, EventArgs e)
        {
            ReviewId = Convert.ToInt32(Session["ReviewId"]);
            if (!IsPostBack)
            {
                if (ReviewId != -1)
                {
                    DisplayReview();
                }
            }


        }

        void DisplayReview()
        {
            Template4UClassLib.clsReviewCollection Reviews = new Template4UClassLib.clsReviewCollection();
            Reviews.ThisReview.find(ReviewId);
            TextReviewId.Text = Reviews.ThisReview.ReviewId.ToString();
            TextGrade.Text = Reviews.ThisReview.Grade.ToString();
            TextReviewComment.Text = Reviews.ThisReview.ReviewComment;
            TextDateAdded.Text = Reviews.ThisReview.DateAdded.ToString();
            TextUserId.Text = Reviews.ThisReview.UserId.ToString();
            TextProductId.Text = Reviews.ThisReview.ProductId.ToString();

        }
        protected void TextReviewId_TextChanged(object sender, EventArgs e)
        {

        }
        protected void TextGrade_TextChanged(object sender, EventArgs e)
        {

        }
        protected void TextReviewComment_TextChanged(object sender, EventArgs e)
        {

        }
        protected void TextDateAdded_TextChanged(object sender, EventArgs e)
        {

        }
        protected void TextUserId_TextChanged(object sender, EventArgs e)
        {

        }
        protected void Edited_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonOK_Click(object sender, EventArgs e)
        {
          
            clsReview AnReview = new clsReview();
  
            string Grade = TextGrade.Text;
            string ReviewComment = TextReviewComment.Text;
            string DateAdded = TextDateAdded.Text;
            string UserId = TextUserId.Text;
            string ProductId = TextProductId.Text;
            string Error = "";

            Error = AnReview.valid(Grade, ReviewComment, DateAdded, UserId, ProductId);
            if (Error == "")
            {
                AnReview.ReviewId = ReviewId;
                AnReview.Grade = int.Parse(Grade);
                AnReview.ReviewComment = ReviewComment;
                AnReview.DateAdded = Convert.ToDateTime(DateAdded);
                AnReview.UserId = int.Parse(UserId);
                AnReview.Edited = false;
                AnReview.ProductId = int.Parse(ProductId);

                clsReviewCollection ReviewList = new clsReviewCollection();

                if (ReviewId == -1)
                {
                    ReviewList.ThisReview = AnReview;
                    ReviewList.Add();
                }
                else
                {
                    ReviewList.ThisReview.find(ReviewId);
                    ReviewList.ThisReview = AnReview;
                    ReviewList.update();
                }

                Response.Redirect("ReviewList.aspx");
            }
            else
            {
                ErrorLabel.Text = Error;
            }


        }

        protected void ButtonFind_Click(object sender, EventArgs e)
        {
        clsReview AnReview = new clsReview();
            Int32 ReviewId;
            Boolean Found = false;
            ReviewId = Convert.ToInt32(TextReviewId.Text);
            Found = AnReview.find(ReviewId);
            if (Found)
            {
                TextGrade.Text = AnReview.Grade.ToString();
                TextReviewComment.Text = AnReview.ReviewComment;
                TextDateAdded.Text = AnReview.DateAdded.ToString();
                TextUserId.Text = AnReview.UserId.ToString();
            }
            else { }

        }


    }
}