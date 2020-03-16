using System;

namespace Template4UClassLib
{
    public class clsCustomer
    {
        public int mCustomerId { get; set; }
        public string mCustomerEmail { get; set; }
        public string mCustomerPassword { get; set; }
        public string mCustomerName { get; set; }
        public DateTime mRegistrationDate { get; set; }
        public bool mIsBusinessCustomer { get; set; }

        public clsCustomer()
        {
        }
        //public bool FindAll()
        //{
        //    clsDataConnection DB = new clsDataConnection();
        //    DB.Execute("sproc_tblCustomer_SelectAll");
        //    if (DB.Count > 0)
        //    {
        //        mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
        //        mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
        //        mCustomerPassword = Convert.ToString(DB.DataTable.Rows[0]["CustomerPassword"]);
        //        mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
        //        mRegistrationDate = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerRegDate"]);
        //        mIsBusinessCustomer = Convert.ToBoolean(DB.DataTable.Rows[0]["CustomerIsBussinessClient"]);

        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //}

        public bool Find(int cId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", cId);
            DB.Execute("sproc_tblCustomer_SelectSingle");
            if (DB.Count  == 1)
            {
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mCustomerPassword = Convert.ToString(DB.DataTable.Rows[0]["CustomerPassword"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mRegistrationDate = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerRegDate"]);
                mIsBusinessCustomer = Convert.ToBoolean(DB.DataTable.Rows[0]["CustomerIsBussinessClient"]);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}