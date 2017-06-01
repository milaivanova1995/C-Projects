using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace PTS_eUniversity.ViewModels
{
    public class LogInModel
    {
        [Display(Name = "Имейл")]
        [Required(ErrorMessage = "Моля, въведете имейл.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Парола")]
        [Required(ErrorMessage = "Моля, въведете парола.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [HiddenInput]
        public string ReturnUrl { get; set; }
    }
}