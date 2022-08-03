using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Gen_App.Entities;
using CS_Gen_App.Database;

namespace CS_Gen_App.Models
{

    public delegate void EventHandler();
    public class DoctorLogic : IDbOperations<Doctor, int>
    {
        public event EventHandler NewRegistration;
        public event EventHandler DeleteStaff;
        public event EventHandler UpdateStaff;

        int len = globalstaffstore.GlobalStaffStore.Count;
        void IDbOperations<Doctor, int>.Create(int id, Doctor entity)
        {
            if (globalstaffstore.GlobalStaffStore != null)
            {
                globalstaffstore.GlobalStaffStore.Add(id, entity);
                NewRegistration();
            }
            
            
        }

        Dictionary<int, Staff> IDbOperations<Doctor, int>.Delete(int id)
        {
            bool flag = false;
            foreach (var v in globalstaffstore.GlobalStaffStore)
            {
                if (id == v.Key && v.Value.Staffcategory == "doctor")
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                globalstaffstore.GlobalStaffStore.Remove(id);
                DeleteStaff();
            }
            else
            {
                Console.WriteLine("Inavalid Key or category");
            }
            return globalstaffstore.GlobalStaffStore;
        }

        Dictionary<int, Staff> IDbOperations<Doctor, int>.GetAll()
        {
          
            return globalstaffstore.GlobalStaffStore;
        }

        int IDbOperations<Doctor, int>.length()
        {
            int length = globalstaffstore.GlobalStaffStore.Count;
            return length;
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
                        a.Location = Console.ReadLine();
                        a.Education = Console.ReadLine();
                        a.Specilization = Console.ReadLine();
                    }
                }
                UpdateStaff();
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
        public event EventHandler NewRegistration;
        public event EventHandler DeleteStaff;
        public event EventHandler UpdateStaff;

        void IDbOperations<Nurse, int>.Create(int id, Nurse entity)
        {
            if (globalstaffstore.GlobalStaffStore != null)
            {
                globalstaffstore.GlobalStaffStore.Add(id, entity);
                NewRegistration();
            }
        }

        Dictionary<int, Staff> IDbOperations<Nurse, int>.Delete(int id)
        {

            bool flag = false;
            foreach (var v in globalstaffstore.GlobalStaffStore)
            {
                if (id == v.Key && v.Value.Staffcategory == "nurse")
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                globalstaffstore.GlobalStaffStore.Remove(id);
                DeleteStaff();
            }
            else
            {
                Console.WriteLine("Inavalid Key or Staffcategory");
            }
            return globalstaffstore.GlobalStaffStore;
        }

        Dictionary<int, Staff> IDbOperations<Nurse, int>.GetAll()
        {
            return globalstaffstore.GlobalStaffStore;
        }

        int IDbOperations<Nurse, int>.length()
        {
            throw new NotImplementedException();
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
                        a.AssignedRoom = Convert.ToInt32(Console.ReadLine());
                    }
                    else {
                        Console.WriteLine("Inavalid StaffCategory");
                    }
                }
                UpdateStaff();
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
        public event EventHandler NewRegistration;
        public event EventHandler DeleteStaff;
        public event EventHandler UpdateStaff;

        void IDbOperations<Driver, int>.Create(int id, Driver entity)
        {
            if (globalstaffstore.GlobalStaffStore != null)
            {
                globalstaffstore.GlobalStaffStore.Add(id, entity);
                NewRegistration();
            }
        }

        Dictionary<int, Staff> IDbOperations<Driver, int>.Delete(int id)
        {
            bool flag = false;
            foreach (var v in globalstaffstore.GlobalStaffStore)
            {
                if (id == v.Key && v.Value.Staffcategory == "driver")
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                globalstaffstore.GlobalStaffStore.Remove(id);
                DeleteStaff();
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

        int IDbOperations<Driver, int>.length()
        {
            throw new NotImplementedException();
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
                    if (s.Key == id && s.Value.Staffcategory == "driver")
                    {
                        var a = (Driver)s.Value;
                        a.StaffName = Console.ReadLine();
                        a.Email = Console.ReadLine();
                        a.contactno = Convert.ToInt32(Console.ReadLine());
                        a.ShiftStartTime = Convert.ToInt32(Console.ReadLine());
                        a.ShiftEndTime = Convert.ToInt32(Console.ReadLine());
                        a.Staffcategory = Console.ReadLine();
                        a.VehicleType = Console.ReadLine();
                        a.Experience = Convert.ToInt32(Console.ReadLine());
                        
                    }
                }
                UpdateStaff();
                
            }
            else
            {
                Console.WriteLine("Record Not Found");
            }
            return globalstaffstore.GlobalStaffStore;
        }
    }

    public class EventListner
    {

        private IDbOperations<Doctor, int> logic;
        private IDbOperations<Nurse, int> logic1;
        private IDbOperations<Driver, int> logic2;


        public EventListner(IDbOperations<Doctor, int> logic)
        {
            this.logic = logic;
            logic.NewRegistration += Logic_NewRegistration;
            logic.DeleteStaff += Logic_Delete;
            logic.UpdateStaff += Logic_Update;
            
        }
        public EventListner(IDbOperations<Nurse, int> logic1)
        {
            this.logic1 = logic1;
            logic1.NewRegistration += Logic_NewRegistration;
            logic1.DeleteStaff += Logic_Delete;
            logic1.UpdateStaff += Logic_Update;

        }

        //public EventListner(IDbOperations<Doctor, int> logic, IDbOperations<Nurse, int> logic1, IDbOperations<Driver, int> logic2) : this(logic)
        //{
        //    this.logic1 = logic1;
        //    this.logic2 = logic2;
        //}
        public EventListner(IDbOperations<Driver, int> logic2)
        {
            this.logic2 = logic2;
            logic2.NewRegistration += Logic_NewRegistration;
            logic2.DeleteStaff += Logic_Delete;
            logic2.UpdateStaff += Logic_Update;

        }
        private void Logic_NewRegistration()
        {
            Console.WriteLine("Registerd Successfully");

        }

        private void Logic_Delete() 
        {
            Console.WriteLine("Deleted successfully");
        }

        private void Logic_Update() 
        {
            Console.WriteLine("Updated successfully");
        }


    }

}


