using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Template4UClassLib;

namespace Template4UFrontEnd
{
    public partial class Default : System.Web.UI.Page
    {
        Int32 OrderId;
        protected void Page_Load(object sender, EventArgs e)
        {
            OrderId = Convert.ToInt32(Session["OrderId"]);
            if(IsPostBack == false)
            {
                if(OrderId != -1)
                {
                    DisplayOrder();
                }
            }
        }
        protected void ButtonOK_Click(object sender, EventArgs e)
        {
            clsOrder AnOrder = new clsOrder();
            string tstOrderId = TextOrderId.Text.Trim();
            string tstPromoCode = TextPromoCode.Text.Trim();
            string tstDatePlaced = TextDatePlaced.Text.Trim();
            string tstOrderlineId = TextOrderlineId.Text.Trim();
            bool tstIsCompleted = chkIsCompleted.Checked;
            String error = AnOrder.validate(tstOrderId, tstPromoCode, tstDatePlaced);
            if (error == "")
            {
                AnOrder.OrderId = int.Parse(tstOrderId);
                AnOrder.PromoCode = tstPromoCode;
                AnOrder.OrderlineId = int.Parse(tstOrderlineId);
                AnOrder.DatePlaced = Convert.ToDateTime(tstDatePlaced);
                AnOrder.IsCompleted = tstIsCompleted;
                
                clsOrderCollection OrderList = new clsOrderCollection();
                if (OrderId == -1)
                {
                    OrderList.ThisOrder = AnOrder;
                    OrderList.Add();
                }

                else
                {
                    OrderList.ThisOrder.find(OrderId);
                    OrderList.ThisOrder = AnOrder;
                    OrderList.Update();
                }
                Response.Redirect("OrderList.aspx");
            }
            else
            {
                ErrorLabel.Text = error;
            }

        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderList.aspx");
        }
        protected void ButtonFind_Click(object sender, EventArgs e)
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Int32 OrderId = Convert.ToInt32(TextOrderId.Text);
            Found = AnOrder.find(OrderId);
            if (Found)
            {
                TextOrderlineId.Text = AnOrder.OrderlineId.ToString();
                TextPromoCode.Text = AnOrder.PromoCode.ToString();
                TextDatePlaced.Text = AnOrder.DatePlaced.ToString();
                chkIsCompleted.Checked = AnOrder.IsCompleted;
         
            }
            else { }

        }

        void DisplayOrder()
        {
            clsOrderCollection OrderList = new clsOrderCollection();
            OrderList.ThisOrder.find(OrderId);
            TextOrderId.Text = OrderList.ThisOrder.OrderId.ToString();
            TextOrderlineId.Text = OrderList.ThisOrder.OrderlineId.ToString();
            TextPromoCode.Text = OrderList.ThisOrder.PromoCode;
            TextDatePlaced.Text = OrderList.ThisOrder.DatePlaced.ToString();
            chkIsCompleted.Checked = OrderList.ThisOrder.IsCompleted;

        }

    }
}