using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EfCoreProgramFirst.Models
{
    public class Person
    {
        [Key]
        public int PersonUniqueId { get; set; }
        [Required]
        [StringLength(100)]
        public string PersonId { get; set; }
        [Required]
        [StringLength(200)]
        public string PersonName { get; set; }
        [Required]
        [StringLength(700)]
        public string Address { get; set; }
        [Required]
        public int age { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
    }
}
