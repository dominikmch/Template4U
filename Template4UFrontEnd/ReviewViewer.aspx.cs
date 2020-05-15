using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Template4UClassLib;

namespace Template4UFrontEnd
{
    public partial class ReviewViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Int32 ReviewId;
            ReviewId = Convert.ToInt32(Session["ReviewId"]);
            if (!IsPostBack)
            {
                if (ReviewId != -1)
                {
                    DisplayReview();
                }
            }
            void DisplayReview()
            {
                Template4UClassLib.clsReviewCollection Reviews = new Template4UClassLib.clsReviewCollection();
                Reviews.ThisReview.find(ReviewId);
                productId.Text ="Product Id : "+ Reviews.ThisReview.ProductId.ToString();
                grade.Text = "Grade : "+Reviews.ThisReview.Grade.ToString();
                description.Text = "Comment : "+Reviews.ThisReview.ReviewComment;
                date.Text = "Date Added: "+Reviews.ThisReview.DateAdded.ToString();
                userId.Text = "User Id : "+ Reviews.ThisReview.UserId.ToString();
            }


        }

        protected void btnNo_Click(object sender, EventArgs e)
        {

        }
    }
}