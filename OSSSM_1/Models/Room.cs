using System.Data;
using System;
using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;

namespace OSSSM_1.Models
{
    public class Room
    {
        public int Room_ID { get; set; }
        public int Room_Type { get; set; }

        public Room()
        {
            Room_ID = -1;
            Room_Type = -1;
        }
        public Room(int roomid, int roomtype)
        {
            this.Room_ID = roomid;
            this.Room_Type = roomtype;  
        }
        public Room(DataRow row)
        {
            this.Room_ID = (int)row["Room_ID"];
            this.Room_Type = (int)row["Room_Type"];
        }
    }
}