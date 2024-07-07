using System.Data;
using System;
using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;

namespace OSSSM_1.Models
{
    public class Patient
    {
        public int Patient_ID { get; set; }
        public DateTime Patient_DateofBirth { get; set; }
        public DateTime Patient_Checkin { get; set; }
        public DateTime Patient_Checkout { get; set; }
        public string Patient_Name { get; set; }
        public string Patient_Symptom { get; set; }
        public string Patient_Disease {  get; set; }
        public int Patient_Gender { get; set; }
        public int Patient_Status { get; set; }
        public int FK_Staff_Receiver { get; set; }
        public int FK_Staff_Main { get; set; }
        public int FK_Room_ID { get; set; }
        public int FK_Finace {  get; set; }

        public Patient ()
        {
            this.Patient_ID = -1;
        }

        public Patient(int id, int finance, string name, string disease, int pgender , int pstatus,  string symptom, DateTime checkin, DateTime checkout, DateTime patientbirthday, int receiver, int roomid, int staffmain)
        {
            this.Patient_ID = id;
            this.Patient_DateofBirth = patientbirthday;
            this.Patient_Checkin = checkin;
            this.Patient_Checkout = checkout;
            this.Patient_Name = name;
            this.Patient_Symptom = symptom;
            this.Patient_Disease = disease;
            this.Patient_Gender = pgender;
            this.Patient_Status = pstatus;
            this.FK_Staff_Receiver = receiver;
            this.FK_Staff_Main = staffmain;
            this.FK_Room_ID = roomid;
            this.FK_Finace = finance;
        }
        public Patient(DataRow row)
        {
            this.Patient_ID = (int)row["Patient_ID"];
            this.Patient_DateofBirth = (DateTime)row["Patient_DateofBirth"];
            this.Patient_Checkin = (DateTime)row["Patient_Checkin"];
            this.Patient_Checkout = row.IsNull("Patient_Checkout") ? DateTime.MinValue : (DateTime)row["Patient_Checkout"];
            this.Patient_Name = (string)row["Patient_Name"];
            this.Patient_Symptom = (string)row["Patient_Symtom"];
            this.Patient_Disease = (string)row["Patient_Disease"];
            this.Patient_Gender = (int)row["Patient_Gender"];
            this.Patient_Status = row.IsNull("Patient_Status") ? -1 : (int)row["Patient_Status"];
            this.FK_Staff_Receiver = row.IsNull("FK_Staff_Receiver") ? -1 : (int)row["FK_Staff_Receiver"];
            this.FK_Staff_Main = row.IsNull("FK_Staff_Main") ? -1: (int)row["FK_Staff_Main"];
            this.FK_Room_ID = row.IsNull("FK_Room_ID") ? -1 : (int)row["FK_Room_ID"];
            this.FK_Finace = row.IsNull("FK_Finace") ? -1: (int)row["FK_Finace"];
            
        }
    }
}
