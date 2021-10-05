using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_ComputerStore.Infrastucture.Models
{
    public class GroupReviewDTO
    {
        public ICollection<ReviewDTO> Reviews { get; set; }
        public GroupReviewDTO()
        {
            Reviews = new List<ReviewDTO>();
        }
    }
}
