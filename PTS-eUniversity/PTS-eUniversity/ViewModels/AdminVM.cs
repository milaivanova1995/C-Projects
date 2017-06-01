using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace PTS_eUniversity.ViewModels
{
    public class AdminVM
    {
        [Display(Name = "Имейл")]
        [Required(ErrorMessage = "Моля, въведете имейл.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Парола")]
        [Required(ErrorMessage = "Моля, въведете парола.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Име")]
        [Required(ErrorMessage = "Моля, въведете име.")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Моля, въведете фамилия.")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Display(Name = "Факултет")]
        [Required(ErrorMessage = "Моля, въведете имейл.")]
        [DataType(DataType.Text)]
        public string Faculty { get; set; }

        [HiddenInput]
        public string ReturnUrl { get; set; }

    }
}