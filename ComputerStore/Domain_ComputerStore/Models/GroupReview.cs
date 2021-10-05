using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_ComputerStore.Models
{
    public class GroupReview
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public GroupReview()
        {
            Reviews = new List<Review>();
        }
    }
}
