using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace Template4UClassLib
{
    public class clsCustomerCollection
    {
        // Fields
        List<clsCustomer> _mCustomerList = new List<clsCustomer>();
        clsCustomer _mThisCustomer = new clsCustomer();

        // Properties
        public List<clsCustomer> CustomersList
        {
            get => _mCustomerList;
            set => _mCustomerList = value;
        }

        public int Count => _mCustomerList.Count;

        public clsCustomer ThisCustomer
        {
            get => _mThisCustomer;
            set => _mThisCustomer = value;
        }

        // Constructors
        public clsCustomerCollection()
        {
            SelectAllCustomers();
        }

        public void SelectAllCustomers()
        {
            var DB = new clsDataConnection();
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
            _mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (index < recordCount)
            {
                //create a blank address
                clsCustomer anCustomer = new clsCustomer();
                //read in the fields from the current record
                anCustomer.CustomerId = Convert.ToInt32(db.DataTable.Rows[index]["CustomerId"]);
                anCustomer.CustomerEmail = Convert.ToString(db.DataTable.Rows[index]["CustomerEmail"]);
                anCustomer.CustomerPassword = Convert.ToString(db.DataTable.Rows[index]["CustomerPassword"]);
                anCustomer.CustomerName = Convert.ToString(db.DataTable.Rows[index]["CustomerName"]);
                anCustomer.RegistrationDate = Convert.ToDateTime(db.DataTable.Rows[index]["CustomerRegDate"]);
                anCustomer.IsBusinessCustomer = Convert.ToBoolean(db.DataTable.Rows[index]["CustomerIsBussinessClient"]);
                //add the record to the private data mamber
                _mCustomerList.Add(anCustomer);
                //point at the next record
                index++;
            }

        }

        public void Add()
        {
            clsDataConnection DB = new clsDataConnection();

            //Set parameters
            DB.AddParameter("@CustomerEmail", _mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerPassword", _mThisCustomer.CustomerPassword);
            DB.AddParameter("@CustomerName", _mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerIsBussinessClient", _mThisCustomer.IsBusinessCustomer);
            DB.AddParameter("@CustomerRegDate", _mThisCustomer.RegistrationDate);

            //Execute
            DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            //Set parameters
            DB.AddParameter("@CustomerId", _mThisCustomer.CustomerId);
            DB.AddParameter("@CustomerEmail", _mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerPassword", _mThisCustomer.CustomerPassword);
            DB.AddParameter("@CustomerName", _mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerIsBussinessClient", _mThisCustomer.IsBusinessCustomer);

            //Execute
            DB.Execute("sproc_tblCustomer_UpdateCustomerDetails");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            //Set parameters
            DB.AddParameter("@CustomerID", _mThisCustomer.CustomerId);

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