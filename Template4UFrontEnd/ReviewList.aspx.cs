﻿using System;
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

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Session["ReviewId"] = -1;
            Response.Redirect("Review.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Int32 ReviewId;

            if (ListReviews.SelectedIndex != -1)
            {
                ReviewId = Convert.ToInt32(ListReviews.SelectedValue);
                Session["ReviewId"] = ReviewId;
                Response.Redirect("DeleteReview.aspx");
            }
            else
            {
                lblError.Text = "Please select a record to delete from the list";
            }

        }
    }
}