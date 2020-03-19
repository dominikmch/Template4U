using System;

namespace Template4UClassLib
{
    public class clsCustomer
    {
        public int CustomerId { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPassword { get; set; }
        public string CustomerName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool IsBusinessCustomer { get; set; }

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
                CustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                CustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                CustomerPassword = Convert.ToString(DB.DataTable.Rows[0]["CustomerPassword"]);
                CustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                RegistrationDate = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerRegDate"]);
                IsBusinessCustomer = Convert.ToBoolean(DB.DataTable.Rows[0]["CustomerIsBussinessClient"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        public void Add(string name, string password, string email, bool isBusiness)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerEmail", email);
            DB.AddParameter("@CustomerPassword", password);
            DB.AddParameter("@CustomerName", name);
            DB.AddParameter("@CustomerIsBussinessClient", isBusiness);
            DB.AddParameter("@CustomerRegDate", DateTime.Today);
            DB.Execute("sproc_tblCustomer_Insert");

            if (DB.Count != 0)
            {

            }
            else
            {
            }

        }

        public string ValidateFields(string customerId, string customerEmail, string customerName)
        {
            var error = "";
            try
            {
                if (customerEmail.Length == 0)
                { error += "Email cannot be empty"; }
                if (customerEmail.Length > 32)
                {
                    error += "Email cannot be longer than 32 characters";
                }
            }
            catch (Exception e)
            {
                error += "\n" + e;
            }

            try
            {
                if (customerName.Length == 0)
                { error += "Name cannot be empty"; }
                if (customerName.Length > 32)
                {
                    error += "Name cannot be longer than 32 characters";
                }
            }
            catch (Exception e)
            {
                error += "\n" + e;
            }

            try
            {
                if (customerId.Length == 0)
                { error += "Id cannot be empty"; }
                if (customerName.Length > 32)
                {
                    error += "Id max length is 32";
                }

                if (Find(int.Parse(customerId)))
                {
                    error += "Id does not exist in the database";
                }
            }
            catch (Exception e)
            {
                error += "\n" + e;
            }
            return error;
        }

        public string ValidateId(string customerId)
        {
            var error = "";
            try
            {
                if (customerId.Length == 0)
                { error = "Id cannot be empty"; }
                if (customerId.Length > 32)
                {
                    error = "Id max length is 32";
                }

                if (!Find(int.Parse(customerId)))
                {
                    error = "Id does not exist in the database";
                }
            }
            catch (Exception e)
            {
                error = "\n" + e;
            }
            return error;
        }
    }
}