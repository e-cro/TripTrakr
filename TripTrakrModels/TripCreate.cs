using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripTrakrData;

namespace TripTrakrModels
{
    public class TripCreate
    {
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Trip Start Date")]
        public DateTime TripStartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Trip End Date")]
        public DateTime TripEndDate { get; set; }

        [Display(Name = "Person")]
        public string FullName { get; set; }
        public int PersonId { get; set; }
        
        [Display(Name = "Country")]
        public string CountryName { get; set; }

       public int CountryId { get; set; }

        

        [Display(Name = "Places")]
        public string Places { get; set; }

        [Display(Name = "Memories")]
        public string MemoriesDescription { get; set; }

    }
}
