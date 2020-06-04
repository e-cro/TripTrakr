using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripTrakrData;

namespace TripTrakrModels
{
    public class PlaceListItem
    {
        public int PlaceId { get; set; }

        [Display(Name = "Place")]
        public string PlaceName { get; set; }

        [Display(Name = "Country")]
        public string CountryName { get; set; }
    }
}
