using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Gen_App.Entities
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int contactno { get; set; }
        public int ShiftStartTime { get; set; }
        public int ShiftEndTime { get; set; }

        public string Staffcategory { get; set; } = string.Empty ;

        public string DeptName { get; set; } = string.Empty;

        public string Location { get; set; } = string.Empty;
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