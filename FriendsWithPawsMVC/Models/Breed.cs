using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsWithPawsMVC.Models
{
    public class Breed
    {
        public int BreedID { get; set; }

        [Required()]
        [Display(Name = "Breed name")]
        [StringLength(25, MinimumLength = 3)]
        public string BreedName { get; set; }

        [Required()]
        [Display(Name = "Food cost per kg £")]
        public decimal FoodCostPerKG { get; set; }

        [Required()]
        [Display(Name = "Housing cost per year £")]
        public decimal HousingCost { get; set; }

        // Many breed belongs to one specie. Many to one relationship
        public int SpecieID { get; set; }

        // navigation property enables lazy loading feature of EF
        // lazy loading means contents of these prop will be automatically loaded from db 
        // when accessed
        public virtual Specie Specie { get; set; }


    }
}
