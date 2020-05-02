using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace Template4UClassLib
{
    class clsCustomerCollection
    {
        // Fields
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();

        // Properties
        public List<clsCustomer> CustomersList
        {
            get => mCustomerList;
            set => mCustomerList = value;
        }

        public int Count => mCustomerList.Count;

        public clsCustomer ThisCustomer
        {
            get => mThisCustomer;
            set => mThisCustomer = value;
        }

        // Constructors
        public clsCustomerCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection db)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 index = 0;
            //var to store the record count
            Int32 recordCount;
            //get the count of records
            recordCount = db.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (index < recordCount)
            {
                //create a blank address
                clsCustomer anCustomer = new clsCustomer();
                //read in the fields from the current record
                anCustomer.CustomerId = Convert.ToInt32(db.DataTable.Rows[0]["CustomerId"]);
                anCustomer.CustomerEmail = Convert.ToString(db.DataTable.Rows[0]["CustomerEmail"]);
                anCustomer.CustomerPassword = Convert.ToString(db.DataTable.Rows[0]["CustomerPassword"]);
                anCustomer.CustomerName = Convert.ToString(db.DataTable.Rows[0]["CustomerName"]);
                anCustomer.RegistrationDate = Convert.ToDateTime(db.DataTable.Rows[0]["CustomerRegDate"]);
                anCustomer.IsBusinessCustomer = Convert.ToBoolean(db.DataTable.Rows[0]["CustomerIsBussinessClient"]);
                //add the record to the private data mamber
                mCustomerList.Add(anCustomer);
                //point at the next record
                index++;
            }

        }

        public void Add(string name, string password, string email, bool isBusiness)
        {
            clsDataConnection DB = new clsDataConnection();

            //Set parameters
            DB.AddParameter("@CustomerEmail", email);
            DB.AddParameter("@CustomerPassword", password);
            DB.AddParameter("@CustomerName", name);
            DB.AddParameter("@CustomerIsBussinessClient", isBusiness);
            DB.AddParameter("@CustomerRegDate", DateTime.Today);

            //Execute
            DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update(int id, string name, string password, string email, bool isBusiness)
        {
            clsDataConnection DB = new clsDataConnection();

            //Set parameters
            DB.AddParameter("@CustomerId", id);
            DB.AddParameter("@CustomerEmail", email);
            DB.AddParameter("@CustomerPassword", password);
            DB.AddParameter("@CustomerName", name);
            DB.AddParameter("@CustomerIsBussinessClient", isBusiness);

            //Execute
            DB.Execute("sproc_tblCustomer_UpdateCustomerDetails");
        }

        public void Delete(int id)
        {
            clsDataConnection DB = new clsDataConnection();

            //Set parameters
            DB.AddParameter("@CustomerId", id);

            //Execute
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByType(bool isBusiness)
        {
            clsDataConnection DB = new clsDataConnection();

            //Set parameters
            DB.AddParameter("@CustomerIsBussinessClient", isBusiness);

            //Execute
            DB.Execute("sproc_tblCustomer_FilterByType");

            PopulateArray(DB);
        }
    }
}