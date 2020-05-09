using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Template4UClassLib;

namespace Template4UFrontEnd
{
    public partial class AStaff : System.Web.UI.Page
    { Int32 StaffID;
        protected void Page_Load(object sender, EventArgs e)
        {
            StaffID = Convert.ToInt32(Session["StaffID"]);
            if (!IsPostBack)
            {
                if (StaffID != -1)
                {
                    DisplayStaff();
                }
            }
        }

        void DisplayStaff()
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            
        }
    }
}