// See https://aka.ms/new-console-template for more information
using CS_FIleStreamApp;
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
    Data data = new Data();
    //data.AddData();
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
                    var a = data.addDoctor();

                    dlogic.WriteFile(a);
                }
                else if (staff_cat == "nurse")
                {
                    var a = data.addNurse();
                    nurseLogic.WriteFile(a);
                }
                else if (staff_cat == "technician")
                {
                    var a = data.addTechnician();
                    technicianLogic.WriteFile(a);
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
                search.updatebyid();
                break;

            case 6:
                search.delete();
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

