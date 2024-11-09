using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TruckLoadingApplication.Models
{
    public class ApplicationUser : IdentityUser
    {
        [StringLength(50)]
        [MaxLength(50)]
        [Required]
        public string? Name { get; set; }

        public string? Address { get; set; }

    }
}
