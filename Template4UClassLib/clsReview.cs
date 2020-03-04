using System;

namespace Template4UClassLib
{
    public class clsReview
    {       
        private Boolean mEdited;
        private String mDescription;
        private int mGrade;
        private int mReviewId;
        private DateTime mDateAdded;
        public string Description
        {
            get
            {
                return mDescription;
            }
            set
            {
                mDescription = value;
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

        public int ReviewId
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

        public bool find(int ReviewId)
        {
            mEdited = false;
            mDescription = "Very goood template";
            mGrade = 4;
            mDateAdded = Convert.ToDateTime("04/03/2020");
            mReviewId = 21;
            return true;
        }
    }
}