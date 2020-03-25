using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Template4UFrontEnd
{
    public partial class ReviewList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                DisplayReviews();
            }

        }
        void DisplayReviews()
        {
            Template4UClassLib.clsReviewCollection Reviews = new Template4UClassLib.clsReviewCollection();
            ListReviews.DataSource = Reviews.ReviewList;
            ListReviews.DataValueField = "ReviewId";
            ListReviews.DataTextField = "ReviewComment";
            ListReviews.DataBind();

        }
    }
}