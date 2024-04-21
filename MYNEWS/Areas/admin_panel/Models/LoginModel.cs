using System.ComponentModel.DataAnnotations;

namespace MYNEWS.Areas.admin_panel.Models
{
    public class LoginModel
    {
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
