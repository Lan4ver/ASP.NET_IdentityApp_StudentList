using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Projekt1_Podorozhnyi_50402.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Required]        
        [Display(Name = "Student Number")]
        public int StudentNum { get; set; }

        [Required]
        [Display(Name = "Date of birth")]
        public int Year { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(20, ErrorMessage = " {0} should  have at least {2} max {1} digit", MinimumLength = 4)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Different passwords")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string PasswordConfirm { get; set; }        
    }
}
