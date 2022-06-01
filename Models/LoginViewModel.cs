using System.ComponentModel.DataAnnotations;

namespace epi_razor_pages.Models;

public class LoginViewModel
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }
}
