using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProject.Models
{
    public class PersonModel
    {
        [Key]
        public int PersonId { get; set; }

        [Required(ErrorMessage = "Name is mandatory!")]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        [StringLength(200)]
        public string Lastname { get; set; }
        [Required]
        [Range(18, 60)]
        public int Age { get; set; }
        [Required]
        [StringLength(200)]
        public string Email { get; set; }
        [Required]
        
        public int Contactnumber { get; set; }
        [Required]
        
        public int Password { get; set; }
        [Required]
        
        public int Confirmpassword { get; set; }

        
    }
}
