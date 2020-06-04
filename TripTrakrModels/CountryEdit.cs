using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripTrakrModels
{
    public class CountryEdit
    {
        public int CountryId { get; set; }

        [Display(Name = "Country")]
        public string CountryName { get; set; }
    }
}
