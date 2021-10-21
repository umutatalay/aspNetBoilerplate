using System.ComponentModel.DataAnnotations;

namespace Umut.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}