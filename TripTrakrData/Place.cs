using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripTrakrData
{
    public class Place
    {
        [Key]
        public int PlaceId { get; set; }
        [Required]
        [Display(Name = "Place")]
        public string PlaceName { get; set; }
        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        [Required]
        public Guid UserId { get; set; }

    }
}
