using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Template4UClassLib;

namespace Template4UFrontEnd
{
    public partial class OrderViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Int32 OrderId;
            OrderId = Convert.ToInt32(Session["OrderId"]);
            if (!IsPostBack)
            {
                if (OrderId != -1)
                {
                    DisplayReview();
                }
            }
            void DisplayReview()
            {
                Template4UClassLib.clsOrderCollection Orders = new Template4UClassLib.clsOrderCollection();
                Orders.ThisOrder.find(OrderId);
                lblOrderId.Text = "Order ID: " + Orders.ThisOrder.OrderId.ToString();
                PromoCode.Text = "Promo code : " + Orders.ThisOrder.PromoCode;
                DatePlaced.Text = "Date placed : " + Orders.ThisOrder.DatePlaced.ToString();
                OrderlineId.Text = "OrderlineId : " + Orders.ThisOrder.OrderlineId.ToString();
                IsCompleted.Text = "Is order completed: " + Orders.ThisOrder.IsCompleted.ToString();
            }


        }
    }

}