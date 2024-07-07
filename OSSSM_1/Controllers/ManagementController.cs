using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Data;
using System.Threading.Tasks;
using OSSSM_1.Models;
using OSSSM_1.DAO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using DocumentFormat.OpenXml.Drawing;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;
using System.Reflection.Metadata;
using System.Collections;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;

namespace OSSSM_1.Controllers
{
    public class ManagementController : Controller
    {

        public IActionResult Index()
        {
            return RedirectToAction("Overview");
        }
        // Quản lý sản phẩm
        public IActionResult Patient()
        {
            // Khởi tạo
            String field;
            String sortOrder;
            String searchField;
            String searchString;
            String page;

            /// Lấy query, không có => đặt mặc định
            var urlQuery = Request.HttpContext.Request.Query; // Url: .../Member?Sort={sortOrder}&searchField={searchField}...
            // Update số hàng tồn
            field = urlQuery["field"];
            sortOrder = urlQuery["sort"];
            searchField = urlQuery["searchField"];
            searchString = urlQuery["SearchString"];
            page = urlQuery["page"];
            field = field == null ? "All" : field;

            sortOrder = sortOrder == null ? "Name" : sortOrder; ;
            searchField = searchField == null ? "Patient_Name" : searchField;
            searchString = searchString == null ? "" : searchString;
            page = page == null ? "1" : page;
            int currentPage = Convert.ToInt32(page);

            ItemDisplay<Patient> PatientList = new ItemDisplay<Patient>();
            PatientList.SortOrder = sortOrder;
            PatientList.CurrentSearchField = searchField;
            PatientList.CurrentSearchString = searchString;
            PatientList.CurrentPage = currentPage;


            List<Patient> Patient;
            Patient = DataProvider<Patient>.Instance.GetListItem("Patient_Status", 1, "tbl_Patient"); // Hiển thị bệnh nhân còn trong viện
            Patient = Function.Instance.searchItems(Patient, PatientList);
            Patient = Function.Instance.sortItems(Patient, PatientList.SortOrder);
            PatientList.Paging(Patient, 10);

            if (PatientList.PageCount > 0)
            {
                if (PatientList.CurrentPage > PatientList.PageCount) PatientList.CurrentPage = PatientList.PageCount;
                if (PatientList.CurrentPage < 1) PatientList.CurrentPage = 1;
                if (PatientList.CurrentPage != PatientList.PageCount)
                    try
                    {
                        PatientList.Items = PatientList.Items.GetRange((PatientList.CurrentPage - 1) * PatientList.PageSize, PatientList.PageSize);
                    }
                    catch { }

                else
                    PatientList.Items = PatientList.Items.GetRange((PatientList.CurrentPage - 1) * PatientList.PageSize, PatientList.Items.Count % PatientList.PageSize == 0 ? PatientList.PageSize : PatientList.Items.Count % PatientList.PageSize);
            }
            
            return View("~/Views/Shared/Patient.cshtml", PatientList);
        }
        [HttpPost]
        public IActionResult Patient(String sortOrder, String searchString, String searchField, int currentPage = 1)
        {
            return RedirectToAction("Patient", new { sort = sortOrder, searchField = searchField, searchString = searchString, page = currentPage });
        }
        public IActionResult Patient_Add()
        {            
            return View("~/Views/Shared/Patient_Add.cshtml");
        }
        [HttpPost]
        public IActionResult Patient_Add (string pname, string Pbirthday, int pgender, string paddress, int pphonenumber, int pID, string symtom, string disease, string Checkintime ) 
        {

            // Chuyen kieu datetime
            DateTime pbirthday = new DateTime();
            pbirthday = DateTime.Parse(Pbirthday);
            string patientbirthday = pbirthday.ToString("yyyy-MM-dd HH:mm:ss");


            DateTime checkintime = new DateTime ();
            checkintime = DateTime.Parse(Checkintime);
            string checkin = checkintime.ToString("yyyy-MM-dd HH:mm:ss");
            
            string query = String.Format ("Insert into dbo.tbl_Patient (Patient_Name, Patient_DateofBirth, Patient_Gender, Patient_Address, Patient_Phone, Patient_ID, Patient_Symtom, Patient_Disease, Patient_Checkin, Patient_Status)"
                + "values(N'{0}','{1}', {2}, N'{3}', {4}, {5}, N'{6}', N'{7}', '{8}', 1 )", pname, patientbirthday, pgender, paddress, pphonenumber, pID, symtom, disease, checkin);
            DataProvider<Patient>.Instance.ExcuteQuery(query);
            return RedirectToAction("Patient");
        }
        public IActionResult DeletePatient()
        {
            var urlQuery = Request.HttpContext.Request.Query;
            string patient_id_delete = urlQuery["patient_id"];
            DataProvider<Patient>.Instance.ExcuteQuery (String.Format ("Update dbo.tbl_Patient set Patient_Status = -1 where Patient_ID = {0}", patient_id_delete));
            return RedirectToAction("Patient");
        }
        public IActionResult Patient_Save ()
        {
            return View("~/Views/Shared/Patient_Save.cshtml");
        }
       
