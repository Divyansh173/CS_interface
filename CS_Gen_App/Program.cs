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
digittoword dg = new digittoword();
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
Nurse n1 = new Nurse() { StaffId = 9, StaffName = "riya", Email = "riya@Movie.com", contactno = 9988919, ShiftStartTime = 8, ShiftEndTime = 20, Staffcategory = "nurse", Location = "pune", Experience = 10, AssignedRoom = 101 };
logic1.Create(n1.StaffId, n1);
Nurse n2 = new Nurse() { StaffId = 10, StaffName = "diya", Email = "diya@Movie.com", contactno = 9988929, ShiftStartTime = 8, ShiftEndTime = 20, Staffcategory = "nurse", Location = "mumbai", Experience = 10, AssignedRoom = 102 };
logic1.Create(n2.StaffId, n2);
Nurse n3 = new Nurse() { StaffId = 11, StaffName = "deppika", Email = "deepika@Movie.com", contactno = 9988939, ShiftStartTime = 8, ShiftEndTime = 20, Staffcategory = "nurse", Location = "chennai", Experience = 10, AssignedRoom = 103 };
logic1.Create(n3.StaffId, n3);
Nurse n4 = new Nurse() { StaffId = 12, StaffName = "shreya", Email = "shreya@Movie.com", contactno = 9988949, ShiftStartTime = 8, ShiftEndTime = 20, Staffcategory = "nurse", Location = "pune", Experience = 10, AssignedRoom = 104 };
logic1.Create(n4.StaffId, n4);
Nurse n5 = new Nurse() { StaffId = 13, StaffName = "deepa", Email = "deppa@Movie.com", contactno = 9988959, ShiftStartTime = 8, ShiftEndTime = 20, Staffcategory = "nurse", Location = "kanpur", Experience = 10, AssignedRoom = 105 };
logic1.Create(n5.StaffId, n5);
Nurse n6 = new Nurse() { StaffId = 14, StaffName = "shradha", Email = "shradha@Movie.com", contactno = 9988969, ShiftStartTime = 8, ShiftEndTime = 20, Staffcategory = "nurse", Location = "pune", Experience = 10, AssignedRoom = 106 };
logic1.Create(n6.StaffId, n6);
Nurse n7 = new Nurse() { StaffId = 15, StaffName = "khushi", Email = "khushi@Movie.com", contactno = 9988799, ShiftStartTime = 8, ShiftEndTime = 20, Staffcategory = "nurse", Location = "delhi", Experience = 10, AssignedRoom = 107 };
logic1.Create(n7.StaffId, n7);
Nurse n8 = new Nurse() { StaffId = 16, StaffName = "sonal", Email = "sonal@Movie.com", contactno = 9988989, ShiftStartTime = 8, ShiftEndTime = 20, Staffcategory = "nurse", Location = "pune", Experience = 10, AssignedRoom = 108 };
logic1.Create(n8.StaffId, n8);
Driver d1 = new Driver() { StaffId = 17, StaffName = "rakesh", Email = "rakesh@Movie.com", contactno = 99889129, ShiftStartTime = 8, ShiftEndTime = 20, Staffcategory = "driver", Location = "mumbai", VehicleType = "car", Experience = 10 };
logic2.Create(d1.StaffId, d1);
Driver d2 = new Driver() { StaffId = 18, StaffName = "rajesh", Email = "rajesh@Movie.com", contactno = 99889139, ShiftStartTime = 8, ShiftEndTime = 20, Staffcategory = "driver", Location = "pune", VehicleType = "ambulance", Experience = 10 };
logic2.Create(d2.StaffId, d2);
Driver d3 = new Driver() { StaffId = 19, StaffName = "ramesh", Email = "ramesh@Movie.com", contactno = 99889149, ShiftStartTime = 8, ShiftEndTime = 20, Staffcategory = "driver", Location = "chennai", VehicleType = "car", Experience = 10 };
logic2.Create(d3.StaffId, d3);
Driver d4 = new Driver() { StaffId = 20, StaffName = "prshant", Email = "prashant@Movie.com", contactno = 99889449, ShiftStartTime = 8, ShiftEndTime = 20, Staffcategory = "driver", Location = "pune", VehicleType = "ambulance", Experience = 10 };
logic2.Create(d4.StaffId, d4);
Driver d5 = new Driver() { StaffId = 21, StaffName = "romesh", Email = "romesh@Movie.com", contactno = 99889122, ShiftStartTime = 8, ShiftEndTime = 20, Staffcategory = "driver", Location = "delhi", VehicleType = "car", Experience = 10 };
logic2.Create(d5.StaffId, d5);
Driver d6 = new Driver() { StaffId = 22, StaffName = "vivek", Email = "vivek@Movie.com", contactno = 99889129, ShiftStartTime = 8, ShiftEndTime = 20, Staffcategory = "driver", Location = "pune", VehicleType = "ambulance", Experience = 10 };
logic2.Create(d6.StaffId, d6);

