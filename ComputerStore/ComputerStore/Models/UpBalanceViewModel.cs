using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UI_ComputerStore.Models
{
    public class UpBalanceViewModel
    {
        [Required]
        [RegularExpression(@"^(5[1-5][0-9]{14}|2(22[1-9][0-9]{12}|2[3-9][0-9]{13}|[3-6][0-9]{14}|7[0-1][0-9]{13}|720[0-9]{12}))$", ErrorMessage = "Incorrect card number")]
        public string CardNumber { get; set; }
        [Required]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "Incorrect CVV")]
        public string CVV { get; set; }
        [Range(1, 50000, ErrorMessage = "Incorrect sum")]
        public int Amount { get; set; }
    }
}
