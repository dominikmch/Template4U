using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Template4UClassLib;

namespace Template4UFrontEnd
{
    public partial class DeleteCustomer : System.Web.UI.Page
    {
        private int _customerId;
        protected void Page_Load(object sender, EventArgs e)
        {
            _customerId = Convert.ToInt32(Session["CustomerId"]);
        }

        protected void btnYes_OnClick(object sender, EventArgs e)
        {
            var customerCollection = new clsCustomerCollection();

            customerCollection.ThisCustomer.Find(_customerId);
            customerCollection.Delete();
            Response.Redirect("CustomerList.aspx");

        }

        protected void btnNo_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("CustomerList.aspx");
        }
    }
}