using System;

namespace Template4UTesting
{
    internal class clsStaff
    {
        public clsStaff()
        {
        }

        public bool isEmployed { get; internal set; }
        public int StaffID { get; internal set; }
        public string StaffRole { get; internal set; }
        public DateTime StartingDate { get; internal set; }
        public double Salary { get; internal set; }
    }
}