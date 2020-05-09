using System.Collections.Generic;

namespace Template4UClassLib
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();
        public List<clsStaff> StaffList {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
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
            clsDataConnection DB = clsDataConnection();
        }
        }
    }
}