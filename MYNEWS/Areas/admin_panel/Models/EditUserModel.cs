using MYNEWS.CustomValidations;
using System.ComponentModel.DataAnnotations;

namespace MYNEWS.Areas.admin_panel.Models
{
    public class EditUserModel
    {
        public string Id { get; set; }
        public string NickName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        [CustomBirthDateValidator]
        public DateTime BirthDate { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string ProfilePhotoPath { get; set; }
        [FileValidator(AcceptedTypes = ".png, .jpg, .jpeg, .svg")]
        public IFormFile? ProfilePhoto { get; set; }
    }
}
