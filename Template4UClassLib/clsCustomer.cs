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

        public bool Find(int cId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", cId);
            DB.Execute("sproc_tblCustomer_SelectSingle");
            if (DB.Count == 1)
            {
                CustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                CustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                CustomerPassword = Convert.ToString(DB.DataTable.Rows[0]["CustomerPassword"]);
                CustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                RegistrationDate = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerRegDate"]);
                IsBusinessCustomer = Convert.ToBoolean(DB.DataTable.Rows[0]["CustomerIsBussinessClient"]);

                return true;
            }

            return false;
            
        }

        public string ValidateFields(string customerId, string customerEmail, string customerName, string customerPassword, string customerIsBusiness)
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

                if (customerName.Length == 0)
                { error += "Name cannot be empty"; }
                if (customerName.Length > 32)
                {
                    error += "Name cannot be longer than 32 characters";
                }

                if (customerPassword.Length == 0)
                { error += "Password cannot be empty"; }
                if (customerPassword.Length > 32)
                {
                    error += "Password cannot be longer than 32 characters";
                }

                if (customerPassword.Length == 0)
                { error += "Business must be either true or false. Empty"; }
                if (customerPassword.Length > 9)
                {
                    error += "Business must be either true or false. Too long";
                }

                if (customerId.Length <= 0)
                {
                    error += "Id length cannot be less than 0";
                }
            }
            catch (Exception e)
            {
                error += e;
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
            }
            catch (Exception e)
            {
                error = "\n" + e;
            }
            return error;
        }
    }
}