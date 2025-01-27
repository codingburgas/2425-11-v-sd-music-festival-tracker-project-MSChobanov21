using System.ComponentModel.DataAnnotations;
using Festival.DAL.Models;

public class SignUpModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 6)]
    public string Password { get; set; }

    [Compare("Password")]
    public string ConfirmPassword { get; set; }
}