using System;

namespace Template4UClassLib
{
    public class clsReview
    {       
        private  Boolean mEdited;
        private String mReviewComment;
        private int mGrade;
        private int mReviewId;
        private int mUserId;
        private DateTime mDateAdded;
        private int mProductId;
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
                mProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductId"]);

                return true;
                }
            else{
                return false; }

            }

        public string valid(String grade, String reviewComment, String dateAdded, String userId, String ProductId)
        {
            String Error = "";
            DateTime DateTemp;
            try
            { 
                //Grade validating
                if (grade.ToString().Length == 0)
                { Error += "Grade may not be empty"; }
                Int32 value;
                if (!int.TryParse(grade, out value))
                {
                    Error += "Grade must be a number";

                }
                if (int.Parse(grade) < 0)
                {
                    Error += "Grade cannot be smaller than 0, was your tamplate that bad?";
                }
                if (int.Parse(grade) > 5)
                {
                    Error += "Thats really kind, but greatest grade you can give us is 5";
                }
                //date validating
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                { Error += "The date cannot be in the past"; }
                if (DateTemp > DateTime.Now.Date)
                { Error += "The date cannot be in the future"; }
            }
            catch
            {
                Error += "The date was not a valid date";
            }
            //ReviewComment validation
            string[] words = reviewComment.Split(' ');
            if (words.Length>200)
                Error += "Comment is too long, max 200 words";
            return Error;   
        }
    }
}