using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripTrakrModels
{
    public class TripDetail
    {
        public int TripId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Trip Start Date")]
        public DateTime TripStartDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Trip End Date")]
        public DateTime TripEndDate { get; set; }

        [Display(Name = "Country")]
        public string CountryName { get; set; }


        public string FirstName { get; set; }

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

        [Display(Name = "Places Visited")]
        public string Places { get; set; }


        [Display(Name = "Memories")]
        public string MemoriesDescription { get; set; }
    }
}
