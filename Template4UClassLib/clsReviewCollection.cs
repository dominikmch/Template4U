﻿using System;
using System.Collections.Generic;
namespace Template4UClassLib
{
    public class clsReviewCollection
    {
        List<clsReview> mReviewList = new List<clsReview>();
        clsReview mThisReview = new clsReview();
        public List<clsReview> ReviewList{
        get { return mReviewList; }
        set { mReviewList = value; } }
        public int Count {
            get { return mReviewList.Count; }
            set { } }
        public clsReview ThisReview {
            get { return mThisReview; }
            set { mThisReview = value; } }

        public clsReviewCollection()
        {
            int index = 0;

            int recordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblReview_SelectAll");
            recordCount = DB.Count;

            while (index < recordCount)
            {
                clsReview AnReview = new clsReview();

                AnReview.ReviewId = Convert.ToInt32(DB.DataTable.Rows[index]["ReviewID"]);
                AnReview.UserId = Convert.ToInt32(DB.DataTable.Rows[index]["UserID"]);
                AnReview.Edited = Convert.ToBoolean(DB.DataTable.Rows[index]["Edited"]);
                AnReview.ReviewComment = Convert.ToString(DB.DataTable.Rows[index]["ReviewComment"]);
                AnReview.Grade = Convert.ToInt32(DB.DataTable.Rows[index]["Grade"]);
                AnReview.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[index]["DateAdded"]);

                mReviewList.Add(AnReview);

                index++;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@UserId", mThisReview.UserId);
            DB.AddParameter("@Grade", mThisReview.Grade);
            DB.AddParameter("@Edited", mThisReview.Edited);
            DB.AddParameter("@ReviewComment", mThisReview.ReviewComment);
            DB.AddParameter("@DateAdded", mThisReview.DateAdded);
            DB.AddParameter("@ProductId", mThisReview.ProductId);

            return DB.Execute("sproc_tblReview_InsertReview");
        }
    }
}