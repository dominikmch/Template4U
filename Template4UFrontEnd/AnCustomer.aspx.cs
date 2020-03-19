using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Template4UClassLib;

namespace Template4UFrontEnd
{
    public partial class AnCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsCustomer anCustomer = new clsCustomer();
            anCustomer = (clsCustomer)Session["anCustomer"];
        }


        protected void ButtonOk_Click(object sender, EventArgs e)
        {
            var customer = new clsCustomer();

            var tstCustomerId = TextCustomerID.Text;
            var tstCustomerEmail = TextCustomerEmail.Text;
            var tstCustomerName = TextCustomerName.Text;
            var tstCustomerPassword = TextCustomerPassword.Text;
            var tstCustomerDateTime = CustomerDateTime.Text;
            var tstCustomerIsBusiness = CustomerBusiness.Text;

            var error = customer.ValidateFields(tstCustomerEmail, tstCustomerName);

            if (string.IsNullOrWhiteSpace(error))
            {
                //customer.CustomerId = int.Parse(tstCustomerId);
                customer.CustomerEmail = tstCustomerEmail;
                customer.CustomerName = tstCustomerName;
                customer.CustomerPassword = tstCustomerPassword;
                //customer.RegistrationDate = Convert.ToDateTime(tstCustomerDateTime);
                //customer.IsBusinessCustomer = bool.Parse(tstCustomerIsBusiness);

                Session["AnCustomer"] = customer;
                Response.Redirect("CustomerViewer.aspx");
            }
            else
            {
                
            }
        }
    }
}