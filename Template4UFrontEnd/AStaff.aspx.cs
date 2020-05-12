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
            Template4UClassLib.clsStaffCollection Staffs = new Template4UClassLib.clsStaffCollection();
            Staffs.ThisStaff.Find(StaffID);
            txtStaffID.Text = Staffs.ThisStaff.StaffID.ToString();
            txtStaffRole.Text = Staffs.ThisStaff.StaffRole;
            txtStartingDate.Text = Staffs.ThisStaff.StartingDate.ToString();
            txtSalary.Text = Staffs.ThisStaff.Salary.ToString();
            cbisEmployed.Checked = Staffs.ThisStaff.isEmployed;
            
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            clsStaff AStaff = new clsStaff();

            string StaffRole = txtStaffRole.Text;
            string StartingDate = txtStartingDate.Text;
            string Salary = txtSalary.Text;
            string Error = "";

            Error = AStaff.Valid(StaffRole, StartingDate, Salary);
            if (Error == "")
            {
                AStaff.StaffID = StaffID;
                AStaff.StaffRole = StaffRole;
                AStaff.StartingDate = Convert.ToDateTime(StartingDate);
                AStaff.Salary = double.Parse(Salary);
                AStaff.isEmployed = cbisEmployed.Checked;
                clsStaffCollection StaffList = new clsStaffCollection();

                
                if (StaffID == -1)
                {
                    StaffList.ThisStaff = AStaff;
                    StaffList.Add();
                }
                else
                {
                    StaffList.ThisStaff.Find(StaffID);
                    StaffList.ThisStaff = AStaff;
                    StaffList.Update();
                }
               
                Response.Redirect("StaffList.aspx");
                                            
                           }
            else
            {
                lblError.Text = Error;
            }
           
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            clsStaff AStaff = new clsStaff();
            Int32 StaffID;
            Boolean Found = false;
            StaffID = Convert.ToInt32(txtStaffID.Text);
            Found = AStaff.Find(StaffID);
            if (Found)
            {
                txtStaffRole.Text = AStaff.StaffRole;
                txtStartingDate.Text = AStaff.StartingDate.ToString();
                txtSalary.Text = AStaff.Salary.ToString();

            }
            else { }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            
        }
    }
}