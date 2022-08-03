// See https://aka.ms/new-console-template for more information
//using CS_Gen_App.Models;
//using CS_Gen_App.Entities;
Console.WriteLine("Hello, World!");
//DoctorLogic logic = new DoctorLogic();
Doctor doctor = new Doctor();
IDbOperations<Doctor, int> logic = new DoctorLogic();

Nurse nurse = new Nurse();
IDbOperations<Nurse, int> logic1 = new NurseLogic();

Driver driver = new Driver();
IDbOperations<Driver, int> logic2 = new DriverLogic();

Hsearch search = new Hsearch();
EventListner listner = new EventListner(logic);
EventListner listner1 = new EventListner(logic1);
EventListner listner2 = new EventListner(logic2);


Doctor doc1 = new Doctor() { StaffId = 1, StaffName = "Divyansh", Email = "divyansh@Movie.com", contactno = 998899, Education = "M.B.B.S", ShiftStartTime = 8, ShiftEndTime = 20, DeptName = "Cancer", Staffcategory = "doctor", Location = "pune", Specilization = "cancer" };
logic.Create(doc1.StaffId, doc1);
Doctor doc2 = new Doctor() { StaffId = 2, StaffName = "omkar", Email = "omkar@Movie.com", contactno = 997799, Education = "B.A.M.S", ShiftStartTime = 7, ShiftEndTime = 19, DeptName = "Heart", Staffcategory = "doctor", Location = "mumbai", Specilization = "cancer" };
logic.Create(doc2.StaffId, doc2);
Doctor doc3 = new Doctor() { StaffId = 3, StaffName = "rahul", Email = "rahul@Movie.com", contactno = 996699, Education = "B.A.M.S", ShiftStartTime = 8, ShiftEndTime = 20, DeptName = "Heart", Staffcategory = "doctor", Location = "pune", Specilization = "cancer" };
logic.Create(doc3.StaffId, doc3);
Doctor doc4 = new Doctor() { StaffId = 4, StaffName = "vivek", Email = "vivek@Movie.com", contactno = 995599, Education = "B.H.M.S", ShiftStartTime = 9, ShiftEndTime = 21, DeptName = "Cancer", Staffcategory = "doctor", Location = "chennai", Specilization = "cancer" };
logic.Create(doc4.StaffId, doc4);
Doctor doc5 = new Doctor() { StaffId = 5, StaffName = "omkar", Email = "omkar@Movie.com", contactno = 994499, Education = "M.B.B.S", ShiftStartTime = 10, ShiftEndTime = 22, DeptName = "eye", Staffcategory = "doctor", Location = "pune", Specilization = "cancer" };
logic.Create(doc5.StaffId, doc5);
Doctor doc6 = new Doctor() { StaffId = 6, StaffName = "anurag", Email = "anurag@Movie.com", contactno = 993399, Education = "M.B.B.S", ShiftStartTime = 9, ShiftEndTime = 21, DeptName = "Cancer", Staffcategory = "doctor", Location = "mumbai", Specilization = "cancer" };
logic.Create(doc6.StaffId, doc6);
Doctor doc7 = new Doctor() { StaffId = 7, StaffName = "rohan", Email = "rohan@Movie.com", contactno = 992299, Education = "B.H.M.S", ShiftStartTime = 10, ShiftEndTime = 22, DeptName = "eye", Staffcategory = "doctor", Location = "chennai", Specilization = "cancer" };
logic.Create(doc7.StaffId, doc7);
Doctor doc8 = new Doctor() { StaffId = 8, StaffName = "sachin", Email = "sachin@Movie.com", contactno = 991199, Education = "ssc", ShiftStartTime = 8, ShiftEndTime = 20, DeptName = "driving", Staffcategory = "doctor", Location = "pune", Specilization = "cancer" };
logic.Create(doc8.StaffId, doc8);
Nurse n1 = new Nurse() { StaffId = 1, StaffName = "Divyansh", Email = "divyansh@Movie.com", contactno = 998899, ShiftStartTime = 8, ShiftEndTime = 20, Staffcategory = "nurse", Location = "pune", Experience = 10, AssignedRoom= 101 };
logic1.Create(doc1.StaffId, n1);

