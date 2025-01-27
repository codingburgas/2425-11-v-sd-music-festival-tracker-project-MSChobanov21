using System.ComponentModel.DataAnnotations;

namespace Festival.DAL.Models
{
    public class Model
    {
        [Required]
        [EmailAddress]
        public static string Email { get; set; } 

        [Required]
        [StringLength(100, MinimumLength = 6)]
        public static string Password { get; set; } 

        [Compare("Password")]
        public static string ConfirmPassword { get; set; } 
    }
}