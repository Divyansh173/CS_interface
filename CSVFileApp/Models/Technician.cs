using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVFileApp.Models
{
    public class Technician:Staff
    {
        public string Specialization { get; set; }

        public string Expertise { get; set; }
    }
}
