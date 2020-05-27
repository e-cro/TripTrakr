using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripTrakrData
{
    public class Photo
    {
        [Key]
        public int PhotoId { get; set; }
        [Required]
        [Display(Name = "Photo URL")]
        public string PhotoUrl { get; set; }
        public string PhotoCaption { get; set; }

        [ForeignKey(nameof(Place))]
        public int PlaceId { get; set; }
        public virtual Place Place { get; set; }


    }
}
