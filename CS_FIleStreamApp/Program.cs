// See https://aka.ms/new-console-template for more information
//CReate a File USing FileSTream. Using the StreamWriter Add Staff Records (Doctor, Nurses, Technician) in it(MIn 50 Records).
//Create a class with Following Methods to perform OPerations on the File
//ReadStaffByCategory(string staffCategory)
//This should return staff based on the staffCategory e.g. staffCategory=Doctor will return all doctors
//CheckIfTheStaffExsist(int StaffId)
//This will return the Staff based on the StaffId
//ReadRecordsByCount(int count)
//This will return records from the file based on the COunt
//DeleteStaffById(int StaffId)
//This will delete the records by StaffIf
//UpdateStaffById(int StaffId)
//This will update record by StaffId
//Explore The MemoryStream and NetworkStream class
//Write a C# code that will read an Image File and Print its details as follows
//FileName
//FileSize
//Extension
//Write a C# Code that will convert the Byte Array into Image and Image into Byte Array
//Write a C# COde to Read All Files from a DIctionary and its SubDirectories an print its details as follows
//FileName FileSize DateCreated DateMOdified
//Write a C# COde that will copy all files from SourceDIrectory to TargetDictory

using CS_FIleStreamApp.Logic;
using CS_FIleStreamApp.Models;
using CS_FIleStreamApp.Search;

DoctorLogic dlogic = new DoctorLogic();
Doctor doctor = new Doctor();
NurseLogic nurseLogic= new NurseLogic();
Nurse nurse = new Nurse();
TechnicianLogic technicianLogic = new TechnicianLogic();
Technician technician = new Technician();

