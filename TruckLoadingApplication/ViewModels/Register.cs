using System.ComponentModel.DataAnnotations;

namespace TruckLoadingApplication.ViewModels
{
    public class Register
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password don't match")]
        [Display(Name = "Confirm Password")]
        public string? ConfirmPassword { get; set; }


        [Required]
        [DataType(DataType.MultilineText)]
        public string? Address { get; set; }
    }
}
