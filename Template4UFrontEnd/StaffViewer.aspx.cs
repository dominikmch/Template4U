using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Template4UFrontEnd
{
    public partial class StaffViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Int32 StaffID;
            StaffID = Convert.ToInt32(Session["StaffID"]);
            if (!IsPostBack)
            {
                if (StaffID != -1)
                {
                    DisplayStaff();
                }

            }
            void DisplayStaff()
            {
                Template4UClassLib.clsStaffCollection Staffs = new Template4UClassLib.clsStaffCollection();
                Staffs.ThisStaff.Find(StaffID);
                
            }
        }
    }
}