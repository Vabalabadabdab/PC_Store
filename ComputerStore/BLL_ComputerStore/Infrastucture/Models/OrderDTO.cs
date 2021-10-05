using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_ComputerStore.Infrastucture.Models
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public decimal TotalSum { get; set; }
        public ICollection<ProductDTO> Products { get; set; }

        public OrderDTO()
        {
            Products = new List<ProductDTO>();
        }
    }
}
