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
                Console.WriteLine("Enter the key");
                int id1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("StaffId  StaffName  Email  ContactNo  ShiftStartTime  ShiftEndTime  StaffCategory  Education  Speclization");
                Doctor d1 = new Doctor()
                {
                    StaffId = Convert.ToInt32(Console.ReadLine()),
                    StaffName = Console.ReadLine(),
                    Email = Console.ReadLine(),
                    contactno = Convert.ToInt32(Console.ReadLine()),
                    ShiftStartTime = Convert.ToInt32(Console.ReadLine()),
                    ShiftEndTime = Convert.ToInt32(Console.ReadLine()),
                    Staffcategory = Console.ReadLine(),
                    Education = Console.ReadLine(),
                    Specilization = Console.ReadLine()
                };
                logic.Create(id1, d1);
            }
            else if (str == "nurse")
            {
                Console.WriteLine("Enter the key");
                int id1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("StaffId  StaffName  Email  ContactNo  ShiftStartTime  ShiftEndTime  StaffCategory  Education  Speclization");
                Nurse n1 = new Nurse()
                {
                    StaffId = Convert.ToInt32(Console.ReadLine()),
                    StaffName = Console.ReadLine(),
                    Email = Console.ReadLine(),
                    contactno = Convert.ToInt32(Console.ReadLine()),
                    ShiftStartTime = Convert.ToInt32(Console.ReadLine()),
                    ShiftEndTime = Convert.ToInt32(Console.ReadLine()),
                    Staffcategory = Console.ReadLine(),
                    Experience = Convert.ToInt32(Console.ReadLine()),
                    
                };
                logic1.Create(id1, n1);
            }
            else if (str == "driver")
            {
                Console.WriteLine("Enter the key");
                int id1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("StaffId  StaffName  Email  ContactNo  ShiftStartTime  ShiftEndTime  StaffCategory  Education  Speclization");
                Driver d1 = new Driver()
                {
                    StaffId = Convert.ToInt32(Console.ReadLine()),
                    StaffName = Console.ReadLine(),
                    Email = Console.ReadLine(),
                    contactno = Convert.ToInt32(Console.ReadLine()),
                    ShiftStartTime = Convert.ToInt32(Console.ReadLine()),
                    ShiftEndTime = Convert.ToInt32(Console.ReadLine()),
                    Staffcategory = Console.ReadLine(),
                    VehicleType = Console.ReadLine(),

                };
                logic2.Create(id1, d1);
            }
            break;
       case 2:
            Console.WriteLine("Enter staffcategory to get the details");
            string str1 = Console.ReadLine().ToLower();
            Console.WriteLine("Enter the staffId");
            int id = Convert.ToInt32(Console.ReadLine());
            var Staffs1 = logic.GetAll();

            if (str1 == "doctor")
            {
                foreach (KeyValuePair<int, Staff> s in Staffs1)
                {
                    if (s.Value.StaffId == id)
                    {
                        var a = (Doctor)s.Value;
                        Console.WriteLine($"{a.StaffId}  {a.StaffName}  {a.Email}  {a.contactno}  {a.ShiftStartTime}  {a.ShiftEndTime}  {a.Staffcategory}  {a.Education}  {a.Specilization} ");
                        break;

                    }
                }
            }
            else if (str1 == "nurse")
            {
                foreach (KeyValuePair<int, Staff> s in Staffs1)
                {
                    if (s.Value.StaffId == id)
                    {
                        var a = (Nurse)s.Value;
                        Console.WriteLine($"{a.StaffId}  {a.StaffName}  {a.Email}  {a.contactno}  {a.ShiftStartTime}  {a.ShiftEndTime}  {a.Staffcategory}  {a.Experience}");
                        break;

                    }
                }
            }
            if (str1 == "driver")
            {
                foreach (KeyValuePair<int, Staff> s in Staffs1)
                {
                    if (s.Value.StaffId == id)
                    {
                        var a = (Driver)s.Value;
                        Console.WriteLine($"{a.StaffId}  {a.StaffName}  {a.Email}  {a.contactno}  {a.ShiftStartTime}  {a.ShiftEndTime}  {a.Staffcategory}  {a.VehicleType}");
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
                Console.WriteLine("StaffName  Email  ContactNo  ShiftStartTime  ShiftEndTime  StaffCategory  Education  Specilization");
                logic = new DoctorLogic();
                logic.Update(id4, d);
            }
            else if (str4 == "nurse")
            {
                Nurse n = new Nurse();
                Console.WriteLine("Enter key to be updated");
                int id4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("StaffName  Email  ContactNo  ShiftStartTime  ShiftEndTime  StaffCategory  Education  Specilization");
                logic1 = new NurseLogic();
                logic1.Update(id4, n);
            }
            else if (str4 == "driver")
            {
                Driver dr = new Driver();
                Console.WriteLine("Enter key to be updated");
                int id4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("StaffName  Email  ContactNo  ShiftStartTime  ShiftEndTime  StaffCategory  Education  Specilization");
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
                            Console.WriteLine($"HospitalShare = {accounts.GetTax(staff)}");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine($"HospitalShare = {accounts.GetStaffIncome(staff)}");

                        }
                        else
                        {
                            Console.WriteLine("Inavlid Id or StaffCategory");
                        }
                    }

                }
            break;
    }
} while (want_to_continue == "y" || want_to_continue == "Y");

//Doctor d1 = new Doctor()
//{
//    StaffId = 1,
//    StaffName = "vivek",
//    Education = "M.B.B.S",
//    Specilization = "hjds"
//};
//ob1.Create(d1.StaffId, d1);
//IDbOperations<Doctor, int> logic = new DoctorLogic();
//var a = logic.GetAll();
//foreach (KeyValuePair<int ,Staff> s  in a)
//{
//    var b = (Doctor)s.Value;
//    Console.WriteLine($"{b.StaffId}  {b.StaffName}  {b.Education} {b.Specilization}");
    //if (s.Value.StaffId == id && s.Value.StaffDept == str2)
    //{
    //    var a = (Doctor)s.Value;
    //    Console.WriteLine($"{a.StaffId}  {a.StaffName}  {a.Specilization}  {a.Education}");
    //    break;
    //
    //}
//}






