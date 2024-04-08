using System.ComponentModel.DataAnnotations;

namespace MYNEWS.CustomValidations
{
    public class CustomBirthDateValidator : ValidationAttribute
    {
        public CustomBirthDateValidator()
        {
            ErrorMessage = "The date of birth must be between 1900 and today.";
        }
        public override bool IsValid(object value)
        {
            var dateTime = (DateTime)value;

            return dateTime >= new DateTime(1900, 1, 1) && dateTime <= DateTime.Today;
        }
    }
}
