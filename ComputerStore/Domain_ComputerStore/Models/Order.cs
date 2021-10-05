using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_ComputerStore.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public decimal TotalSum { get; set; }
        public ICollection<Product> Products { get; set; }

        public Order()
        {
            Products = new List<Product>();
        }
    }
}
