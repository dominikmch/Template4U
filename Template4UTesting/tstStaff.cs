using System;

/// <summary>
/// Test methods for the clsStaff
/// </summary>
[TestMethod]

	public InstanceOK()
	{
    clsReview review = new clsReview();
    Assert.IsNotNull(review);
	}

[TestMethod]

public StaffIDPropertyOK()
{
    clsStaff AStaff = new clsStaff();
    Int32 TestData = 1;
    AStaff.StaffID = TestData;
    Assert.AreEqual(AStaff.StaffID, TestData);
}

[TestMethod]

public StaffRolePropertyOK()
{
    clsStaff AStaff = new clsStaff();
    string TestData = "Manager";
    AStaff.StaffRole = TestData;
    Assert.AreEqual(AStaff.StaffID, TestData);
}

[TestMethod]

public StartingDatePropertyOK()
{
    clsStaff AStaff = new clsStaff();
    DateTime TestData = DateTime.Now.Date;
    AStaff.StartingDate = TestData;
    Assert.AreEqual(AStaff.StartingDate, TestData);
}

[TestMethod]

public SalaryPropertyOK()
{
    clsStaff AStaff = new clsStaff();
    double TestData = 0;
    AStaff.Salary = TestData;
    Assert.AreEqual(AStaff.Salary, TestData);
}

[TestMethod]

public isEmployedPropertyOK()
{
    clsStaff AStaff = new clsStaff();
    Boolean TestData = true;
    AStaff.isEmployed = TestData;
    Assert.AreEqual(AStaff.isEmployed, TestData);
}

[TestMethod]

public FindMethodOK()
{
    clsStaff AStaff = new clsStaff();
    Boolean Found = false;
    Int32 StaffID = 1;
    Found =  AStaff.Find(StaffID);
}



