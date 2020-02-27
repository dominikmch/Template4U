using System;


namespace Template4UClassLib
{
    public class ClsReview
    {
        public int Grade { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public int ReviewId { get; set; }
        public bool Edited { get; set; }

        private readonly clsDataConnection _clsDataConnection;


        public ClsReview(int Gr, string Descr)
        {
            Grade = Gr;
            Description = Descr;
            DateAdded = DateTime.Now();
            Edited = false;
        }

        public bool Find(int ReviewID)
        {
            _clsDataConnection DB = new _clsDataConnection();
            DB.AddParameter("@ReviewID", ReviewID);
            DB.Execute("sproc_tblReview_SelectId");
            
            if (DB.Count == 1)
            {
                    Grade = Convert.ToInt32(DB.DataTable.Rows[0]["Grade"]);

                };

            }

        }






    }
}
