using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template4UClassLib

{
    private int mStaffID;
    public int StaffID
    {
        get
        {
            return mStaffID;
        }
        set
        {
            mStaffID = value;
        }
    }
    private String mStaffRole;
    public String StaffRole
    {
        get
        {
            return mStaffRole;
        }
        set
        {
            mStaffRole = value;
        }
    }

    private DateTime mStartingDate;
    public DateTime StartingDate
    {
        get
        {
            return mStartingDate;
        }
        set
        {
            mStartingDate = value;
        }
    }
    private Double Salary;
    public Double Salary
    {
        get
        {
            return mSalary;
        }
        set
        {
            mSalary = value;
        }
    }
    private Boolean misEmployed;
    public Boolean isEmployed
    {
        get
        {
            return misEmployed;
        }
        set
        {
            misEmployed = value;
        }
    }

    

    public bool Find(int StaffID)
    {
        clsDataConnection DB = new clsDataConnection();
        DB.AddParameter("@StaffID", StaffID);
        DB.Execute("sproc_tblStaff_FilterByStaffID");
        if (DB.Count == 1)
        {
            mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
            mStaffRole = Convert.ToString(DB.DataTable.Rows[0]["StaffRole"]);
            mStartingDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StartingDate"]);
            mSalary = Convert.ToDouble(DB.DataTable.Rows[0]["Salary"]);
            misEmployed = Convert.ToBoolean(DB.DataTable.Rows[0]["isEmployed"]);

            return true;
        }
        else
        {
            return false;
        }


        public void Delete(int StaffID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", StaffID);
            DB.Execute("sproc_tblStaff_Delete");
        }
    }
