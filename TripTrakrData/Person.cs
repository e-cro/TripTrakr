using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripTrakrData
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        
        public string HowKnown { get; set; }

        public DateTime YearMet { get; set; } //Do I need code here to allow only year entry? (YYYY)

        public int YearsKnown
        {
            get
            {
                return DateTime.Now.Year - YearMet.Year;
            }
        }
    }
}
