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
        private int _customerId;

        protected void Page_Load(object sender, EventArgs e)
        {
            _customerId = Convert.ToInt32(Session["CustomerId"]);

            if (!IsPostBack)
            {
                if (_customerId != -1)
                {
                    ShowCustomer();
                }
            }
        }


        protected void ButtonOk_Click(object sender, EventArgs e)
        {
            Submit();
        }

        private void ShowCustomer()
        {
            var customerCollection = new clsCustomerCollection();

            customerCollection.ThisCustomer.Find(_customerId);

            TextCustomerName.Text = customerCollection.ThisCustomer.CustomerName;
            TextCustomerEmail.Text = customerCollection.ThisCustomer.CustomerEmail;
            TextCustomerPassword.Text = customerCollection.ThisCustomer.CustomerPassword;
            CustomerBusiness.Checked = customerCollection.ThisCustomer.IsBusinessCustomer;
            CustomerDateTime.Text = customerCollection.ThisCustomer.RegistrationDate.ToShortDateString();
            TextCustomerID.Text = customerCollection.ThisCustomer.CustomerId.ToString();
        }

        private void Submit()
        {
            var customer = new clsCustomer();


            var customerName = TextCustomerName.Text;
            var customerEmail = TextCustomerEmail.Text;
            var customerPassword = TextCustomerPassword.Text;
            var customerIsBusiness = CustomerBusiness.Checked.ToString();
            var customerRegistrationDate = CustomerDateTime.Text;
            var customerId = TextCustomerID.Text;

            var error = customer.ValidateFields(customerId, customerEmail, customerName, customerPassword, customerIsBusiness);

            if (string.IsNullOrWhiteSpace(error))
            {
                customer.CustomerId = int.Parse(customerId);
                customer.CustomerEmail = customerEmail;
                customer.CustomerName = customerName;
                customer.CustomerPassword = customerPassword;
                customer.IsBusinessCustomer = bool.Parse(customerIsBusiness);
                customer.RegistrationDate = DateTime.Parse(customerRegistrationDate);

                var customerList = new clsCustomerCollection();       

                if (_customerId == -1)
                {
                    customerList.ThisCustomer = customer;
                    customerList.Add();
                }
                else
                {
                    customerList.ThisCustomer.Find(_customerId);
                    customerList.ThisCustomer = customer;
                    customerList.Update();
                }


                Response.Redirect("CustomerList.aspx");
            }
            else
            {
                warningID.Text = error;
            }
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            var customer = new clsCustomer();
            int CustomerId;
            bool Found = false;
            _customerId = Convert.ToInt32(TextCustomerID.Text);
            Found = customer.Find(_customerId);
            if (Found)
            {
                TextCustomerName.Text = customer.CustomerName;
                TextCustomerEmail.Text = customer.CustomerEmail;
                TextCustomerPassword.Text = customer.CustomerPassword;
                CustomerBusiness.Checked = customer.IsBusinessCustomer;
                CustomerDateTime.Text = customer.RegistrationDate.ToShortDateString();
                TextCustomerID.Text = customer.CustomerId.ToString();
            }
        }
    }
}