using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Examensarbete.ViewModels
{
    public class HomeViewModel
    {
        [Required(ErrorMessage = "Required")]
        [EmailAddress(ErrorMessage = "The Email field is not a valid e-mail address")]
        [Display(Name = "Your Email")] //Inte IStringLOcaliser TODO fatta
        public string Email { get; set; }
    }
}
