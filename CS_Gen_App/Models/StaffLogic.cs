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
        public event EventHandler UpdateStaff;

        void IDbOperations<Doctor, int>.Create(int id, Doctor entity)
        {
            if (globalstaffstore.GlobalStaffStore != null)
            {
                globalstaffstore.GlobalStaffStore.Add(id, entity);
                NewRegistration();
            }


        }

        void IDbOperations<Doctor, int>.Delete(int id)
        {
            if (globalstaffstore.GlobalStaffStore.ContainsKey(id))
            {

                globalstaffstore.GlobalStaffStore.Remove(id);
            }
           
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

        Doctor IDbOperations<Doctor, int>.Update(int id, Doctor entity)
        {

            globalstaffstore.GlobalStaffStore[id] = entity;
            UpdateStaff();
            return entity;
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

        void IDbOperations<Nurse, int>.Delete(int id)
        {
            if (globalstaffstore.GlobalStaffStore.ContainsKey(id))
            {

                globalstaffstore.GlobalStaffStore.Remove(id);
            }

        }

        Dictionary<int, Staff> IDbOperations<Nurse, int>.GetAll()
        {
            return globalstaffstore.GlobalStaffStore;
        }

        int IDbOperations<Nurse, int>.length()
        {
            throw new NotImplementedException();
        }

        Nurse IDbOperations<Nurse, int>.Update(int id, Nurse entity)

        {
            globalstaffstore.GlobalStaffStore[id] = entity;
            UpdateStaff();
            return entity;
           
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

        void IDbOperations<Driver, int>.Delete(int id)
        {
            if (globalstaffstore.GlobalStaffStore.ContainsKey(id))
            {

                globalstaffstore.GlobalStaffStore.Remove(id);
            }
        }

        Dictionary<int, Staff> IDbOperations<Driver, int>.GetAll()
        {
            return globalstaffstore.GlobalStaffStore;
        }

        int IDbOperations<Driver, int>.length()
        {
            throw new NotImplementedException();
        }

        Driver IDbOperations<Driver, int>.Update(int id, Driver entity)
        {
            globalstaffstore.GlobalStaffStore[id] = entity;
            UpdateStaff();
            return entity;

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
            logic.UpdateStaff += Logic_Update;

        }

        public EventListner(IDbOperations<Nurse, int> logic1)
        {
            this.logic1 = logic1;
            logic1.NewRegistration += Logic_NewRegistration;
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
            logic2.UpdateStaff += Logic_Update;

        }
        private void Logic_NewRegistration()
        {
            Console.WriteLine("Registerd Successfully");

        }

        private void Logic_Update()
        {
            Console.WriteLine("Updated successfully");
        }


    }




}