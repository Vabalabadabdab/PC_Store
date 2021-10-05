using Domain_ComputerStore.Models;
using System;
using System.Collections.Generic;

namespace BLL_ComputerStore.Infrastucture.Models
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Cost { get; set; }
        public string ProductImage { get; set; }
        public DateTime? Guarantee { get; set; }
        public string Category { get; set; }
        public float Rate { get; set; }

        public ICollection<PropertyDTO> Properties { get; set; }

        public ProductDTO()
        {
            Properties = new List<PropertyDTO>();
        }
        //public int DiscountId { get; set; }
        //public Discount Discount { get; set; }
        //public ICollection<ValueDTO> Values { get; set; }
        //public ICollection<OrderDTO> Orders { get; set; }
        //public ProductDTO()
        //{
        //    Values = new List<ValueDTO>();
        //    Orders = new List<OrderDTO>();
        //}
    }
}
