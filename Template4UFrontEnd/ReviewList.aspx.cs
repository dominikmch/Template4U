using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Template4UClassLib;

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

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Int32 ReviewId;
            if (ListReviews.SelectedIndex != -1)
            {
                ReviewId = Convert.ToInt32(ListReviews.SelectedValue);
                Session["ReviewId"] = ReviewId;
                Response.Redirect("Review.aspx");
            }
            else
            {
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            clsReviewCollection Reviews = new clsReviewCollection();

                Reviews.ReportByProductId(int.Parse(txtFilter.Text));
                ListReviews.DataSource = Reviews.ReviewList;
                ListReviews.DataValueField = "ReviewId";
                ListReviews.DataTextField = "ReviewComment";
                ListReviews.DataBind();
            txtFilter.Text = int.Parse(txtFilter.Text).ToString(); ;


        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            clsReviewCollection Reviews = new clsReviewCollection();
            Reviews.ReportByProductId(0);
            txtFilter.Text = "0";

            ListReviews.DataSource = Reviews.ReviewList;
            ListReviews.DataValueField = "ReviewId";
            ListReviews.DataTextField = ("ReviewComment");
            ListReviews.DataBind();
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Int32 ReviewId;

            if (ListReviews.SelectedIndex != -1)
            {
                ReviewId = Convert.ToInt32(ListReviews.SelectedValue);
                Session["ReviewId"] = ReviewId;
                Response.Redirect("ReviewViewer.aspx");
            }
            else
            {
                lblError.Text = "Please select a record to view from the list";
            }
        }
    }
}