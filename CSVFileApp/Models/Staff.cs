using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CSVFileApp.Models
{
    [Serializable]
    public class Staff
    {
        public int StaffId { get; set; }

        public string StaffName { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public int ContactNo { get; set; }

        public string staff_category { get; set; }
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
        public int ShiftEndTime { get; set; }      
        public int BasicPay { get; set; }
    }
}
