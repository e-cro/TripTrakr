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
        public DateTime TripStartDate { get; set; } //can month and day be optional?

        [Required]
        [Display(Name = "Trip End Date")]
        public DateTime TripEndDate { get; set; } //can month and day be optional?

        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        [Required]
        [Display(Name = "Trip Title")]
        public string TripTitle
        {
            get
            {
                return TripStartDate.Year + " " + Country.CountryName + " with " + Person.FirstName; //Need logic for listing all the countries and all the people
            }
        }


        [ForeignKey(nameof(Place))]
        public int PlaceId { get; set; }
        public virtual Place Place { get; set; }

        [ForeignKey(nameof(Person))]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }

        //How to indicate if that person was travel companion on this trip? (Can be more than one person per trip, some might be travel companion and some might be visited -- maybe check starred function on ElevenNoteMVC module?)

        [Display(Name = "Sites")]
        public string SitesDescription { get; set; }

        [Display(Name = "Memories")]
        public string MemoriesDescription { get; set; }

        [ForeignKey(nameof(Photo))]
        public int PhotoId { get; set; }
        public virtual Photo Photo { get; set; }
    }
}
