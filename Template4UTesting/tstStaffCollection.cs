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
    }
}
