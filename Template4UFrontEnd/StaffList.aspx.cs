﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Template4UFrontEnd
{
    public partial class StaffList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                DisplayStaff();
            }
        }
        void DisplayStaff()
        {
            Template4UClassLib.clsStaffCollection Staffs = new Template4UClassLib.clsStaffCollection();
            lstStaffList.DataSource = Staffs.StaffList;
            lstStaffList.DataValueField = "StaffID";
            lstStaffList.DataTextField = "StaffRole";
            lstStaffList.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

        }

        protected void lstStaffList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}