using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Template4UTesting
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]

        public void InstanceOK()
        {
            clsStaff AStaff = new clsStaff();
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]

        public void StaffIDPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            Int32 TestData = 1;
            AStaff.StaffID = TestData;
            Assert.AreEqual(AStaff.StaffID, TestData);
        }

        [TestMethod]

        public void StaffRolePropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            string TestData = "Manager";
            AStaff.StaffRole = TestData;
            Assert.AreEqual(AStaff.StaffID, TestData);
        }

        [TestMethod]

        public void StartingDatePropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            AStaff.StartingDate = TestData;
            Assert.AreEqual(AStaff.StartingDate, TestData);
        }

        [TestMethod]

        public void SalaryPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            double TestData = 0;
            AStaff.Salary = TestData;
            Assert.AreEqual(AStaff.Salary, TestData);
        }

        [TestMethod]

        public void isEmployedPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            Boolean TestData = true;
            AStaff.isEmployed = TestData;
            Assert.AreEqual(AStaff.isEmployed, TestData);
        }


        [TestMethod]

        public void FindMethodOK()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Int32 StaffID = 1;
            Found = AStaff.Find(StaffID);
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestStaffIDFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 21;
            Found = AStaff.Find(StaffID);
            if (AStaff.StaffID != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

