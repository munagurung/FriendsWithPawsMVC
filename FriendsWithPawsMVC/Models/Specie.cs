using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsWithPawsMVC.Models
{
    public class Specie
    {
        // species info 
        public int SpecieID { get; set; }

        [Required()]
        [StringLength(25, MinimumLength = 3)]
        [Display(Name= "Specie name")]
        public string SpecieName { get; set; }

        // One specie will have many breeds. One to many relationship
        public virtual List<Breed> Breeds { get; set; }
    }
}
