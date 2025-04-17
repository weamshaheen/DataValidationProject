using System.ComponentModel.DataAnnotations;

namespace DataValidationProject.Models
{
    public class UserLogin
    {
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Username is rquired")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 50 character") ]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password is rquired")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Username must at least 6 characters ")] 

        public string Password { get; set; }

        [Display(Name = "Remember me")]
        [Required(ErrorMessage = "Remember me is rquired")]
        public bool RememberMe { get; set; }

    }
}
 