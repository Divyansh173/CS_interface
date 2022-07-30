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
        // Doctor IDbOperations<Doctor, int>.Create(int id,Doctor entity)
        //{
        //    if (globalstaffstore.GlobalStaffStore != null)
        //    {
        //        globalstaffstore.GlobalStaffStore.Add(id, entity);
        //    }
            
        //}

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

        Doctor IDbOperations<Doctor, int>.Get(int id)
        {
            throw new NotImplementedException();
        }

        Dictionary<int, Staff> IDbOperations<Doctor, int>.GetAll()
        {
          
            return globalstaffstore.GlobalStaffStore;
        }

        //Dictionary<int, Doctor> IDbOperations<Doctor, int>.GetAll()
        //{
        //    return globalstaffstore.GlobalStaffStore;
        //}

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
                    if (s.Key == id)
                    {
                        var a = (Doctor)s.Value;
                        a.StaffName = Console.ReadLine();
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
        //Nurse IDbOperations<Nurse, int>.Create(Nurse entity)
        //{
        //    throw new NotImplementedException();
        //}

        void IDbOperations<Nurse, int>.Create(int id, Nurse entity)
        {
            throw new NotImplementedException();
        }

        Dictionary<int, Staff> IDbOperations<Nurse, int>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        Nurse IDbOperations<Nurse, int>.Get(int id)
        {
            throw new NotImplementedException();
        }

        //List<Nurse> IDbOperations<Nurse, int>.GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        Dictionary<int, Staff> IDbOperations<Nurse, int>.GetAll()
        {
            throw new NotImplementedException();
        }

        Dictionary<int, Staff> IDbOperations<Nurse, int>.Update(int id, Nurse entity)
        {
            throw new NotImplementedException();
        }
    }

    public class DriverLogic : IDbOperations<Driver, int>
    {
        //Driver IDbOperations<Driver, int>.Create(Driver entity)
        //{
        //    throw new NotImplementedException();
        //}

        void IDbOperations<Driver, int>.Create(int id, Driver entity)
        {
            throw new NotImplementedException();
        }

        Dictionary<int, Staff> IDbOperations<Driver, int>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        Driver IDbOperations<Driver, int>.Get(int id)
        {
            throw new NotImplementedException();
        }

        //List<Driver> IDbOperations<Driver, int>.GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        Dictionary<int, Staff> IDbOperations<Driver, int>.GetAll()
        {
            throw new NotImplementedException();
        }

        Dictionary<int, Staff> IDbOperations<Driver, int>.Update(int id, Driver entity)
        {
            throw new NotImplementedException();
        }
    }

}
