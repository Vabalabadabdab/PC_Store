using System;
using System.Collections.Generic;

namespace Domain_ComputerStore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Cost { get; set; }
        public string ProductImage { get; set; }
        public DateTime? Guarantee { get; set; }
        public string Category { get; set; }
        public float Rate { get; set; }

        public int? DiscountId { get; set; }
        public Discount Discount { get; set; }
        public ICollection<Property> Properties { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Basket> Baskets { get; set; }
        public Product()
        {
            Properties = new List<Property>();
            Orders = new List<Order>();
            Baskets = new List<Basket>();
        }
    }
}
