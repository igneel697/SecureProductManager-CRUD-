using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace SecureProductManager.Attributes
{
    public class SanitizeHtmlAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) return ValidationResult.Success;

            var input = value.ToString();

            // Remove potentially dangerous tags
            var sanitized = Regex.Replace(input, "<script.*?</script>", "",
                RegexOptions.IgnoreCase | RegexOptions.Singleline);

            sanitized = Regex.Replace(sanitized, "on\\w+\\s*=", "",
                RegexOptions.IgnoreCase);

            if (input != sanitized)
            {
                return new ValidationResult("Input contains potentially dangerous content.");
            }

            return ValidationResult.Success;
        }
    }
}