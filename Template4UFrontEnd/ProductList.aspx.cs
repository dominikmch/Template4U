using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Template4UClassLib;

namespace Template4UFrontEnd
{
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                DisplayProducts();
            }
        }
            void DisplayProducts()

            {

                Template4UClassLib.clsProductListCollection AnProduct = new Template4UClassLib.clsProductListCollection();

                ListProducts.DataSource = AnProduct.ProductLists;

                ListProducts.DataValueField = "ProductId";

                ListProducts.DataTextField = "ProductDescription";

                ListProducts.DataBind();

            }

        protected void btnAdd_Click(object sender, EventArgs e)

        {
            Session["ProductId"] = -1;

            Response.Redirect("Product.aspx");
        }


        protected void btnDelete_Click(object sender, EventArgs e)

        {

            Int32 ProductId;

            if (ListProducts.SelectedIndex != -1)

            {
                ProductId = Convert.ToInt32(ListProducts.SelectedValue);

                Session["ProductId"] = ProductId;
                Response.Redirect("DeleteProduct.aspx");
            }

            else

            {
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)

        {

            Int32 ProductId;

            if (ListProducts.SelectedIndex != -1)

            {
                ProductId = Convert.ToInt32(ListProducts.SelectedValue);

                Session["ProductId"] = ProductId;
                Response.Redirect("Product.aspx");
            }

            else

            {
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        protected void btnApply_Click(object sender, EventArgs e)

        {

            clsProductListCollection AnProduct = new clsProductListCollection();



            AnProduct.FilterByPrice(int.Parse(txtFilter.Text));

            ListProducts.DataSource = AnProduct.ProductLists;
            ListProducts.DataValueField = "Price";
            ListProducts.DataTextField = "ProductName";
            ListProducts.DataBind();
            txtFilter.Text = int.Parse(txtFilter.Text).ToString();
        }



        protected void btnClear_Click(object sender, EventArgs e)

        {
            clsProductListCollection AnProduct = new clsProductListCollection();

            AnProduct.FilterByPrice(0);
            txtFilter.Text = "0";
            ListProducts.DataSource = AnProduct.ProductLists;
            ListProducts.DataValueField = "Price";
            ListProducts.DataTextField = ("ProductName");
            ListProducts.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)

            {

                Int32 ProductId;

                if (ListProducts.SelectedIndex != -1)

                {
                    ProductId = Convert.ToInt32(ListProducts.SelectedValue);

                    Session["ProductId"] = ProductId; 
                    Response.Redirect("ProductViewer.aspx");
                }

                else

                {
                    lblError.Text = "Please select a record to view from the list";
                }
        }
    }
}