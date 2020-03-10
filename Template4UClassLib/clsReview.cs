using System;

namespace Template4UClassLib
{
    public class clsReview
    {       
        private Boolean mEdited;
        private String mReviewComment;
        private int mGrade;
        private int mReviewId;
        private int mUserId;
        private DateTime mDateAdded;
        public string ReviewComment
        {
            get
            {
                return mReviewComment;
            }
            set
            {
                mReviewComment = value;
            }
        }
        public bool Edited
        {
            get
            {
                return mEdited;
            }
            set
            {
                mEdited = value;
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
        public int Grade
        {
            get
            {
                return mGrade;
            }
            set
            {
                mGrade = value;
            }
        }

        public int  ReviewId
        {
            get
            {
                return mReviewId;
            }
            set
            {
                mReviewId = value;
            }
        }
        public int UserId
        {
            get
            {
                return mUserId;
            }
            set
            {
                mUserId = value;
            }
        }

            public bool find(int ReviewId)
            {
                clsDataConnection DB = new clsDataConnection();
                DB.AddParameter("@ReviewId", ReviewId);
                DB.Execute("sproc_tblReview_SelectId");
                if (DB.Count == 1)
                {
                mReviewId= Convert.ToInt32(DB.DataTable.Rows[0]["ReviewID"]);
                mUserId = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mEdited = Convert.ToBoolean(DB.DataTable.Rows[0]["Edited"]);
                mReviewComment = Convert.ToString(DB.DataTable.Rows[0]["ReviewComment"]);
                mGrade = Convert.ToInt32(DB.DataTable.Rows[0]["Grade"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);

                return true;
                }
            else{
                return false; }

            }

        
    }
}