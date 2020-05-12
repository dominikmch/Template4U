using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Template4UClassLib;

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
            Session["StaffID"] = -1;
            Response.Redirect("AStaff.aspx");
        }

        protected void lstStaffList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Int32 StaffID;
            if (lstStaffList.SelectedIndex != -1)
            {
                StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
                Session["StaffID"] = StaffID;
                Response.Redirect("DeleteStaff.aspx");
            }
            else
            {
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Int32 StaffID;
            if (lstStaffList.SelectedIndex != -1)
            {
                StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
                Session["StaffID"] = StaffID;
                Response.Redirect("AStaff.aspx");
            }
            else
            {
                lblError.Text = "Please select a record to delete from this list";
            }

            
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            clsStaffCollection Staffs = new clsStaffCollection();
                        Staffs.FilterBySalary(double.Parse(txtSalary.Text));
            lstStaffList.DataSource = Staffs.StaffList;
            lstStaffList.DataValueField = "StaffID";
            lstStaffList.DataTextField = "Salary";
            lstStaffList.DataBind();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            clsStaffCollection Staffs = new clsStaffCollection();
            Staffs.FilterBySalary(0);
            txtSalary.Text = "0";
            lstStaffList.DataSource = Staffs.StaffList;
            lstStaffList.DataValueField = "StaffID";
            lstStaffList.DataTextField = "Salary";
            lstStaffList.DataBind();

        }
    }
}