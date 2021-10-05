using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_ComputerStore.Models
{
    public class Discount
    {
        public int Id { get; set; }
        public float Value { get; set; }

        public ICollection<Product> Products { get; set; }
        public Discount()
        {
            Products = new List<Product>();
        }
    }
}
