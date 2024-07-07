using System.Collections.Generic;

namespace OSSSM_1.Models
{
    public class CalenderDetail
    {
        public List<Patient> patients { get; set; }
        public List<Room> rooms { get; set; }
        public List<Surgery> surgery { get; set; }
        public List<Staff> staffs { get; set; }
        
    }
}
