using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ZombieParty.Models
{
    public class HuntingLog
    {
        public int Id { get; set; }
        [StringLength(25, MinimumLength = 5)]
        public string Title { get; set; }
        [StringLength(255)]
        [Display(Name = "Hunting Description")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ValidationRequired")]

        public string Description { get; set; }
        [Display(Name = "Point")]
        [Range(1, 20, ErrorMessage = "RangeValidation")]

        public DateTime AdventureDate { get; set; }

        [ValidateNever]
        public virtual List<Zombie> Zombies { get; set; }
    }
}
