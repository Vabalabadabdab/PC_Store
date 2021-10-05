using System.ComponentModel.DataAnnotations;

namespace UI_ComputerStore.Models
{
    public class ChangePasswordViewModel
    {
        [Required]
        public string OldPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "confirm password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
