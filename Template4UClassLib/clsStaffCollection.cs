using System;
using System.Collections.Generic;

namespace Template4UClassLib
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();
        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }

            public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set { }
        }

        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }

        public clsStaffCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            RecordCount = DB.Count;
            PopulateArray(DB);
        }


        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            
            DB.AddParameter("@StaffRole", mThisStaff.StaffRole);
            DB.AddParameter("@StartingDate", mThisStaff.StartingDate);
            DB.AddParameter("@Salary", mThisStaff.Salary);
            DB.AddParameter("@isEmployed", mThisStaff.isEmployed);

            return DB.Execute("sproc_tblStaff_Add");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@StaffRole", mThisStaff.StaffRole);
            DB.AddParameter("@StartingDate", mThisStaff.StartingDate);
            DB.AddParameter("@Salary", mThisStaff.Salary);
            DB.AddParameter("@isEmployed", mThisStaff.isEmployed);

            DB.Execute("sproc_tblStaff_Update");

        }



        public void FilterBySalary(double Salary )
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Salary", Salary);
            DB.Execute("sproc_tblStaff_FilterBySalary");
            PopulateArray(DB);
        }

        private void PopulateArray(clsDataConnection DB)
        {
            int index = 0;
            int recordCount = 0;
            recordCount = DB.Count;
            mStaffList = new List<clsStaff>();

            while (index < recordCount)
            {
                clsStaff AStaff = new clsStaff();

                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[index]["StaffID"]);
                AStaff.StaffRole = Convert.ToString(DB.DataTable.Rows[index]["StaffRole"]);
                AStaff.StartingDate = Convert.ToDateTime(DB.DataTable.Rows[index]["StartingDate"]);
                AStaff.Salary = Convert.ToDouble(DB.DataTable.Rows[index]["Salary"]);
                AStaff.isEmployed = Convert.ToBoolean(DB.DataTable.Rows[index]["isEmployed"]);

                mStaffList.Add(AStaff);

                index++;

            }
        }
    }
    }
