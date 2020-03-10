using System;
namespace Template4UClassLib
{
    public class clsOrder
    {
        private int mOrderId;
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

    }
}