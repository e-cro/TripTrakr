using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripTrakrModels
{
    public class CountryCreate
    {
        [Required]
        [Display(Name = "Country")]
        [MaxLength(30, ErrorMessage = "Max 30 letters")]
        public string CountryName { get; set; }
    }
}
