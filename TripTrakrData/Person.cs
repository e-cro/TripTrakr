using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripTrakrData
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [Range(1,20, ErrorMessage ="Must be between 1 and 20 characters")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Range(1, 20, ErrorMessage = "Must be between 1 and 20 characters")]
        public string LastName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        
        [Required]
        [Display(Name ="How Known")]
        [Range(2,500)]
        public string HowKnown { get; set; }

        [Display(Name ="Year Met")]
        public DateTime YearMet { get; set; } //Do I need code here to allow only year entry? (YYYY)

        [Display(Name ="Years Known")]
        public int YearsKnown
        {
            get
            {
                return DateTime.Now.Year - YearMet.Year;
            }
        }
    }
}
