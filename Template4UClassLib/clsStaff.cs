﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template4UClassLib
{
    public class clsStaff
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
        private Double mSalary;
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

            


    


        }

        public string Valid(string staffID, string staffRole, string startingDate, string salary)
        {
            String Error = "";
            if (staffID.Length == 0)
            {
                Error = Error + "The Staff ID may not be blank : ";
            }
            Int32 num1;

            if (!int.TryParse(staffID, out num1))
            {
                Error += " The Staff ID must be an interger";
            }
            if (staffID.Length > 5)
            {
                Error = Error + "The Staff ID must not be 5 characters or longer : ";
            }

            try
            {
                DateTime DateTemp = Convert.ToDateTime(startingDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }
            if (staffRole.Length == 0)
            {
                Error = Error + "The Staff Role may not be blank : ";
            }
            if (staffRole.Length > 20)
            {
                Error = Error + "The Staff Role may not be more than 20 characters : ";
            }
            if (salary.Length == 0)
            {
                Error = Error + "The Salary field must not be left empty : ";

            }
            if (salary.Length > 8)
            {
                Error = Error + "The salary field may not have this many characters : ";
            }
            return Error;

        }
    }
}
