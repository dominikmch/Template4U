using System;

namespace Template4UClassLib
{
    public class clsProductList
    {
        private int mProductId;
        private String mProductName;
        private String mProductDescription;
        private int mPrice;
        private DateTime mDateAdded;
        private Boolean misAvailable;

        public int ProductId
        {
            get
            {
                return mProductId;
            }
            set
            {
                mProductId = value;
            }
        }
        public String ProductName
        {
            get
            {
                return mProductName;
            }
            set
            {
                mProductName = value;
            }
        }
        public String ProductDescription
        {
            get
            {
                return mProductDescription;
            }
            set
            {
                mProductDescription = value;
            }
        }
        public int Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }

        public bool isAvailable
        {
            get
            {
                return misAvailable;
            }
            set
            {
                misAvailable = value;
            }
        }
        public bool Find(int ProductId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductId", ProductId);
            DB.Execute("sproc_tblProductList_SelectId");
            if (DB.Count == 1)
            {
                mProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductId"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mProductDescription = Convert.ToString(DB.DataTable.Rows[0]["ProductDescription"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                misAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["isAvailable"]);

                return true;
            }

            else
            {
                return false;
            }

        }

        public string Valid(string ProductId, string ProductName, string ProductDescription, string Price, string DateAdded, string isAvailable)
        {
            String Error = "";
            DateTime DateTemp;
            try
            {
                if (Price.ToString().Length == 0)
                { Error += "Price cannot be empty!"; }
                Int32 value;
                if (!int.TryParse(Price, out value))
                {
                    Error += "Wrong value, price must be a number!";

                }
                if (int.Parse(Price) < 0)
                {
                    Error += "Price cannot be smaller than 0!";
                }
                if (int.Parse(Price) > 500)
                {
                    Error += "Price cannot be higher than 500 as we don't sell as expensive templates!";
                }
                DateTemp = Convert.ToDateTime(DateAdded);
                if (DateTemp < DateTime.Now.Date)
                { Error += "The date cannot be in the past"; }
                if (DateTemp > DateTime.Now.Date)
                { Error += "The date cannot be in the future"; }
            }
            catch
            {
                Error += "The date was not a valid date";
            }
            string[] words = ProductDescription.Split(' ');
            if (words.Length > 200)
                Error += "Product's description cannot be longer than 200 words, soory.";
            return Error;
        }

        public void Find(string productId)
        {
            throw new NotImplementedException();
        }
    }
}