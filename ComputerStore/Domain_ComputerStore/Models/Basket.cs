using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_ComputerStore.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public ICollection<Product> Products { get; set; }
        public Basket()
        {
            Products = new List<Product>();
        }
    }
}
