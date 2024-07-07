using Azure.Core;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Collections.Generic;

namespace OSSSM_1.Models
{
    public class RoomDetail
    {
        public Room room { get; set; } // Phòng
        public Surgery surgery { get; set; }// lịch mổ
        public Staff staff { get; set; }
        public RoomDetail() // Hàm khởi tạo, chuyền vào phòng và lịch mổ tương ứng
        {
            this.room = new Room();
            this.surgery = new Surgery();
            this.staff = new Staff();
        } 
        public RoomDetail(Room room, Surgery surgery, Staff staff) // Hàm khởi tạo, chuyền vào phòng và lịch mổ tương ứng
        {
            this.room = room;
            this.surgery = surgery;
            this.staff = staff;
        }

    }
}