        // Hiển thị nội dung chi tiết sản phẩm
        /*public IActionResult PatientDetail()
        {
            var urlQuery = Request.HttpContext.Request.Query;
            string ID = urlQuery["Patient_id"];
            Patient Patient;
            
            Patient = DataProvider<Patient>.Instance.GetItem("Patient_ID",ID,"Patient");
            return View("~/Views/Shared/PatientDetail.cshtml", Patient);
        }
        // Sửa thông tín sản phẩm
        [HttpPost]
        public IActionResult EditPatient( string name, int cost, int price, string image, string text, int quanity, string category)
        {
            var urlQuery = Request.HttpContext.Request.Query;
            String CurrentID = urlQuery["ID"];
            String Image= urlQuery["image"];

            var Patient = new Patient(CurrentID, name, cost, price, Image, text, quanity, category); 
         
            PatientDAO.Instance.EditPatient(Patient);

            return RedirectToAction("Patient");
        }
        [HttpPost]
        public virtual IActionResult UploadImg(string var, string id, IFormFile file, [FromServices] IWebHostEnvironment hostingEnvironment)
        {
            string fileName = $"{hostingEnvironment.WebRootPath}/img/Patient/{file.FileName}";
            // Dẩy file vào thư mục
            using (FileStream fileStream = System.IO.File.Create(fileName))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }
            TempData["img"] = file.FileName; // Lưu tên vào TempData => Lưu vào Excel
            if (var == "edit")
                return RedirectToAction("PatientDetail", new { image = file.FileName,ID = id});
            else
            {
                return RedirectToAction("AddPatient", new { image = file.FileName });
            }
        }
        */
        // Thông tin bác sĩ
        public IActionResult Staff()
        {
            // Khởi tạo
            String field;
            String sortOrder;
            String searchField;
            String searchString;
            String page;

            /// Lấy query, không có => đặt mặc định
            var urlQuery = Request.HttpContext.Request.Query; // Url: .../Member?Sort={sortOrder}&searchField={searchField}...
                                                              // Update số hàng tồn
            field = urlQuery["field"];
            sortOrder = urlQuery["sort"];
            searchField = urlQuery["searchField"];
            searchString = urlQuery["SearchString"];
            page = urlQuery["page"];
            field = field == null ? "All" : field;

            sortOrder = sortOrder == null ? "Name" : sortOrder; ;
            searchField = searchField == null ? "Staff_Name" : searchField;
            searchString = searchString == null ? "" : searchString;
            page = page == null ? "1" : page;
            int currentPage = Convert.ToInt32(page);

            ItemDisplay<Staff> StaffList = new ItemDisplay<Staff>();
            StaffList.SortOrder = sortOrder;
            StaffList.CurrentSearchField = searchField;
            StaffList.CurrentSearchString = searchString;
            StaffList.CurrentPage = currentPage;


            List<Staff> Staff;
            Staff = DataProvider<Staff>.Instance.GetListItem("Staff_Status", 1, "tbl_Staff");
            Staff = Function.Instance.searchItems(Staff, StaffList);
            Staff = Function.Instance.sortItems(Staff, StaffList.SortOrder);
            StaffList.Paging(Staff, 10);

            if (StaffList.PageCount > 0)
            {
                if (StaffList.CurrentPage > StaffList.PageCount) StaffList.CurrentPage = StaffList.PageCount;
                if (StaffList.CurrentPage < 1) StaffList.CurrentPage = 1;
                if (StaffList.CurrentPage != StaffList.PageCount)
                    try
                    {
                        StaffList.Items = StaffList.Items.GetRange((StaffList.CurrentPage - 1) * StaffList.PageSize, StaffList.PageSize);
                    }
                    catch { }

                else
                    StaffList.Items = StaffList.Items.GetRange((StaffList.CurrentPage - 1) * StaffList.PageSize, StaffList.Items.Count % StaffList.PageSize == 0 ? StaffList.PageSize : StaffList.Items.Count % StaffList.PageSize);
            }
            return View("~/Views/Shared/Staff.cshtml", StaffList);
        }
        [HttpPost]
        public IActionResult Staff(String sortOrder, String searchString, String searchField, int currentPage = 1)
        {
            return RedirectToAction("Staff", new { sort = sortOrder, searchField = searchField, searchString = searchString, page = currentPage });
        }
        public IActionResult Staff_Add()
        {
            return View("~/Views/Shared/Staff_Add.cshtml");
        }
        public IActionResult DeleteStaff()
        {
            var urlQuery = Request.HttpContext.Request.Query;
            string staff_id_delete = urlQuery["staff_id"];
            DataProvider<Staff>.Instance.ExcuteQuery(String.Format("Update dbo.tbl_Staff set Staff_Status = -1 where Staff_ID = {0}", staff_id_delete));
            return RedirectToAction("Staff");
        } 
        [HttpPost]
        public IActionResult Staff_Add(string sname, string Sbirthday, int sgender, int sphone, int sID, int position)
        {
            DateTime staffbirthday = new DateTime();
            staffbirthday = DateTime.Parse(Sbirthday);
            string sbirthday = staffbirthday.ToString("yyyy-MM-dd HH:mm:ss");

            string query = String.Format("Insert into dbo.tbl_Staff(Staff_Name, Staff_DateofBirth, Staff_Gender, Staff_Phone, Staff_ID, Staff_Position, Staff_Status) " +
                "values(N'{0}','{1}', {2}, {3}, {4}, {5}, 1 )", sname, sbirthday, sgender, sphone, sID, position);
            DataProvider<Staff>.Instance.ExcuteQuery(query);
            return RedirectToAction("Staff");
        }
        public IActionResult Room()
        {
            String field;
            String sortOrder;
            String searchField;
            String searchString;
            String page;
            var urlQuery = Request.HttpContext.Request.Query;
            field = urlQuery["field"];
            sortOrder = urlQuery["sort"];
            searchField = urlQuery["searchField"];
            searchString = urlQuery["SearchString"];
            page = urlQuery["page"];
            field = field == null ? "All" : field;

            sortOrder = sortOrder == null ? "Name" : sortOrder; ;
            searchField = searchField == null ? "Room_ID" : searchField;
            searchString = searchString == null ? "" : searchString;
            page = page == null ? "1" : page;
            int currentPage = Convert.ToInt32(page);


            List<RoomDetail> surgery_Room_List = new List<RoomDetail>(); // Bây giờ ta muốn truyền vào cái model bọc cả 2 thằng
            List<Room> roomList = DAO.DataProvider<Room>.Instance.GetListItem("tbl_Room"); // Lấy ra danh sách Room
            // Thêm từng thằng trong danh sách Room vào model bọc
            foreach (Room room in roomList)
            {
                
                // Với mỗi thằng Room có ID nào đó, ta sẽ thêm vào list 1 thằng Surgery tương ứng
                Surgery surgery = DAO.DataProvider<Surgery>.Instance.GetItem ("FK_Room_ID", room.Room_ID, "tbl_Surgery");
                Staff staff = new Staff();
                // Lấy ra thằng Staff có ID là FK_Staff_Main
                if (surgery != null)
                {
                    staff = DAO.DataProvider<Staff>.Instance.GetItem("Staff_ID", surgery.FK_Staff_Main, "tbl_Staff");

                }
                RoomDetail surgeryRoom = new RoomDetail();
                if (surgery != null && staff != null)
                {
                    surgeryRoom.room = room;
                    surgeryRoom.staff = staff;
                    surgeryRoom.surgery = surgery;
                }
                else
                {
                    Surgery surgeryNull = new Surgery();
                    Staff staffNull = new Staff();
                    surgeryRoom.room = room;
                    surgeryRoom.staff = staffNull;
                    surgeryRoom.surgery = surgeryNull;

                }

                surgery_Room_List.Add(surgeryRoom);
            }

            ItemDisplay<RoomDetail> RoomList = new ItemDisplay<RoomDetail>();
            RoomList.SortOrder = sortOrder;
            RoomList.CurrentSearchField = searchField;
            RoomList.CurrentSearchString = searchString;
            RoomList.CurrentPage = currentPage;

            RoomList.Paging(surgery_Room_List, 10);

            if (RoomList.PageCount > 0)
            {
                if (RoomList.CurrentPage > RoomList.PageCount) RoomList.CurrentPage = RoomList.PageCount;
                if (RoomList.CurrentPage < 1) RoomList.CurrentPage = 1;
                if (RoomList.CurrentPage != RoomList.PageCount)
                    try
                    {
                        RoomList.Items = RoomList.Items.GetRange((RoomList.CurrentPage - 1) * RoomList.PageSize, RoomList.PageSize);
                    }
                    catch { }

                else
                    RoomList.Items = RoomList.Items.GetRange((RoomList.CurrentPage - 1) * RoomList.PageSize, RoomList.Items.Count % RoomList.PageSize == 0 ? RoomList.PageSize : RoomList.Items.Count % RoomList.PageSize);
            }
            return View("~/Views/Shared/Room.cshtml", RoomList);
        }
        [HttpPost]
        public IActionResult Room(String sortOrder, String searchString, String searchField, int currentPage = 1)
        {
            return RedirectToAction("Room", new { sort = sortOrder, searchField = searchField, searchString = searchString, page = currentPage });
        }
        public IActionResult Room_Add()
        {
            return View("~/Views/Shared/Room_Add.cshtml");
        }
        [HttpPost]
        public IActionResult Room_Add(int roomid, int roomtype)
        {
            string query = String.Format("Insert into dbo.tbl_Room(Room_ID, Room_Type) " +
                "values({0},{1})", roomid, roomtype );
            DataProvider<Room>.Instance.ExcuteQuery(query);
            return View("~/Views/Shared/Room_Add.cshtml");
        }
        public IActionResult Room_Setting()
        {
            return View("~/Views/Shared/Room_Setting.cshtml");
        }
        public IActionResult Overview()
        {
            int sum_patient = 0;
            List<Patient> patient = DataProvider<Patient>.Instance.GetListItem("tbl_Patient");
            foreach (Patient item in patient)
            {
                sum_patient += 1;
            }
            int sum_room = 0;
            List<Room> room = DataProvider<Room>.Instance.GetListItem("tbl_Room");
            foreach (Room item in room)
            {
                sum_room += 1;
            }
            int sum_staff = 0;
            List<Staff> staff = DataProvider<Staff>.Instance.GetListItem("tbl_Staff");
            foreach (Staff item in staff)
            {
                sum_staff += 1;
            }
            Overview overviews = new Overview();
            overviews.total_staff = sum_staff;
            overviews.total_room = sum_room;
            overviews.total_patient = sum_patient; 

            return View("~/Views/Shared/Overview.cshtml", overviews);
        }


