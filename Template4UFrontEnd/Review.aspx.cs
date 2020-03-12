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
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
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
            AnReview.ReviewComment =TextReviewComment.Text;
            Session["AnReview"] = AnReview;
            Response.Redirect("ReviewViewer.aspx");


        }

        protected void CheckBox1_CheckedChanged1(object sender, EventArgs e)
        {
        
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