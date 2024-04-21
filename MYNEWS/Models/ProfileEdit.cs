using MYNEWS.CustomValidations;
using System.ComponentModel.DataAnnotations;

namespace MYNEWS.Models
{
    public class ProfileEdit
    {
        public string Id { get; set; }
        [Required]
        public string NickName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [CustomBirthDateValidator]
        public DateTime BirthDate { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string ProfilePhotoUrl { get; set; }
        [Required]
        [FileValidator(AcceptedTypes = ".png, .jpg, .jpeg, .svg")]
        public IFormFile? ProfilePhoto { get; set; }
    }
}
