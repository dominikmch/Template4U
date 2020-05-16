﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Template4UClassLib;

namespace Template4UFrontEnd
{
    public partial class CustomerList : System.Web.UI.Page
    {
        private int _customerId;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                ShowCustomers();
            }
        }

        void ShowCustomers()
        {
            var customers = new clsCustomerCollection();

            ListCustomers.DataSource = customers.CustomersList;
            ListCustomers.DataValueField = "CustomerId";
            //ListCustomers.DataTextField = "CustomerEmail";
            ListCustomers.DataTextField = "CustomerName";

            ListCustomers.DataBind();
        }

        protected void ViewCustomer_OnClick(object sender, EventArgs e)
        {
            //int _customerId;

            if (ListCustomers.SelectedIndex != -1)
            {
                _customerId = Convert.ToInt32(ListCustomers.SelectedValue);
                Session["CustomerId"] = _customerId;
                Response.Redirect("CustomerViewer.aspx");
            }
            else
            {
                lblError.Text = "Please select a record to delete from the list";
            }
        }


        protected void btnDelete_OnClick(object sender, EventArgs e)
        {
            //int _customerId;

            if (ListCustomers.SelectedIndex != -1)
            {
                _customerId = Convert.ToInt32(ListCustomers.SelectedValue);
                Session["CustomerId"] = _customerId;
                Response.Redirect("DeleteCustomer.aspx");
            }
            else
            {
                lblError.Text = "Please select an item from the list above.";
            }
        }

        protected void btnUpdate_OnClick(object sender, EventArgs e)
        {
            //int _customerId;

            if (ListCustomers.SelectedIndex != -1)
            {
                _customerId = Convert.ToInt32(ListCustomers.SelectedValue);
                Session["CustomerId"] = _customerId;
                Response.Redirect("AnCustomer.aspx");
            }
            else
            {
                lblError.Text = "Please select an item from the list above.";
            }
        }

        protected void btnAdd_OnClick(object sender, EventArgs e)
        {
            Session["CustomerId"] = 0;
            Response.Redirect("AnCustomer.aspx");
        }

        protected void btnApply_OnClick(object sender, EventArgs e)
        {
            var customers = new clsCustomerCollection();

            customers.ReportByType(CustomerBusiness.Checked);

            ListCustomers.DataSource = customers.CustomersList;
            ListCustomers.DataValueField = "CustomerId";
            //ListCustomers.DataTextField = "CustomerEmail";
            ListCustomers.DataTextField = "CustomerName";
            ListCustomers.DataBind();
        }

        protected void btnClear_OnClick(object sender, EventArgs e)
        {
            var customers = new clsCustomerCollection();

            CustomerBusiness.Checked = false;
            customers.SelectAllCustomers();


            ListCustomers.DataSource = customers.CustomersList;
            ListCustomers.DataValueField = "CustomerId";
            //ListCustomers.DataTextField = "CustomerEmail";
            ListCustomers.DataTextField = "CustomerName";
            ListCustomers.DataBind();
        }
    }
}