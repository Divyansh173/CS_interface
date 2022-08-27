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

using CS_Inheritence.Logic;
using CS_Inheritence.Models;

DoctorLogic dl = new DoctorLogic();
Doctor doctor = new Doctor();
NurseLogic nl= new NurseLogic();
Nurse nurse = new Nurse();
TechnicianLogic tl = new TechnicianLogic();
Technician technician = new Technician();

try
{
    static Doctor add()
    {
        Doctor doc = new Doctor();
        Console.WriteLine("Enter StaffId");
        doc.StaffId = Convert.ToInt32(Console.ReadLine());
        //string str = $"{Convert.ToString(doc.StaffId)}.Json";
        Console.WriteLine("Enter StaffName");
        doc.StaffName = Console.ReadLine();
        Console.WriteLine("Enter Email");
        doc.Email = Console.ReadLine();
        Console.WriteLine("Enter Contactno.");
        doc.ContactNo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter dob");
        doc.Dob = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enetr Staff Category");
        doc.staff_category = Console.ReadLine();
        Console.WriteLine("Enter Education");
        doc.Education = Console.ReadLine();
        Console.WriteLine("Enter ShiftStartTime");
        doc.ShiftStartTime = Convert.ToInt32(Console.ReadLine());
        doc.ShiftEndTime = doc.ShiftEndTime1(doc.ShiftStartTime);
        Console.WriteLine("Enter Specialization");
        doc.Specialization = Console.ReadLine();
        Console.WriteLine("Enter Fees");
        doc.Fees = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter MaxPatientsPerDay");
        doc.MaxPatientsPerDay = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter basic pay");
        doc.BasicPay = Convert.ToInt32(Console.ReadLine());
        return doc;
    }

    static Nurse add1()
    {
        Nurse nurs = new Nurse();
        Console.WriteLine("Enter StaffId");
        nurs.StaffId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter StaffName");
        nurs.StaffName = Console.ReadLine();
        Console.WriteLine("Enter Email");
        nurs.Email = Console.ReadLine();
        Console.WriteLine("Enter Contactno.");
        nurs.ContactNo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter dob");
        nurs.Dob = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enetr Staff Category");
        nurs.staff_category = Console.ReadLine();
        Console.WriteLine("Enter Education");
        nurs.Education = Console.ReadLine();
        Console.WriteLine("Enter ShiftStartTime");
        nurs.ShiftStartTime = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Specialization");
        nurs.ShiftEndTime = nurs.ShiftEndTime1(nurs.ShiftStartTime);
        nurs.Specialization = Console.ReadLine();
        Console.WriteLine("Enter Fees");
        nurs.Fees = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Patient attended");
        nurs.patientsattended = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Basicpay");
        nurs.BasicPay = Convert.ToInt32(Console.ReadLine());


        return nurs;
    }
    static Technician add2()
    {
        Technician tech = new Technician();
        Console.WriteLine("Enter StaffId");
        tech.StaffId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter StaffName");
        tech.StaffName = Console.ReadLine();
        Console.WriteLine("Enter Email");
        tech.Email = Console.ReadLine();
        Console.WriteLine("Enter Contactno.");
        tech.ContactNo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter dob");
        tech.Dob = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enetr Staff Category");
        tech.staff_category = Console.ReadLine();
        Console.WriteLine("Enter Education");
        tech.Education = Console.ReadLine();
        Console.WriteLine("Enter ShiftStartTime");
        tech.ShiftStartTime = Convert.ToInt32(Console.ReadLine());
        tech.ShiftEndTime = tech.ShiftEndTime1(tech.ShiftStartTime);
        Console.WriteLine("Enter Specialization");
        tech.Specialization = Console.ReadLine();
        Console.WriteLine("Enter Fees");
        tech.Specialization = Console.ReadLine();
        Console.WriteLine("Enter MaxPatientsPerDay");
        tech.Expertise = Console.ReadLine();
        Console.WriteLine("Enter Basic pay");
        tech.BasicPay = Convert.ToInt32(Console.ReadLine());

        return tech;
    }

    //string want_to_continue = "y";
    //do
    //{

    //} while (want_to_continue == "y" || want_to_continue == "Y");
    //var a = add();
    //dl.WriteFile(a);

    //var b = add1();
    //nl.WriteFile(b);

    //var c = add2();
    //tl.WriteFile(c);

    //dl.ReadFile();



}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
finally
{
    dl.Dispose();
}

