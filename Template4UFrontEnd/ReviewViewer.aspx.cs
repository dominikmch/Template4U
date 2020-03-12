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
            clsReview AnReview = new clsReview();
            AnReview = (clsReview)Session["AnReview"];
            Response.Write(AnReview.ReviewId);

            
        }
    }
}