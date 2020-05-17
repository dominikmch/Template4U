using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Template4UFrontEnd
{
    public partial class ProductViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
            Int32 ProductId;
            ProductId = Convert.ToInt32(Session["ProductId"]);

            if (!IsPostBack)
            {
                if (ProductId != -1)
                {
                    DisplayProducts();
                }
            }

            void DisplayProducts()

            {
                Template4UClassLib.clsProductListCollection AnProduct = new Template4UClassLib.clsProductListCollection();

                AnProduct.ThisProductList.Find(ProductId);

                ProductName.Text = "Product's Name : " + AnProduct.ThisProductList.ProductName.ToString();
                ProductDescription.Text = "Product's Description : " + AnProduct.ThisProductList.ProductDescription;
                Price.Text = "Price: " + AnProduct.ThisProductList.Price.ToString();
                DateAdded.Text = "Added: " + AnProduct.ThisProductList.DateAdded.ToString();
                isAvailable.Text = "Availability: " + AnProduct.ThisProductList.isAvailable.ToString();

            }
        }

        protected void btnNo_Click(object sender, EventArgs e)

        {
        }
    }
}