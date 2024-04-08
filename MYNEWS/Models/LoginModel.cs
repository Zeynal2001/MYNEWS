using System.ComponentModel.DataAnnotations;

namespace MYNEWS.Models
{
    public class LoginModel
    {
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public bool RememberMe { get; set; }
    }
}
