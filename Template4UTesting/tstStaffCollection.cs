using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Template4UClassLib;

namespace Template4UTesting
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]

        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> tstList = new List<clsStaff>();
            clsStaff tstItem = new clsStaff();

            tstItem.StaffID = 12;
            tstItem.StaffRole = "Manager";
            tstItem.StartingDate = DateTime.Now.Date;
            tstItem.Salary = 10;
            tstItem.isEmployed = true;

            tstList.Add(tstItem);
            AllStaff.StaffList = tstList;
            Assert.AreEqual(AllStaff.StaffList, tstList);

        }

        [TestMethod]

        public void ThisStaffOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            clsStaff tstItem = new clsStaff();

            tstItem.StaffID = 12;
            tstItem.StaffRole = "Manager";
            tstItem.StartingDate = DateTime.Now.Date;
            tstItem.Salary = 10;
            tstItem.isEmployed = true;

            AllStaff.ThisStaff = tstItem;
            Assert.AreEqual(AllStaff.ThisStaff, tstItem);

        }

        [TestMethod]

        public void ListAndCountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> tstList = new List<clsStaff>();
            clsStaff tstItem = new clsStaff();

            tstItem.StaffID = 12;
            tstItem.StaffRole = "Manager";
            tstItem.StartingDate = DateTime.Now.Date;
            tstItem.Salary = 10;
            tstItem.isEmployed = true;

            tstList.Add(tstItem);
            AllStaff.StaffList = tstList;
            Assert.AreEqual(AllStaff.Count, tstList.Count);

        }

        [TestMethod]

        public void AddMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            Int32 PrimaryKey = 0;

            clsStaff tstItem = new clsStaff();


            tstItem.StaffRole = "Manager";
            tstItem.StartingDate = DateTime.Now.Date;
            tstItem.Salary = 10;
            tstItem.isEmployed = true;

            AllStaff.ThisStaff = tstItem;

            PrimaryKey = AllStaff.Add();

            tstItem.StaffID = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, tstItem);


        }

        [TestMethod]

        public void DeleteMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff tstItem = new clsStaff();

            Int32 PrimaryKey = 0;

            tstItem.StaffID = 12;
            tstItem.StaffRole = "Manager";
            tstItem.StartingDate = DateTime.Now.Date;
            tstItem.Salary = 10;
            tstItem.isEmployed = true;

            AllStaff.ThisStaff = tstItem;

            PrimaryKey = AllStaff.Add();

            tstItem.StaffID = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            AllStaff.Delete();
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.IsFalse(Found);


        }

        [TestMethod]

        public void UpdateMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff tstItem = new clsStaff();
            Int32 PrimaryKey = 0;


            tstItem.StaffRole = "Manager";
            tstItem.StartingDate = DateTime.Now.Date;
            tstItem.Salary = 10;
            tstItem.isEmployed = true;

            AllStaff.ThisStaff = tstItem;
            PrimaryKey = AllStaff.Add();


            tstItem.StaffRole = "Technician";
            tstItem.StartingDate = DateTime.Now.Date;
            tstItem.Salary = 13;
            tstItem.isEmployed = false;

            AllStaff.ThisStaff = tstItem;
            AllStaff.Update();
            AllStaff.ThisStaff.Find(PrimaryKey);

            Assert.AreEqual(AllStaff.ThisStaff, tstItem);

        }


        [TestMethod]

        public void FilterBySalaryMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.FilterBySalary(0);
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }

        [TestMethod]

        public void FilterBySalaryNotFound()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.FilterBySalary(1000);
            Assert.AreEqual(3, FilteredStaff.Count);
        }

        [TestMethod]

        public void FilterBySalaryDataFound()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.FilterBySalary(100);
            Assert.AreEqual(1, FilteredStaff.Count);
        }



        }
    }

