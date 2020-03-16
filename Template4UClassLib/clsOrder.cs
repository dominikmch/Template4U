using System;
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

    }
}