search search = new search();
try
{
    Doctor doc1 = new Doctor() { StaffId = 1, StaffName = "divyansh", staff_category = "doctor", Email = "divyansh@Movie.com", ContactNo = 998899, Education = "M.B.B.S", ShiftStartTime = 8, ShiftEndTime = 20, Specialization = "Cancer", Fees = 6456, MaxPatientsPerDay = 10 };
    dlogic.WriteFile(doc1);
    Doctor doc2 = new Doctor() { StaffId = 2, StaffName = "omkar", staff_category = "doctor", Email = "omkar@Movie.com", ContactNo = 997799, Education = "B.A.M.S", ShiftStartTime = 7, ShiftEndTime = 19, Specialization = "Heart", Fees = 6000, MaxPatientsPerDay = 8 };
    dlogic.WriteFile(doc2);
    Doctor doc3 = new Doctor() { StaffId = 3, StaffName = "rahul", staff_category = "doctor", Email = "rahul@Movie.com", ContactNo = 996699, Education = "B.A.M.S", ShiftStartTime = 8, ShiftEndTime = 20, Specialization = "Heart", Fees = 7000, MaxPatientsPerDay = 6 };
    dlogic.WriteFile(doc3);
    Doctor doc4 = new Doctor() { StaffId = 4, StaffName = "vivek", staff_category = "doctor", Email = "vivek@Movie.com", ContactNo = 995599, Education = "B.H.M.S", ShiftStartTime = 9, ShiftEndTime = 21, Specialization = "Cancer", Fees = 8000, MaxPatientsPerDay = 16 };
    dlogic.WriteFile(doc4);
    Doctor doc5 = new Doctor() { StaffId = 5, StaffName = "omkar", staff_category = "doctor", Email = "omkar@Movie.com", ContactNo = 994499, Education = "M.B.B.S", ShiftStartTime = 10, ShiftEndTime = 22, Specialization = "eye", Fees = 8000, MaxPatientsPerDay = 17 };
    dlogic.WriteFile(doc5);
    Doctor doc6 = new Doctor() { StaffId = 6, StaffName = "anurag", staff_category = "doctor", Email = "anurag@Movie.com", ContactNo = 993399, Education = "M.B.B.S", ShiftStartTime = 9, ShiftEndTime = 21, Specialization = "Cancer", Fees = 6556, MaxPatientsPerDay = 18 };
    dlogic.WriteFile(doc6);
    Doctor doc7 = new Doctor() { StaffId = 7, StaffName = "rohan", staff_category = "doctor", Email = "rohan@Movie.com", ContactNo = 992299, Education = "B.H.M.S", ShiftStartTime = 10, ShiftEndTime = 22, Specialization = "eye", Fees = 9000, MaxPatientsPerDay = 19 };
    dlogic.WriteFile(doc7);
    Doctor doc8 = new Doctor() { StaffId = 8, StaffName = "sachin", staff_category = "doctor", Email = "sachin@Movie.com", ContactNo = 991199, Education = "ssc", ShiftStartTime = 8, ShiftEndTime = 20, Specialization = "driving", Fees = 8000, MaxPatientsPerDay = 9 };
    dlogic.WriteFile(doc8);
    Nurse n1 = new Nurse() { StaffId = 9, StaffName = "sakshi", staff_category = "nurse", Email = "sakshi@Movie.com", ContactNo = 998899, Education = "bsc nursing", ShiftStartTime = 8, ShiftEndTime = 20, Specialization = "Cancer", Fees = 6456, patientsattended = 10 };
    nurseLogic.WriteFile(n1);
    Nurse n2 = new Nurse() { StaffId = 10, StaffName = "sonali", staff_category = "nurse", Email = "sonalih@Movie.com", ContactNo = 998899, Education = "anm", ShiftStartTime = 8, ShiftEndTime = 20, Specialization = "Cancer", Fees = 6456, patientsattended = 10 };
    nurseLogic.WriteFile(n2);
    Nurse n3 = new Nurse() { StaffId = 11, StaffName = "indumati", staff_category = "nurse", Email = "indumati@Movie.com", ContactNo = 998899, Education = "anm", ShiftStartTime = 8, ShiftEndTime = 20, Specialization = "Cancer", Fees = 6000, patientsattended = 10 };
    nurseLogic.WriteFile(n3);
    Nurse n4 = new Nurse() { StaffId = 12, StaffName = "kavita", staff_category = "nurse", Email = "kavita@Movie.com", ContactNo = 998899, Education = "bsc nursing", ShiftStartTime = 8, ShiftEndTime = 20, Specialization = "Cancer", Fees = 6236, patientsattended = 10 };
    nurseLogic.WriteFile(n4);
    Nurse n5 = new Nurse() { StaffId = 13, StaffName = "rashika", staff_category = "nurse", Email = "rashika@Movie.com", ContactNo = 998899, Education = "anm", ShiftStartTime = 8, ShiftEndTime = 20, Specialization = "Cancer", Fees = 7896, patientsattended = 10 };
    nurseLogic.WriteFile(n5);
    Nurse n6 = new Nurse() { StaffId = 15, StaffName = "katrina", staff_category = "nurse", Email = "katrina@Movie.com", ContactNo = 998899, Education = "bsc nursing", ShiftStartTime = 8, ShiftEndTime = 20, Specialization = "Cancer", Fees = 7000, patientsattended = 10 };
    nurseLogic.WriteFile(n6);
    Nurse n7 = new Nurse() { StaffId = 16, StaffName = "kareena", staff_category = "nurse", Email = "kareena@Movie.com", ContactNo = 998899, Education = "anm", ShiftStartTime = 8, ShiftEndTime = 20, Specialization = "Cancer", Fees = 8000, patientsattended = 10 };
    nurseLogic.WriteFile(n7);
    Technician tech1 = new Technician() { StaffId = 17, StaffName = "mihir", staff_category = "technician", Email = "mihir@Movie.com", ContactNo = 96799, Education = "hsc", ShiftStartTime = 8, ShiftEndTime = 20, Specialization = "driving", Expertise = "ambulance" };
    technicianLogic.WriteFile(tech1);
    Technician tech2 = new Technician() { StaffId = 18, StaffName = "subhankar", staff_category = "technician", Email = "subhankar@Movie.com", ContactNo = 12354, Education = "hsc", ShiftStartTime = 10, ShiftEndTime = 20, Specialization = "driving", Expertise = "ambulance" };
    technicianLogic.WriteFile(tech2);
    Technician tech3 = new Technician() { StaffId = 19, StaffName = "pavan", staff_category = "technician", Email = "pavan@Movie.com", ContactNo = 672347, Education = "ssc", ShiftStartTime = 7, ShiftEndTime = 20, Specialization = "driving", Expertise = "ambulance" };
    technicianLogic.WriteFile(tech3);
    Technician tech4 = new Technician() { StaffId = 20, StaffName = "ram", staff_category = "technician", Email = "ram@Movie.com", ContactNo = 34437, Education = "ssc", ShiftStartTime = 18, ShiftEndTime = 20, Specialization = "driving", Expertise = "ambulance" };
    technicianLogic.WriteFile(tech4);
    Technician tech5 = new Technician() { StaffId = 21, StaffName = "laxman", staff_category = "technician", Email = "laxamn@Movie.com", ContactNo = 28934, Education = "hsc", ShiftStartTime = 20, ShiftEndTime = 20, Specialization = "driving", Expertise = "ambulance" };
    technicianLogic.WriteFile(tech5);
    Technician tech6 = new Technician() { StaffId = 22, StaffName = "manav", staff_category = "technician", Email = "manav@Movie.com", ContactNo = 28943, Education = "ssc", ShiftStartTime = 9, ShiftEndTime = 20, Specialization = "driving", Expertise = "ambulance" };
    technicianLogic.WriteFile(tech6);
    Technician tech7 = new Technician() { StaffId = 23, StaffName = "hemant", staff_category = "technician", Email = "hemant@Movie.com", ContactNo = 97329, Education = "hsc", ShiftStartTime = 7, ShiftEndTime = 20, Specialization = "driving", Expertise = "ambulance" };
    technicianLogic.WriteFile(tech7);
    //Staff._StaffId = 23;
    //static Doctor add()
    //{
    //    Doctor doc = new Doctor();
    //    Console.WriteLine("Enter StaffId");
    //    doc.StaffId = Staff._StaffId;
    //    //string str = $"{Convert.ToString(doc.StaffId)}.Json";
    //    Console.WriteLine("Enter StaffName");
    //    doc.StaffName = Console.ReadLine();
    //    Console.WriteLine("Enter Email");
    //    doc.Email = Console.ReadLine();
    //    Console.WriteLine("Enter Contactno.");
    //    doc.ContactNo = Convert.ToInt32(Console.ReadLine());
    //    Console.WriteLine("Enter dob");
    //    doc.Dob = DateTime.Parse(Console.ReadLine());
    //    Console.WriteLine("Enetr Staff Category");
    //    doc.staff_category = Console.ReadLine();
    //    Console.WriteLine("Enter Education");
    //    doc.Education = Console.ReadLine();
    //    Console.WriteLine("Enter ShiftStartTime");
    //    doc.ShiftStartTime = Convert.ToInt32(Console.ReadLine());
    //    doc.ShiftEndTime = doc.ShiftEndTime1(doc.ShiftStartTime);
    //    Console.WriteLine("Enter Specialization");
    //    doc.Specialization = Console.ReadLine();
    //    Console.WriteLine("Enter Fees");
    //    doc.Fees = Convert.ToInt32(Console.ReadLine());
    //    Console.WriteLine("Enter MaxPatientsPerDay");
    //    doc.MaxPatientsPerDay = Convert.ToInt32(Console.ReadLine());
    //    Console.WriteLine("Enter basic pay");
    //    doc.BasicPay = Convert.ToInt32(Console.ReadLine());
    //    Staff._StaffId++;
    //    return doc;
    //}

    //static Nurse add1()
    //{
    //    Nurse nurs = new Nurse();
    //    Console.WriteLine("Enter StaffId");
    //    nurs.StaffId = Staff._StaffId++;
    //    Console.WriteLine("Enter StaffName");
    //    nurs.StaffName = Console.ReadLine();
    //    Console.WriteLine("Enter Email");
    //    nurs.Email = Console.ReadLine();
    //    Console.WriteLine("Enter Contactno.");
    //    nurs.ContactNo = Convert.ToInt32(Console.ReadLine());
    //    Console.WriteLine("Enter dob");
    //    nurs.Dob = DateTime.Parse(Console.ReadLine());
    //    Console.WriteLine("Enetr Staff Category");
    //    nurs.staff_category = Console.ReadLine();
    //    Console.WriteLine("Enter Education");
    //    nurs.Education = Console.ReadLine();
    //    Console.WriteLine("Enter ShiftStartTime");
    //    nurs.ShiftStartTime = Convert.ToInt32(Console.ReadLine());
    //    Console.WriteLine("Enter Specialization");
    //    nurs.ShiftEndTime = nurs.ShiftEndTime1(nurs.ShiftStartTime);
    //    nurs.Specialization = Console.ReadLine();
    //    Console.WriteLine("Enter Fees");
    //    nurs.Fees = Convert.ToInt32(Console.ReadLine());
    //    Console.WriteLine("Enter Patient attended");
    //    nurs.patientsattended = Convert.ToInt32(Console.ReadLine());
    //    Console.WriteLine("Enter Basicpay");
    //    nurs.BasicPay = Convert.ToInt32(Console.ReadLine());
    //    Staff._StaffId++;

    //    return nurs;
    //}
    //static Technician add2()
    //{
    //    Technician tech = new Technician();
    //    Console.WriteLine("Enter StaffId");
    //    tech.StaffId = Staff._StaffId++;
    //    Console.WriteLine("Enter StaffName");
    //    tech.StaffName = Console.ReadLine();
    //    Console.WriteLine("Enter Email");
    //    tech.Email = Console.ReadLine();
    //    Console.WriteLine("Enter Contactno.");
    //    tech.ContactNo = Convert.ToInt32(Console.ReadLine());
    //    Console.WriteLine("Enter dob");
    //    tech.Dob = DateTime.Parse(Console.ReadLine());
    //    Console.WriteLine("Enetr Staff Category");
    //    tech.staff_category = Console.ReadLine();
    //    Console.WriteLine("Enter Education");
    //    tech.Education = Console.ReadLine();
    //    Console.WriteLine("Enter ShiftStartTime");
    //    tech.ShiftStartTime = Convert.ToInt32(Console.ReadLine());
    //    tech.ShiftEndTime = tech.ShiftEndTime1(tech.ShiftStartTime);
    //    Console.WriteLine("Enter Specialization");
    //    tech.Specialization = Console.ReadLine();
    //    Console.WriteLine("Enter Fees");
    //    tech.Specialization = Console.ReadLine();
    //    Console.WriteLine("Enter MaxPatientsPerDay");
    //    tech.Expertise = Console.ReadLine();
    //    Console.WriteLine("Enter Basic pay");
    //    tech.BasicPay = Convert.ToInt32(Console.ReadLine());
    //    Staff._StaffId++;
    //    return tech;
    //}

    string want_to_continue = "y";
    do
    {
        Console.WriteLine("1.Add Details");
        Console.WriteLine("2.get details by staff_cat");
        Console.WriteLine("3.get details by Id");
        Console.WriteLine("4.get details by count");
        Console.WriteLine("5.update staff by Id");
        Console.WriteLine("6.delete staff by Id");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice) 
        {
            case 1:
                string staff_cat = Console.ReadLine().ToLower();
                if (staff_cat == "doctor")
                {
                    //var a = add();
                   
                    //dlogic.WriteFile(a);
                }
                else if (staff_cat == "nurse")
                {
                    //var a = add1();
                    //nurseLogic.WriteFile(a);
                }
                else if (staff_cat == "technician") 
                {    
                   // var a = add2();
                    //technicianLogic.WriteFile(a);
                }
                break;

           case 2:
                search.searchbycat();
                break;

           case 3:
                search.searchbyId();
                break;

           case 4:
                search.getdetailsbycount();
                break;

           case 5:
                Console.WriteLine("Enter Id to be updated");
                int id = Convert.ToInt32(Console.ReadLine());
                dlogic.updatebyid(id);
                break;

            case 6:
                search sh = new search();
                sh.delete();
                break;


        }

        Console.WriteLine("Press y to continue");

        want_to_continue = Console.ReadLine();


    } while (want_to_continue == "y" || want_to_continue == "Y");

}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
finally
{
    dlogic.Dispose();
    nurseLogic.Dispose();
    technicianLogic.Dispose();
}

Console.ReadLine();

