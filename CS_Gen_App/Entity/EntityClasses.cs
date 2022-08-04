using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Gen_App.Entities
{
    public class Staff
    {
        private int _StaffId;
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
        public string StaffName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        private int _contactno { get; set; }
        public int contactno
        {
            get { return _contactno; }
            set
            {
                bool staff_id = true;
                while (staff_id)
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("Conatct no. can not be less than or equal to zero");
                        value = Convert.ToInt32(Console.ReadLine());
                        if (value > 0)
                        {
                            _contactno = value;
                            staff_id = false;
                        }

                    }
                    else
                    {
                        _contactno = value;
                        staff_id = false;
                    }
                }
            }
        }
        private int _ShiftStartTime { get; set; }
        public int ShiftStartTime
        {
            get { return _ShiftStartTime; }
            set
            {
                bool staff_id = true;
                while (staff_id)
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("Conatct no. can not be less than or equal to zero");
                        value = Convert.ToInt32(Console.ReadLine());
                        if (value > 0)
                        {
                            _ShiftStartTime = value;
                            staff_id = false;
                        }

                    }
                    else
                    {
                        _ShiftStartTime = value;
                        staff_id = false;
                    }
                }
            }
        }

        public int ShiftEndTime { get; set; }

        public string Staffcategory { get; set; } = string.Empty ;

        public string DeptName { get; set; } = string.Empty;

        private string _Location { get; set; } = string.Empty;
        public string Location
        {
            get { return _Location; }
            set
            {
                bool staff_name = true;
                //int count = 0;
                bool staff_name1 = false;
                String str = @"\|!#$%&/()=?»«@{}.-;'<>_,";
                while (staff_name)
                {
                    foreach (char ch in value)
                    {
                        if (str.Contains(ch))
                        {
                            Console.WriteLine("Staffname can not have a special character");
                            staff_name1 = true;
                            break;
                        }
                    }

                    if (staff_name1)
                    {
                        value = Console.ReadLine();
                        _Location = value;
                        staff_name1 = false;
                        break;
                    }
                    else
                    {
                        _Location = value;
                        staff_name = false;
                    }

                }

            }
        }
    }

    public class Doctor : Staff
    {
        public string Education { get; set; } = string.Empty;
        public string Specilization { get; set; } = string.Empty;
    }

    public class Nurse : Staff
    {
        public int Experience { get; set; }

        public int AssignedRoom { get; set; }
    }

    public class Driver : Staff
    {
        public string VehicleType { get; set; }

        public int Experience { get; set; }
    }

}