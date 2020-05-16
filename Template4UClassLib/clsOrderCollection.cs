using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template4UClassLib
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();

        public List<clsOrder> OrderList
        {
            get { return mOrderList; }
            set { mOrderList = value; }
        }

        public clsOrder ThisOrder
        {
            get { return mThisOrder; }
            set { mThisOrder = value; }
        }

        public int Count
        {
            get { return mOrderList.Count; }
        }

        public clsOrderCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            PopulateOrderCollection(DB);
        }

        public void populateCollectionWithAllCustomers()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            PopulateOrderCollection(DB);

        }

         void PopulateOrderCollection(clsDataConnection DB)
        {
            int numberOfOrders = DB.Count;
            int index = 0;
            mOrderList = new List<clsOrder>();
            while (index < numberOfOrders){
                clsOrder AnOrder = new clsOrder();
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[index]["OrderId"]);
                AnOrder.OrderlineId = Convert.ToInt32(DB.DataTable.Rows[index]["OrderlineId"]);
                AnOrder.PromoCode = Convert.ToString(DB.DataTable.Rows[index]["PromoCode"]);
                AnOrder.IsCompleted = Convert.ToBoolean(DB.DataTable.Rows[index]["IsCompleted"]);
                AnOrder.DatePlaced = Convert.ToDateTime(DB.DataTable.Rows[index]["DatePlaced"]);

                mOrderList.Add(AnOrder);
                index++;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderlineId", mThisOrder.OrderlineId);
            DB.AddParameter("@PromoCode", mThisOrder.PromoCode);
            DB.AddParameter("@DatePlaced", mThisOrder.DatePlaced);
            DB.AddParameter("@IsCompleted", mThisOrder.IsCompleted);

            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            DB.Execute("sproc_tblOrder_DeleteOrder");   
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            DB.AddParameter("@OrderlineId", mThisOrder.OrderlineId);
            DB.AddParameter("@PromoCode", mThisOrder.PromoCode);
            DB.AddParameter("@DatePlaced", mThisOrder.DatePlaced);
            DB.AddParameter("@IsCompleted", mThisOrder.IsCompleted);
            DB.Execute("sproc_tblOrder_Update");
        }

        public void ReportByIsCompleted(bool isCompleted)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@IsCompleted", isCompleted);
            DB.Execute("sproc_tblOrder_FilterByIsCompleted");
            PopulateOrderCollection(DB);
        }
    }
}
