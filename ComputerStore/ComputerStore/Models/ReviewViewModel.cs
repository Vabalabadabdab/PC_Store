using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UI_ComputerStore.Models
{
    public class ReviewViewModel
    {
        [Required]
        [Range(1, 5)]
        public int CostRate { get; set; }
        [Required]
        [Range(1, 5)]
        public int QualityRate { get; set; }
        [Required]
        [Range(1, 5)]
        public int FuncRate { get; set; }



        [Required]
        [StringLength(30)]
        public string Pros { get; set; }

        [Required]
        [StringLength(30)]
        public string Cons { get; set; }

        [Required]
        [StringLength(100)]
        public string Comment { get; set; }

        [Required]
        public int isRecommend { get; set; }

        public string UserName { get; set; }
        public int ProductId { get; set; }
    }
}
