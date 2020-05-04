﻿using System;
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
            var anCustomer = new clsCustomer();
            anCustomer = (clsCustomer)Session["anCustomer"];
        }


        protected void ButtonOk_Click(object sender, EventArgs e)
        {
            var customer = new clsCustomer();
            if (Editable.Checked)
            {
                AdminMode(customer);
            }
            else
            {
                Find(customer, int.Parse(TextCustomerID.Text));
            }
            
        }

        private void Find(clsCustomer customer, int CId)
        {
            var customerClass = customer;

            
            var found = false;

            found = customerClass.Find(Convert.ToInt32(CId));
            if (found)
            {
                TextCustomerName.Text = customerClass.CustomerName;
                TextCustomerEmail.Text = customerClass.CustomerEmail;
                TextCustomerPassword.Text = customerClass.CustomerPassword;
                CustomerBusiness.Checked = customerClass.IsBusinessCustomer;
                CustomerDateTime.Text = customerClass.RegistrationDate.ToShortDateString();
                TextCustomerID.Text = customerClass.CustomerId.ToString();
            }
            else { }
        }

        private void AdminMode(clsCustomer customer)
        {
            clsCustomerCollection customerCollection = new clsCustomerCollection();

            var tstCustomerId = TextCustomerID.Text;
            var tstCustomerEmail = TextCustomerEmail.Text;
            var tstCustomerName = TextCustomerName.Text;
            var tstCustomerPassword = TextCustomerPassword.Text;
            var tstCustomerIsBusiness = CustomerBusiness.Checked;

            var error = customer.ValidateFields(tstCustomerId, tstCustomerEmail, tstCustomerName, tstCustomerPassword,  tstCustomerIsBusiness.ToString());

            if (string.IsNullOrWhiteSpace(error))
            {
                if (!customer.Find(int.Parse(tstCustomerId)))
                {
                    customerCollection.Add(tstCustomerName, tstCustomerPassword, tstCustomerEmail, tstCustomerIsBusiness);
                }
                else
                {
                    customerCollection.Update(int.Parse(tstCustomerId), tstCustomerName, tstCustomerPassword, tstCustomerEmail, tstCustomerIsBusiness);
                }

                
                Session["anCustomer"] = customer;
                Response.Redirect("CustomerViewer.aspx");
            }
            else
            {

            }
        }

        protected void Editable_OnCheckedChanged(object sender, EventArgs e)
        {
            var customer = new clsCustomer();
            var error = customer.ValidateId(TextCustomerID.Text);
            var editable = false;

            warningID.Text = "";

            if (string.IsNullOrWhiteSpace(error))
            {
                if (customer.Find(int.Parse(TextCustomerID.Text)))
                {
                    editable = Editable.Checked;


                    //To be changed or removed when update function added...
                    CustomerDateTime.Text = customer.RegistrationDate.ToShortDateString();
                }
            }
            else
            {
                Editable.Checked = false;
                CustomerDateTime.Text = "";
                warningID.Text = error;
            }
            
          
            TextCustomerID.Enabled = !editable;
            TextCustomerEmail.Enabled = editable;
            TextCustomerName.Enabled = editable;
            TextCustomerPassword.Enabled = editable;
            CustomerBusiness.Enabled = editable;

        }

        protected void TextCustomerID_OnTextChanged(object sender, EventArgs e)
        {
            var customer = new clsCustomer();
            var error = customer.ValidateId(TextCustomerID.Text);

            Find(customer, int.Parse(TextCustomerID.Text));
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}