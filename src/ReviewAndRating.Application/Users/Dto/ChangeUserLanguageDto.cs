using System.ComponentModel.DataAnnotations;

namespace ReviewAndRating.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}