            public IActionResult Calender ()
        {
            String field;
            String sortOrder;
            String searchField;
            String searchString;
            String page;

            /// Lấy query, không có => đặt mặc định
            var urlQuery = Request.HttpContext.Request.Query; // Url: .../Member?Sort={sortOrder}&searchField={searchField}...
                                                              // Update số hàng tồn
            field = urlQuery["field"];
            sortOrder = urlQuery["sort"];
            searchField = urlQuery["searchField"];
            searchString = urlQuery["SearchString"];
            page = urlQuery["page"];
            field = field == null ? "All" : field;

            sortOrder = sortOrder == null ? "Name" : sortOrder; ;
            searchField = searchField == null ? "Patient_Name" : searchField;
            searchString = searchString == null ? "" : searchString;
            page = page == null ? "1" : page;
            int currentPage = Convert.ToInt32(page);

            ItemDisplay<Calender> CalenderList = new ItemDisplay<Calender>();
            CalenderList.SortOrder = sortOrder;
            CalenderList.CurrentSearchField = searchField;
            CalenderList.CurrentSearchString = searchString;
            CalenderList.CurrentPage = currentPage;


            List<Calender> Calender;
            Calender = DataProvider<Calender>.Instance.GetListItem("tbl_Surgery");

            Calender = Function.Instance.searchItems(Calender, CalenderList);
            Calender = Function.Instance.sortItems(Calender, CalenderList.SortOrder);

            CalenderList.Paging(Calender, 10);

            if (CalenderList.PageCount > 0)
            {
                if (CalenderList.CurrentPage > CalenderList.PageCount) CalenderList.CurrentPage = CalenderList.PageCount;
                if (CalenderList.CurrentPage < 1) CalenderList.CurrentPage = 1;
                if (CalenderList.CurrentPage != CalenderList.PageCount)
                    try
                    {
                        CalenderList.Items = CalenderList.Items.GetRange((CalenderList.CurrentPage - 1) * CalenderList.PageSize, CalenderList.PageSize);
                    }
                    catch { }

                else
                    CalenderList.Items = CalenderList.Items.GetRange((CalenderList.CurrentPage - 1) * CalenderList.PageSize, CalenderList.Items.Count % CalenderList.PageSize == 0 ? CalenderList.PageSize : CalenderList.Items.Count % CalenderList.PageSize);
            }

            return View("~/Views/Shared/Calender.cshtml", CalenderList ); // Truyền model vào
        }
        [HttpPost]
        public IActionResult Calender(String sortOrder, String searchString, String searchField, int currentPage = 1)
        {
            return RedirectToAction("Calender", new { sort = sortOrder, searchField = searchField, searchString = searchString, page = currentPage });
        }
    
