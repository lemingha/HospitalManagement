using System.Data;
using System;
using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;

namespace OSSSM_1.Models
{
    public class Calender
    {
        public int Surgery_ID { get; set; }
        public int FK_Patient_ID { get; set; }
        public DateTime Surgery_Time { get; set; }
        public int FK_Staff_Main { get; set; }
        public int FK_Room_ID { get; set; }


        public Calender(int sursid, int pname, DateTime surtime, int staffmain, int roomid)
        {
            this.Surgery_ID=sursid;
            this.FK_Patient_ID = pname;
            this.Surgery_Time = surtime;
            this.FK_Staff_Main = staffmain;
            this.FK_Room_ID = roomid;
        }
        public Calender(DataRow row)
        {
            this.Surgery_ID = (int)row["Surgery_ID"];
            this.FK_Patient_ID = (int)row["FK_Patient_ID"];
            this.Surgery_Time = (DateTime)row["Surgery_Time"];
            this.FK_Staff_Main = (int)row["FK_Staff_Main"];
            this.FK_Room_ID = (int)row["FK_Room_ID"];
        }
    }
}

