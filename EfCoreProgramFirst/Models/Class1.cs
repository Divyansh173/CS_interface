using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EfCoreProgramFirst.Models
{
    public abstract class Staff
    {
        [Key]

        public int Id { get; set; }
        public string? Name { get; set; }    

        public string? specialization { get; set; }

       
    }

    public class Doctor : Staff
    {

        public int PateintCount { get; set; }

     
    }

    public class Wardboy : Staff
    {
        public int MachineCount { get; set; }

    }

    public class Nurse : Staff 
    {
        public int RoomCount { get; set; }
    }
}
