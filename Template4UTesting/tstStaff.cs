using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Template4UClassLib;

namespace Template4UTesting
{
    [TestClass]
    public class tstStaff
    {
        String tstStaffID = "12";
        String tstStaffRole = "Manager";
        String tstStartingDate = DateTime.Now.Date.ToString();
        String tstSalary = "4";
        
        
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
            Int32 StaffID = 3;
            Found = AStaff.Find(StaffID);
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestStaffIDFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 3;
            Found = AStaff.Find(StaffID);
            if (AStaff.StaffID != 3)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestStaffRoleFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 3;
            Found = AStaff.Find(StaffID);
            if (AStaff.StaffRole != "tester")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestStartingDatefound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 3;
            Found = AStaff.Find(StaffID);
            if (AStaff.StartingDate != Convert.ToDateTime("20/04/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestSalaryFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 3;
            Found = AStaff.Find(StaffID);
            if(AStaff.Salary != 25)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ValidMethodOK()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            Error = AStaff.Valid(tstStaffRole, tstStartingDate, tstSalary);
            Assert.IsTrue(Error == "");
        }
    



        [TestMethod]
        public void StartingDateMinAndMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            DateTime Date = DateTime.Now.Date;
            tstStartingDate = Date.ToString();
            Error = AStaff.Valid(tstStaffRole, tstStartingDate, tstSalary);
            Assert.IsTrue(Error == "");
        }

        [TestMethod]
        public void StartingDateMinMinusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            DateTime Date = DateTime.Now.Date;
            Date = Date.AddDays(-1);
            tstStartingDate = Date.ToString();
            Error = AStaff.Valid(tstStaffRole, tstStartingDate, tstSalary);
            Assert.IsTrue(Error == "");
        }

        [TestMethod]
        public void StartingDateExtemeMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            DateTime Date = DateTime.Now.Date;
            Date = Date.AddDays(-1000);
            tstStartingDate = Date.ToString();
            Error = AStaff.Valid(tstStaffRole, tstStartingDate, tstSalary);
            Assert.IsTrue(Error == "");
        }

        [TestMethod]
        public void StartingDateMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            DateTime Date = DateTime.Now.Date;
            Date = Date.AddDays(1);
            tstStartingDate = Date.ToString();
            Error = AStaff.Valid( tstStaffRole, tstStartingDate, tstSalary);
            Assert.IsTrue(Error == "");
        }

        [TestMethod]
        public void StartingDateExtemeMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            DateTime Date = DateTime.Now.Date;
            Date = Date.AddDays(1000);
            tstStartingDate = Date.ToString();
            Error = AStaff.Valid(tstStaffRole, tstStartingDate, tstSalary);
            Assert.IsTrue(Error == "");
        }

        [TestMethod]

        public void StartingDateWrongType()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            tstStartingDate = "Today";
            Error = AStaff.Valid(tstStaffRole, tstStartingDate, tstSalary);
            Assert.IsTrue(Error == "");
        }

        [TestMethod]

        public void StartingDateEmpty()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            tstStartingDate = "";
            Error = AStaff.Valid(tstStaffRole, tstStartingDate, tstSalary);
            Assert.IsTrue(Error == "");
        }

        [TestMethod]

        public void SalaryEmpty()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            tstSalary = "";
            Error = AStaff.Valid(tstStaffRole, tstStartingDate, tstSalary);
            Assert.IsTrue(Error == "");
        }

        [TestMethod]

        public void StaffRoleEmpty()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            tstStaffRole = "";
            Error = AStaff.Valid(tstStaffRole, tstStartingDate, tstSalary);
            Assert.IsTrue(Error == "");
        }

        [TestMethod]

        public void SalaryMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            tstSalary = "1234567";
            Error = AStaff.Valid(tstStaffRole, tstStartingDate, tstSalary);
            Assert.IsTrue(Error == "");

        }

        [TestMethod]

        public void SalaryMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            tstSalary = "12345678";
            Error = AStaff.Valid(tstStaffRole, tstStartingDate, tstSalary);
            Assert.IsTrue(Error == "");

        }

        [TestMethod]

        public void SalaryExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            tstSalary = "1000000000000000000000000000000000";
            Error = AStaff.Valid(tstStaffRole, tstStartingDate, tstSalary);
            Assert.IsTrue(Error == "");

        }

        [TestMethod]

        public void StaffRoleMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            tstStaffRole = "handyman/designmans";
            Error = AStaff.Valid(tstStaffRole, tstStartingDate, tstSalary);
            Assert.IsTrue(Error == "");

        }

        [TestMethod]

        public void StaffRoleMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            tstStaffRole = "handyman/designmansa";
            Error = AStaff.Valid(tstStaffRole, tstStartingDate, tstSalary);
            Assert.IsTrue(Error == "");

        }

        [TestMethod]

        public void StaffRoleExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            tstStaffRole = "handyman/designmansaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaarwrw";
            Error = AStaff.Valid(tstStaffRole, tstStartingDate, tstSalary);
            Assert.IsTrue(Error == "");

        }






    }
}
