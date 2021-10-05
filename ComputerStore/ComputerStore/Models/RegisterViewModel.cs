using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UI_ComputerStore.Models
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        [StringLength(30)]
        public string Surname { get; set; }
        [Required]
        [StringLength(30)]
        public string Patronymic { get; set; }

        [Required]
        [RegularExpression(@"^\+?3?8?(0[5-9][0-9]\d{7})$", ErrorMessage = "Incorrect phone number")]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(30)]
        public string Email { get; set; }

        [Required]
        [StringLength(30)]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "confirm password")]
        [Compare("Password")]
        public string ConfrimPassword { get; set; }

    }
}
