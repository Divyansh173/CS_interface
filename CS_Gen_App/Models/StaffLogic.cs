using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Gen_App.Entities;
using CS_Gen_App.Database;

namespace CS_Gen_App.Models
{


    public class DoctorLogic : IDbOperations<Doctor, int>
    {
        void IDbOperations<Doctor, int>.Create(int id, Doctor entity)
        {
            if (globalstaffstore.GlobalStaffStore != null)
            {
                globalstaffstore.GlobalStaffStore.Add(id, entity);
            }
        }

        Dictionary<int, Staff> IDbOperations<Doctor, int>.Delete(int id)
        {
            bool flag = false;
            foreach (var v in globalstaffstore.GlobalStaffStore)
            {
                if (id == v.Key)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                globalstaffstore.GlobalStaffStore.Remove(id);
                Console.WriteLine("Data deleted successfully");
            }
            else
            {
                Console.WriteLine("Inavalid Key");
            }
            return globalstaffstore.GlobalStaffStore;
        }

        Dictionary<int, Staff> IDbOperations<Doctor, int>.GetAll()
        {
          
            return globalstaffstore.GlobalStaffStore;
        }

        Dictionary<int, Staff> IDbOperations<Doctor, int>.Update(int id, Doctor entity)
        {
            bool flag = false;
            foreach (var v in globalstaffstore.GlobalStaffStore)
            {
                if (id == v.Key)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                foreach (KeyValuePair<int, Staff> s in globalstaffstore.GlobalStaffStore)
                {
                    if (s.Key == id && s.Value.Staffcategory == "doctor")
                    {
                        var a = (Doctor)s.Value;
                        a.StaffName = Console.ReadLine();
                        a.Email = Console.ReadLine();
                        a.contactno = Convert.ToInt32(Console.ReadLine());
                        a.ShiftStartTime = Convert.ToInt32(Console.ReadLine());
                        a.ShiftEndTime = Convert.ToInt32(Console.ReadLine());
                        a.Staffcategory = Console.ReadLine();
                        a.DeptName = Console.ReadLine();
                        a.Education = Console.ReadLine();
                        a.Specilization = Console.ReadLine();
                    }
                }
                Console.WriteLine("Data updated successfully");
            }
            else
            {
                Console.WriteLine("Record Not Found");
            }
            return globalstaffstore.GlobalStaffStore;
        }
    }

    public class NurseLogic : IDbOperations<Nurse, int>
    {
        void IDbOperations<Nurse, int>.Create(int id, Nurse entity)
        {
            if (globalstaffstore.GlobalStaffStore != null)
            {
                globalstaffstore.GlobalStaffStore.Add(id, entity);
            }
        }

        Dictionary<int, Staff> IDbOperations<Nurse, int>.Delete(int id)
        {

            bool flag = false;
            foreach (var v in globalstaffstore.GlobalStaffStore)
            {
                if (id == v.Key)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                globalstaffstore.GlobalStaffStore.Remove(id);
                Console.WriteLine("Data deleted successfully");
            }
            else
            {
                Console.WriteLine("Inavalid Key");
            }
            return globalstaffstore.GlobalStaffStore;
        }

        Dictionary<int, Staff> IDbOperations<Nurse, int>.GetAll()
        {
            return globalstaffstore.GlobalStaffStore;
        }

        Dictionary<int, Staff> IDbOperations<Nurse, int>.Update(int id, Nurse entity)
        {
            bool flag = false;
            foreach (var v in globalstaffstore.GlobalStaffStore)
            {
                if (id == v.Key)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                foreach (KeyValuePair<int, Staff> s in globalstaffstore.GlobalStaffStore)
                {
                    if (s.Key == id && s.Value.Staffcategory == "nurse")
                    {
                        var a = (Nurse)s.Value;
                        a.StaffName = Console.ReadLine();
                        a.Email = Console.ReadLine();
                        a.contactno = Convert.ToInt32(Console.ReadLine());
                        a.ShiftStartTime = Convert.ToInt32(Console.ReadLine());
                        a.ShiftEndTime = Convert.ToInt32(Console.ReadLine());
                        a.Staffcategory = Console.ReadLine();
                        a.Experience = Convert.ToInt32(Console.ReadLine());
                       
                    }
                }
                Console.WriteLine("Data updated successfully");
            }
            else
            {
                Console.WriteLine("Record Not Found");
            }
            return globalstaffstore.GlobalStaffStore;
        }
    }

    public class DriverLogic : IDbOperations<Driver, int>
    {
        void IDbOperations<Driver, int>.Create(int id, Driver entity)
        {
            if (globalstaffstore.GlobalStaffStore != null)
            {
                globalstaffstore.GlobalStaffStore.Add(id, entity);
            }
        }

        Dictionary<int, Staff> IDbOperations<Driver, int>.Delete(int id)
        {
            bool flag = false;
            foreach (var v in globalstaffstore.GlobalStaffStore)
            {
                if (id == v.Key)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                globalstaffstore.GlobalStaffStore.Remove(id);
                Console.WriteLine("Data deleted successfully");
            }
            else
            {
                Console.WriteLine("Inavalid Key");
            }
            return globalstaffstore.GlobalStaffStore;
        }

        Dictionary<int, Staff> IDbOperations<Driver, int>.GetAll()
        {
            return globalstaffstore.GlobalStaffStore;
        }

        Dictionary<int, Staff> IDbOperations<Driver, int>.Update(int id, Driver entity)
        {
            bool flag = false;
            foreach (var v in globalstaffstore.GlobalStaffStore)
            {
                if (id == v.Key)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                foreach (KeyValuePair<int, Staff> s in globalstaffstore.GlobalStaffStore)
                {
                    if (s.Key == id && s.Value.Staffcategory == "doctor")
                    {
                        var a = (Driver)s.Value;
                        a.StaffName = Console.ReadLine();
                        a.Email = Console.ReadLine();
                        a.contactno = Convert.ToInt32(Console.ReadLine());
                        a.ShiftStartTime = Convert.ToInt32(Console.ReadLine());
                        a.ShiftEndTime = Convert.ToInt32(Console.ReadLine());
                        a.Staffcategory = Console.ReadLine();
                        a.VehicleType = Console.ReadLine();
                        
                    }
                }
                Console.WriteLine("Data updated successfully");
            }
            else
            {
                Console.WriteLine("Record Not Found");
            }
            return globalstaffstore.GlobalStaffStore;
        }
    }

}
