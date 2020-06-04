using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripTrakrModels
{
    public class PersonCreate
    {
        [Required]
        [Display(Name = "First Name")]
        [MaxLength(20, ErrorMessage = "Max 20 letters")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [MaxLength(20, ErrorMessage = "Max 20 letters")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Relationship")]
        [MaxLength(50, ErrorMessage = "Max 50 letters")]
        public string HowKnown { get; set; }
    }
}
