using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Template4UClassLib;

namespace Template4UFrontEnd
{
    public partial class CustomerViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var anCustomer = Convert.ToInt32(Session["CustomerId"]);
            if (!IsPostBack)
            {
                if (anCustomer != -1)
                {
                    ShowCustomers(anCustomer);
                }
            }
        }

        void ShowCustomers(int cId)
        {
            var customers = new clsCustomerCollection();

            customers.ThisCustomer.Find(cId);

            customerId.Text = "Customer ID: " + customers.ThisCustomer.CustomerId;
            customerName.Text = "Customer name: " + customers.ThisCustomer.CustomerName;
            customerEmail.Text = "Customer email: " + customers.ThisCustomer.CustomerEmail;
            customerRegistrationDate.Text = "Customer registration date: " + customers.ThisCustomer.RegistrationDate;
            customerPassword.Text = "Customer Password: " + customers.ThisCustomer.CustomerPassword;
            customerIsBusiness.Text = "Customer is business client: " + customers.ThisCustomer.IsBusinessCustomer;
        }
    }
}