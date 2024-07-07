using System.Data;
using System;
using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;

namespace OSSSM_1.Models
{
    public class Staff
    {
        public int Staff_ID { get; set; }
        public DateTime Staff_DateofBirth { get; set; }
        public string Staff_Name { get; set; }
        public int Staff_Gender {  get; set; }
        public int Staff_Position { get; set; }
        public int Staff_Phone { get; set; }
        public int Staff_Status { get; set; }
        public int FK_Staff_Salary { get; set; }


        public Staff()
        {
            this.Staff_ID = -1;
            this.Staff_Gender = -1;
            this.Staff_Phone = -1;
            this.Staff_Position = -1;
            this.Staff_Name = "N/A";
            this.Staff_Status = -1;
            this.Staff_DateofBirth = DateTime.MinValue;
        }
        public Staff(int sID, int sphone, int salary,  string sname, int position, int sgender, int sstatus, DateTime sbirthday)
        {
            this.Staff_ID = sID;
            this.Staff_DateofBirth = sbirthday;
            this.Staff_Name = sname;
            this.Staff_Gender = sgender;
            this.Staff_Position = position;
            this.Staff_Phone = sphone;
            this.Staff_Status = sstatus;
            this.FK_Staff_Salary = salary;         
        }
        public Staff(DataRow row)
        {
            this.Staff_ID = (int)row["Staff_ID"];
            this.Staff_DateofBirth = (DateTime)row["Staff_DateofBirth"];
            this.Staff_Name = (string)row["Staff_Name"];
            this.Staff_Gender = (int)row["Staff_Gender"];
            this.Staff_Position = (int)row["Staff_Position"];
            this.Staff_Phone = (int)row["Staff_Phone"];
            this.Staff_Status = row.IsNull("Staff_Status") ? -1 : (int)row["Staff_Status"];
            this.FK_Staff_Salary = row.IsNull("FK_Staff_Salary") ? -1: (int)row["FK_Staff_Salary"];
        }
    }
}
