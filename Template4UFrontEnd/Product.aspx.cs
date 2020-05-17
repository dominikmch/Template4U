using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Template4UClassLib;

namespace Template4UFrontEnd
{
    public partial class Product : System.Web.UI.Page
    {

        Int32 ProductId;

        protected void Page_Load(object sender, EventArgs e)
        {
            ProductId = Convert.ToInt32(Session["ProductId"]);

            if (!IsPostBack)

            {
                if (ProductId != -1)
                {
                    DisplayProduct();
                }

                else
                {
                    TextDateAdded.Text = DateTime.Today.ToShortDateString().ToString();
                }
            }
        }

        void DisplayProduct()

        {
            Template4UClassLib.clsProductListCollection AnProduct = new Template4UClassLib.clsProductListCollection();

            AnProduct.ThisProductList.Find(ProductId);
            TextProductId.Text = AnProduct.ThisProductList.ProductId.ToString();
            TextProductName.Text = AnProduct.ThisProductList.ProductName.ToString();
            TextProductDescription.Text = AnProduct.ThisProductList.ProductDescription.ToString();
            TextPrice.Text = AnProduct.ThisProductList.Price.ToString();
            TextDateAdded.Text = AnProduct.ThisProductList.DateAdded.ToString();
            TextisAvailable.Text = AnProduct.ThisProductList.isAvailable.ToString();
        }

        protected void ButtonOK_Click(object sender, EventArgs e)

        {
            clsProductList AnProduct = new clsProductList();

            string ProductName = TextProductName.Text;
            string ProductDescription = TextProductDescription.Text;
            string Price = TextPrice.Text;
            string DateAdded = TextDateAdded.Text;
            string isAvailable = TextisAvailable.Text;
            string Error = "";

            Error = AnProduct.Valid(ProductName, ProductDescription, Price, DateAdded, isAvailable);

            if (Error == "")

            {
                AnProduct.ProductId = ProductId;
                AnProduct.ProductName = ProductName;
                AnProduct.ProductDescription = ProductDescription;
                AnProduct.Price = int.Parse(Price);
                AnProduct.DateAdded = Convert.ToDateTime(DateAdded);
                AnProduct.isAvailable = false;

                clsProductListCollection ProductLists = new clsProductListCollection();

                if (ProductId == -1)

                {
                    ProductLists.ThisProductList = AnProduct;
                    ProductLists.Add();
                }

                else

                {
                    ProductLists.ThisProductList.Find(ProductId);
                    ProductLists.ThisProductList = AnProduct;
                    ProductLists.Update();
                }

                Response.Redirect("ProductList.aspx");
            
            }

            else

            {
                ErrorLabel.Text = Error;
            }
        }

        protected void ButtonFind_Click(object sender, EventArgs e)
        {

        }
    }
}