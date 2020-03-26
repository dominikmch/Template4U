using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Template4UClassLib;

namespace Template4UFrontEnd
{
    public partial class Delete : System.Web.UI.Page
    {
        Int32 ReviewId;

        protected void Page_Load(object sender, EventArgs e)
        {
            ReviewId = Convert.ToInt32(Session["ReviewId"]);

        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            clsReviewCollection ReviewList = new clsReviewCollection();

            ReviewList.ThisReview.find(ReviewId);
            ReviewList.delete();
            Response.Redirect("ReviewList.aspx");

        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReviewList.aspx");
        }
    }
}