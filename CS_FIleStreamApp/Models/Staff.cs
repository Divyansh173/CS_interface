using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CS_FIleStreamApp.Models
{
    [Serializable]
    public class Staff
    {

        public Staff()
        {
            //Console.WriteLine("CTOR for Staff");
        }
        private int _StaffId { get; set; }

        public int StaffId
        {
            get { return _StaffId; }
            set
            {
                bool staff_id = true;
                while (staff_id)
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("StaffId can not be less than or equal to zero");
                        value = Convert.ToInt32(Console.ReadLine());
                        if (value > 0)
                        {
                            _StaffId = value;
                            staff_id = false;
                        }

                    }
                    else
                    {
                        _StaffId = value;
                        staff_id = false;
                    }
                }
            }
        }
        public string StaffName { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public int ContactNo { get; set; }

        public string staff_category;
        public string? Education { get; set; }

        private DateTime _dob { get; set; }

        public DateTime Dob { 
         
            get { return _dob; }
            set
            {
                bool staff_id = true;
                DateTime now = DateTime.Now;
                var a = now.Year - value.Year;
                while (staff_id)
                {
                    
                    if (a < 26)
                    {
                        Console.WriteLine("Date of birth can not be less than or equal to 27");
                        value = DateTime.Parse(Console.ReadLine());
                        a = now.Year - value.Year;
                        if (a > 27)
                        {
                            _dob = value;
                            staff_id = false;
                        }

                    }
                    else
                    {
                        _dob = value;
                        staff_id = false;
                    }
                }



            }
        }
        public int ShiftStartTime { get; set; }

        public int ShiftEndTime1(int ShiftStartTime)
        {
            //get { return _ShiftEndTime; }

            int a = ShiftStartTime;
            if (a > 14)
            {
                a = a - 12;
                ShiftEndTime = a - 2;
            }
            else
            {
                ShiftEndTime = a + 10;
            }
            return ShiftEndTime;
        }
        public int ShiftEndTime { get; set; }

        //public int ShiftEndTime 
        //{
        //    get { return _ShiftEndTime; }
        //    set
        //    {
        //        _ShiftEndTime = time(ShiftStartTime);
        //    }
        //}

        
        public int BasicPay { get; set; }
    }
}
