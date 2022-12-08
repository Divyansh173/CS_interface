using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVFileApp.Models
{
    public class Nurse : Staff
    {
        public string? Specialization { get; set; }
        public int Fees { get; set; }
        public int patientsattended { get; set; }

    }
}