        public IActionResult Calender_Add()
        {
            List<Patient> patients;
            patients = DataProvider<Patient>.Instance.GetListItem("Patient_Status", 1 ,"tbl_Patient");
            List<Staff> staffs;
            staffs = DataProvider<Staff>.Instance.GetListItem( "Staff_Status",1,"tbl_Staff");
            List<Room> rooms;
            rooms = DataProvider<Room>.Instance.GetListItem("tbl_Room");
            CalenderDetail calenderDetail = new CalenderDetail();
            calenderDetail.staffs = staffs;
            calenderDetail.patients = patients;
            calenderDetail.rooms = rooms;
           


            return View("~/Views/Shared/Calender_Add.cshtml",calenderDetail );
        }
        [HttpPost]
        public IActionResult Calender_Add(int surgeryID, int pID, int surmain, string surtime, int roomID)
        {
            List<Surgery> surgeries = DataProvider<Surgery>.Instance.GetListItem("tbl_Surgery");
            int max = 1;
            foreach (var item in surgeries)
            {

                if (item.Surgery_ID >= max)
                {
                    max = item.Surgery_ID;


                }
            }
            surgeryID = max + 1;
            DateTime time = new DateTime();
            time = DateTime.Parse(surtime);
            string surgerytime = time.ToString("yyyy-MM-dd HH:mm:ss");

            string query = String.Format("Insert into dbo.tbl_Surgery(Surgery_ID, FK_Patient_ID, Surgery_Time, FK_Staff_Main, FK_Room_ID) " +
            "values({0},{1}, '{2}', {3}, {4} )", surgeryID, pID, surgerytime, surmain, roomID);
            DataProvider<Staff>.Instance.ExcuteQuery(query);
            return RedirectToAction("Calender");
        }
        public IActionResult DeleteCalender()
        {
            var urlQuery = Request.HttpContext.Request.Query;
            string surgery_id_delete = urlQuery["surgery_id"];
            DataProvider<CalenderDetail>.Instance.DeleteItem("Surgery_ID", surgery_id_delete, "tbl_Surgery");
            return RedirectToAction("Calender");
        }
    }
}