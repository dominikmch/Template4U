using System.Collections.Generic;
using System;

namespace Template4UClassLib
{
    public class clsProductListCollection
    {
        List<clsProductList> mProductList = new List<clsProductList>();
        clsProductList mThisProduct = new clsProductList();

        public List<clsProductList> ProductLists
        {
            get { return mProductList; }
            set { mProductList = value; }
        }
        public int Count
        {
            get { return mProductList.Count; }
            set { }
        }
        public clsProductList ThisProductList
        {
            get { return mThisProduct; }
            set { mThisProduct = value; }
        }

        public clsProductListCollection()
        {

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblProductList_SelectAll");


            PopulateArray(DB);

        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ProductName", mThisProduct.ProductName);
            DB.AddParameter("@ProductDescription", mThisProduct.ProductDescription);
            DB.AddParameter("@Price", mThisProduct.Price);
            DB.AddParameter("@DateAdded", mThisProduct.DateAdded);
            DB.AddParameter("@isAvailable", mThisProduct.isAvailable);

            return DB.Execute("sproc_tblProductList_Add");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ProductId", mThisProduct.ProductId);

            DB.Execute("sproc_tblProductList_Delete");
        }
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ProductId", mThisProduct.ProductId);
            DB.AddParameter("@ProductName", mThisProduct.ProductName);
            DB.AddParameter("@ProductDescription", mThisProduct.ProductDescription);
            DB.AddParameter("@Price", mThisProduct.Price);
            DB.AddParameter("@DateAdded", mThisProduct.DateAdded);
            DB.AddParameter("@isAvailable", mThisProduct.isAvailable);

            DB.Execute("sproc_tblProductList_UpdateProductDetails");
        }

        public void FilterByPrice(int Price)
        {
            if (Price != 0)
            {


                clsDataConnection DB = new clsDataConnection();

                DB.AddParameter("@Price", Price);

                DB.Execute("sproc_tblProductList_FilterByPrice");

                PopulateArray(DB);
            }


        }

        void PopulateArray(clsDataConnection DB)
        {
            int index = 0;

            int recordCount = 0;

            recordCount = DB.Count;

            mProductList = new List<clsProductList>();

            while (index < recordCount)
            {
                clsProductList Product = new clsProductList();

                Product.ProductId = Convert.ToInt32(DB.DataTable.Rows[index]["ProductId"]);
                Product.ProductName = Convert.ToString(DB.DataTable.Rows[index]["ProductName"]);
                Product.ProductDescription = Convert.ToString(DB.DataTable.Rows[index]["ProductDescription"]);
                Product.Price = Convert.ToInt32(value: DB.DataTable.Rows[index]["Price"]);
                Product.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[index]["DateAdded"]);
                Product.isAvailable = Convert.ToBoolean(DB.DataTable.Rows[index]["isAvailable"]);

                mProductList.Add(Product);

                index++;
            }
        }
    }
}