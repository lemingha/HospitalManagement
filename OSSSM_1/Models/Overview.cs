namespace OSSSM_1.Models
{
    public class Overview
    {
        public int total_room { get; set; } // Phòng
        public int total_patient { get; set; }// lịch mổ
        public int total_staff { get; set; }
        public Surgery status_surgery { get; set; }
        public Staff status_staff { get; set; }
        public Patient status_patient { get; set; }
        public Overview() // Hàm khởi tạo, chuyền vào phòng và lịch mổ tương ứng
        {
            this.total_room = 0;
            this.total_patient = 0;
            this.total_staff = 0;
            this.status_surgery = new Surgery();
            this.status_patient = new Patient();
            this.status_staff = new Staff();
        }
        public Overview (Patient status_patient, Staff status_staff, Surgery status_surgery)
        {
            this.status_patient = status_patient;
            this.status_staff = status_staff;
            this.status_surgery = status_surgery;
        }
    }
}