string want_to_continue = "y";
do {
    Console.WriteLine("1.Enter new Record");
    Console.WriteLine("2.To get the details of all the staffs");
    Console.WriteLine("3.To update the details");
    Console.WriteLine("4.To delete the details");
    Console.WriteLine("5.To get the netIncome");
    Console.WriteLine("6.To search");
    Console.WriteLine("Enter your Choice");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice) {
        case 1:
            Console.WriteLine("Enter the staffcategory to register");
            string str = Console.ReadLine().ToLower();
            if (str == "doctor")
            {

                Console.WriteLine("StaffId  StaffName  Email  ContactNo  ShiftStartTime  ShiftEndTime  StaffCategory  Location  DeptName  Education  Speclization");
                Doctor d10 = new Doctor()
                {
                    StaffId = Convert.ToInt32(Console.ReadLine()),
                    StaffName = Console.ReadLine(),
                    Email = Console.ReadLine(),
                    contactno = Convert.ToInt32(Console.ReadLine()),
                    ShiftStartTime = Convert.ToInt32(Console.ReadLine()),
                    ShiftEndTime = Convert.ToInt32(Console.ReadLine()),
                    Staffcategory = Console.ReadLine(),
                    Location = Console.ReadLine(),
                    DeptName = Console.ReadLine(),
                    Education = Console.ReadLine(),
                    Specilization = Console.ReadLine()
                };
                logic.Create(d10.StaffId, d10);
            }
            else if (str == "nurse")
            {
                Console.WriteLine("StaffId  StaffName  Email  ContactNo  ShiftStartTime  ShiftEndTime  StaffCategory  Location  DeptName   Experience  AssignedRoom");
                Nurse n9 = new Nurse()
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
                logic1.Create(n9.StaffId, n9);
            }
            else if (str == "driver")
            {
                Console.WriteLine("StaffId  StaffName  Email  ContactNo  ShiftStartTime  ShiftEndTime  StaffCategory  Location  DeptName  VehicleType  Experience");
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
            var Staffs1 = logic.GetAll().OrderBy(s => s.Value.StaffName);
            //var staffs2 = Staffs1.OrderBy(s => s.Value.StaffName);

            if (str1 == "doctor")
            {
                foreach (KeyValuePair<int, Staff> s in Staffs1)
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
                foreach (KeyValuePair<int, Staff> s in Staffs1)
                {
                    if (Convert.ToString(s.Value.GetType()).Contains("Nurse"))
                    {
                        var a = (Nurse)s.Value;
                        Console.WriteLine($"{a.StaffId}  {a.StaffName}  {a.Email}  {a.contactno}  {a.ShiftStartTime}  {a.ShiftEndTime}  {a.Staffcategory}  {a.Location}  {a.Experience}  {a.AssignedRoom}");
                    }
                }
            }
            if (str1 == "driver")
            {
                foreach (KeyValuePair<int, Staff> s in Staffs1)
                {
                    if (Convert.ToString(s.Value.GetType()).Contains("Driver"))
                    {
                        var a = (Driver)s.Value;
                        Console.WriteLine($"{a.StaffId}  {a.StaffName}  {a.Email}  {a.contactno}  {a.ShiftStartTime}  {a.ShiftEndTime}  {a.Staffcategory}  {a.Location}  {a.VehicleType}  {a.Experience}");
                    }
                }
            }
            break;
        case 3:
            Console.WriteLine("Enter the staffdept");
            string str4 = Console.ReadLine().ToLower();
            
            if (str4 == "doctor")
            {
                Console.WriteLine("Enter id");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("StaffName  Email  ContactNo  ShiftStartTime  ShiftEndTime  StaffCategory  Location  DeptName  Education  Speclization");
                doctor = new Doctor()
                {
                    StaffId = id,
                    StaffName = Console.ReadLine(),
                    Email = Console.ReadLine(),
                    contactno = Convert.ToInt32(Console.ReadLine()),
                    ShiftStartTime = Convert.ToInt32(Console.ReadLine()),
                    ShiftEndTime = Convert.ToInt32(Console.ReadLine()),
                    Staffcategory = Console.ReadLine(),
                    Location = Console.ReadLine(),
                    DeptName = Console.ReadLine(),
                    Education = Console.ReadLine(),
                    Specilization = Console.ReadLine()
                };
                logic.Update(id, doctor);
            }
            else if (str4 == "nurse")
            {
                Console.WriteLine("Enter id");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("StaffName  Email  ContactNo  ShiftStartTime  ShiftEndTime  StaffCategory  Location  Experience  AssignedRoom");
                nurse = new Nurse()
                {
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
                logic1.Update(id, nurse);

            }
            else if (str4 == "driver")
            {
                Console.WriteLine("Enter id");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("StaffName  Email  ContactNo  ShiftStartTime  ShiftEndTime  StaffCategory  Location  VwhicleType  Experience");
                nurse = new Nurse()
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
                logic1.Update(id, nurse);

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
                string fileName = string.Empty;
                string b = string.Empty;
                string directory = @"c:\Files";
                foreach (var v in staffs)
                {
                    if (v.Value.StaffId == id6)
                    {
                        fileName = Convert.ToString(v.Value.StaffId) + ".txt";
                        b = v.Value.StaffName;

                    }
                }
                    Console.WriteLine(fileName);

                    FileOperations operation = new FileOperations();

                    operation.CreateFile(directory, fileName);
                    Console.WriteLine("Enter Patientsdiagnoesd");
                    int patientsdiagnosed = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter operations per day");
                    int operations_per_day = Convert.ToInt32(Console.ReadLine());
                    StaffLogicAbstract staff = new DoctorLogicEx(id6, patientsdiagnosed, operations_per_day);
                    Account accounts = new Account();
                    string a = Convert.ToString(id6);
                    int c = Convert.ToInt32(accounts.GrossInsome(staff));
                    decimal d = accounts.HospitalShare(staff);
                    decimal e = accounts.GetTax(staff);
                    decimal f = accounts.GetStaffIncome(staff);
                    //Console.WriteLine(dg.digit_word(Convert.ToInt32(c)));
                   


                string[] data = new string[] { $"{a}\n\n{b}\n\nIncome Details\nGross Income \t : {c}{dg.digit_word(Convert.ToInt32(c))}\n\nHospitalShare \t : {d}\t{dg.digit_word(Convert.ToInt32(d))}\n\n", $"tax \t\t : {e}\t\t{dg.digit_word(Convert.ToInt32(e))}\n", $"NetIncome \t : {f}\t{dg.digit_word(Convert.ToInt32(f))}" };

                operation.WriteFile(directory, fileName, data);
                Console.Clear();
                Console.WriteLine(operation.ReadFile(directory,fileName));
                Console.ReadLine();

                
            }
            else if (str6 == "nurse")
            {
                Console.WriteLine("Enter the StaffId");
                int id6 = Convert.ToInt32(Console.ReadLine());
                var staffs = logic.GetAll();
                string fileName = string.Empty;
                string b = string.Empty;
                string directory = @"c:\Files";
                foreach (var v in staffs)
                {
                    if (v.Value.StaffId == id6)
                    {
                        fileName = Convert.ToString(v.Value.StaffId) + ".txt";
                        b = v.Value.StaffName;
                    }
                }

                    FileOperations operation = new FileOperations();

                    operation.CreateFile(directory, fileName);
                    Console.WriteLine("Enter Injection Applied");
                    int injection_applied = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter patients monitored per day");
                    int patients_monitored = Convert.ToInt32(Console.ReadLine());
                    StaffLogicAbstract staff = new NurseLogicEx(id6, injection_applied, patients_monitored);
                    Account accounts = new Account();
                    string a = Convert.ToString(id6);
                    int c = Convert.ToInt32(accounts.GrossInsome(staff));
                    decimal d = accounts.HospitalShare(staff);
                    decimal e = accounts.GetTax(staff);
                    decimal f = accounts.GetStaffIncome(staff);


                string[] data = new string[] { $"{a}\n\n{b}\n\nIncome Details\nGross Income \t : {c}{dg.digit_word(Convert.ToInt32(c))}\n\nHospitalShare \t : {d}\t{dg.digit_word(Convert.ToInt32(d))}\n\n", $"tax \t\t : {e}\t\t{dg.digit_word(Convert.ToInt32(e))}\n", $"NetIncome \t : {f}\t{dg.digit_word(Convert.ToInt32(f))}" };

                operation.WriteFile(directory, fileName, data);
                
            }
            else if (str6 == "driver")
            {
                Console.WriteLine("Enter the StaffId");
                int id6 = Convert.ToInt32(Console.ReadLine());
                var staffs = logic.GetAll();
                string fileName = string.Empty;
                string b = string.Empty;
                string directory = @"c:\Files";
                foreach (var v in staffs)
                {
                    if (v.Value.StaffId == id6)
                    {
                        fileName = Convert.ToString(v.Value.StaffId) + ".txt";
                        b = v.Value.StaffName;
                    }
                }

                    FileOperations operation = new FileOperations();

                    operation.CreateFile(directory, fileName);
                    Console.WriteLine("Enter no. of working days");
                    int no_of_days = Convert.ToInt32(Console.ReadLine());
                    StaffLogicAbstract staff = new DriverLogicEx(id6, no_of_days);
                    Account accounts = new Account();
                    string a = Convert.ToString(id6);
                    int c = Convert.ToInt32(accounts.GrossInsome(staff));
                    decimal d = accounts.HospitalShare(staff);
                    decimal e = accounts.GetTax(staff);
                    decimal f = accounts.GetStaffIncome(staff);


                string[] data = new string[] { $"{a}\n\n{b}\n\nIncome Details\nGross Income \t : {c}{dg.digit_word(Convert.ToInt32(c))}\n\nHospitalShare \t : {d}\t{dg.digit_word(Convert.ToInt32(d))}\n\n", $"tax \t\t : {e}\t\t{dg.digit_word(Convert.ToInt32(e))}\n", $"NetIncome \t : {f}\t{dg.digit_word(Convert.ToInt32(f))}" };




                operation.WriteFile(directory, fileName, data);
                
            }

            break;
        case 6:
            Console.WriteLine("Enter the StaffCategory to search");
            string str2 = Console.ReadLine().ToLower();
            Console.WriteLine("search by id/name/location");
            string searchop = Console.ReadLine().ToLower();
            if (str2 == "doctor" && searchop == "id")
            {
                Console.WriteLine("Enter Id");
                int id2 = Convert.ToInt32(Console.ReadLine());
               
                    var s = search.searchbyId(id2);
                    foreach (var res in s)
                    {
                        Console.Write(res + " ");

                    }
                
            }
            else if (str2 == "doctor" && searchop == "name") {
               
                Console.WriteLine("Enter StaffName");
                string staff_name = Console.ReadLine().ToLower();
  
                    var s = search.searchbyname(staff_name);
                    foreach (var res in s)
                    {
                        Console.Write(res + " ");

                    }
                
            }
            else if (str2 == "doctor" && searchop == "location") {
               
                Console.WriteLine("Enter Location");
                string loc = Console.ReadLine().ToLower();
                
               
                    var s = search.searchbylocation(loc);
                    foreach (var res in s)
                    {
                        Console.Write(res + " ");

                    }
                
            }
            if (str2 == "nurse" && searchop == "id")
            {
                
                Console.WriteLine("Enter Id");
                int id2 = Convert.ToInt32(Console.ReadLine());
                    var s = search.searchbyId(id2);
                    foreach (var res in s)
                    {
                        Console.Write(res + " ");

                    }
                
            }
            else if (str2 == "nurse" && searchop == "name")
            {
                
                Console.WriteLine("Enter StaffName");
                string staff_name = Console.ReadLine().ToLower();
              
                        var s = search.searchbyname1(staff_name);
                        foreach (var res in s)
                        {
                            Console.Write(res + " ");

                        }
                    
                
            }
            else if (str2 == "nurse" && searchop == "location")
            {
                Console.WriteLine("Enter Location");
                string loc = Console.ReadLine().ToLower();
                
                    var s = search.searchbylocation1(loc);
                    foreach (var res in s)
                    {
                        Console.Write(res + " ");

                    }
                
            }
            if (str2 == "driver" && searchop == "id")
            {
                Console.WriteLine("Enter Id");
                int id2 = Convert.ToInt32(Console.ReadLine());
                    var s = search.searchbyId(id2);
                    foreach (var res in s)
                    {
                        Console.Write(res + " ");
                        
                    }
            }
            else if (str2 == "driver" && searchop == "name")
            {
                Console.WriteLine("Enter StaffName");
                string staff_name = Console.ReadLine().ToLower();
               
                    var s = search.searchbyname2(staff_name);
                    foreach (var res in s)
                    {
                        Console.Write(res + " ");
                    }
                
            }
            else if (str2 == "driver" && searchop == "location")
            {
                bool flag = false;
                Console.WriteLine("Enter Location");
                string loc = Console.ReadLine().ToLower();
                    var s = search.searchbylocation2(loc);
                    foreach (var res in s)
                    {
                        Console.Write(res + " ");
                        
                    }
                
            }

            break;
    }
    Console.WriteLine("Press Y to continue");
    want_to_continue = Console.ReadLine();
} while (want_to_continue == "y" || want_to_continue == "Y");








