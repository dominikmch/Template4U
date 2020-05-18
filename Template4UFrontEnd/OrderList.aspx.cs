using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Template4UClassLib;

namespace Template4UFrontEnd
{
    public partial class OrderList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                DisplayOrders();
            }
        }

        void DisplayOrders()
        {
            Template4UClassLib.clsOrderCollection Orders = new Template4UClassLib.clsOrderCollection();
            lstOrders.DataSource = Orders.OrderList;
            lstOrders.DataValueField = "OrderId";
            lstOrders.DataTextField = "OrderlineId";
            lstOrders.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Session["OrderId"] = -1;
            Response.Redirect("Order.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Int32 OrderId;
            if(lstOrders.SelectedIndex != -1)
            {
                OrderId = Convert.ToInt32(lstOrders.SelectedValue);
                Session["OrderId"] = OrderId;
                Response.Redirect("DeleteOrder.aspx");
            }
            else
            {
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Int32 OrderId;
            if(lstOrders.SelectedIndex != -1)
            {
                OrderId = Convert.ToInt32(lstOrders.SelectedValue);
                Session["OrderId"] = OrderId;
                Response.Redirect("Order.aspx");
            }
            else
            {
                lblError.Text = "Please select a record to edit";
            }
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
       
            clsOrderCollection Orders = new clsOrderCollection();
            Orders.ReportByIsCompleted(OrderCompleted.Checked);
            lstOrders.DataSource = Orders.OrderList;
            lstOrders.DataValueField = "OrderId";
            lstOrders.DataTextField = "OrderlineId";
            lstOrders.DataBind();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            clsOrderCollection Orders = new clsOrderCollection();
            
            OrderCompleted.Checked = false;
            lstOrders.DataSource = Orders.OrderList;
            lstOrders.DataValueField = "OrderId";
            lstOrders.DataTextField = "OrderlineId";
            lstOrders.DataBind();
        }

        protected void ButtonView_Click(object sender, EventArgs e)
        {
            Int32 OrderId;

            if (lstOrders.SelectedIndex != -1)
            {
                OrderId = Convert.ToInt32(lstOrders.SelectedValue);
                Session["OrderId"] = OrderId;
                Response.Redirect("OrderViewer.aspx");
            }
            else
            {
                lblError.Text = "Please select an order to view";
            }
        }
    }
}