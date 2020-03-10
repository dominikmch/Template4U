using System;

namespace Template4UClassLib
{
    public class clsCustomer
    {
        public int mCustomerId { get; private set; }
        public string mCustomerEmail { get; private set; }
        public string mCustomerPassword { get; private set; }
        public string mCustomerName { get; private set; }
        public DateTime mRegistrationDate { get; private set; }
        public bool mIsBusinessCustomer { get; private set; }

        public clsCustomer()
        {
        }
        public bool FindAll()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            if (DB.Count == 1)
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