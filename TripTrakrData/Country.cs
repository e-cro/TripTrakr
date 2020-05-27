using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripTrakrData
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        [Required]
        [Display(Name = "Country")]
        public string CountryName { get; set; }

    }
}
