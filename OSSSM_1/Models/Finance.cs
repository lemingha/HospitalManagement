using System.Data;
using System;
using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;

namespace OSSSM_1.Models
{
    public class Finance
    {
        public int Finace_ID { get; set; }
        public string Finace_Name { get; set; }
        public DateTime Finace_Date { get; set; }
        public string Finace_Type {  get; set; }
        public int Finace_Value {  get; set; }

        public Finance(int fiid, string finame, DateTime fidate, string fitype, int fivalue)
        {
            this.Finace_ID = fiid;
            this.Finace_Name = finame;
            this.Finace_Date = fidate;
            this.Finace_Type = fitype;
            this.Finace_Value = fivalue;
        }
        public Finance(DataRow row)
        {
            this.Finace_ID = (int)row["Finace_ID"];
            this.Finace_Name = (string)row["Finace_Name"];
            this.Finace_Date = (DateTime)row["Finace_Date"];
            this.Finace_Type = (string)row["Finace_Type"];
            this.Finace_Value = (int)row["Finace_Value"];
        }
    }
}
