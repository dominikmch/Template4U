using System;
using System.Linq;

namespace Template4UClassLib
{
    public class clsOrder
    {
        private int mOrderId;
        private int mOrderlineId;
        private string mPromoCode;
        private DateTime mDatePlaced;
        private Boolean mIsCompleted;
        public int OrderId
        {
            get
            {
                return mOrderId;
            }
            set
            {
                mOrderId = value;
            }
        }
        public int OrderlineId
        {
            get
            {
                return mOrderlineId;
            }
            set
            {
                mOrderlineId = value;
            }
        }

        public DateTime DatePlaced
        {
            get
            {
                return mDatePlaced;
            }
            set
            {
                mDatePlaced = value;
            }
        }
        public bool IsCompleted
        {
            get
            {
                return mIsCompleted;
            }
            set
            {
                mIsCompleted = value;
            }
        }
        public string PromoCode
        {
            get
            {
                return mPromoCode;
            }
            set
            {
                mPromoCode = value;
            }
        }

        public bool find(int OrderId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", OrderId);
            DB.Execute("sproc_tblOrder_SelectById");
            if (DB.Count == 1)
            {
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mOrderlineId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderlineId"]);
                mIsCompleted = Convert.ToBoolean(DB.DataTable.Rows[0]["IsCompleted"]);
                mPromoCode = Convert.ToString(DB.DataTable.Rows[0]["PromoCode"]);
                mDatePlaced= Convert.ToDateTime(DB.DataTable.Rows[0]["DatePlaced"]);

                return true;
            }
            else
            {
                return false;
            }

        }
        public string validate(String orderId, string orderlineId, String promoCode, String datePlaced)
        {
            String Error = "";
            //checking if order Id contains only allowed characters
            if(!orderId.All(Char.IsDigit))
            {
                Error += "OrderId can only contain digits";
            }
            if(orderId.ToString().Length == 0)
            {
                Error += "OrderId cannot be empty";
            }
            //orderlineId validation
            if(!orderlineId.All(Char.IsDigit))
            {
                Error += "OrderlineId can only contain digits";
            }
            if(orderlineId.ToString().Length == 0)
            {
               Error += "OrderlineId cannot be empty";
            }
            //promoCode validation
            if (promoCode.Length < 4 || promoCode.Length > 20)
            {
                Error += "PromoCode has to be between 4 and 20 characters long";
            }
            //datePlaced validation
            try
            {
                DateTime DateTest = Convert.ToDateTime(datePlaced);
                if (Convert.ToDateTime(datePlaced) < DateTime.Now.Date)
                { Error += "The date appears to be in the past. It has to be today's date"; }
                if (Convert.ToDateTime(datePlaced) > DateTime.Now.Date)
                { Error += "The date appears to be in the future. It has to be today's date"; }
            }
            catch
            {
                Error += "This is not a valid date";
            }
          
            return Error;
        }
        public void Add(string orderlineId, string promoCode, bool isCompleted)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderLineId", orderlineId);
            DB.AddParameter("@PromoCode", promoCode);
            DB.AddParameter("@IsCompleted", isCompleted);
            DB.Execute("sproc_tblOrder_Insert");


        }

    }
}