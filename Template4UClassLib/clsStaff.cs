namespace Template4UTesting
{
	public void Delete(int StaffID) 
	{
		clsDataConnection DB = new clsDataConnection();
		DB.AddParameter("@StaffID", StaffID);
		DB.Execute("sproc_tblStaff_Delete");
	}
}
