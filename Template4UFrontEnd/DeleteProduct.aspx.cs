using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Template4UClassLib;

namespace Template4UFrontEnd
{
    public partial class DeleteProduct : System.Web.UI.Page
    {

        Int32 ProductId;

        protected void Page_Load(object sender, EventArgs e)

        {
            ProductId = Convert.ToInt32(Session["ProductId"]);
        }

        protected void btnYes_Click(object sender, EventArgs e)

        {
            clsProductListCollection AnProductList = new clsProductListCollection();

            AnProductList.ThisProductList.Find(ProductId);
            AnProductList.Delete();
            Response.Redirect("ProductList.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)

        {
            Response.Redirect("ProductList.aspx");
        }
    }
}