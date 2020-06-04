using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripTrakrData
{
    public class Trip
    {
        [Key]
        public int TripId { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        [Display(Name = "Trip Start Date")]
        public DateTime TripStartDate { get; set; }

        [Required]
        [Display(Name = "Trip End Date")]
        public DateTime TripEndDate { get; set; }

        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        [Display(Name = "Trip Title")]
        public string TripTitle
        {
            get
            {
                if (Person.FirstName != null)
                { 
                    return TripStartDate.Year + " " + Country.CountryName + " with " + Person.FirstName;
                }
                return TripStartDate.Year + " " + Country.CountryName;
            }
        }


        [ForeignKey(nameof(Person))]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }

        //[Display(Name = "Places")]
        //public virtual ICollection<Place> Places { get; set; }

        [Display(Name = "Sites")]
        public string SitesDescription { get; set; }

        [Display(Name = "Memories")]
        public string MemoriesDescription { get; set; }
    }
}
