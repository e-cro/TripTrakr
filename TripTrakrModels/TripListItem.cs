using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripTrakrModels
{
    public class TripListItem
    {
        public int TripId { get; set; }

        public DateTime TripStartDate { get; set; }

        public string CountryName { get; set; }

        public string FirstName { get; set; }

        [Display(Name = "Trip Title")]
        public string TripTitle
        {
            get
            {
                if (FirstName != null)
                {
                    return TripStartDate.Year + " " + CountryName + " with " + FirstName;
                }
                return TripStartDate.Year + " " + CountryName;
            }
        }
    }
}
