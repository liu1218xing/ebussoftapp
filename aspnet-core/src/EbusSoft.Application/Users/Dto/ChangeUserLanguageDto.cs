using System.ComponentModel.DataAnnotations;

namespace EbusSoft.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}