using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Template4UClassLib;

namespace Template4UFrontEnd
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButtonOK_Click(object sender, EventArgs e)
        {
            clsOrder AnOrder = new clsOrder();
            string tstOrderId = TextOrderId.Text.Trim();
            string tstPromoCode = TextPromoCode.Text.Trim();
            string tstDatePlaced = TextDatePlaced.Text.Trim();
            String error = AnOrder.validate(tstOrderId, tstPromoCode, tstDatePlaced);
            if(error == "")
            {
                AnOrder.OrderId = int.Parse(tstOrderId);
                AnOrder.PromoCode = tstPromoCode;
                AnOrder.DatePlaced = Convert.ToDateTime(tstDatePlaced);
                Session["AnOrder"] = AnOrder;
                Response.Redirect("OrderViewer.aspx");
            }
            else
            {
                ErrorLabel.Text = error;
            }

        }
        protected void ButtonFind_Click(object sender, EventArgs e)
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Int32 OrderId = Convert.ToInt32(TextOrderId.Text);
            Found = AnOrder.find(OrderId);
            if (Found)
            {
                TextPromoCode.Text = AnOrder.PromoCode.ToString();
                TextDatePlaced.Text = AnOrder.DatePlaced.ToString();
         
            }
            else { }

        }
    }
}