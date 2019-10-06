using System.ComponentModel.DataAnnotations;

namespace KworkPracticeTask.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}