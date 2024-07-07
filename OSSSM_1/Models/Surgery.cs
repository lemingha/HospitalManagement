using System.Data;
using System;
using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;

namespace OSSSM_1.Models
{
    public class Surgery
    {
        public int Surgery_ID { get; set; }
        public DateTime Surgery_Time { get; set; }
        public int Surgery_Status { get; set; }
        public int FK_Patient_ID { get; set; }
        public int FK_Staff_Main { get; set; }
        public int FK_Room_ID { get; set; }
        public Surgery ()
        {
            this.Surgery_ID = -1;
            this.Surgery_Time = DateTime.MinValue;
            this.Surgery_Status = -1;
        }
        public Surgery(int surid, DateTime surtime, int surstatus, int id, int staffmain, int roomid)
        {
            this.Surgery_ID = surid;
            this.Surgery_Time = surtime;
            this.Surgery_Status = surstatus;
            this.FK_Patient_ID = id;
            this.FK_Staff_Main = staffmain;
            this.FK_Room_ID = roomid;
        }
        public Surgery(DataRow row)
        {
            this.Surgery_ID = (int)row["Surgery_ID"];
            this.Surgery_Time = (DateTime)row["Surgery_Time"];
            this.Surgery_Status = row.IsNull("Surgery_Status") ? -1 : (int)row["Surgery_Status"];
            this.FK_Patient_ID = (int)row["FK_Patient_ID"];
            this.FK_Staff_Main = (int)row["FK_Staff_Main"];
            this.FK_Room_ID = (int)row["FK_Room_ID"];
        }
    }
}

