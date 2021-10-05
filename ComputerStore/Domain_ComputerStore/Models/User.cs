using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Domain_ComputerStore.Models
{
    public class User : IdentityUser<Guid>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public decimal Money { get; set; }
        public int BasketId { get; set; }

        public ICollection<Review> Reviews { get; set; }
        public ICollection<Order> Orders { get; set; }

        public User()
        {
            Reviews = new List<Review>();
            Orders = new List<Order>();
        }
    }
}
