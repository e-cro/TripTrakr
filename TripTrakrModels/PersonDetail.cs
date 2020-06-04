using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripTrakrModels
{
    public class PersonDetail
    {
        public int PersonId { get; set; }

        [Display(Name = "First Name")]
        [Range(1, 20, ErrorMessage = "Must be between 1 and 20 characters")]
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

        [Display(Name = "Relationship")]
        [Range(2, 50)]
        public string HowKnown { get; set; }
    }
}