string want_to_continue = "y";
do {
    Console.WriteLine("1.Enter new Record");
    Console.WriteLine("2.To get the details of all the staffs");
    Console.WriteLine("3.To update the details");
    Console.WriteLine("4.To delete the details");
    Console.WriteLine("5.To get the netIncome");
    Console.WriteLine("6.To search");
    Console.WriteLine("7.Search doctor by Education");
    Console.WriteLine("Enter your Choice");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice) {
        case 1:
            Console.WriteLine("Enter the staffcategory to register");
            string str = Console.ReadLine().ToLower();           
            if (str == "doctor")
            {
               
                Console.WriteLine("StaffId  StaffName  Email  ContactNo  ShiftStartTime  ShiftEndTime  StaffCategory  DeptName  Education  Speclization");
                Doctor d1 = new Doctor()
                {
                    StaffId = Convert.ToInt32(Console.ReadLine()),
                    StaffName = Console.ReadLine(),
                    Email = Console.ReadLine(),
                    contactno = Convert.ToInt32(Console.ReadLine()),
                    ShiftStartTime = Convert.ToInt32(Console.ReadLine()),
                    ShiftEndTime = Convert.ToInt32(Console.ReadLine()),
                    Staffcategory = Console.ReadLine(),
                    DeptName = Console.ReadLine(),
                    Education = Console.ReadLine(),
                    Specilization = Console.ReadLine()
                };
                logic.Create(d1.StaffId, d1);
            }
            else if (str == "nurse")
            {
                Console.WriteLine("StaffId  StaffName  Email  ContactNo  ShiftStartTime  ShiftEndTime  StaffCategory  Location  Experience  AssignedRoom");
                Nurse n1 = new Nurse()
                {
                    StaffId = Convert.ToInt32(Console.ReadLine()),
                    StaffName = Console.ReadLine(),
                    Email = Console.ReadLine(),
                    contactno = Convert.ToInt32(Console.ReadLine()),
                    ShiftStartTime = Convert.ToInt32(Console.ReadLine()),
                    ShiftEndTime = Convert.ToInt32(Console.ReadLine()),
                    Staffcategory = Console.ReadLine(),
                    Location = Console.ReadLine(),
                    DeptName = String.Empty,
                    Experience = Convert.ToInt32(Console.ReadLine()),
                    AssignedRoom = Convert.ToInt32(Console.ReadLine()),
                    
                };
                logic1.Create(n1.StaffId, n1);
            }
            else if (str == "driver")
            {
                Console.WriteLine("StaffId  StaffName  Email  ContactNo  ShiftStartTime  ShiftEndTime  StaffCategory  Location  VehicleType  Experience");
                Driver dr = new Driver()
                {
                    StaffId = Convert.ToInt32(Console.ReadLine()),
                    StaffName = Console.ReadLine(),
                    Email = Console.ReadLine(),
                    contactno = Convert.ToInt32(Console.ReadLine()),
                    ShiftStartTime = Convert.ToInt32(Console.ReadLine()),
                    ShiftEndTime = Convert.ToInt32(Console.ReadLine()),
                    Staffcategory = Console.ReadLine(),
                    Location = Console.ReadLine(),
                    DeptName = String.Empty,
                    VehicleType = Console.ReadLine(),
                    Experience = Convert.ToInt32(Console.ReadLine()),

                };
                logic2.Create(dr.StaffId, dr);
            }
            break;
       case 2:
            Console.WriteLine("Enter staffcategory to get the details");
            string str1 = Console.ReadLine().ToLower();
            var Staffs1 = logic.GetAll();
            var staffs2 = Staffs1.OrderBy(s => s.Value.StaffName);

            if (str1 == "doctor")
            {
                foreach (KeyValuePair<int, Staff> s in staffs2)
                {
                    if (Convert.ToString(s.Value.GetType()).Contains("Doctor"))
                    {
                        var a = (Doctor)s.Value;
                        Console.WriteLine($"{a.StaffId}  {a.StaffName}  {a.Email}  {a.contactno}  {a.ShiftStartTime}  {a.ShiftEndTime}  {a.Staffcategory}  {a.Location}  {a.DeptName}  {a.Education}  {a.Specilization} ");
                    }
                }
            }
            else if (str1 == "nurse")
            {
                foreach (KeyValuePair<int, Staff> s in staffs2)
                {
                    if (Convert.ToString(s.Value.GetType()).Contains("Nurse"))
                    {
                        var a = (Nurse)s.Value;
                        Console.WriteLine($"{a.StaffId}  {a.StaffName}  {a.Email}  {a.contactno}  {a.ShiftStartTime}  {a.ShiftEndTime}  {a.Staffcategory}  {a.Location}  {a.Experience}  {a.AssignedRoom}");
                        break;

                    }
                }
            }
            if (str1 == "driver")
            {
                foreach (KeyValuePair<int, Staff> s in staffs2)
                {
                    if (Convert.ToString(s.Value.GetType()).Contains("Driver"))
                    {
                        var a = (Driver)s.Value;
                        Console.WriteLine($"{a.StaffId}  {a.StaffName}  {a.Email}  {a.contactno}  {a.ShiftStartTime}  {a.ShiftEndTime}  {a.Staffcategory}  {a.Location}  {a.VehicleType}  {a.Experience}");
                        break;

                    }
                }
            }
            break;
        case 3:
            Console.WriteLine("Enter the staffdept");
            string str4 = Console.ReadLine().ToLower();
            if (str4 == "doctor")
            {
                Doctor d = new Doctor();
                Console.WriteLine("Enter key to be updated");
                int id4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("StaffName  Email  ContactNo  ShiftStartTime  ShiftEndTime  StaffCategory  Location  DeptNmae  Location  Education  Specilization");
                logic = new DoctorLogic();
                logic.Update(id4, d);
            }
            else if (str4 == "nurse")
            {
                Nurse n = new Nurse();
                Console.WriteLine("Enter key to be updated");
                int id4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("StaffName  Email  ContactNo  ShiftStartTime  ShiftEndTime  StaffCategory  Location  Experience  AssignedRoom");
                logic1 = new NurseLogic();
                logic1.Update(id4, n);
            }
            else if (str4 == "driver")
            {
                Driver dr = new Driver();
                Console.WriteLine("Enter key to be updated");
                int id4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("StaffName  Email  ContactNo  ShiftStartTime  ShiftEndTime  StaffCategory  Location  VwhicleType  Experience");
                logic2 = new DriverLogic();
                logic2.Update(id4, dr);
            }
            break;
        case 4:
            Console.WriteLine("Enter the staffdept");
            string str5 = Console.ReadLine().ToLower();
            if (str5 == "doctor")
            {
                Console.WriteLine("Enter the id to be deleted");
                int id5 = Convert.ToInt32(Console.ReadLine());
                logic = new DoctorLogic();
                logic.Delete(id5);
            }
            else if (str5 == "nurse")
                {
                    Console.WriteLine("Enter the id to be deleted");
                    int id5 = Convert.ToInt32(Console.ReadLine());
                    logic1 = new NurseLogic();
                    logic1.Delete(id5);
            }
            else if (str5 == "driver")
            {
                Console.WriteLine("Enter the id to be deleted");
                int id5 = Convert.ToInt32(Console.ReadLine());
                logic2 = new DriverLogic();
                logic2.Delete(id5);
            }
            break;
        case 5:
            Console.WriteLine("Enter the staffdept");
            string str6 = Console.ReadLine().ToLower();

            if (str6 == "doctor")
            {
                Console.WriteLine("Enter the StaffId");
                int id6 = Convert.ToInt32(Console.ReadLine());
                var staffs = logic.GetAll();
                foreach (var v in staffs)
                {
                    if (v.Value.StaffId == id6 && v.Value.Staffcategory == str6)
                    {
                        Console.WriteLine("Enter Patientsdiagnoesd");
                        int patientsdiagnosed = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter operations per day");
                        int operations_per_day = Convert.ToInt32(Console.ReadLine());
                        StaffLogicAbstract staff = new DoctorLogicEx(id6, patientsdiagnosed, operations_per_day);
                        Account accounts = new Account();
                        Console.Clear();
                        Console.WriteLine($"{v.Value.StaffId}");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine($"{v.Value.StaffName}");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Income Details");
                        Console.WriteLine("=====================================================");
                        Console.WriteLine($"Gross Income = \t \t \t \t \t{accounts.GrossInsome(staff)}");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine($"HospitalShare = \t \t \t \t \t{accounts.HospitalShare(staff)}");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine($"HospitalShare = \t \t \t \t \t{accounts.GetTax(staff)}");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine($"HospitalShare = \t \t \t \t \t{accounts.GetStaffIncome(staff)}");

                    }
                    else {
                        Console.WriteLine("Inavlid Id or StaffCategory");
                    }
                }

            }
            else if (str6 == "nurse")
            {
                    Console.WriteLine("Enter the StaffId");
                    int id6 = Convert.ToInt32(Console.ReadLine());
                    var staffs = logic.GetAll();
                    foreach (var v in staffs)
                    {
                        if (v.Value.StaffId == id6 && v.Value.Staffcategory == str6)
                        {
                            Console.WriteLine("Enter the InjectionApplied");
                            int injection_applied = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the PatientsMonitored");
                            int patients_monitored = Convert.ToInt32(Console.ReadLine());

                            StaffLogicAbstract staff = new NurseLogicEx(id6, injection_applied, patients_monitored);
                            Account accounts = new Account();
                            Console.Clear();
                            Console.WriteLine($"{v.Value.StaffId}");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine($"{v.Value.StaffName}");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Income Details");
                            Console.WriteLine("================================================");
                            Console.WriteLine($"Gross Income = {accounts.GrossInsome(staff)}");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine($"HospitalShare = {accounts.HospitalShare(staff)}");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine($"Tax = {accounts.GetTax(staff)}");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine($"NetIncome = {accounts.GetStaffIncome(staff)}");
                            Console.ReadLine();

                        }
                        else
                        {
                            Console.WriteLine("Inavlid Id or StaffCategory");
                        }
                    }

            }
            else if (str6 == "driver")
            {
                Console.WriteLine("Enter the StaffId");
                int id6 = Convert.ToInt32(Console.ReadLine());
                var staffs = logic.GetAll();
                foreach (var v in staffs)
                {
                    if (v.Value.StaffId == id6 && v.Value.Staffcategory == str6)
                    {
                        Console.WriteLine("Enter the No of working Days");
                        int no_of_days = Convert.ToInt32(Console.ReadLine());

                        StaffLogicAbstract staff = new DriverLogicEx(id6, no_of_days);
                        Account accounts = new Account();
                        Console.Clear();
                        Console.WriteLine($"{v.Value.StaffId}");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine($"{v.Value.StaffName}");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Income Details");
                        Console.WriteLine("================================================");
                        Console.WriteLine($"Gross Income = {accounts.GrossInsome(staff)}");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine($"HospitalShare = {accounts.HospitalShare(staff)}");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine($"HospitalShare = {accounts.GetTax(staff)}");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine($"HospitalShare = {accounts.GetStaffIncome(staff)}");
                        Console.ReadLine();

                    }
                    else
                    {
                        Console.WriteLine("Inavlid Id or StaffCategory");
                    }
                }

            }
            break;
        case 6:
            Console.WriteLine("Enter the StaffCategory to search");
            string str2 = Console.ReadLine().ToLower();
            Console.WriteLine("search by id/name/location");
            string searchop = Console.ReadLine().ToLower();
            var staffs1 = logic.GetAll();
            if (str2 == "doctor" && searchop == "id")
            {
                bool flag = false;
                Console.WriteLine("Enter Id");
                int id2 = Convert.ToInt32(Console.ReadLine());
                foreach (var v in staffs1)
                {
                    if (v.Value.Staffcategory == "doctor")
                    {
                        flag = true;
                    }
                }
                if (flag)
                {
                    var s = search.searchbyId(id2);
                    foreach (var res in s)
                    {
                        Console.Write(res + " ");

                    }
                }
            }
            else if (str2 == "doctor" && searchop == "name") {
                bool flag = false;
                Console.WriteLine("Enter StaffName");
                string staff_name = Console.ReadLine().ToLower();
                foreach (var v in staffs1)
                {
                    if (v.Value.Staffcategory == "doctor")
                    {
                        flag = true;
                    }
                }
                if (flag)
                {
                    var s = search.searchbyname(staff_name);
                    foreach (var res in s)
                    {
                        Console.Write(res + " ");

                    }
                }
            }
            else if (str2 == "doctor" && searchop == "location") {
                bool flag = false;
                Console.WriteLine("Enter Location");
                string loc = Console.ReadLine().ToLower();
                foreach (var v in staffs1)
                {
                    if (v.Value.Staffcategory == "doctor")
                    {
                        flag = true;
                    }
                }
                if (flag) {
                    var s = search.searchbylocation(loc);
                    foreach (var res in s)
                    {
                        Console.Write(res + " ");

                    }
                }
            }
            if (str2 == "nurse" && searchop == "id")
            {
                bool flag = false;
                Console.WriteLine("Enter Id");
                int id2 = Convert.ToInt32(Console.ReadLine());
                foreach (var v in staffs1)
                {
                    if (v.Value.Staffcategory == "nurse")
                    {
                        flag = true;  
                    }
                }
                if (flag) {
                    var s = search.searchbyId(id2);
                    foreach (var res in s)
                    {
                        Console.Write(res + " ");

                    }
                }
            }
            else if (str2 == "nurse" && searchop == "name")
            {
                bool flag = false;
                Console.WriteLine("Enter StaffName");
                string staff_name = Console.ReadLine().ToLower();
                foreach (var v in staffs1)
                {
                    if (v.Value.Staffcategory == "nurse")
                    {
                        flag = true;
                    }
                    if (flag) {
                        var s = search.searchbyname(staff_name);
                        foreach (var res in s)
                        {
                            Console.Write(res + " ");

                        }
                    }
                }
            }
            else if (str2 == "nurse" && searchop == "location")
            {
                bool flag = false;
                Console.WriteLine("Enter Location");
                string loc = Console.ReadLine().ToLower();
                foreach (var v in staffs1)
                {
                    if (v.Value.Staffcategory == "nurse")
                    {
                        flag = true;
                    }
                }
                if (flag) {
                    var s = search.searchbylocation(loc);
                    foreach (var res in s)
                    {
                        Console.Write(res + " ");

                    }
                }
            }
            if (str2 == "driver" && searchop == "id")
            {
                bool flag = false;
                Console.WriteLine("Enter Id");
                int id2 = Convert.ToInt32(Console.ReadLine());
                foreach (var v in staffs1)
                {
                    if (v.Value.Staffcategory == "driver")
                    {
                        flag = true;
                    }
                }
                if (flag) {
                    var s = search.searchbyId(id2);
                    foreach (var res in s)
                    {
                        Console.Write(res + " ");
                        ;
                    }
                }
            }
            else if (str2 == "driver" && searchop == "name")
            {
                bool flag = false;
                Console.WriteLine("Enter StaffName");
                string staff_name = Console.ReadLine().ToLower();
                foreach(var v in staffs1)
                {
                    if (v.Value.Staffcategory == "driver")
                    {
                        flag = true;
                    }
                }
                if (flag)
                {
                    var s = search.searchbyname(staff_name);
                    foreach (var res in s)
                    {
                        Console.Write(res + " ");
                        ;
                    }
                }
            }
            else if (str2 == "driver" && searchop == "location")
            {
                bool flag = false;
                Console.WriteLine("Enter Location");
                string loc = Console.ReadLine().ToLower();
               foreach(var v in staffs1)
                {
                    if (v.Value.Staffcategory == "driver")
                    {
                        flag = true;
                    }
                }
                if (flag)
                {
                    var s = search.searchbylocation(loc);
                    foreach (var res in s)
                    {
                        Console.Write(res + " ");
                        
                    }
                }
            }

            break;
    }
} while (want_to_continue == "y" || want_to_continue == "Y");








